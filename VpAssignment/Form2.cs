using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VpAssignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            string query = "SELECT COUNT(*) FROM Users_New WHERE Email = @Email AND Password = @Password";

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["UserDBConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 1)
                    {
                        MessageBox.Show("Login successful!");

                        DashboardForm dashboard = new DashboardForm(email);
                        dashboard.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 registrationForm = new Form1();  
            registrationForm.Show();
            this.Hide();  
        }

    }
}
