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
    public partial class Refresh : Form
    {
        public Refresh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeinout ti = new timeinout();
            ti.Show();
            this.Close();
        }
    }
}
