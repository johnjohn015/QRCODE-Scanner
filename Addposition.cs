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
    public partial class Addposition : Form
    {
        public Addposition()
        {
            InitializeComponent();
        }

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;

        SqlCommand cmd;
        DataSet ds = new DataSet();

        private void Addposition_Load(object sender, EventArgs e)
        {

        }

        private void tbcancel_Click(object sender, EventArgs e)
        {
            position_superior ps = new position_superior();
            ps.MdiParent = Main.ActiveForm;
            ps.Show();
            this.Close();
        }

        private void tbok_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into position(description,supervisor)values('" + this.tbposition.Text + "','" + this.tbsupervisor.Text + "'); ";



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Save Successfully");
                    position_superior ps = new position_superior();
                    ps.MdiParent = Main.ActiveForm;
                    ps.Show();
                    this.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
