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
    public partial class frmFileMaintenance : Form
    {
        public frmFileMaintenance()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.Show();

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier supplier = new frmSupplier();
            supplier.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProducts product = new frmProducts();
            product.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmProductCategory category = new frmProductCategory();
            category.Show();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            frmProductType type = new frmProductType();
            type.Show();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            frmProductUnit unit = new frmProductUnit();
            unit.Show();

        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            frmProductSize size = new frmProductSize();
            size.Show();
        }

        private void bntSubCategory_Click(object sender, EventArgs e)
        {
            frmProductSubCategory subcategory = new frmProductSubCategory();
            subcategory.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDiscount discount = new frmDiscount();
            discount.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
