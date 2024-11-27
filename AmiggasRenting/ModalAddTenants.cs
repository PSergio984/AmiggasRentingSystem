using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AmiggasRenting
{
    public partial class ModalAddTenants : Form
    {
        private DatabaseManager dbManager;
        private int? tenantID; // Nullable int to store tenant ID for editing
        private int i = 0;

        public ModalAddTenants(int? tenantID = null)
        {
            InitializeComponent();

            // Initialize the timer
            ModalEffect_Timer.Interval = 20; // Set the interval to 20 milliseconds
            ModalEffect_Timer.Tick += new EventHandler(ModalEffect_Timer_Tick);
            // Initialize the DatabaseManager
            dbManager = new DatabaseManager();

            this.tenantID = tenantID;
        }

        private void ModalAddTenants_Load(object sender, EventArgs e)
        {
            i = AddTenants.parentY + 50;

            // Set the initial location of the form
            this.Location = new Point(AddTenants.parentX + 220, AddTenants.parentY + 160);
            Opacity = 0; // Set initial opacity to 0 for fade-in effect

            // Start the timer for the animation effect
            ModalEffect_Timer.Start();

            // If tenantID is provided, load tenant data for editing
            if (tenantID.HasValue)
            {
                LoadTenantData(tenantID.Value);
                btnAdd.Text = "Update";
            }
        }

        private void ModalEffect_Timer_Tick(object sender, EventArgs e)
        {
            // Incrementally increase opacity
            if (Opacity < 1)
            {
                Opacity += 0.03;
            }

            // Incrementally move the form upwards
            if (this.Location.Y > AddTenants.parentY)
            {
                this.Location = new Point(this.Location.X, this.Location.Y - 3);
            }

            // Stop the timer when the animation is complete
            if (Opacity >= 1 && this.Location.Y <= AddTenants.parentY)
            {
                ModalEffect_Timer.Stop();
            }
        }

        private void LoadTenantData(int tenantID)
        {
            string query = "SELECT Name, Age, Birthday, ContactNumber FROM Tenants WHERE TenantID = @TenantID";
            var parameters = new Dictionary<string, object>
            {
                { "@TenantID", tenantID }
            };

            try
            {
                using (DataTable tenantTable = dbManager.ExecuteQuery(query, parameters))
                {
                    if (tenantTable.Rows.Count > 0)
                    {
                        DataRow row = tenantTable.Rows[0];
                        txtName.Text = row["Name"].ToString();
                        txtAge.Text = row["Age"].ToString();
                        txtBirthday.Text = DateTime.Parse(row["Birthday"].ToString()).ToString("yyyy-MM-dd");
                        txtContact.Text = row["ContactNumber"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading tenant data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            // Gather input data from text boxes
            string name = txtName.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string birthdayText = txtBirthday.Text.Trim();
            string contactNumber = txtContact.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ageText, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(birthdayText, out DateTime birthday))
            {
                MessageBox.Show("Please enter a valid date for the birthday.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(contactNumber))
            {
                MessageBox.Show("Contact number is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query;
            var parameters = new Dictionary<string, object>
            {
                { "@Name", name },
                { "@Age", age },
                { "@Birthday", birthday },
                { "@ContactNumber", contactNumber }
            };

            if (tenantID.HasValue)
            {
                // Update existing tenant
                query = "UPDATE Tenants SET Name = @Name, Age = @Age, Birthday = @Birthday, ContactNumber = @ContactNumber WHERE TenantID = @TenantID";
                parameters.Add("@TenantID", tenantID.Value);
            }
            else
            {
                // Insert new tenant
                query = "INSERT INTO Tenants (Name, Age, Birthday, ContactNumber) VALUES (@Name, @Age, @Birthday, @ContactNumber)";
            }

            try
            {
                dbManager.ExecuteNonQuery(query, parameters);
                MessageBox.Show(tenantID.HasValue ? "Tenant updated successfully!" : "Tenant added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload the tenant data in the AddTenants form
                AddTenants addTenantsForm = (AddTenants)Application.OpenForms["AddTenants"];
                addTenantsForm.LoadTenants();
                
                this.Close(); // Close the modal form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the tenant: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
