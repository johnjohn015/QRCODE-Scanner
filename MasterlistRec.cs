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
    public partial class MasterlistRec : Form
    {
        public MasterlistRec()
        {
            InitializeComponent();
        }

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        private void MasterlistRec_Load(object sender, EventArgs e)
        {
            retrieve();
            fillsearch();
        }


        public void fillsearch()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    SqlCommand sc = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'masterlist' ORDER BY ORDINAL_POSITION", con);
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


        public void searchApp()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {

                string sql = "select employee_id AS EmployeeID, firstname as Firstname,middlename as Middlename,surname as Surname, designation as Designation,immediate_superior as Supervisor,department as Department,date_start as Date_of_Start,length_service as length_of_service,birthdate as Birthdate, age as Age,gender as Gender,employment as Employment,civil_status as Civil_Status,bloodtype as Bloodtype,educational_attain as Educational_Attainment,address as Address, remarks as Remarks,prev_company as Previous_Company,current_company as Current_Company, tin as Tin,hdmf as HDMF, sss as SSS, phic as PHIC,loc,photo,schedule as Schedule from masterlist Order by employee_id desc";
                cmd = new SqlCommand(sql, con);

                try
                {
                    con.Open();

                    string value = cbsearch.Text;

                    cmd.CommandText = String.Format(
                                @"select employee_id AS EmployeeID, firstname as Firstname,middlename as Middlename,surname as Surname, designation as Designation,immediate_superior as Supervisor,department as Department,date_start as Date_of_Start,length_service as length_of_service,birthdate as Birthdate, age as Age,gender as Gender,employment as Employment,civil_status as Civil_Status,bloodtype as Bloodtype,educational_attain as Educational_Attainment,address as Address, remarks as Remarks,prev_company as Previous_Company,current_company as Current_Company, tin as Tin,hdmf as HDMF, sss as SSS, phic as PHIC,loc,photo,schedule as Schedule from masterlist
                            where {0} like @searchKey Order by employee_id desc", value);

                    cmd.Parameters.AddWithValue("@searchKey", tbsearch.Text.ToString() + "%");
                    SqlDataAdapter kuhain = new SqlDataAdapter(cmd);
                    DataTable dtt = new DataTable(sql);
                    kuhain.Fill(dtt);
                    dgvmaster.DataSource = dtt;
                    con.Close();
                }

                catch
                {
                    MessageBox.Show("Select field where you want to search for.");
                    con.Close();
                }
            }

        }

        public void retrieve()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select id, employee_id AS EmployeeID, firstname as Firstname,middlename as Middlename,surname as Surname, designation as Designation,immediate_superior as Supervisor,department as Department,date_start as Date_of_Start,length_service as length_of_service,birthdate as Birthdate, age as Age,gender as Gender,employment as Employment,civil_status as Civil_Status,bloodtype as Bloodtype,educational_attain as Educational_Attainment,address as Address, remarks as Remarks,prev_company as Previous_Company,current_company as Current_Company, tin as Tin,hdmf as HDMF, sss as SSS, phic as PHIC,loc,photo,schedule as Schedule from masterlist", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvmaster.DataSource = dt;
                    this.dgvmaster.Columns["id"].Visible = false;
                    this.dgvmaster.Columns["photo"].Visible = false;
                    this.dgvmaster.Columns["loc"].Visible = false;



                }
                catch (Exception)
                {

                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Masterlist ml = new Masterlist();
            ml.MdiParent = Main.ActiveForm;
            ml.Show();
            this.Close();
            
        }

        private void dgvmaster_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Update_Masterlist um = new Update_Masterlist();
            um.MdiParent = Main.ActiveForm;
            um.id.Text = this.dgvmaster.CurrentRow.Cells[0].Value.ToString();
            um.tbempid.Text = this.dgvmaster.CurrentRow.Cells[1].Value.ToString();
            um.tbsurname.Text = this.dgvmaster.CurrentRow.Cells[4].Value.ToString();
            um.tbmname.Text = this.dgvmaster.CurrentRow.Cells[3].Value.ToString();
            um.tbfname.Text = this.dgvmaster.CurrentRow.Cells[2].Value.ToString();
            um.cbposition.Text = this.dgvmaster.CurrentRow.Cells[5].Value.ToString();
            um.cbsupervisor.Text = this.dgvmaster.CurrentRow.Cells[6].Value.ToString();
            um.cbdept.Text = this.dgvmaster.CurrentRow.Cells[7].Value.ToString();
            um.dtstart.Text = this.dgvmaster.CurrentRow.Cells[8].Value.ToString();
            um.tbstart.Text = this.dgvmaster.CurrentRow.Cells[9].Value.ToString();
            um.dtbdate.Text = this.dgvmaster.CurrentRow.Cells[10].Value.ToString();
            um.tbage.Text = this.dgvmaster.CurrentRow.Cells[11].Value.ToString();
            um.cbgender.Text = this.dgvmaster.CurrentRow.Cells[12].Value.ToString();
            um.cbemployement.Text = this.dgvmaster.CurrentRow.Cells[13].Value.ToString();
            um.cbstatus.Text = this.dgvmaster.CurrentRow.Cells[14].Value.ToString();
            um.tbbtype.Text = this.dgvmaster.CurrentRow.Cells[15].Value.ToString();
            um.tbeduc.Text = this.dgvmaster.CurrentRow.Cells[16].Value.ToString();
            um.tbaddress.Text = this.dgvmaster.CurrentRow.Cells[17].Value.ToString();
            um.tbremarks.Text = this.dgvmaster.CurrentRow.Cells[18].Value.ToString();
            um.tbprevcompany.Text = this.dgvmaster.CurrentRow.Cells[19].Value.ToString();
            um.tbcurcompany.Text = this.dgvmaster.CurrentRow.Cells[20].Value.ToString();
            um.tbtin.Text = this.dgvmaster.CurrentRow.Cells[21].Value.ToString();
            um.tbhdmf.Text = this.dgvmaster.CurrentRow.Cells[22].Value.ToString();
            um.tbsss.Text = this.dgvmaster.CurrentRow.Cells[23].Value.ToString();
            um.tbphic.Text = this.dgvmaster.CurrentRow.Cells[24].Value.ToString();
            um.cbsched.Text = this.dgvmaster.CurrentRow.Cells[27].Value.ToString();





            Byte[] img = (Byte[])dgvmaster.CurrentRow.Cells[26].Value;
            MemoryStream ms = new MemoryStream(img);
            um.pb1.Image = Image.FromStream(ms);
            um.tbLoc1.Text = this.dgvmaster.CurrentRow.Cells[25].Value.ToString();
            um.Show();
            this.Close();
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            searchApp();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            retrieve();
            tbsearch.Text = "";
        }

        private void tbsearch_TextChanged_1(object sender, EventArgs e)
        {
            searchApp();
        }
    }
}
