using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankWindowsForm
{
    public partial class frmTransaction : Form
    {
        string _UserName;
        public frmTransaction(string userName)
        {
            InitializeComponent();
            _UserName = userName;
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _UserName;
        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            frmDeposite frm = new frmDeposite(_UserName);
            frm.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            frmWithdraw frm = new frmWithdraw(_UserName);
            frm.ShowDialog();
        }

        private void btnTotalBalance_Click(object sender, EventArgs e)
        {
            frmTotalBalance frm = new frmTotalBalance(_UserName);
            frm.ShowDialog();
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            frmTransfer frm = new frmTransfer(_UserName);
            frm.ShowDialog();
        }
    }
}
