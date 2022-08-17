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
    public partial class Updateposition : Form
    {
        public Updateposition()
        {
            InitializeComponent();
        }

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;

        SqlCommand cmd;
        DataSet ds = new DataSet();

        private void btnok_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {



                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update position set  description = '" + tbposition.Text + "',supervisor = '" + tbsupervisor.Text + "'   Where id = '" + id.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
                position_superior ps = new position_superior();
                ps.MdiParent = Main.ActiveForm;
                ps.Show();
                this.Close();
                con.Close();


            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            position_superior ps = new position_superior();
            ps.MdiParent = Main.ActiveForm;
            ps.Show();
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "Delete From position WHERE id ='" + this.id.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted");
                    position_superior ps = new position_superior();
                    ps.MdiParent = Main.ActiveForm;
                    ps.Show();
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
