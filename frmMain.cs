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
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form childForm in MdiChildren)
            //{
            //    childForm.Close();
            //}

            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //frmDashboard dashboard = new frmDashboard();
            //dashboard.MdiParent = this;
            //dashboard.Show();
            //dashboard.Dock = DockStyle.Fill;
            //dashboard.BringToFront();

            this.toolStripStatusLabel1.BorderStyle = Border3DStyle.Sunken;
            this.toolStripStatusLabel1.AutoSize = true;
            this.toolStripStatusLabel1.Text = "Application Login Time " + System.DateTime.Now.ToString("ddd, dd MMM yyy HH:mm:ss");
            this.toolStripStatusLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;

            //this.toolStripStatusLabel2.BorderStyle = Border3DStyle.Sunken;
            //this.toolStripStatusLabel2.AutoSize = false;
            //this.toolStripStatusLabel2.Text = "SMS v2.1.0";
            //this.toolStripStatusLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Left;
        }

        private void schoolProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSchProfile schoolProfile = new frmSchProfile();
            schoolProfile.MdiParent = this;
            schoolProfile.Show();
            schoolProfile.BringToFront();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserCreation User = new UserCreation();
            User.MdiParent = this;
            User.Show();
            User.BringToFront();
        }

        private void academicSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcademicSession AcadSession = new AcademicSession();
            AcadSession.MdiParent = this;
            AcadSession.Show();
            AcadSession.BringToFront();
            

        }

        private void classMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class clsmaster = new Class();
            clsmaster.MdiParent = this;
            clsmaster.Show();
            clsmaster.BringToFront();
        }

        private void sectionmaster_Click(object sender, EventArgs e)
        {
            Section sectionMaster = new Section();
            sectionMaster.MdiParent = this;
            sectionMaster.Show();
            sectionMaster.BringToFront();
        }

        private void transportMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transport transpoetMaster = new Transport();
            transpoetMaster.MdiParent = this;
            transpoetMaster.Show();
            transpoetMaster.BringToFront();
        }
    }
}
