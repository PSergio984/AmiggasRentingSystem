using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace AmiggasRenting
{
    public partial class Payments : Form
    {
        private static Payments instance;
        private DatabaseManager dbManager; // Database manager instance for executing queries.
        public static int parentX, parentY;
        // Singleton instance to ensure only one instance of the form exists at a time.
        public static Payments Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Payments();
                }
                return instance;
            }
        }

        public Payments()
        {
            InitializeComponent();
            dbManager = new DatabaseManager(); // Initialize database manager.
            LoadPayments(); // Load payment data when the form is initalized
            this.Activated += new EventHandler(Payments_Activated);// Load payment data when the form is activated.
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            LoadPayments(); // Load payment data when the form loads.
        }
        private void Payments_Activated(object sender, EventArgs e)
        {
            LoadPayments();// Load payment data when the form is activated.
        }

        // Method to load payment data into the DataGridView.
        public void LoadPayments()
        {
            string query = @"
    SELECT 
        u.UnitID AS 'Apartment',
        t.TenantID AS 'TenantID',
        t.Name AS 'Tenant Name',
        t.RegistrationDate AS 'Registration Date',
        u.MonthlyRent AS 'Monthly Rate',
        ROUND((julianday('now') - julianday(t.RegistrationDate)) / 30 * u.MonthlyRent 
        - IFNULL((SELECT SUM(p.AmountPaid) FROM Payments p WHERE p.TenantID = t.TenantID), 0), 2) 
        AS 'Outstanding Balance'
    FROM Tenants t
    JOIN Units u ON t.TenantID = u.TenantID
    WHERE u.Availability = 0;";

            try
            {
                using (DataTable paymentsTable = dbManager.ExecuteQuery(query))
                {
                    dataPayments.DataSource = paymentsTable;
                }

                AddButtonColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // Method to add "Take Fee" and "Receipt" buttons to the DataGridView.
        private void AddButtonColumns()
        {
            // Add "Take Fee" button if not already present.
            if (dataPayments.Columns["TakeFeeButton"] == null)
            {
                DataGridViewButtonColumn takeFeeButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "TakeFeeButton",
                    HeaderText = "Take Fee",
                    Text = "Take Fee",
                    UseColumnTextForButtonValue = true // Ensures button displays text.
                };
                dataPayments.Columns.Add(takeFeeButtonColumn);
            }

            // Add "Receipt" button if not already present.
            if (dataPayments.Columns["ReceiptButton"] == null)
            {
                DataGridViewButtonColumn receiptButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "ReceiptButton",
                    HeaderText = "Receipt",
                    Text = "Receipt",
                    UseColumnTextForButtonValue = true // Ensures button displays text.
                };
                dataPayments.Columns.Add(receiptButtonColumn);
            }
        }

        // Event handler for button clicks in the DataGridView.
        private void dataPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Check if the "Take Fee" button is clicked
                if (dataPayments.Columns[e.ColumnIndex].Name == "TakeFeeButton")
                {
                    // Retrieve the necessary information from the selected row
                    string tenantName = dataPayments.Rows[e.RowIndex].Cells["Tenant Name"].Value?.ToString();
                    string apartmentNo = dataPayments.Rows[e.RowIndex].Cells["Apartment"].Value?.ToString();
                    int tenantID = Convert.ToInt32(dataPayments.Rows[e.RowIndex].Cells["TenantID"].Value); // Assuming TenantID column exists
                    int unitID = Convert.ToInt32(dataPayments.Rows[e.RowIndex].Cells["Apartment"].Value); // Assuming UnitID column exists
                    decimal totalPaid = 0;

                    // SQL query to calculate the total amount paid by this tenant
                    string query = "SELECT IFNULL(SUM(AmountPaid), 0) AS TotalPaid FROM Payments WHERE TenantID = @TenantID;";

                    // Execute the query using the database manager
                    var parameters = new Dictionary<string, object>
            {
                { "@TenantID", tenantID } // Pass the TenantID as a parameter to prevent SQL injection
            };
                    object result = dbManager.ExecuteScalar(query, parameters);

                    // Convert the result to decimal; default to 0 if null
                    totalPaid = result != null ? Convert.ToDecimal(result) : 0;

                    // Create a semi-transparent background form
                    Form modalBackground = new Form();
                    using (modalTakeFee modalTakeFeeForm = new modalTakeFee(tenantID))
                    {
                        // Pass the retrieved data to the modalTakeFee form
                        modalTakeFeeForm.lblApartmentNo.Text = apartmentNo; // Set the apartment number
                        modalTakeFeeForm.lblTenantName.Text = tenantName;  // Set the tenant's name
                        modalTakeFeeForm.lblTotalPaid.Text = totalPaid.ToString("C"); // Format the total paid as currency
                        modalTakeFeeForm.lblTenantID.Text = tenantID.ToString(); // Set the TenantID for reference  
                        modalTakeFeeForm.tenantID = tenantID; // Set the TenantID for processing
                        modalTakeFeeForm.unitID = unitID;
                        // Configure and display the modal background form
                        modalBackground.StartPosition = FormStartPosition.Manual;
                        modalBackground.FormBorderStyle = FormBorderStyle.None;
                        modalBackground.Opacity = .50d;
                        modalBackground.BackColor = Color.Black;
                        modalBackground.Size = this.Size;
                        modalBackground.Location = this.Location;
                        modalBackground.ShowInTaskbar = false;
                        modalBackground.Show();
                        // Set the parent location for the animation effect
                        parentX = this.Location.X;
                        parentY = this.Location.Y;
                        // Set the modal background as the owner of the modalTakeFee form
                        modalTakeFeeForm.Owner = modalBackground;

                        // Set the start position of the modalTakeFeeForm to center parent
                        modalTakeFeeForm.StartPosition = FormStartPosition.CenterParent;

                        // Display the modal dialog
                        modalTakeFeeForm.ShowDialog();

                        // Dispose of the modal background form after closing the dialog
                        modalBackground.Dispose();
                    }

                }
                // Placeholder logic for "Receipt" button
                else if (dataPayments.Columns[e.ColumnIndex].Name == "ReceiptButton")
                {
                    MessageBox.Show("Receipt button clicked. Action not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void Payments_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Prevent closing the form if necessary actions need to be handled.
        }

        private void Payments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Exit the application when the form is closed.
        }
    }
}
