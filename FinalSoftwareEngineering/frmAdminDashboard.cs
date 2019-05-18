using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSoftwareEngineering
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void btnFIlemaintenance_Click(object sender, EventArgs e)
        {
            frmFileMaintenance file = new frmFileMaintenance();
            file.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            frmRental rental = new frmRental();
            rental.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            frmPurchase purchase = new frmPurchase();
            purchase.Show();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTransactions transaction = new frmTransactions();
            transaction.Show();
        }
    }
}
