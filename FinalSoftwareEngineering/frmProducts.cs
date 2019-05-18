using MySql.Data.MySqlClient;
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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=africascatering;  username =root; password=");
        MySqlCommand command;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
       
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT CategoryName FROM tblprodcategory", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbCategory.DataSource = table;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryName";


            MySqlDataAdapter adapter1 = new MySqlDataAdapter("SELECT SubCategory FROM tblprodsub", connection);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);
            cmbSubCategory.DataSource = table1;
            cmbSubCategory.DisplayMember = "SubCategory";
            cmbSubCategory.ValueMember = "SubCategory";


            MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT TypeName FROM tblprodtype", connection);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            cmbType.DataSource = table2;
            cmbType.DisplayMember = "TypeName";
            cmbType.ValueMember = "TypeName";

            MySqlDataAdapter adapter3 = new MySqlDataAdapter("SELECT SizeName FROM tblprodsize", connection);
            DataTable table3 = new DataTable();
            adapter3.Fill(table3);
            cmbSize.DataSource = table3;
            cmbSize.DisplayMember = "SizeName";
            cmbSize.ValueMember = "SizeName";

            MySqlDataAdapter adapter4 = new MySqlDataAdapter("SELECT UnitName FROM tblprodunit", connection);
            DataTable table4 = new DataTable();
            adapter4.Fill(table4);
            cmbUnit.DataSource = table4;
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "UnitName";



            populateDGV();
        }

        private void populateDGV()
        {
            string selectQuery = "Select *  FROM tblProducts";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvProducts.DataSource = table;
        }

        #region Execute Query Database
        public void executeQuery(string query)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                    MessageBox.Show("Query not executed");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        private void dgvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtProductId.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            cmbSubCategory.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            cmbType.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
            cmbSize.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            cmbUnit.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();
            txtRate.Text = dgvProducts.CurrentRow.Cells[7].Value.ToString();
            
        }

        void clearTextboxes()
        {
            txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            cmbCategory.Text = string.Empty;
            cmbSubCategory.Text = string.Empty;
            cmbType.Text = string.Empty;
            cmbSize.Text = string.Empty;
            cmbUnit.Text = string.Empty;
            txtRate.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string insertData = "INSERT INTO tblsupplier (supplierId, companyname, supType, supFirstname, supLastname, supContact, supStreet, supBarangay, supCity) VALUES ('" + txtSupplierId.Text + "','" + txtCompanyname.Text + "', '" + cmbSupplierType.Text + "', '" + txtFirstname.Text + "','" + txtLastname.Text + "','" + txtContact.Text + "', '" + txtStreet.Text + "', '" + txtBarangay.Text + "','" + txtCity.Text + "')";

            string insertData = "INSERT INTO tblproducts(productId, ProductName, Category, SubCategory, Type, Size, Unit, Rate) VALUES ('" + txtProductId.Text + "', '" + txtProductName.Text + "','" + cmbCategory.Text + "','" + cmbSubCategory.Text + "','" + cmbType.Text + "','" + cmbSize.Text + "','" + cmbUnit.Text + "','" + txtRate.Text + "')";
            executeQuery(insertData);
            clearTextboxes();
            populateDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tblProducts SET Productname='" + txtProductName.Text + "', Category='" +cmbCategory.Text+ "', Subcategory = '"+cmbSubCategory.Text+ "', Type ='"+cmbType.Text+ "', Size = '"+cmbSize.Text+ "', Unit='"+cmbUnit.Text+ "', rate ='"+txtRate.Text+ "' WHERE ProductId = '" + txtProductId.Text + "'";
            executeQuery(updateQuery);
            clearTextboxes();
            populateDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = " DELETE FROM tblProducts WHERE productId='" + txtProductId.Text + "'";
            executeQuery(deleteQuery);
            clearTextboxes();
            populateDGV();
        }

  

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = "SELECT * FROM tblproducts WHERE productId like '" + txtSearch.Text + "' or ProductName like '" + txtSearch.Text + "' or Category like '" + txtSearch.Text + "' or SubCategory like '" + txtSearch.Text + "%'";
            connection.Open();
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvProducts.DataSource = table;
            connection.Close();
        }

        private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
