using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using ClosedXML.Excel;
using System.Drawing.Imaging;
using System.Configuration;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing.Presentation;
using ZXing;

namespace HRTimekeeping
{
    public partial class timeinout : Form
    {
        public timeinout()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitime2"].ConnectionString;
        MySqlCommand cmd;
        DataSet ds = new DataSet();
        string cs2 = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        SqlCommand cmd2;
        DataSet ds2 = new DataSet();

        private void timeinout_Load(object sender, EventArgs e)
        {
            tbempid.Focus();
            retrieve();
            
            timer2.Start();
            date.Text = DateTime.Now.ToString("MM/dd/yyyy");
            time.Text = DateTime.Now.ToString("HH:mm:ss");


            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cbdevice.Items.Add(filterInfo.Name);
            cbdevice.SelectedIndex = 0;

            dgvbio.EnableHeadersVisualStyles = false;
            dgvbio.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;

            

            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbdevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();

        }

        public void retrieve ()
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select date as Date,employee_id as id,concat(lastname,' ',firstname,' ',middlename) as Name,time_in as timein,time_out as timeout from  attendance order by date desc", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvbio.DataSource = dt;
                    



                }
                catch (Exception)
                {

                }
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
           
            timein();
            retrieve();

        }

        

        public void timein()
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                cmd2 = new SqlCommand("SELECT * FROM attendance where  employee_id ='" + tbempid.Text + "'  and   date='" + date.Text + "' and time_in is not null", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("You have already Time in for Today ");
                    tbempid.Clear();
                    retrieve();
                    ds.Clear();

                }

                else if (lblmname.Text == "Name" | tbempid.Text == "" )
                {
                    MessageBox.Show("No Record Found or Empty Employee ID");
                }


                else
                {
                    con.Open();
                    string sql;
                    DataSet dss;
                    sql = "INSERT into attendance (employee_id,date,time_in,lastname,firstname,middlename) VALUES (@ID,@Date,@TimeIN,@lastname,@firstname,@middlename)";
                    SqlDataAdapter da2 = new SqlDataAdapter(sql, con);
                    da2.SelectCommand.Parameters.AddWithValue("@ID", tbempid.Text);
                    da2.SelectCommand.Parameters.AddWithValue("@Date", date.Text);
                    da2.SelectCommand.Parameters.AddWithValue("@TimeIN", time.Text);
                    da2.SelectCommand.Parameters.AddWithValue("@lastname", lbllName.Text);
                    da2.SelectCommand.Parameters.AddWithValue("@firstname", lblfname.Text);
                    da2.SelectCommand.Parameters.AddWithValue("@middlename", lblmname.Text);
                    da2.Fill(ds, "attendance");
                    messagebox();
                    MessageBox.Show("Attendance Saved", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    retrieve();
                    con.Close();
                    tbempid.Text = "";
                }
            }
        }

        public void timeout()
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                cmd2 = new SqlCommand("SELECT * FROM attendance where employee_id='" + tbempid.Text + "' and date='" + date.Text + "' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i < 1)
                {
                    MessageBox.Show("Cannot Time Out, No Time In");
                    retrieve();
                    ds.Clear();

                }

                else if (lblmname.Text == "Name" | tbempid.Text == "")
                {
                    MessageBox.Show("No Record Found or Empty Employee ID");
                }

                else if ( lblfname.Text == "")
                {
                    MessageBox.Show("No Record Found or Empty Employee ID");
                }


                else
                {
                    con.Open();
                    string sql;
                    DataSet dss;
                    sql = "Update attendance set time_out=@TimeOUT WHERE employee_id=@ID";
                    SqlDataAdapter da3 = new SqlDataAdapter(sql, con);
                    //int ID = (dataGridView1.CurrentRow.Index).Cells(3).Value;
                    da3.SelectCommand.Parameters.AddWithValue("@ID", tbempid.Text);
                    da3.SelectCommand.Parameters.AddWithValue("@TimeOUT", time.Text);
                    da3.Fill(ds, "attendance");
                    messageboxout();
                    MessageBox.Show("Attendance Save", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbempid.Text = "";
                    retrieve();
                    con.Close();
                }
            }
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            
            timeout();
            
        }

        
        private void tbempid_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                
                
                con.Open();
               
                SqlCommand cmd1 = new SqlCommand("select surname,firstname,middlename,photo from masterlist where employee_id  = @employee_id ", con);
                cmd1.Parameters.AddWithValue("@employee_id", tbempid.Text);
                SqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    lbllName.Text = reader1["surname"].ToString();
                    lblfname.Text = reader1["firstname"].ToString();
                    lblmname.Text = reader1["middlename"].ToString();



                    byte[] picbyte = reader1["Photo"] as byte[] ?? null;
                    if (picbyte != null)
                    {
                        MemoryStream mstream = new MemoryStream(picbyte);
                        pictureBox3.Image = System.Drawing.Image.FromStream(mstream);
                        System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(mstream);
                    }
        
                    

                    captureDevice = new VideoCaptureDevice(filterInfoCollection[cbdevice.SelectedIndex].MonikerString);
                    captureDevice.NewFrame += CaptureDevice_NewFrame;
                    captureDevice.Start();
                    timer1.Start();

                }
                else
                {
                  //  MessageBox.Show("No Data Found");
                  //  tbempid.Text = "";
                    lblfname.Text = "";
                    lbllName.Text = "";
                    lblmname.Text = "";
                    captureDevice = new VideoCaptureDevice(filterInfoCollection[cbdevice.SelectedIndex].MonikerString);
                    captureDevice.NewFrame += CaptureDevice_NewFrame;
                    captureDevice.Start();
                    timer1.Start();
                }
                con.Close();
            }
        }
        public void messagebox()
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select concat(surname,', ',firstname,', ',middlename) as Name from masterlist where employee_id  = @employee_id ", con);
                cmd1.Parameters.AddWithValue("@employee_id", tbempid.Text);
                SqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {

                    MessageBox.Show("Welcome :"+ reader1["Name"].ToString()+"");
                    captureDevice = new VideoCaptureDevice(filterInfoCollection[cbdevice.SelectedIndex].MonikerString);
                    captureDevice.NewFrame += CaptureDevice_NewFrame;
                    captureDevice.Start();
                    timer1.Start();
                    lblfname.Text = "";
                    lbllName.Text = "";
                    lblmname.Text = "";
                }
                else
                {

                }
            }
        }


        public void messageboxout()
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select concat(surname,', ',firstname,', ',middlename) as Name from masterlist where employee_id  = @employee_id ", con);
                cmd1.Parameters.AddWithValue("@employee_id", tbempid.Text);
                SqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {

                    MessageBox.Show("Goodbye :" + reader1["Name"].ToString() + "");
                    captureDevice = new VideoCaptureDevice(filterInfoCollection[cbdevice.SelectedIndex].MonikerString);
                    captureDevice.NewFrame += CaptureDevice_NewFrame;
                    captureDevice.Start();
                    timer1.Start();
                    lblfname.Text = "";
                    lbllName.Text = "";
                    lblmname.Text = "";
                }
                else
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbdevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timeinout_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox2.Image !=null)
            {
                ZXing.BarcodeReader barcodeReader = new ZXing.BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox2.Image);
                if(result != null)
                {
                    tbempid.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            tbempid.Clear();
            lbllName.Text="";
            lblfname.Text = "";
            lblmname.Text = "";


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Start();
            time.Text = DateTime.Now.ToString("HH:mm:ss");
            date.Text = DateTime.Now.ToString("MM/dd/yyyy");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timeinout tt = new timeinout();
            tt.Show();
           
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
