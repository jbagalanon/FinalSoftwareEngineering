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
    public partial class frmDiscount : Form
    {
        public frmDiscount()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=africascatering;  username =root; password=");
        MySqlCommand command;
        private void frmDiscount_Load(object sender, EventArgs e)
        {
            populateDGV();
        }
        private void populateDGV()
        {
            string selectQuery = "Select *  FROM tbldiscount";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
           dgvDiscount.DataSource = table;
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
        void clearTextboxes()
        {
            txtDiscountId.Text = string.Empty;
            txtDiscountName.Text = string.Empty;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string insertData = "INSERT INTO tbldiscount (DiscountID, DiscountName) VALUES ('" + txtDiscountId.Text + "', '" + txtDiscountName.Text + "')";
            executeQuery(insertData);
            clearTextboxes();
            populateDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tbldiscount SET DiscountName='" + txtDiscountName.Text + "' WHERE DiscountID = '" + txtDiscountId.Text + "'";
            executeQuery(updateQuery);
            clearTextboxes();
            populateDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = " DELETE FROM tbldiscount WHERE DiscountID='" + txtDiscountId.Text + "'";
            executeQuery(deleteQuery);
            clearTextboxes();
            populateDGV();
        }

        private void txtSubCatSearch_TextChanged(object sender, EventArgs e)
        {
            string search = "SELECT * FROM tbldiscount WHERE DiscountID like '" + txtDiscountSearch.Text + "' or DiscountName like '" + txtDiscountSearch.Text + "%'";
            connection.Open();
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvDiscount.DataSource = table;
            connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAdminDashboard frm = new frmAdminDashboard();
            frm.Show();
        }
    }
}
