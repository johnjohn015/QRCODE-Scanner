using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;

namespace HRTimekeeping
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        SqlDataAdapter dr;

        private void Sort_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("select date,employee_id,lastname,firstname,middlename,time_in,time_out,  CAST(DATEDIFF(minute,time_in,time_out)/60.0 as decimal(18,2)) as total_hr  from attendance where date >= '" + dt1.Text + "'  and date <= '" + dt2.Text + "' and employee_id = '" + tbempid.Text + "' ORDER BY date ASC, time_in  ASC", con);
                dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);

                attendancelog tr = new attendancelog();
                tr.Database.Tables["attendance"].SetDataSource(dt);

                this.crystalReportViewer1.ReportSource = tr;

                con.Close();
            }
        }

        private void Preview_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dtr dt = new dtr();
            dt.MdiParent = Main.ActiveForm;
            dt.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("select date,employee_id,lastname,firstname,middlename,time_in,time_out,  CAST(DATEDIFF(minute,time_in,time_out)/60.0 as decimal(18,2)) as total_hr  from attendance where date >= '" + dt1.Text + "'  and date <= '" + dt2.Text + "' ORDER BY date ASC, time_in  ASC", con);
                dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);

                attendancelog tr = new attendancelog();
                tr.Database.Tables["attendance"].SetDataSource(dt);

                this.crystalReportViewer1.ReportSource = tr;

                con.Close();
            }
        }
    }
}
