namespace AmiggasRenting
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddTenants = new Button();
            btnPayments = new Button();
            btnViewApartments = new Button();
            SuspendLayout();
            // 
            // btnAddTenants
            // 
            btnAddTenants.BackgroundImageLayout = ImageLayout.None;
            btnAddTenants.Location = new Point(185, 210);
            btnAddTenants.Name = "btnAddTenants";
            btnAddTenants.Size = new Size(113, 37);
            btnAddTenants.TabIndex = 0;
            btnAddTenants.Text = "Tenants";
            btnAddTenants.UseVisualStyleBackColor = true;
            btnAddTenants.Click += btnAddTenants_Click;
            // 
            // btnPayments
            // 
            btnPayments.BackgroundImageLayout = ImageLayout.None;
            btnPayments.Location = new Point(315, 210);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(113, 37);
            btnPayments.TabIndex = 1;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnViewApartments
            // 
            btnViewApartments.BackgroundImageLayout = ImageLayout.None;
            btnViewApartments.Location = new Point(459, 210);
            btnViewApartments.Name = "btnViewApartments";
            btnViewApartments.Size = new Size(151, 37);
            btnViewApartments.TabIndex = 2;
            btnViewApartments.Text = "View Apartments";
            btnViewApartments.UseVisualStyleBackColor = true;
            btnViewApartments.Click += btnViewApartments_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewApartments);
            Controls.Add(btnPayments);
            Controls.Add(btnAddTenants);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddTenants;
        private Button btnPayments;
        private Button btnViewApartments;
    }
}