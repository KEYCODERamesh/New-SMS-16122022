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
    public partial class frmSchoolProfile : Form
    {
        public frmSchoolProfile()
        {
            InitializeComponent();
        }

        private void frmSchoolProfile_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(((this.MdiParent.ClientSize.Width / 2) - (this.Width / 2)),
            //    ((this.MdiParent.ClientSize.Height / 2) - (this.Height / 2)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
