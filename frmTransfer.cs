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
    public partial class frmTransfer : Form
    {
        string _UserName;
        clsClients _DelieverClient;
        clsClients _RecieveClient;
        public frmTransfer(string userName)
        {
            InitializeComponent();
            _UserName = userName;
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _UserName;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
             _DelieverClient = clsClients.FindByAccountNumber(txtAccountNumber.Text);
            if (_DelieverClient != null) 
            {
                lblName.Text = "Name: " + _DelieverClient.FirstName + " " + _DelieverClient.LastName;
                lblAccountNumber.Text = "Acc.Number: " + _DelieverClient.AccountNumber;
                lblAcountBalance.Text = "Acc.Balance: " + _DelieverClient.AccountBalance.ToString();
            }
            else 
            {
                MessageBox.Show("Client is not found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             _RecieveClient = clsClients.FindByAccountNumber(txtRecieveAccountNumber.Text);
            if (_RecieveClient != null)
            {
                lblRecieveName.Text = "Name: "+_RecieveClient.FirstName +" "+ _RecieveClient.LastName;
                lblRecieveAccNum.Text = "Acc.Number: "+_RecieveClient.AccountNumber;
                lblRecieveAccBalance.Text = "Acc.Balance: "+_RecieveClient.AccountBalance.ToString();
            }
            else
            {
                MessageBox.Show("Client is not found");
            }
        }

        private void _RefreshData() 
        {
            _RecieveClient = clsClients.FindByAccountNumber(txtRecieveAccountNumber.Text);
            _DelieverClient = clsClients.FindByAccountNumber(txtAccountNumber.Text);
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want transfer for this client ["+ _RecieveClient.AccountNumber +"]", "Transfer Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                if(_DelieverClient.Transfer(_RecieveClient, int.Parse(txtAmount.Text))) 
                {
                    MessageBox.Show("Transfer done Successfully");
                    _RefreshData();
                    lblAcountBalance.Text = "Acc.Balance: " + _DelieverClient.AccountBalance.ToString();
                    lblRecieveAccBalance.Text = "Acc.Balance: " + _RecieveClient.AccountBalance.ToString();
                }
                else 
                {
                    MessageBox.Show("Transfer Operation failed, balance in deliverClient is lower than amount that want to transfer");
                }
            }
        }
    }
}
