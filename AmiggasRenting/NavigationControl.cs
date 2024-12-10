using System;
using System.Windows.Forms;

namespace AmiggasRenting
{
    public partial class NavigationControl : UserControl
    {
        public NavigationControl()
        {
            InitializeComponent();
        }

        // Event handler for Add Tenants button click
        private void btnAddTenants_Click(object sender, EventArgs e)
        {

            NavigateToForm(AddTenants.Instance);

        }

        // Event handler for View Apartments button click
        private void btnViewApartments_Click(object sender, EventArgs e)
        {
            NavigateToForm(ViewApartments.Instance);
        }

        // Event handler for Payments button click
        private void btnPayments_Click(object sender, EventArgs e)
        {
            NavigateToForm(Payments.Instance);
        }

        // Event handler for Dashboard button click
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            NavigateToForm(HomePage.Instance);
        }

        // Reusable navigation logic
        private void NavigateToForm(Form targetForm)
        {
            Form? currentForm = this.FindForm(); // Get the parent form

            // Check if the target form is the same as the current form
            if (currentForm != null && targetForm != null && currentForm.GetType() == targetForm.GetType())
            {
                return; // Do nothing if the target form is the same as the current form
            }

            if (targetForm == null || targetForm.IsDisposed)
            {
                targetForm = (Form)Activator.CreateInstance(targetForm?.GetType() ?? throw new InvalidOperationException("Target form type is null"));
            }

            targetForm.Show();

            if (currentForm != null)
            {
                currentForm.Hide();
                targetForm.FormClosed += (s, args) => currentForm.Show();
            }
        }

        private void TargetForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Form? currentForm = this.FindForm();
            currentForm?.Show();
        }

        // Helper method to create a new instance of a form
        private Form CreateNewInstance(Type? formType)
        {
            if (formType == null)
                throw new InvalidOperationException("Target form type is null.");

            return (Form)Activator.CreateInstance(formType);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
