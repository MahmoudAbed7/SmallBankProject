using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BankClientsBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankWindowsForm
{
    public partial class frmFindClient : Form
    {
        string _UserName;
        public frmFindClient(string UserName)
        {
            _UserName = UserName;
            InitializeComponent();
        }

        private void frmFindClient_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _UserName;
            lvFindClient.Visible = false;
        }

        private void _FindClient() 
        {
            clsClients client = clsClients.Find(txtNameSearch.Text);
            if (client != null)
            {
                lvFindClient.Visible = true;
                ListViewItem Item = new ListViewItem(txtNameSearch.Text.Trim());
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
        private void btnSerach_Click(object sender, EventArgs e)
        {
           _FindClient();
        }
    }
}
