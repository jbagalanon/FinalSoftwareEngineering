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
    public partial class frmUserdashboard : Form
    {
        public frmUserdashboard()
        {
            InitializeComponent();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            frmRental rental = new frmRental();
            rental.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void btnFIlemaintenance_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.Show();
        }
    }
}
