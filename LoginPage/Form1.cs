using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;  // To handle file paths

namespace LoginPage
{
    public partial class Form1 : Form
    {
        // Build the connection string using relative path
        private static string connectionString = @"Data Source=rentingDB.db;Version=3;";


        public Form1()
        {
            InitializeComponent();

           
          

     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            


            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Connect to the SQLite database
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    // Query to check if the email and password match
                    string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND passwordHash = @Password";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        // Use parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Execute the query
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Navigate to the next form or main application here
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SQLiteException sqliteEx)
            {
                MessageBox.Show($"SQLite error occurred: {sqliteEx.Message}", "SQLite Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
