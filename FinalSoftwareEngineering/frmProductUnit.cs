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
    public partial class frmProductUnit : Form
    {
        public frmProductUnit()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=africascatering;  username =root; password=");
        MySqlCommand command;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductUnit_Load(object sender, EventArgs e)
        {
            populateDGV();
        }

        private void populateDGV()
        {
            string selectQuery = "Select *  FROM tblProdunit";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvProductUnit.DataSource = table;
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
                    MessageBox.Show("Data successfully updated");
                }
                else
                    MessageBox.Show("Process Failed");

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
            string insertData = "INSERT INTO tblProdunit (UnitId, UnitName) VALUES ('" +txtUnitId.Text+ "', '" +txtProductUnit.Text+ "')";
            executeQuery(insertData);
            clearTextboxes();
            populateDGV();
        }


              

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tblProdUnit SET UnitName='" + txtProductUnit.Text + "' WHERE unitID = '" + txtUnitId.Text + "'";
            executeQuery(updateQuery);
            clearTextboxes();
            populateDGV();
        }

        void clearTextboxes()
        {
            txtUnitId.Text = string.Empty;
            txtProductUnit.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = " DELETE FROM tblProdUnit WHERE Unitid='" + txtUnitId.Text + "'";
            executeQuery(deleteQuery);
            clearTextboxes();
            populateDGV();
        }

        private void dgvProductUnit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUnitId.Text = dgvProductUnit.CurrentRow.Cells[0].Value.ToString();
            txtProductUnit.Text = dgvProductUnit.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtProductUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductUnitSearch_TextChanged(object sender, EventArgs e)
        {
            string search = "SELECT * FROM tblprodunit WHERE UnitId like '" + txtProductUnitSearch.Text + "' or UnitName like '" + txtProductUnitSearch.Text + "%'";
            connection.Open();
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvProductUnit.DataSource = table;
            connection.Close();
        }
    }
}
