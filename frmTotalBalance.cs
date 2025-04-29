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
    public partial class frmTotalBalance : Form
    {
        string _UserName;
        public frmTotalBalance(string userName)
        {
            InitializeComponent();
            _UserName = userName;
        }

        private void frmTotalBalance_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _UserName;
            lblTotalBalance.Text = clsClients.GetTotalBalance().ToString() + "$";
        }
    }
}
