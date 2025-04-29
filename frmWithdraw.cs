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
    public partial class frmWithdraw : Form
    {
        string _UserName;
        public frmWithdraw(string UserName)
        {
            _UserName = UserName;
            InitializeComponent();
        }

        private void frmWithdraw_Load(object sender, EventArgs e)
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

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            int NewBalance = 0;
            clsClients Client = clsClients.FindByAccountNumber(txtAccNumber.Text);
            if (Client != null)
            {
                if (MessageBox.Show("Are you sure you want to withdraw for this account number: [" + Client.AccountNumber + "]", "Withdraw Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    if (Client.Withdraw(txtAccNumber.Text, int.Parse(txtAmount.Text)))
                    {
                        NewBalance = Client.AccountBalance - int.Parse(txtAmount.Text);
                        MessageBox.Show("Withdraw done successfully, Balance now equal: [" + NewBalance + "]", "Balance Update", MessageBoxButtons.OK);
                        if (lvFindClient.Items.Count > 0)
                        {
                            lvFindClient.Items.RemoveAt(0);
                            _RefreshData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Withdraw failed, withdraw amount more than your total balance: ["+ Client.AccountBalance +"]");
                    }
                }
            }
        }
    }
}
