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
    public partial class frmDeposite : Form
    {
        string _UserName;
        public frmDeposite(string UserName)
        {
            _UserName = UserName;
            InitializeComponent();
        }

        private void frmDeposite_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _UserName;
            lvFindClient.Visible = false;
        }

        private void _RefreshData() 
        {
            clsClients client = clsClients.FindByAccountNumber(txtAccNumber.Text);
            if (client != null)
            {
                lvFindClient.Visible = true;
                ListViewItem Item = new ListViewItem(client.FirstName.Trim());
                Item.SubItems.Add(client.LastName.Trim());
                Item.SubItems.Add(client.Email.Trim());
                Item.SubItems.Add(client.Phone.Trim());
                Item.SubItems.Add(client.Address.Trim());
                Item.SubItems.Add(client.AccountNumber.Trim());
                Item.SubItems.Add(client.AccountBalance.ToString().Trim());
                lvFindClient.Items.Add(Item);
            }
            else
            {
                MessageBox.Show("Client is not found");
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            int NewBalance = 0;
            clsClients Client = clsClients.FindByAccountNumber(txtAccNumber.Text);
            if (Client != null) 
            {
                if (MessageBox.Show("Are you sure you want to deposite for this account number: [" +Client.AccountNumber+"]", "Deposite Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK) 
                {
                    if (Client.Deposite(txtAccNumber.Text, int.Parse(txtAmount.Text)))
                    {
                        NewBalance = Client.AccountBalance + int.Parse(txtAmount.Text);
                        MessageBox.Show("Deposite done successfully, Balance now equal: [" + NewBalance + "]", "Balance Update", MessageBoxButtons.OK);
                        if(lvFindClient.Items.Count > 0) 
                        {
                            lvFindClient.Items.RemoveAt(0);
                            _RefreshData();
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Deposite failed");
                    }
                }
            }
        }
    }
}
