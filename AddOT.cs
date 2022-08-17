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
    public partial class AddOT : Form
    {
        public AddOT()
        {
            InitializeComponent();
        }

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        private void AddOT_Load(object sender, EventArgs e)
        {

        }


        public void total()
        {
            TimeSpan d1 = TimeSpan.Parse(timestart.Text);
            TimeSpan d2 = TimeSpan.Parse(timeend.Text);


            TimeSpan total = d2 - d1;

            tbtotalhours.Text = (total.TotalHours).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            total();
        }

        private void timein_ValueChanged(object sender, EventArgs e)
        {
            total();
        }

        private void timeout_ValueChanged(object sender, EventArgs e)
        {
            total();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into overtime(employee_id,lastname,firsname,middlename,position,department,supervisor,start_time,end_time,total_hrs,date,reason)values('" + this.tbempid.Text + "','" + this.tbsname.Text + "','" + this.tbfname.Text + "','" + this.tbmname.Text + "','" + this.tbposition.Text + "','" + this.tbdept.Text + "','" + this.tbsupervisor.Text + "','" + this.timestart.Text + "','" + this.timeend.Text + "','" + this.tbtotalhours.Text + "','" + this.date.Text + "','" + this.tbreason.Text + "'); ";



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Save Successfully");
                    OTRec dt = new OTRec();
                    dt.MdiParent = Main.ActiveForm;
                    dt.Show();
                    this.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OTRec dt = new OTRec();
            dt.MdiParent = Main.ActiveForm;
            dt.Show();
            this.Close();
        }

        private void tbtotalhours_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbempid_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select surname,firstname,middlename,department,designation,immediate_superior from masterlist where employee_id  = @employee_id ", con);
                cmd1.Parameters.AddWithValue("@employee_id", tbempid.Text);
                SqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    tbsname.Text = reader1["surname"].ToString();
                    tbfname.Text = reader1["firstname"].ToString();
                    tbmname.Text = reader1["middlename"].ToString();
                    tbdept.Text = reader1["department"].ToString();
                    tbposition.Text = reader1["designation"].ToString();
                    tbsupervisor.Text = reader1["immediate_superior"].ToString();


                }
                else
                {
             //       MessageBox.Show("No Data Found");
                


                }
                con.Close();
            }
        }
    }
}
