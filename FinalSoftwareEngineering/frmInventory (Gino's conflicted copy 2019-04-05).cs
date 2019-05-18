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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=africascatering;  username =root; password=");
        MySqlCommand command;
        public void populateGDV()
        {
            string selectQuery = " SELECT * FROM tblProducts ORDER BY ProductId DESC";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvProducts.DataSource = table;
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            populateGDV();
        }

        private void cmbCategories_TextChanged(object sender, EventArgs e)
        {
            string search = "SELECT * FROM tblprodcategory WHERE CategoryId like '" + cmbCategories.Text + "' or CategoryName like '" + cmbCategories.Text + "%'";

            connection.Open();
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvProducts.DataSource = table;
        }
    }
}
