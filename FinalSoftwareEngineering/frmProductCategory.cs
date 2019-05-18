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
    public partial class frmProductCategory : Form
    {
        public frmProductCategory()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=africascatering;  username =root; password=");
        MySqlCommand command;


        private void frmProductCategory_Load(object sender, EventArgs e)
        {
            populateDGV();
        }


        private void populateDGV()
        {
            string selectQuery = "Select *  FROM tblProdcategory";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvCategories.DataSource = table;
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



        private void btnADD_Click(object sender, EventArgs e)

        {
            string insertData = "INSERT INTO tblProdCategory (CategoryId, CategoryName) VALUES ('" + txtCategoryId.Text + "', '" + txtCategoryName.Text + "')";
            executeQuery(insertData);
            clearTextboxes();
            populateDGV();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string insertData = "Update tblProdCategory set CategoryName='" + txtCategoryName.Text + "' where CategoryID ='" + txtCategoryId.Text + "'";
            executeQuery(insertData);
            clearTextboxes();
            populateDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = " DELETE FROM tblProdCategory WHERE CategoryID ='" + txtCategoryId.Text + "'";
            executeQuery(deleteQuery);
            clearTextboxes();
            populateDGV();
        }

        void clearTextboxes()
        {
            txtCategoryId.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategories_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtCategoryId.Text = dgvCategories.CurrentRow.Cells[0].Value.ToString();
            txtCategoryName.Text = dgvCategories.CurrentRow.Cells[1].Value.ToString();

        }

        private void txtCategorySearch_TextChanged(object sender, EventArgs e)
        {
            string search = "SELECT * FROM tblprodcategory WHERE CategoryId like '" + txtCategorySearch.Text + "' or CategoryName like '" + txtCategorySearch.Text + "%'";
            connection.Open();
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvCategories.DataSource = table;
            connection.Close();
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
