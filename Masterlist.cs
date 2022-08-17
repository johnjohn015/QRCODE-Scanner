using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using QRCoder;

namespace HRTimekeeping
{
    public partial class Masterlist : Form
    {
        public Masterlist()
        {
            InitializeComponent();
        }

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitime"].ConnectionString;
        string cs2 = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        MySqlCommand cmd;
        SqlCommand cmd2;
        DataSet ds = new DataSet();

        private void Masterlist_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dddd , MMM dd, yyyy");
            fillposition();
            fillsupervisor();
            filldept();
            fillsched();
        }

        public void fillsched()
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                try
                {
                    con.Open();
                    SqlCommand sc = new SqlCommand("select CONCAT(day,' - ',time_in,' - ',time_out) as sched from schedule", con);
                    SqlDataReader reader;
                    reader = sc.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("sched", typeof(string));
                    dt.Load(reader);
                    cbsched.ValueMember = "sched";
                    cbsched.DataSource = dt;
                    con.Close();
                }
                catch (Exception)
                {

                }
            }
        }
        public void fillposition()
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                try
                {
                    con.Open();
                    SqlCommand sc = new SqlCommand("Select DISTINCT description from position", con);
                    SqlDataReader reader;
                    reader = sc.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("description", typeof(string));
                    dt.Load(reader);
                    cbposition.ValueMember = "description";
                    cbposition.DataSource = dt;
                    con.Close();
                }
                catch (Exception)
                {

                }
            }
        }

        public void filldept()
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                try
                {
                    con.Open();
                    SqlCommand sc = new SqlCommand("Select DISTINCT department from department", con);
                    SqlDataReader reader;
                    reader = sc.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("department", typeof(string));
                    dt.Load(reader);
                    cbdept.ValueMember = "department";
                    cbdept.DataSource = dt;
                    con.Close();
                }
                catch (Exception)
                {

                }
            }
        }

        public void fillsupervisor()
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                try
                {
                    con.Open();
                    SqlCommand sc = new SqlCommand("Select DISTINCT supervisor from position order by supervisor desc", con);
                    SqlDataReader reader;
                    reader = sc.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("supervisor", typeof(string));
                    dt.Load(reader);
                    cbsupervisor.ValueMember = "supervisor";
                    cbsupervisor.DataSource = dt;
                    con.Close();
                }
                catch (Exception)
                {

                }
            }
        }


        public long CalcAge(System.DateTime StartDate, System.DateTime EndDate)
        {
            long age = 0;
            System.TimeSpan ts = new TimeSpan(StartDate.Ticks - EndDate.Ticks);
            age = (long)(ts.Days / 365);
            return age;
        }

     

        private void dtstart_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime startdate = dtstart.Value.Date;
            DateTime enddate = DateTime.Now;
            tbstart.Text = CalcAge(enddate, startdate).ToString();
        }

        private void dtbdate_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime startdate = dtbdate.Value.Date;
            DateTime enddate = DateTime.Now;
            tbage.Text = CalcAge(enddate, startdate).ToString();
        }

        public void empty()
        {
            if (tbempid.Text == "")
            {
                MessageBox.Show("");
            }
        }

        

        

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                try
                {



                    byte[] imageBt = null;
                    FileStream fstream = new FileStream(this.tbLoc1.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    imageBt = br.ReadBytes((int)fstream.Length);



                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into masterlist(employee_id,surname,firstname,middlename,designation,immediate_superior,department,date_start,length_service,birthdate,age,gender,employment,civil_status,bloodtype,educational_attain,address,remarks,prev_company,current_company,tin,hdmf,sss,phic,loc,photo,schedule)values('" + this.tbempid.Text + "','" + this.tbsurname.Text + "','" + this.tbfname.Text + "','" + this.tbmname.Text + "','" + this.cbposition.Text + "','" + this.cbsupervisor.Text + "','" + this.cbdept.Text + "','" + this.dtstart.Text + "','" + this.tbstart.Text + "','" + this.dtbdate.Text + "','" + this.tbage.Text + "','" + this.cbgender.Text + "','" + this.cbemployement.Text + "','" + this.cbstatus.Text + "','" + this.tbbtype.Text + "','" + this.tbeduc.Text + "','" + this.tbaddress.Text + "','" + this.tbremarks.Text + "','" + this.tbprevcompany.Text + "','" + this.tbcurcompany.Text + "','" + this.tbtin.Text + "','" + this.tbhdmf.Text + "','" + this.tbsss.Text + "','" + this.tbphic.Text + "',@loc,@IMG,'" + this.cbsched.Text + "'); ";

                    cmd.Parameters.Add(new SqlParameter("@IMG", imageBt));
                    cmd.Parameters.Add(new SqlParameter("@loc", tbLoc1.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Save Successfully");
                    MasterlistRec mr = new MasterlistRec();
                    mr.MdiParent = Main.ActiveForm;
                    mr.Show();
                    this.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            MasterlistRec mr = new MasterlistRec();
            mr.MdiParent = Main.ActiveForm;
            mr.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();

                opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF|*.jpg;*.png;*.gif)";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pb1.Image = Image.FromFile(opf.FileName);

                    string picloc = opf.FileName.ToString();
                    tbLoc1.Text = picloc;
                    pb1.ImageLocation = picloc;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG *.JPG|*.jpg ";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(sf.FileName);
            }

        }

        private void tbempid_TextChanged(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(tbempid.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBox2.Image = code.GetGraphic(5);
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
