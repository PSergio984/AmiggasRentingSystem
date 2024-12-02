using System;
using System.Drawing;
using System.Windows.Forms;

namespace AmiggasRenting
{

    public partial class modalTakeFee : Form
    {
        private DatabaseManager dbManager;
        public int? tenantID,unitID; // Nullable int to store tenant ID 
        private int i = 0;
        public modalTakeFee(int tenantID)
        {
            InitializeComponent();
            // Initialize the timer
            ModalEffect_Timer.Interval = 10; // Set the interval to 20 milliseconds
            ModalEffect_Timer.Tick += new EventHandler(ModalEffect_Timer_Tick);
            // Initialize the DatabaseManager
            dbManager = new DatabaseManager();
        }

        private void modalTakeFee_Load(object sender, EventArgs e)
        {
            i = Payments.parentY + 50;

            // Set the initial location of the form
            this.Location = new Point(Payments.parentX + 220, Payments.parentY + 160);
            Opacity = 0; // Set initial opacity to 0 for fade-in effect

            // Start the timer for the animation effect
            ModalEffect_Timer.Start();

        }
        private void ModalEffect_Timer_Tick(object sender, EventArgs e)
        {
            // Incrementally increase opacity
            if (Opacity < 1)
            {
                Opacity += 0.03;
            }

            // Incrementally move the form upwards
            if (this.Location.Y > Payments.parentY)
            {
                this.Location = new Point(this.Location.X, this.Location.Y - 3);
            }

            // Stop the timer when the animation is complete
            if (Opacity >= 1 && this.Location.Y <= Payments.parentY)
            {
                ModalEffect_Timer.Stop();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int receiptNo = (int)numReceipt.Value;
            decimal amountPaid = numAmountPaid.Value;

            // Check if the receipt number already exists in the database
            string checkQuery = "SELECT COUNT(*) FROM Payments WHERE PaymentID = @PaymentID;";
            var checkParameters = new Dictionary<string, object>
    {
        { "@PaymentID", receiptNo }
    };

            object result = dbManager.ExecuteScalar(checkQuery, checkParameters);
            int count = result != null ? Convert.ToInt32(result) : 0;

            if (count > 0)
            {
                MessageBox.Show("The receipt number already exists. Please enter a unique receipt number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert the payment record into the database
            string insertQuery = "INSERT INTO Payments (PaymentID, TenantID,UnitID, AmountPaid, PaymentDate) VALUES (@PaymentID, @TenantID,@UnitID, @AmountPaid, @PaymentDate);";
            var insertParameters = new Dictionary<string, object>
    {
        { "@PaymentID", receiptNo },
        { "@TenantID", tenantID },
        {"@UnitID",unitID },// Add the UnitID parameter
        { "@AmountPaid", amountPaid },
        { "@PaymentDate", DateTime.Now.Date }// Use the current date
    };

            try
            {
                dbManager.ExecuteNonQuery(insertQuery, insertParameters);
                MessageBox.Show("Payment record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Payments.Instance.LoadPayments();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the payment record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
