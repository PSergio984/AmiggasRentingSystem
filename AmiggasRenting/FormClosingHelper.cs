using System;
using System.Windows.Forms;

namespace AmiggasRenting
{
    public static class FormClosingHelper
    {
        private static bool isExiting = false;

        public static void HandleFormClosing(FormClosingEventArgs e)
        {
            // If already in the process of exiting, skip further handling
            if (isExiting) return;

            // Ask user for confirmation to close
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close the program?",
                "Confirm Close",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Proceed with closing the application
                isExiting = true;
                MessageBox.Show("Thank you for using our program!", "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                // Cancel the close event
                e.Cancel = true;
            }
        }
    }
}
