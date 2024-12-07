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
        u.UnitID AS 'Unit',
        t.TenantID AS 'ID',
        t.Name AS 'Name',
        t.RegistrationDate AS 'Registry',
        t.ContactNumber AS 'Contact', -- Include contact number in the query
        u.MonthlyRent AS 'Rate',
        ROUND((julianday('now') - julianday(t.RegistrationDate)) / 30 * u.MonthlyRent 
        - IFNULL((SELECT SUM(p.AmountPaid) FROM Payments p WHERE p.TenantID = t.TenantID), 0), 2) 
        AS 'Total Balance'
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
                    HeaderText = "Fee",
                    Text = "Fee",
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
                    string tenantName = dataPayments.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                    string apartmentNo = dataPayments.Rows[e.RowIndex].Cells["Unit"].Value?.ToString();
                    int tenantID = Convert.ToInt32(dataPayments.Rows[e.RowIndex].Cells["ID"].Value); // Assuming TenantID column exists
                    int unitID = Convert.ToInt32(dataPayments.Rows[e.RowIndex].Cells["Unit"].Value); // Assuming UnitID column exists
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
                // Logic for "Receipt" button
                else if (dataPayments.Columns[e.ColumnIndex].Name == "ReceiptButton")
                {

                    // Retrieve the necessary information from the selected row
                    string tenantName = dataPayments.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                    string apartmentNo = dataPayments.Rows[e.RowIndex].Cells["Unit"].Value?.ToString();
                    string contactNumber = dataPayments.Rows[e.RowIndex].Cells["Contact"].Value?.ToString(); // Retrieve contact number from the selected row
                    string registrationDate = dataPayments.Rows[e.RowIndex].Cells["Registry"].Value?.ToString();
                    string monthlyRate = dataPayments.Rows[e.RowIndex].Cells["Rate"].Value?.ToString();
                    string outstandingBalance = dataPayments.Rows[e.RowIndex].Cells["Total Balance"].Value?.ToString();
                    int tenantID = Convert.ToInt32(dataPayments.Rows[e.RowIndex].Cells["ID"].Value); // Assuming TenantID column exists

                    // SQL query to get the latest payment date and total amount paid by this tenant
                    string query = @"
                        SELECT 
                            MAX(PaymentDate) AS LatestDatePaid,
                            IFNULL(SUM(AmountPaid), 0) AS TotalPaid
                        FROM Payments
                        WHERE TenantID = @TenantID;";

                    // Execute the query using the database manager
                    var parameters = new Dictionary<string, object>
                    {
                        { "@TenantID", tenantID } // Pass the TenantID as a parameter to prevent SQL injection
                    };
                    DataTable resultTable = dbManager.ExecuteQuery(query, parameters);

                    string latestDatePaid = resultTable.Rows[0]["LatestDatePaid"]?.ToString();
                    decimal totalPaid = resultTable.Rows[0]["TotalPaid"] != DBNull.Value ? Convert.ToDecimal(resultTable.Rows[0]["TotalPaid"]) : 0;

                    // SQL query to get the payment details for the receipt
                    string receiptQuery = @"
                        SELECT 
                            PaymentID AS 'Receipt No',
                            PaymentDate AS 'Date Paid',
                            AmountPaid AS 'Amount Paid'
                        FROM Payments
                        WHERE TenantID = @TenantID;";

                    DataTable receiptTable = dbManager.ExecuteQuery(receiptQuery, parameters);

                    // Create a semi-transparent background form
                    Form modalBackground = new Form();
                    using (ModalReceipt modalReceiptForm = new ModalReceipt())
                    {
                        // Pass the retrieved data to the modalReceipt form
                        modalReceiptForm.lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy"); // Set the current date
                        modalReceiptForm.lblTenantName.Text = tenantName; // Set the tenant's name
                        modalReceiptForm.lblApartmentNo.Text = apartmentNo; // Set the apartment number
                        modalReceiptForm.lblContact.Text = contactNumber; // Set the contact number
                        modalReceiptForm.lblRegistrationDate.Text = registrationDate; // Set the registration date
                        modalReceiptForm.lblDatePaid.Text = latestDatePaid; // Set the latest date paid
                        modalReceiptForm.lblMonthly.Text = monthlyRate; // Set the monthly rate
                        modalReceiptForm.lblOutstanding.Text = outstandingBalance; // Set the outstanding balance
                        modalReceiptForm.dataReceipt.DataSource = receiptTable; // Set the receipt data
                        modalReceiptForm.lblTotal.Text = totalPaid.ToString("C"); // Format the total paid as currency

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
                        // Set the modal background as the owner of the modalReceipt form
                        modalReceiptForm.Owner = modalBackground;

                        // Set the start position of the modalReceiptForm to center parent
                        modalReceiptForm.StartPosition = FormStartPosition.CenterParent;

                        // Display the modal dialog
                        modalReceiptForm.ShowDialog();

                        // Dispose of the modal background form after closing the dialog
                        modalBackground.Dispose();
                    }
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

        private void dataPayments_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
