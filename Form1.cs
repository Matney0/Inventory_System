using Microsoft.Data.SqlClient; // Use Microsoft.Data.SqlClient instead of System.Data.SqlClient
using System.Data;
using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string username = textBox1.Text;
            string password = textBox2.Text;
            string connectionstring;
            connectionstring = @"Data Source=BB21318\SQL_FALL_MATNEY;Initial Catalog=Login;User ID=user;password=matney;TrustServerCertificate=True";

            using (Microsoft.Data.SqlClient.SqlConnection con = new Microsoft.Data.SqlClient.SqlConnection(connectionstring))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";
                    Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string username = textBox4.Text;
            string password = textBox3.Text;
            string connectionstring;
            connectionstring = @"Data Source=BB21318\SQL_FALL_MATNEY;Initial Catalog=Login;User ID=user;password=matney;TrustServerCertificate=True";

            using (Microsoft.Data.SqlClient.SqlConnection con = new Microsoft.Data.SqlClient.SqlConnection(connectionstring))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                    Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Registered Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}


