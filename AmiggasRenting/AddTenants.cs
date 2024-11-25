using System;
using System.Collections.Generic;
using System.Data;
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

        // Method to load tenant data from the database into the DataGridView
        private void LoadTenants(string searchTerm = "")
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
                    MessageBox.Show("Edit button clicked for tenant row " + e.RowIndex.ToString());
                }
                else if (dataGridTenants.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
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

        // Event handler for the search button click


        // Event handler for the search text box text changed
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            LoadTenants(searchTerm);
        }

        private void btnAddTenants_Click(object sender, EventArgs e)
        {

        }

        private void btnViewApartments_Click(object sender, EventArgs e)
        {
            ViewApartments viewApartments = new ViewApartments();
            viewApartments.Show();
            this.Hide();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Dispose(); // Dispose of the current form
        }

        private void AddTenants_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Tenants(object sender, EventArgs e)
        {

        }

        private void navigationControl1_Load(object sender, EventArgs e)
        {

        }

        private void AddTenants_Load(object sender, EventArgs e)
        {

        }
    }
}