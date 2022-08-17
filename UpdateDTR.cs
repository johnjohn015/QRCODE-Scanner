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
    public partial class UpdateDTR : Form
    {
        public UpdateDTR()
        {
            InitializeComponent();
        }

        string cs2 = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        SqlCommand cmd2;
        DataSet ds2 = new DataSet();

        private void UpdateDTR_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtr dt = new dtr();
            dt.MdiParent = Main.ActiveForm;
            dt.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update attendance set  employee_id = '" + tbempid.Text + "',lastname = '" + tbsname.Text + "',firstname = '" + tbfname.Text + "',middlename = '" + tbmname.Text + "',time_in = '" + timein.Text + "',time_out = '" + timeout.Text + "',date = '" + date.Text + "'   Where id = '" + id.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
                dtr dtt = new dtr();
                dtt.MdiParent = Main.ActiveForm;
                dtt.Show();
                this.Close();
                con.Close();
            }
        }
    }
}
