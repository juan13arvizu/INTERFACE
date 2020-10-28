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

namespace USER
{
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
        }
        private void Login()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=user";
            string query = "SELECT * FROM user where Username = '" + UsertxtBox.Text + "'AND Password='" + PswtxtBox.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader bibliophile;


            try
            {
                databaseConnection.Open();
                bibliophile = commandDatabase.ExecuteReader();
                if (bibliophile.Read())
                {
                    MessageBox.Show("ACCESS ACCEPTED");
                }
                else
                {
                    MessageBox.Show("Username/Password, MISTAKEN.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Register()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=user";
            string query = "INSERT * INTO user (`id`,`Username`, `Password`) VALUES (NULL, '" + UsertxtBox.Text + "','" + PswtxtBox.Text + "')";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader bibliophile;


            try
            {
                databaseConnection.Open();
                bibliophile = commandDatabase.ExecuteReader();
                if (bibliophile.Read())
                {
                    MessageBox.Show("SUCCESSFUL REGISTARING");
                }
                else
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Access_Button_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void UsertxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PswtxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (UsertxtBox.Text == "")
                {
                    MessageBox.Show("Username is missing");

                }
                else if (PswtxtBox.Text == "")
                {
                    MessageBox.Show("Password is missing");

                }
                else if (UsertxtBox.Text == "" && PswtxtBox.Text == "")
                {
                    MessageBox.Show("Come on, both are missing!");

                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void Save_Botton_Click(object sender, EventArgs e)
        {

            try
            {
                if (UsertxtBox.Text == "")
                {
                    MessageBox.Show("Username is missing");

                }
                else if (PswtxtBox.Text == "")
                {
                    MessageBox.Show("Password is missing");

                }
                else if (UsertxtBox.Text == "" && PswtxtBox.Text == "")
                {
                    MessageBox.Show("Come on, both are missing!");

                }
                else
                {
                    Register();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void RegisterButton__Click(object sender, EventArgs e)
        {
            Register registered = new Register();
            registered.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
 