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
    public partial class ValidUser : Form
    {
        public ValidUser()
        {
            InitializeComponent();
        }
        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["kqfitimesql"].ConnectionString;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        private void ValidUser_Load(object sender, EventArgs e)
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
                    SqlDataAdapter da = new SqlDataAdapter("select id as ID,employee_id as EmployeeID, firstname as Firstname, middlename as Middlename, lastname as Lastname,email as Email,password as Password, confirm_password as Confirm_Password, role as Role,status as Status from users", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvtime.DataSource = dt;
                    this.dgvtime.Columns["id"].Visible = false;
                    this.dgvtime.Columns["password"].Visible = false;
                    this.dgvtime.Columns["confirm_password"].Visible = false;



                }
                catch (Exception)
                {

                }
            }
        }
    }
}
