using System;
using System.Data;
using System.Windows.Forms;

namespace AmiggasRenting
{
    public partial class AddTenants : Form
    {
        private DatabaseManager dbManager;

        public AddTenants()
        {
            InitializeComponent();
            dbManager = new DatabaseManager(); // Instantiate the DatabaseManager
            LoadTenants(); // Load tenant data when the form is initialized
        }

        // Method to load tenant data from the database into the DataGridView
        private void LoadTenants()
        {
            string query = "SELECT TenantID, Name, Age, Birthday, ContactNumber FROM Tenants";
            try
            {
                DataTable tenantsTable = dbManager.ExecuteQuery(query); // Use DatabaseManager to execute query
                dataGridTenants.DataSource = tenantsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridTenants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}