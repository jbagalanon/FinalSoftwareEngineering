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
    public partial class frmRental : Form
    {
        public frmRental()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; database=africascatering;  username =root; password=");
        MySqlCommand command;
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void frmRental_Load(object sender, EventArgs e)
        {
   
        }
        }
    }
