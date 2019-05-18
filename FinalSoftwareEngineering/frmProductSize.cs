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
    public partial class frmProductSize : Form
    {
        public frmProductSize()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=africascatering;  username =root; password=");
        MySqlCommand command;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductSize_Load(object sender, EventArgs e)
        {
            populateDGV();
        }

        private void populateDGV()
        {
            string selectQuery = "Select *  FROM tblProdSize";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvProdSize.DataSource = table;
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
            string insertData = "INSERT INTO tblProdSize (SizeId, SizeName) VALUES ('" + txtSizeid.Text + "', '" + txtSizeName.Text + "')";
            executeQuery(insertData);
            clearTextboxes();
            populateDGV();
        }

        void clearTextboxes()
        {
            txtSizeName.Text = string.Empty;
            txtSizeid.Text = string.Empty;
        }

        private void dgvProdSize_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSizeid.Text = dgvProdSize.CurrentRow.Cells[0].Value.ToString();
            txtSizeName.Text = dgvProdSize.CurrentRow.Cells[1].Value.ToString();
        }

    
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tblProdSize SET sizename='" + txtSizeName.Text + "' WHERE SizeId = '" + txtSizeid.Text + "'";
            executeQuery(updateQuery);
            clearTextboxes();
            populateDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = " DELETE FROM tblProdSize WHERE Sizeid='" + txtSizeid.Text + "'";
            executeQuery(deleteQuery);
            clearTextboxes();
            populateDGV();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = "SELECT * FROM tblprodsize WHERE SizeId like '" + txtSearch.Text + "' or SizeName like '" + txtSearch.Text + "%'";
            connection.Open();
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvProdSize.DataSource = table;
            connection.Close();
        }

        private void txtSizeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
