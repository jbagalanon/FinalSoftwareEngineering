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
         string selectQuery = " SELECT * FROM tblProducts";
        DataTable table = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
        adapter.Fill(table);
        dgvInventory.DataSource = table;
            }

private void frmInventory_Load(object sender, EventArgs e)
        {
            populateGDV();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT CategoryName FROM tblprodcategory", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbCategories.DataSource = table;
           cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryName";


            MySqlDataAdapter adapter1 = new MySqlDataAdapter("SELECT SubCategory FROM tblprodsub", connection);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);
            cmbSubCategory.DataSource = table1;
            cmbSubCategory.DisplayMember = "SubCategory";
            cmbSubCategory.ValueMember = "SubCategory";


            MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT TypeName FROM tblprodtype", connection);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            cmbType.DataSource = table2;
            cmbType.DisplayMember = "TypeName";
            cmbType.ValueMember = "TypeName";

            MySqlDataAdapter adapter3 = new MySqlDataAdapter("SELECT SizeName FROM tblprodsize", connection);
            DataTable table3 = new DataTable();
            adapter3.Fill(table3);
            cmbSize.DataSource = table3;
            cmbSize.DisplayMember = "SizeName";
            cmbSize.ValueMember = "SizeName";

            MySqlDataAdapter adapter4 = new MySqlDataAdapter("SELECT UnitName FROM tblprodunit", connection);
            DataTable table4 = new DataTable();
            adapter4.Fill(table4);
            cmbUnit.DataSource = table4;
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "UnitName";

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            
            string search = "SELECT productId, ProductName, Category, SubCategory, Type, Size, Unit, Rate FROM tblProducts Where Category Like '" + cmbCategories.Text + "'and SubCategory Like '" + cmbSubCategory.Text + "' and Type Like'" + cmbType.Text + "' and Size Like'" + cmbSize.Text + "' and Unit Like'" + cmbUnit.Text + "'";
           
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(search, connection);
            adapter.Fill(table);
            dgvInventory.DataSource = table;
            
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = "SELECT productId, ProductName, Category, SubCategory, Type, Size, Unit, Rate FROM tblProducts WHERE Category like '" + cmbCategories.Text + "'";

            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvInventory.DataSource = table;
         
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

            string search = "SELECT productId, ProductName, Category, SubCategory, Type, Size, Unit, Rate FROM tblProducts WHERE Type like '" + cmbType.Text + "'";
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvInventory.DataSource = table;

        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {


            string search = "SELECT productId, ProductName, Category, SubCategory, Type, Size, Unit, Rate FROM tblProducts WHERE Unit like '" + cmbUnit.Text + "'";
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvInventory.DataSource = table;

        }

        private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            string search = "SELECT productId, ProductName, Category, SubCategory, Type, Size, Unit, Rate FROM tblProducts WHERE SubCategory like '" + cmbSubCategory.Text + "'";
            command = new MySqlCommand(search, connection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            dgvInventory.DataSource = table;


        }
    }
    }

