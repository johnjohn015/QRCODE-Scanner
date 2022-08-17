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
    public partial class dtr : Form
    {
        public dtr()
        {
            InitializeComponent();
        }

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
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
                    SqlDataAdapter da = new SqlDataAdapter("select id,date,employee_id,lastname,firstname,middlename,time_in,time_out,DATEDIFF(HOUR,time_in,time_out) as Total_Hour from attendance", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvtime.DataSource = dt;
                      this.dgvtime.Columns["id"].Visible = false;



                }
                catch (Exception)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Preview pp = new Preview();
            pp.MdiParent = Main.ActiveForm;
            pp.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                DateTime datefrom = DateTime.Parse(dt1.Text);
                DateTime dateto = DateTime.Parse(dt2.Text);
                SqlCommand cmd2 = new SqlCommand("select date,employee_id,lastname,firstname,middlename,time_in,time_out,DATEDIFF(HOUR,time_in,time_out) as Total_Hour from attendance where date >= '" + dt1.Text + "'  and date <= '" + dt2.Text + "' ORDER BY date ASC", con);
                SqlDataAdapter da2 = new SqlDataAdapter();
                da2.SelectCommand = cmd2;
                DataTable dt = new DataTable();
                da2.Fill(dt);
                dgvtime.DataSource = dt;
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            retrieve();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manual man = new Manual();
            man.MdiParent = Main.ActiveForm;
            man.Show();
            this.Close();
        }

        private void dgvtime_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateDTR udtr = new UpdateDTR();
            udtr.MdiParent = Main.ActiveForm;

            udtr.id.Text = this.dgvtime.CurrentRow.Cells[0].Value.ToString();
            udtr.date.Text = this.dgvtime.CurrentRow.Cells[1].Value.ToString();
            udtr.tbempid.Text = this.dgvtime.CurrentRow.Cells[2].Value.ToString();
            udtr.tbsname.Text = this.dgvtime.CurrentRow.Cells[3].Value.ToString();
            udtr.tbfname.Text = this.dgvtime.CurrentRow.Cells[4].Value.ToString();
            udtr.tbmname.Text = this.dgvtime.CurrentRow.Cells[5].Value.ToString();
            udtr.timein.Text = this.dgvtime.CurrentRow.Cells[6].Value.ToString();
            udtr.timeout.Text = this.dgvtime.CurrentRow.Cells[7].Value.ToString();
            

            this.Close();
            udtr.Show();
        }
    }
}
