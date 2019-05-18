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
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=africascatering;  username =root; password=");
        MySqlCommand command;

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            populateDGV();
        }
        private void populateDGV()
        {
            string selectQuery = "Select *  FROM tblsupplier";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvSupplier.DataSource = table;
        }


        private void dgvSupplier_MouseClick(object sender, MouseEventArgs e)
        {
            txtSupplierId.Text = dgvSupplier.CurrentRow.Cells[0].Value.ToString();
            txtCompanyname.Text = dgvSupplier.CurrentRow.Cells[1].Value.ToString();
            cmbSupplierType.Text = dgvSupplier.CurrentRow.Cells[2].Value.ToString();
            txtFirstname.Text = dgvSupplier.CurrentRow.Cells[3].Value.ToString();
            txtLastname.Text = dgvSupplier.CurrentRow.Cells[4].Value.ToString();
            txtContact.Text = dgvSupplier.CurrentRow.Cells[5].Value.ToString();
            txtStreet.Text = dgvSupplier.CurrentRow.Cells[6].Value.ToString();
            txtBarangay.Text = dgvSupplier.CurrentRow.Cells[7].Value.ToString();
            txtCity.Text = dgvSupplier.CurrentRow.Cells[8].Value.ToString();
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string insertData = "INSERT INTO tblsupplier (supplierId, companyname, Type, Firstname, Lastname, Contact, Street, Barangay, City) VALUES ('" + txtSupplierId.Text + "','" + txtCompanyname.Text + "', '" + cmbSupplierType.Text + "', '" + txtFirstname.Text + "','" + txtLastname.Text + "','" + txtContact.Text + "', '" + txtStreet.Text + "', '" + txtBarangay.Text + "','" + txtCity.Text + "')";
            executeQuery(insertData);
            clearTextboxes();
            populateDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tblsupplier SET companyname='" + txtCompanyname.Text + "', Type='" + cmbSupplierType.Text + "', Firstname= '" + txtFirstname.Text + "', Lastname='" + txtLastname.Text + "', Contact='" + txtContact.Text + "', Street='" + txtStreet.Text + "', Barangay='" + txtBarangay.Text + "', City='" + txtCity.Text + "' WHERE supplierId='" + txtSupplierId.Text + "'";
            executeQuery(updateQuery);
            clearTextboxes();
            populateDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = " DELETE FROM tblsupplier WHERE supplierId='" + txtSupplierId.Text + "'";
            executeQuery(deleteQuery);
            clearTextboxes();
            populateDGV();
        }

        private void dgvSupplier_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSupplierId.Text = dgvSupplier.CurrentRow.Cells[0].Value.ToString();
            txtCompanyname.Text = dgvSupplier.CurrentRow.Cells[1].Value.ToString();
            cmbSupplierType.Text = dgvSupplier.CurrentRow.Cells[2].Value.ToString();
            txtFirstname.Text = dgvSupplier.CurrentRow.Cells[3].Value.ToString();
            txtLastname.Text = dgvSupplier.CurrentRow.Cells[4].Value.ToString();
            txtContact.Text = dgvSupplier.CurrentRow.Cells[5].Value.ToString();
            txtStreet.Text = dgvSupplier.CurrentRow.Cells[6].Value.ToString();
            txtBarangay.Text = dgvSupplier.CurrentRow.Cells[7].Value.ToString();
            txtCity.Text = dgvSupplier.CurrentRow.Cells[8].Value.ToString();
        }
        void clearTextboxes()
        {
            txtSupplierId.Text = "";
            txtCompanyname.Text = "";
            cmbSupplierType.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtContact.Text = "";
            txtStreet.Text = "";
            txtBarangay.Text = "";
            txtCity.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextboxes();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = "SELECT * FROM tblsupplier WHERE supplierId like '" + txtSearch.Text + "' or companyname like '" + txtSearch.Text +"%'";
            connection.Open();
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvSupplier.DataSource = table;
            connection.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSupplierId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSupplierId_Click(object sender, EventArgs e)
        {

        }
    }
    }

