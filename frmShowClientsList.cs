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
    public partial class frmShowClientsList : Form
    {
        string _UserName;
       
        public frmShowClientsList(int ClientID, string UserName)
        {
            _UserName = UserName;
            InitializeComponent();
        }

        private void _RefreshData() 
        {
            dgvClientsList.DataSource = clsClients.GetAllClients();
        }
        private void frmShowClientsList_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _UserName;
            _RefreshData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditClients frm = new frmAddEditClients((int)dgvClientsList.CurrentRow.Cells[0].Value, _UserName);
            frm.ShowDialog();
            _RefreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want delete client with id:" +
                " [" + (int)dgvClientsList.CurrentRow.Cells[0].Value +"]","Delete Confirm",
                MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                if (clsClients.DeleteClient((int)dgvClientsList.CurrentRow.Cells[0].Value)) 
                {
                    MessageBox.Show("Delete done successfully");
                    _RefreshData();
                }
                else 
                {
                    MessageBox.Show("Delete failed");
                }
            }
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            frmAddEditClients frm = new frmAddEditClients(-1, _UserName);
            frm.ShowDialog();
            _RefreshData();
        }
    }
}
