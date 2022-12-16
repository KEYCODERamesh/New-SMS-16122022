using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class frmDashboard : Form
    {
        public frmDashboard dashboard;
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Click(object sender, EventArgs e)
        {
            //frmMain main = new frmMain();
            //frmDashboard dashboard = new frmDashboard();
            //foreach(Form AllFrms in main.Controls)
            //{
            //    AllFrms.BringToFront();
            //}
        }

        private void frmDashboard_Activated(object sender, EventArgs e)
        {
            textBox1.Text = "Activated";
        }

        private void frmDashboard_Deactivate(object sender, EventArgs e)
        {
            textBox1.Text = "Deactivated";
        }
    }
}
