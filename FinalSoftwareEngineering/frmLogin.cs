using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalSoftwareEngineering
{
    public partial class frmLogin : Form
    {

        public string connectionString = "server = localhost; database=africascatering; username=root; password=;";
        string user = "";
        string pass = "";

        private MySqlConnection connection;

        public frmLogin()
        {
            InitializeComponent();
        }

        public void forUser()
        {
            user = txtUsername.Text;
            pass = txtPassword.Text;
            try
            {
                softwen2_db();
                MySqlCommand command = new MySqlCommand();
                //  command.CommandText = "SELECT Username, Password FROM admin WHERE Username=@user AND Password=@pass";
                command.CommandText = "SELECT username, password FROM tblusers WHERE username=@user AND password=@pass";
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@pass", pass);
                command.Connection = connection;
                MySqlDataReader login = command.ExecuteReader();

                if (login.Read())
                {
                    MessageBox.Show("LOGGED IN SUCCESSFUL!");
                    connection.Close();

                    frmUserdashboard user = new frmUserdashboard();

                    if (rbnuser.Checked == true)
                    {
                        
                    }

                    this.Hide();
                    user.Show();
                }

                else
                {
                    MessageBox.Show("INCORRECT USERNAME AND PASSWORD!!");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                    rbnadmin.Checked = false;
                    rbnuser.Checked = false;
                    connection.Close();

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        public void forAdmin()
        {
            user = txtUsername.Text;
            pass = txtPassword.Text;
            try
            {
                softwen2_db();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "SELECT Username, Password FROM admin WHERE Username=@user AND Password=@pass";
                // command.CommandText = "SELECT username, password FROM user WHERE username=@user AND password=@pass";
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@pass", pass);
                command.Connection = connection;
                MySqlDataReader login = command.ExecuteReader();

                if (login.Read())
                {
                    MessageBox.Show("LOGGED IN SUCCESSFULLY!");
                    connection.Close();

                    frmAdminDashboard admin = new frmAdminDashboard();

                    this.Hide();
                    admin.Show();
                }

                else
                {
                   

                    MessageBox.Show("INCORRECT USERNAME AND PASSWORD!");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                    rbnadmin.Checked = false;
                    rbnuser.Checked = false;
                    connection.Close();
                   
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void softwen2_db()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = txtUsername.Text;
            pass = txtPassword.Text;


            if (rbnadmin.Checked == true || rbnuser.Checked == true)
            {


                if (user == "" || pass == "")
                {
                    MessageBox.Show("EMPTY FIELDS");
                }
                else
                {

                    if (rbnadmin.Checked == true)
                    {
                        forAdmin();

                    }
                    else
                    {
                        forUser();
                    }

                }
            }
            else
            {
                MessageBox.Show("Please select what type of login do you want to access!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
