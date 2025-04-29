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
    public partial class frmAddEditClients : Form
    {
        public enum enMode { AddNew, Update }
        string _UserName;
        enMode _Mode;
        int _ClientID;
        clsClients _Client;
        public frmAddEditClients(int ClientID, string UserName)
        {
            _ClientID = ClientID;
            _UserName = UserName;
            InitializeComponent();
            if(_ClientID == -1) _Mode = enMode.AddNew;
            else _Mode = enMode.Update;
        }

        private void _LoadData() 
        {
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Client";
                _Client = new clsClients();
                return;
            }
            _Client = clsClients.Find(_ClientID);

            if (_Client == null)
            {
                MessageBox.Show("User is no longer exist");
                this.Close();
                return;
            }
            lblMode.Text = "Edit Client with id: " + _ClientID.ToString();
            lblUserID.Text = _ClientID.ToString();
            txtFirstName.Text = _Client.FirstName;
            txtLastName.Text = _Client.LastName;
            txtEmail.Text = _Client.Email;
            txtPhone.Text = _Client.Phone;
            txtAddress.Text = _Client.Address;
            txtAccNumber.Text = _Client.AccountNumber;
            txtAccBalance.Text = _Client.AccountBalance.ToString();
        }
        private void frmAddEditClients_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _UserName;
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Client.FirstName = txtFirstName.Text;
            _Client.LastName = txtLastName.Text;
            _Client.Email = txtEmail.Text;
            _Client.Phone = txtPhone.Text;
            _Client.Address = txtAddress.Text;
            _Client.AccountNumber = txtAccNumber.Text;
            _Client.AccountBalance = int.Parse(txtAccBalance.Text);


            if (_Client.Save())
            {
                MessageBox.Show("User data save Successfully");
            }
            else
            {
                MessageBox.Show("User data save Failed");
            }
            _Mode = enMode.Update;
            lblMode.Text = "Edit Client with id: " + _Client.ClientID.ToString();
            lblUserID.Text = _Client.ClientID.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
