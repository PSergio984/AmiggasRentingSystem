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
            string query = @"
    SELECT 
        Tenants.Name, 
        Tenants.Age, 
        Tenants.Birthday, 
        Tenants.ContactNumber, 
        Tenants.RegistrationDate,
        Units.UnitID AS ApartmentNo
    FROM Tenants
    LEFT JOIN Units ON Tenants.TenantID = Units.TenantID
    WHERE Tenants.TenantID = @TenantID";

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
                        numAge.Value = Convert.ToInt32(row["Age"]);
                        dateBirthday.Value = Convert.ToDateTime(row["Birthday"]).Date; // Strip time part
                        txtContact.Text = row["ContactNumber"].ToString();
                        dateRegistration.Value = Convert.ToDateTime(row["RegistrationDate"]).Date; // Strip time part
                        numApartment.Value = Convert.ToInt32(row["ApartmentNo"]);
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
            string name = txtName.Text.Trim();
            int age = (int)numAge.Value;
            DateTime birthday = dateBirthday.Value.Date; // Strip time part
            string contactNumber = txtContact.Text.Trim();
            DateTime registrationDate = dateRegistration.Value.Date; // Strip time part
            int unitID = (int)numApartment.Value;

            // Validate inputs
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (birthday > DateTime.Now)
            {
                MessageBox.Show("Birthday cannot be in the future.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(contactNumber))
            {
                MessageBox.Show("Contact number is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contactNumber.Length < 10 || contactNumber.Length > 15 || !long.TryParse(contactNumber, out _))
            {
                MessageBox.Show("Contact number must be a valid number between 10 and 15 digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (registrationDate > DateTime.Now)
            {
                MessageBox.Show("Registration date cannot be in the future.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!tenantID.HasValue || (tenantID.HasValue && unitID != GetCurrentTenantUnitID(tenantID.Value)))
            {
                string checkUnitQuery = "SELECT COUNT(*) FROM Units WHERE UnitID = @UnitID AND TenantID IS NOT NULL";
                var checkUnitParams = new Dictionary<string, object>
        {
            { "@UnitID", unitID }
        };

                try
                {
                    using (DataTable resultTable = dbManager.ExecuteQuery(checkUnitQuery, checkUnitParams))
                    {
                        if (resultTable.Rows.Count > 0 && Convert.ToInt32(resultTable.Rows[0][0]) > 0)
                        {
                            MessageBox.Show($"Unit number {unitID} is already occupied.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while checking unit occupancy: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string query;
            var parameters = new Dictionary<string, object>
    {
        { "@Name", name },
        { "@Age", age },
        { "@Birthday", birthday },
        { "@ContactNumber", contactNumber },
        { "@RegistrationDate", registrationDate },
        { "@UnitID", unitID }
    };

            if (tenantID.HasValue)
            {
                query = @"
        UPDATE Tenants 
        SET Name = @Name, Age = @Age, Birthday = @Birthday, ContactNumber = @ContactNumber, RegistrationDate = @RegistrationDate 
        WHERE TenantID = @TenantID;
        UPDATE Units 
        SET TenantID = NULL 
        WHERE TenantID = @TenantID;
        UPDATE Units 
        SET TenantID = @TenantID 
        WHERE UnitID = @UnitID";
                parameters.Add("@TenantID", tenantID.Value);
            }
            else
            {
                query = @"
        INSERT INTO Tenants (Name, Age, Birthday, ContactNumber, RegistrationDate) 
        VALUES (@Name, @Age, @Birthday, @ContactNumber, @RegistrationDate);
        UPDATE Units 
        SET TenantID = (SELECT last_insert_rowid()) 
        WHERE UnitID = @UnitID";
            }

            try
            {
                dbManager.ExecuteNonQuery(query, parameters);
                MessageBox.Show(tenantID.HasValue ? "Tenant updated successfully!" : "Tenant added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddTenants addTenantsForm = (AddTenants)Application.OpenForms["AddTenants"];
                addTenantsForm.LoadTenants();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the tenant: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        // Helper method to get the current tenant's unit ID
        private int GetCurrentTenantUnitID(int tenantID)
        {
            string query = "SELECT UnitID FROM Units WHERE TenantID = @TenantID";
            var parameters = new Dictionary<string, object>
    {
        { "@TenantID", tenantID }
    };

            try
            {
                using (DataTable resultTable = dbManager.ExecuteQuery(query, parameters))
                {
                    if (resultTable.Rows.Count > 0)
                    {
                        return Convert.ToInt32(resultTable.Rows[0]["UnitID"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the tenant's unit ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1; // Return an invalid unit ID if not found
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numApartment_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
