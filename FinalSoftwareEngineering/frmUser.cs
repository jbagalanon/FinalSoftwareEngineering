using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalSoftwareEngineering
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=africascatering;  username =root; password=");
        MySqlCommand command;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmUsers_Load(object sender, EventArgs e)
        {
            populateDGV();
        }

        private void populateDGV()
        {
            string selectQuery = "Select *  FROM tblusers";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvUsers.DataSource = table;
        }

        private void dgvUsers_MouseClick(object sender, MouseEventArgs e)
        {
            txtUserId.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            txtFirstName.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            txtUsername.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            txtUserPassword.Text = dgvUsers.CurrentRow.Cells[4].Value.ToString();
            txtContact.Text = dgvUsers.CurrentRow.Cells[5].Value.ToString();
            txtStreet.Text = dgvUsers.CurrentRow.Cells[6].Value.ToString();
            txtBarangay.Text = dgvUsers.CurrentRow.Cells[7].Value.ToString();
            txtCity.Text = dgvUsers.CurrentRow.Cells[8].Value.ToString();
            cmbGender.Text = dgvUsers.CurrentRow.Cells[9].Value.ToString();
            cmbUserType.Text = dgvUsers.CurrentRow.Cells[10].Value.ToString();
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
            string insertData = "INSERT INTO tblusers (userId, firstname, lastname, username, password, contact, street, barangay, city, gender, usertype) VALUES ('"+ txtUserId.Text+ "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtUsername.Text + "', '" + txtUserPassword.Text + "', '" + txtContact.Text + "', '" + txtStreet.Text + "', '" + txtBarangay.Text + "', '" + txtCity.Text + "', '" + cmbGender.Text + "', '" + cmbUserType.Text + "')";
            executeQuery(insertData);
            clearTextboxes();
            populateDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tblusers SET firstname='" + txtFirstName.Text + "', lastname='" + txtLastName.Text + "',username= '" + txtUsername.Text + "', password='" + txtUserPassword.Text + "', contact='" + txtContact.Text + "', street='" + txtStreet.Text + "', barangay='" + txtBarangay.Text + "', city='" + txtCity.Text + "', gender='" + cmbGender.Text + "', usertype='" + cmbUserType.Text + "' WHERE userId ='" + txtUserId.Text + "'";
            executeQuery(updateQuery);
            clearTextboxes();
            populateDGV();




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = " DELETE FROM tblusers WHERE userId='" + txtUserId.Text + "'";
            executeQuery(deleteQuery);
            clearTextboxes();
            populateDGV();

        }

        private void dgvUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUserId.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            txtFirstName.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            txtUsername.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            txtUserPassword.Text = dgvUsers.CurrentRow.Cells[4].Value.ToString();
            txtContact.Text = dgvUsers.CurrentRow.Cells[5].Value.ToString();
            txtStreet.Text = dgvUsers.CurrentRow.Cells[6].Value.ToString();
            txtBarangay.Text = dgvUsers.CurrentRow.Cells[7].Value.ToString();
            txtCity.Text = dgvUsers.CurrentRow.Cells[8].Value.ToString();
            cmbGender.Text = dgvUsers.CurrentRow.Cells[9].Value.ToString();
            cmbUserType.Text = dgvUsers.CurrentRow.Cells[10].Value.ToString();
                        
        }

        void clearTextboxes()
        {

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtUserPassword.Text = "";
            txtContact.Text = "";
            txtStreet.Text = "";
            txtBarangay.Text = "";
            txtCity.Text = "";
            cmbGender.Text = "";
            cmbUserType.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            string search = "SELECT * FROM tblusers WHERE userId like '" + txtUserSearch.Text + "' or firstname like '" + txtUserSearch.Text + "' or lastname like '" + txtUserSearch.Text + "%'";
            connection.Open();
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvUsers.DataSource = table;
            connection.Close();
        }
    }
}
   // }



