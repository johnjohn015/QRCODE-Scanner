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
    public partial class position_superior : Form
    {
        public position_superior()
        {
            InitializeComponent();
        }

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        
        SqlCommand cmd;
        DataSet ds = new DataSet();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void retrieve()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select id as Position_ID, description as Position, supervisor as Supervisor from position", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvposition.DataSource = dt;
                      this.dgvposition.Columns["Position_ID"].Visible = false;



                }
                catch (Exception)
                {

                }
            }
        }

        private void position_superior_Load(object sender, EventArgs e)
        {
            retrieve();
            fillsearch();
        }

        public void searchApp()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {

                string sql = "Select id as Position_ID, description as Position, supervisor as Supervisor from position Order by id desc";
                cmd = new SqlCommand(sql, con);

                try
                {
                    con.Open();

                    string value = cbsearch.Text;

                    cmd.CommandText = String.Format(
                                @"Select id as Position_ID, description as Position, supervisor as Supervisor from position
                            where {0} like @searchKey Order by id desc", value);

                    cmd.Parameters.AddWithValue("@searchKey", tbsearch.Text.ToString() + "%");
                    SqlDataAdapter kuhain = new SqlDataAdapter(cmd);
                    DataTable dtt = new DataTable(sql);
                    kuhain.Fill(dtt);
                    dgvposition.DataSource = dtt;
                    con.Close();
                }

                catch
                {
                    MessageBox.Show("Select field where you want to search for.");
                    con.Close();
                }
            }

        }

        public void fillsearch()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    SqlCommand sc = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'position' ORDER BY ORDINAL_POSITION", con);
                    SqlDataReader reader;
                    reader = sc.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("COLUMN_NAME", typeof(string));
                    dt.Load(reader);
                    cbsearch.ValueMember = "COLUMN_NAME";
                    cbsearch.DataSource = dt;
                    con.Close();
                }
                catch (Exception)
                {

                }
            }
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            searchApp();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Addposition ap = new Addposition();
            ap.MdiParent = Main.ActiveForm;
            ap.Show();
            this.Close();
        }

        private void dgvposition_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Updateposition up = new Updateposition();
            up.MdiParent = Main.ActiveForm;

            up.id.Text = this.dgvposition.CurrentRow.Cells[0].Value.ToString();
            up.tbposition.Text = this.dgvposition.CurrentRow.Cells[1].Value.ToString();
            up.tbsupervisor.Text = this.dgvposition.CurrentRow.Cells[2].Value.ToString();

            up.Show();
            this.Close();
        }
    }
}
