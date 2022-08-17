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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace HRTimekeeping
{
    public partial class OTReport : Form
    {
        public OTReport()
        {
            InitializeComponent();
        }

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        SqlDataAdapter dr;

        private void OTReport_Load(object sender, EventArgs e)
        {

        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            view();
        }

        public void view()
        {

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("select date,start_time,end_time,total_hrs,reason from overtime where date >= '" + date1.Text + "' and date <= '" + date2.Text + "' and employee_id = '" + id.Text + "' ", con);
                dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);


                empot ee = new empot();
                TextObject text = (TextObject)ee.ReportDefinition.Sections["PageHeaderSection3"].ReportObjects["name"];
                
                text.Text = tbname.Text;

                TextObject text6 = (TextObject)ee.ReportDefinition.Sections["Section4"].ReportObjects["name2"];
                text6.Text = tbname.Text;


                TextObject text2 = (TextObject)ee.ReportDefinition.Sections["PageHeaderSection3"].ReportObjects["department"];
                text2.Text = tbdept.Text;

                TextObject text3 = (TextObject)ee.ReportDefinition.Sections["PageHeaderSection3"].ReportObjects["position"];
                text3.Text = tbposition.Text;

                TextObject text4 = (TextObject)ee.ReportDefinition.Sections["PageHeaderSection3"].ReportObjects["segment"];
                text4.Text = tbsegment.Text;

                TextObject text5 = (TextObject)ee.ReportDefinition.Sections["PageHeaderSection3"].ReportObjects["supervisor"];
                text5.Text = tbsupervisor.Text;

                ee.Database.Tables["overtime"].SetDataSource(dt);
                crystalReportViewer1.ReportSource = ee;

                con.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OTRec orr = new OTRec();
            orr.MdiParent = Main.ActiveForm;
            orr.Show();
            this.Close();
        }
    }
}
