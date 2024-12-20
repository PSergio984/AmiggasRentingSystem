using AmiggasRenting;
using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class LoginPageForm : Form
    {
        // Connection string for the SQLite database
        private static string connectionString;

        public LoginPageForm()
        {
            InitializeComponent();

            // Set up the database connection string
            try
            {
                // Navigate up to the correct project root
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                DirectoryInfo directory = new DirectoryInfo(baseDir);

                // Explicitly navigate up to "AmiggasRentingSystem"
                while (directory != null && !directory.Name.Equals("AmiggasRentingSystem", StringComparison.OrdinalIgnoreCase))
                {
                    directory = directory.Parent;
                }

                if (directory == null)
                {
                    MessageBox.Show("Project root 'AmiggasRentingSystem' could not be determined. Please check the directory structure.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Construct the database file path
                string projectRoot = directory.FullName;
                string dbFilePath = Path.Combine(projectRoot, "Database", "rentingDB.db");

                // Set the connection string
                connectionString = $@"Data Source={dbFilePath};Version=3;";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while setting up the database path: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the login button click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate input
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

                    // Query to check if the email and password hash match
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
                            // Navigate to the HomePage using the singleton instance
                            HomePage.Instance.lblUser.Text = email;
                            HomePage.Instance.Show();

                            this.Dispose(); // Dispose of the current form


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
                MessageBox.Show($"SQLite error occurred: {sqliteEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Event handler for label click event (optional)
        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click event if needed
        }

        // Event handler for form load event (optional)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Handle form load event if needed
        }

        private bool isExiting = false;

        private void LoginPageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingHelper.HandleFormClosing(e);
        }



        private void btnShow_Click_1(object sender, EventArgs e)
        {
            // Show the password
            txtPassword.PasswordChar = '\0'; // Remove masking to show the password

            // Bring the hide button to the front
            btnHide.BringToFront();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            // Hide the password
            txtPassword.PasswordChar = '*'; // Set masking character to hide the password

            // Bring the show button to the front
            btnShow.BringToFront();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}

