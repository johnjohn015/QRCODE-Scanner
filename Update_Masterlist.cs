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

namespace HRTimekeeping
{
    public partial class Update_Masterlist : Form
    {
        public Update_Masterlist()
        {
            InitializeComponent();
        }

       // string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitime"].ConnectionString;
        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
   //     MySqlCommand cmd;
        SqlCommand cmd2;
        DataSet ds = new DataSet();

        private void btncancel_Click(object sender, EventArgs e)
        {
            MasterlistRec mr = new MasterlistRec();
            mr.MdiParent = Main.ActiveForm;
            mr.Show();
            this.Close();
        }

        private void Update_Masterlist_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dddd , MMM dd, yyyy");
            autocompleteposition();
            autocompletesupervisor();
            autocompletedept();
            autocompletesched();
        }

        public void autocompleteposition()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select DISTINCT description from position", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection mycollections = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    mycollections.Add(dr.GetString(0));

                }
                cbposition.AutoCompleteCustomSource = mycollections;
                con.Close();
            }

        }

        public void autocompletedept()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select department from department", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection mycollections3 = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    mycollections3.Add(dr.GetString(0));

                }
                cbdept.AutoCompleteCustomSource = mycollections3;
                con.Close();
            }

        }


        public void autocompletesupervisor()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select DISTINCT supervisor from position", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection mycollections2 = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    mycollections2.Add(dr.GetString(0));

                }
                cbsupervisor.AutoCompleteCustomSource = mycollections2;
                con.Close();
            }

        }

        public void autocompletesched()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select CONCAT(day,' - ',time_in,' - ',time_out) as sched from schedule", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection mycollections2 = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    mycollections2.Add(dr.GetString(0));

                }
                cbsched.AutoCompleteCustomSource = mycollections2;
                con.Close();
            }

        }
        //float number;

        private void btnsave_Click(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {

                byte[] imageBt = null;
                FileStream fstream = new FileStream(this.tbLoc1.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update masterlist set  phic = '" + tbphic.Text + "' ,sss = '" + tbsss.Text + "' ,hdmf = '" + tbhdmf.Text + "' ,tin = '" + tbtin.Text + "' ,current_company = '" + tbcurcompany.Text + "' ,prev_company = '" + tbprevcompany.Text + "' ,remarks = '" + tbremarks.Text + "' ,address = '" + tbaddress.Text + "' ,educational_attain = '" + tbeduc.Text + "' ,bloodtype = '" + tbbtype.Text + "' ,civil_status = '" + cbstatus.Text + "' ,employment = '" + cbemployement.Text + "' ,gender = '" + cbgender.Text + "' ,age = '" + tbage.Text + "' ,birthdate = '" + dtbdate.Text + "' ,length_service = '" + tbstart.Text + "' ,date_start = '" + dtstart.Text + "' ,immediate_superior = '" + cbsupervisor.Text + "',department = '" + cbdept.Text + "' ,designation = '" + cbposition.Text + "' ,middlename = '" + tbmname.Text + "' ,firstname = '" + tbfname.Text + "' ,surname = '" + tbsurname.Text + "' ,employee_id = '" + tbempid.Text + "' , photo = @IMG , Loc = @loc,schedule = '" + cbsched.Text + "'  Where id = '" + id.Text + "'";
                cmd.Parameters.Add(new SqlParameter("@IMG", imageBt));
                cmd.Parameters.Add(new SqlParameter("@loc", tbLoc1.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
                MasterlistRec mr = new MasterlistRec();
                mr.MdiParent = Main.ActiveForm;
                mr.Show();
                this.Close();


                con.Close();


            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning",
      MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            using (SqlConnection con = new SqlConnection(cs))
            {
                if (result == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete From masterlist WHERE employee_id ='" + this.tbempid.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted");
                    this.Close();
                    con.Close();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Cencel Delete");
                }
            }

        }
    }
}
