using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Tar;
using System.Windows.Forms;

namespace AmiggasRenting
{
    public partial class AddTenants : Form
    {
        private DatabaseManager dbManager;

        private static AddTenants instance;
        public static AddTenants Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new AddTenants();
                }
                return instance;
            }
        }

        public AddTenants()
        {
            InitializeComponent();
            dbManager = new DatabaseManager(); // Instantiate the DatabaseManager
            LoadTenants(); // Load tenant data when the form is initialized
        }
        public static int parentX,parentY;

        // Method to load tenant data from the database into the DataGridView
        public void LoadTenants(string searchTerm = "")
        {
            string query = "SELECT TenantID, Name, Age, Birthday, ContactNumber FROM Tenants";
            Dictionary<string, object> parameters = null;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += " WHERE Name LIKE @SearchTerm OR ContactNumber LIKE @SearchTerm";
                parameters = new Dictionary<string, object>
                {
                    { "@SearchTerm", "%" + searchTerm + "%" }
                };
            }

            try
            {
                using (DataTable tenantsTable = dbManager.ExecuteQuery(query, parameters))
                {
                    dataGridTenants.DataSource = tenantsTable;
                }

                AddButtonColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to add Edit and Delete buttons to the DataGridView
        private void AddButtonColumns()
        {
            if (dataGridTenants.Columns["EditButton"] == null)
            {
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "EditButton",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridTenants.Columns.Add(editButtonColumn);
            }

            if (dataGridTenants.Columns["DeleteButton"] == null)
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "DeleteButton",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridTenants.Columns.Add(deleteButtonColumn);
            }
        }

        // Event handler for button clicks in the DataGridView
        private void dataGridTenants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridTenants.Columns[e.ColumnIndex].Name == "EditButton")
                {
                    // Retrieve the TenantID of the selected row
                    var tenantID = dataGridTenants.Rows[e.RowIndex].Cells["TenantID"].Value;

                    // Open the ModalAddTenants form with the TenantID for editing
                    if (tenantID != null)
                    {
                        // Create a semi-transparent background form
                        Form modalBackground = new Form();
                        using (ModalAddTenants modal = new ModalAddTenants(Convert.ToInt32(tenantID)))
                        {
                            modalBackground.StartPosition = FormStartPosition.Manual;
                            modalBackground.FormBorderStyle = FormBorderStyle.None;
                            modalBackground.Opacity = .50d;
                            modalBackground.BackColor = Color.Black;
                            modalBackground.Size = this.Size;
                            modalBackground.Location = this.Location;
                            modalBackground.ShowInTaskbar = false;
                            modalBackground.Show();
                            modal.Owner = modalBackground;

                            // Set the parent location for the animation effect
                            parentX = this.Location.X;
                            parentY = this.Location.Y;

                            // Show the modal dialog
                            modal.ShowDialog();
                            modalBackground.Dispose();
                        }
                    }
                }
                else if (dataGridTenants.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    // Handle delete button logic
                    var tenantID = dataGridTenants.Rows[e.RowIndex].Cells["TenantID"].Value;
                    var tenantName = dataGridTenants.Rows[e.RowIndex].Cells["Name"].Value;

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete \nTenant ID: {tenantID}\nTenant Name: {tenantName}?",
                        "Delete Tenant",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        DeleteTenant(tenantID);
                    }
                }
            }
        }


        // Method to delete tenant from the database
        private void DeleteTenant(object tenantID)
        {
            string query = "DELETE FROM Tenants WHERE TenantID = @TenantID";
            var parameters = new Dictionary<string, object>
            {
                { "@TenantID", tenantID }
            };

            try
            {
                dbManager.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Tenant deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTenants();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the tenant: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      


        // Event handler for the search text box text changed
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            LoadTenants(searchTerm);
        }

    
     

        private void AddTenants_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      

        private void navigationControl1_Load(object sender, EventArgs e)
        {

        }

        private void AddTenants_Load(object sender, EventArgs e)
        {
            LoadTenants();
        }

        private void btnAddTenants_Click_1(object sender, EventArgs e)
        {
            
           
            
            // Create a semi-transparent background form
            Form modalBackground = new Form();
            using (ModalAddTenants modal = new ModalAddTenants())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;
                
                // Set the parent location for the animation effect
                parentX = this.Location.X;
                parentY = this.Location.Y;

                // Show the modal dialog
                modal.ShowDialog();
                modalBackground.Dispose();
            }
        }
     


    }
}
