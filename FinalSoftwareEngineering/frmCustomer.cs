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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=africascatering;  username =root; password=");
        MySqlCommand command;

        private void tblcustomer_Load(object sender, EventArgs e)
        {
            populateDGV();
        }
        private void populateDGV()
        {
            string selectQuery = "Select *  FROM tblcustomer";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvCustomer.DataSource = table;
        }


       

        private void dgvCustomer_MouseClick(object sender, MouseEventArgs e)
        {
           txtCustId.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtFirstName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            txtContact.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            cmbGender.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            cmbCustomerType.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
            txtStreet.Text = dgvCustomer.CurrentRow.Cells[6].Value.ToString();
            txtBarangay.Text = dgvCustomer.CurrentRow.Cells[7].Value.ToString();
            txtCity.Text = dgvCustomer.CurrentRow.Cells[8].Value.ToString();
        }
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string insertData = "INSERT INTO tblcustomer (custId, Firstname, Lastname, Contact, Gender, Type, Street, Barangay, City) VALUES ('" + txtCustId.Text + "','" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtContact.Text + "','" + cmbGender.Text + "','" + cmbCustomerType.Text + "', '" + txtStreet.Text + "', '" + txtBarangay.Text + "','" + txtCity.Text + "')";
            executeQuery(insertData);
            clearTextboxes();
            populateDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tblcustomer SET Firstname='" + txtFirstName.Text + "', Lastname='" + txtLastName.Text + "', Contact= '" + txtContact.Text + "', Gender='" + cmbGender.Text + "', Type='" + cmbCustomerType.Text + "', Street='" + txtStreet.Text + "', Barangay='" + txtBarangay.Text + "', City='" + txtCity.Text+ "' WHERE custId='" + txtCustId.Text + "'";
            executeQuery(updateQuery);
            clearTextboxes();
            populateDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = " DELETE FROM tblcustomer WHERE custId='" + txtCustId.Text + "'";
            executeQuery(deleteQuery);
            clearTextboxes();
            populateDGV();
        }

        private void dgvCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCustId.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtFirstName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            txtContact.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            cmbGender.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            cmbCustomerType.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
            txtStreet.Text = dgvCustomer.CurrentRow.Cells[6].Value.ToString();
            txtBarangay.Text = dgvCustomer.CurrentRow.Cells[7].Value.ToString();
            txtCity.Text = dgvCustomer.CurrentRow.Cells[8].Value.ToString();
        }
        void clearTextboxes()
        {
            txtCustId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            cmbGender.Text = "";
            cmbCustomerType.Text = "";
            txtStreet.Text = "";
            txtBarangay.Text = "";
            txtCity.Text = "";
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = "SELECT * FROM tblcustomer WHERE custId like '" + txtSearch.Text + "' or custFirstname like '" + txtSearch.Text + "' or custLastname like '" + txtSearch.Text +"%'";
            connection.Open();
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvCustomer.DataSource = table;
            connection.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextboxes();
        }
    }
}
