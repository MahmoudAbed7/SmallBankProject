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
    public partial class frmAddEditUsers : Form
    {
        public enum enMode { AddNew, Update};
        enMode _Mode;
        private int _UserID;
        string _UserName;
        clsUsers _Users;
        public frmAddEditUsers(int UserID, string UserName)
        {
            InitializeComponent();
            _UserID = UserID;
            _UserName = UserName;
            if (_UserID == -1) _Mode = enMode.AddNew;
            else _Mode = enMode.Update;
        }

        private void _LoadData() 
        {
            if(_Mode == enMode.AddNew) 
            {
                lblMode.Text = "Add New User";
                _Users = new clsUsers();
                return;
            }
            _Users = clsUsers.Find(_UserID);

            if(_Users == null) 
            {
                MessageBox.Show("User is no longer exist");
                this.Close();
                return;
            }
            lblMode.Text = "Edit User with id: " + _UserID.ToString();
            lblUserID.Text = _UserID.ToString();
            txtUserName.Text = _Users.UserName;
            txtPassword.Text = _Users.Password;
            txtPermission.Text = _Users.Permission.ToString();
            
        }
        private void frmAddEditUsers_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _UserName;
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _Users.UserName = txtUserName.Text;
            _Users.Password = txtPassword.Text;
            _Users.Permission = Convert.ToInt32(txtPermission.Text);
            

            if (_Users.Save())
            {
                MessageBox.Show("User data save Successfully");
            }
            else
            {
                MessageBox.Show("User data save Failed");
            }
            _Mode = enMode.Update;
            lblMode.Text = _Users.UserID.ToString();
            lblUserID.Text = _Users.UserID.ToString();


        }
    }
}
