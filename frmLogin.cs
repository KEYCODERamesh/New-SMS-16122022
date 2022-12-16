using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SMS
{
    public partial class frmLogin : Form
    {
        MyDBOperations myDB = new MyDBOperations();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtUser.Text = "";
            txtPass.Text = "";
            cmbSchool.Text = "";
            cmbSession.Text = "";
            MyDBOperations.BindComboBox("Bind_SchoolName", cmbSchool, "School_Name", "School_Id","");
            txtUser.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MyMessage.ErrorMsg(ex.Message, "" + GlobalVars.SoftName + "");
            }
            finally
            {
                SqlCon.close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUser.Text =="")
                {
                    MyMessage.Warning("Username cannot be blank", "" + GlobalVars.SoftName + "");
                    txtUser.Focus();
                    return;
                }
                if (txtPass.Text == "")
                {
                    MyMessage.Warning("Password cannot be blank", "" + GlobalVars.SoftName + "");
                    txtPass.Focus();
                    return;
                }
                if (cmbSchool.SelectedIndex < 1)
                {
                    MyMessage.Warning("School cannot be blank", "" + GlobalVars.SoftName + "");
                    cmbSchool.Focus();
                    return;
                }
                if (cmbSession.SelectedIndex < 1)
                {
                    MyMessage.Warning("Session cannot be blank", "" + GlobalVars.SoftName + "");
                    cmbSession.Focus();
                    return;
                }
                DataTable DT = myDB.SearchData("Verify_User",txtUser.Text, txtPass.Text, "", "", System.DateTime.Now, System.DateTime.Now);
                if (DT.Rows.Count > 0)
                {
                    GlobalVars.UserId = DT.Rows[0]["User_Name"].ToString();
                    frmMain main = new frmMain();
                    main.Show();
                    this.Hide();
                    GlobalVars.SchoolId = cmbSchool.SelectedValue.ToString();
                    GlobalVars.SessionId = cmbSession.SelectedValue.ToString();

                    MyMessage.SuccessMsg("SESSION STARTS AT :" + System.DateTime.Now.ToString("ddd, dd MMM yyy HH: mm:ss")+"", "LOGIN SUCCESSFUL");
                }
                else
                {
                    MyMessage.ErrorMsg("Invalid Login Credentials", "" + GlobalVars.SoftName + "");
                    txtPass.Focus();
                }
            }
            catch(Exception ex)
            {
                MyMessage.ErrorMsg(ex.Message, "" + GlobalVars.SoftName + "");
            }
            finally
            {
                SqlCon.close();
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtUser.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbSchool.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtUser.Focus();
            }
        }

        private void cmbSession_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                cmbSchool.Focus();
            }
        }

        private void cmbSchool_Leave(object sender, EventArgs e)
        {
            try
            {
                MyDBOperations.BindComboBox("Bind_Session", cmbSession, cmbSchool.SelectedValue.ToString(), "Year", "Id");
            }
            catch(Exception ex)
            {
                MyMessage.ErrorMsg(ex.Message, "");
            }
            finally
            {
                SqlCon.close();
            }

           
        }

        private void cmbSchool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbSession.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtPass.Focus();
            }
        }
    } 
}
