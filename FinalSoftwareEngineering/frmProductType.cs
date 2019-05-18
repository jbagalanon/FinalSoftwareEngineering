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
    public partial class frmProductType : Form
    {
        public frmProductType()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=africascatering;  username =root; password=");
        MySqlCommand command;

        private void populateDGV()
        {
            string selectQuery = "Select *  FROM tblProdType";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvProdType.DataSource = table;
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
            string insertData = "INSERT INTO tblProdType (TypeId, TypeName) VALUES ('" + txtProdtypeId.Text + "', '" + txtProdType.Text + "')";
            executeQuery(insertData);
            clearTextboxes();
            populateDGV();
        }
                  

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tblProdType SET Typename='" + txtProdType.Text + "' WHERE TypeId = '" + txtProdtypeId.Text + "'";
            executeQuery(updateQuery);
            clearTextboxes();
            populateDGV();
        }
        void clearTextboxes()
        {
            txtProdtypeId.Text = string.Empty;
            txtProdtypeId.Text = string.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = " DELETE FROM tblProdType WHERE Typeid='" + txtProdtypeId.Text + "'";
            executeQuery(deleteQuery);
            clearTextboxes();
            populateDGV();
        }

        private void frmProductType_Load(object sender, EventArgs e)
        {
            populateDGV();
        }

        private void dgvProdType_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtProdtypeId.Text = dgvProdType.CurrentRow.Cells[0].Value.ToString();
            txtProdType.Text = dgvProdType.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtProdTypeSearch_TextChanged(object sender, EventArgs e)
        {
            string search = "SELECT * FROM tblprodtype WHERE TypeId like '" + txtProdTypeSearch.Text + "' or TypeName like '" + txtProdTypeSearch.Text + "%'";
            connection.Open();
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvProdType.DataSource = table;
            connection.Close();
        }
    }
}
