using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankClientsBusinessLayer;

namespace BankWindowsForm
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }
        private string _UserName;
        private string _Password;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            _UserName = txtUserName.Text;
            _Password = txtPassword.Text;
            if(clsUsers.IsUserExist(_UserName, _Password)) 
            {
                frmBankClientsUI frm = new frmBankClientsUI(_UserName);
                frm.ShowDialog();
                this.Close();
            }
            else 
            {
                MessageBox.Show("User name or password is wrong, try put them again","Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserNameValidate(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text)) 
            {
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "This field should have user name");
                e.Cancel = true;
            }
            else 
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtPasswordValidate(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtUserName.Focus();
                errorProvider1.SetError(txtPassword, "This field should have password");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
        }
    }
}
