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
    public partial class OTRec : Form
    {
        public OTRec()
        {
            InitializeComponent();
        }

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        private void btnsave_Click(object sender, EventArgs e)
        {
            AddOT aot = new AddOT();
            aot.MdiParent = Main.ActiveForm;
            aot.Show();
            this.Close();
        }

        private void OTRec_Load(object sender, EventArgs e)
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
                    SqlDataAdapter da = new SqlDataAdapter("select ot_number as ID,employee_id as EmployeeID,Concat(firsname,' ',middlename,' ',lastname) as Name,position as Position,department as Department, supervisor as Supervisor, start_time as Time_Start,end_time as Time_End,total_hrs as Total_Hours,date as Date,reason as Reason from overtime", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvtime.DataSource = dt;
                    this.dgvtime.Columns["ID"].Visible = false;




                }
                catch (Exception)
                {

                }
            }
        }

        private void dgvtime_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OTReport or = new OTReport();
            or.MdiParent = Main.ActiveForm;
            or.id.Text = this.dgvtime.CurrentRow.Cells[1].Value.ToString();
            or.tbname.Text = this.dgvtime.CurrentRow.Cells[2].Value.ToString();
            or.tbposition.Text = this.dgvtime.CurrentRow.Cells[3].Value.ToString();
            or.tbdept.Text = this.dgvtime.CurrentRow.Cells[4].Value.ToString();
            or.tbsupervisor.Text = this.dgvtime.CurrentRow.Cells[5].Value.ToString();
            or.Show();
            this.Close();
        }
    }
}
