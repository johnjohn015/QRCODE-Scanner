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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        int i;

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        private void btnlogin_Click(object sender, EventArgs e)
        {
            signin();
        }
        public void signin()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                i = 0;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " select role from users where employee_id='" + tbUser.Text + "' and password='" + tbPass.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                ;
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Main db = new Main(dt.Rows[0][0].ToString());
                   
                    db.Show();
                }
                else
                {

                    label3.Text = "";
                    MessageBox.Show("Invalid Username/Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPass.Text = "";
                    tbUser.Text = "";
                    tbUser.Focus();

                }






                con.Close();



            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void cbshow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshow.Checked)
            {
                tbPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbPass.UseSystemPasswordChar = true;
            }
        }
    }
}
