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
    public partial class Manual : Form
    {
        
        public Manual()
        {
            InitializeComponent();
        }

        string cs2 = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        SqlCommand cmd2;
        DataSet ds2 = new DataSet();




        private void Manual_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into attendance(employee_id,lastname,firstname,middlename,time_in,time_out,date)values('" + this.tbempid.Text + "','" + this.tbsname.Text + "','" + this.tbfname.Text + "','" + this.tbmname.Text + "','" + this.timein.Text + "','" + this.timeout.Text + "','" + this.date.Text + "'); ";



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Save Successfully");
                    dtr dt = new dtr();
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

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select surname,firstname,middlename from masterlist where employee_id  = @employee_id ", con);
                cmd1.Parameters.AddWithValue("@employee_id", tbempid.Text);
                SqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    tbsname.Text = reader1["surname"].ToString();
                    tbfname.Text = reader1["firstname"].ToString();
                    tbmname.Text = reader1["middlename"].ToString();
                   

                }
                else
                {
                    MessageBox.Show("No Data Found");
                    tbempid.Text = "";
                    tbsname.Text = "";
                    tbfname.Text = "";
                    tbmname.Text = "";
                   
                  
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtr dt = new dtr();
            dt.MdiParent = Main.ActiveForm;
            dt.Show();
            this.Close();
        }
    }
}
