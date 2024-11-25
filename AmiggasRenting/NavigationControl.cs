﻿using System;
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
            NavigateToForm(AddTenants.Instance); // Reuse or create the form
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
    }
}
