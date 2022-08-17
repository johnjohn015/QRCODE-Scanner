using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace HRTimekeeping
{
    public partial class brd : Form
    {
        public brd()
        {
            InitializeComponent();
        }
        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitime"].ConnectionString;
        string cs2 = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        MySqlCommand cmd;
        SqlCommand cmd2;
        DataSet ds = new DataSet();

        private void brd_Load(object sender, EventArgs e)
        {

            retrieve();
            autocompletecomp();
            autocompletedept();
        }
        public void autocompletecomp()
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                SqlCommand cmd = new SqlCommand("Select company from department",con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection mycollections = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    mycollections.Add(dr.GetString(0));

                }
                cbcompany.AutoCompleteCustomSource = mycollections;
                con.Close();
            }

        }
        public void autocompletedept()
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                SqlCommand cmd = new SqlCommand("Select department from department", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection mycollections = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    mycollections.Add(dr.GetString(0));

                }
                cbdeparment.AutoCompleteCustomSource = mycollections;
                con.Close();
            }

        }

        public void retrieve()
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select id as ID,company as Company,department as Department from department", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvdepartment.DataSource = dt;

                



                }
                catch (Exception)
                {

                }
            }

            }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {

        }

        public void searchApp()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {

                string sql = "Select id as ID, company as Company, department as Department from department Order by id desc";
                cmd2 = new SqlCommand(sql, con);

                try
                {
                    con.Open();

                    string value = cbsearch.Text;

                    cmd2.CommandText = String.Format(
                                @"Select id as ID, company as Company, deparment as Department from department
                            where {0} like @searchKey Order by id desc", value);

                    cmd2.Parameters.AddWithValue("@searchKey", tbsearch.Text.ToString() + "%");
                    SqlDataAdapter kuhain = new SqlDataAdapter(cmd2);
                    DataTable dtt = new DataTable(sql);
                    kuhain.Fill(dtt);
                    dgvdepartment.DataSource = dtt;
                    con.Close();
                }

                catch
                {
                    MessageBox.Show("Select field where you want to search for.");
                    con.Close();
                }
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into department(company,department)values('" + this.cbcompany.Text + "','" + this.cbdeparment.Text + "'); ";

                   

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Save Successfully");
                    cbcompany.Text = "";
                    cbdeparment.Text = "";
                    retrieve();
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
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            using (SqlConnection con = new SqlConnection(cs2))
            {

              
                    
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update department set  company = '" + cbcompany.Text + "',department = '" + cbdeparment.Text + "'   Where id = '" + id.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
                cbcompany.Text = "";
                cbdeparment.Text = "";
                retrieve();
                


                con.Close();


            }

        }

        private void dgvdepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvdepartment_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id.Text = this.dgvdepartment.CurrentRow.Cells[0].Value.ToString();
            cbcompany.Text = this.dgvdepartment.CurrentRow.Cells[1].Value.ToString();
            cbdeparment.Text = this.dgvdepartment.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning",
      MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            using (SqlConnection con = new SqlConnection(cs2))
            {
                if (result == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete From department WHERE id ='" + this.id.Text + "'";
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
