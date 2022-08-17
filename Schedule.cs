using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace HRTimekeeping
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }
        
        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        


        private void btnsave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into schedule(time_in,time_out,day)values('" + this.dtimein.Text + "','" + this.dtimeout.Text + "','" + this.s1.Text + "'); ";



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Save Successfully");
                    dtimein.Refresh();
                    dtimeout.Refresh();
                    retrieve();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            retrieve();
        }

        public void retrieve()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select id as ID,time_in as Time_in,time_out as Time_out,day as Day from schedule", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvsched.DataSource = dt;





                }
                catch (Exception)
                {

                }
            }
        }

        private void dgvsched_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvsched_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id.Text = this.dgvsched.CurrentRow.Cells[0].Value.ToString();
            dtimein.Text = this.dgvsched.CurrentRow.Cells[1].Value.ToString();
            dtimeout.Text = this.dgvsched.CurrentRow.Cells[2].Value.ToString();
            s1.Text = this.dgvsched.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "Delete From schedule WHERE id ='" + this.id.Text + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {



                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update schedule set  time_in = '" + dtimein.Text + "',time_out = '" + dtimeout.Text + "',day = '" + s1.Text + "'   Where id = '" + id.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
                dtimein.Refresh();
                dtimeout.Refresh();
                retrieve();



                con.Close();


            }
        }

      

      

      

    }
}
