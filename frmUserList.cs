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
    public partial class frmUserList : Form
    {
        private string _UserName;
        public frmUserList(string UserName)
        {
            _UserName = UserName;
            InitializeComponent();
        }

        private void _RefreshData() 
        {
            dgvUsersList.DataSource = clsUsers.GetAllUser();
        }
        private void frmUserList_Load(object sender, EventArgs e)
        {
           lblUserName.Text = _UserName;
            _RefreshData();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            frmAddEditUsers frm = new frmAddEditUsers(-1, _UserName);
            frm.ShowDialog();
            _RefreshData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUsers frm = new frmAddEditUsers((int)dgvUsersList.CurrentRow.Cells[0].Value, _UserName);
            frm.ShowDialog();
            _RefreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want delete this user", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                clsUsers.DeleteUser((int)dgvUsersList.CurrentRow.Cells[0].Value);
                _RefreshData();
            }
            else 
            {
                MessageBox.Show("Delete user is failed");
            }
        }
    }
}
