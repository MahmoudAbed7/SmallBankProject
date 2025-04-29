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
    public partial class frmBankClientsUI : Form
    {
        string _UserName;
        public frmBankClientsUI(string UserName)
        {
            _UserName = UserName;
            InitializeComponent();
        }
        private void frmBankClientsUI_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _UserName;
        }

        private void btnShowUserList_Click(object sender, EventArgs e)
        {
            frmUserList frm = new frmUserList(_UserName);
            frm.ShowDialog();
        }

        private void btnShowClientList_Click(object sender, EventArgs e)
        {
            lblUserName.Text= _UserName;
            frmShowClientsList frm = new frmShowClientsList(-1, _UserName);
            frm.ShowDialog();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            frmFindClient frm = new frmFindClient(_UserName);
            frm.ShowDialog();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmTransaction frm = new frmTransaction(_UserName);
            frm.ShowDialog();
        }
    }
}
