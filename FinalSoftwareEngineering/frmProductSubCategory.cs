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
    public partial class frmProductSubCategory : Form
    {
        public frmProductSubCategory()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=africascatering;  username =root; password=");
        MySqlCommand command;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductSubCategory_Load(object sender, EventArgs e)
        {
            populateDGV();
        }


        private void populateDGV()
        {
            string selectQuery = "Select *  FROM tblProdSub";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvSubCategories.DataSource = table;
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
            txtSubCatId.Text = string.Empty;
            txtSubCatname.Text = string.Empty;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string insertData = "INSERT INTO tblProdSub (SubCatId, Subcategory) VALUES ('" + txtSubCatId.Text + "', '" + txtSubCatname.Text + "')";
            executeQuery(insertData);
            clearTextboxes();
            populateDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tblProdSub SET Subcategory='" + txtSubCatname.Text + "' WHERE Subcatid = '" + txtSubCatId.Text + "'";
            executeQuery(updateQuery);
            clearTextboxes();
            populateDGV();
        }



        private void dgvSubCategories_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSubCatId.Text = dgvSubCategories.CurrentRow.Cells[0].Value.ToString();
            txtSubCatname.Text = dgvSubCategories.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = " DELETE FROM tblProdSub WHERE Subcatid='" + txtSubCatId.Text + "'";
            executeQuery(deleteQuery);
            clearTextboxes();
            populateDGV();
        }

        private void txtSubCatSearch_TextChanged(object sender, EventArgs e)
        {
            string search = "SELECT * FROM tblprodsub WHERE SubCatId like '" + txtSubCatSearch.Text + "' or SubCategory like '" + txtSubCatSearch.Text + "%'";
            connection.Open();
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvSubCategories.DataSource = table;
            connection.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
