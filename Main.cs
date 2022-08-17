using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRTimekeeping
{
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main(string role)
        {
            InitializeComponent();
            lblrole.Text = role;
        }

        private void masterlistRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dTRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void positionSupervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mlts_Click(object sender, EventArgs e)
        {
            MasterlistRec mr = new MasterlistRec();
            mr.MdiParent = this;
            mr.Show();
        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            position_superior ps = new position_superior();
            ps.MdiParent = this;
            ps.Show();
        }

        private void dtrs_Click(object sender, EventArgs e)
        {
           

        }

        private void deparmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brd bd = new brd();
            bd.MdiParent = this;
            bd.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aa = new About();
            aa.MdiParent = this;
            aa.Show();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule sc = new Schedule();
            sc.MdiParent = this;
            sc.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login ll = new login();
            ll.Show();
            this.Close();
        }

        private void overtimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dTRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OTRec otr = new OTRec();
            otr.MdiParent = this;
            otr.Show();
        }

        private void dtrs_Click_1(object sender, EventArgs e)
        {
            dtr dt = new dtr();
            dt.MdiParent = this;
            dt.Show();
        }
    }
}
