namespace AmiggasRenting
{
    partial class NavigationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            panel1 = new Panel();
            btnDashboard = new Button();
            picUser = new PictureBox();
            btnPayments = new Button();
            btnViewApartments = new Button();
            btnAddTenants = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(204, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(picUser);
            panel1.Controls.Add(btnPayments);
            panel1.Controls.Add(btnViewApartments);
            panel1.Controls.Add(btnAddTenants);
            panel1.Location = new Point(8, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 550);
            panel1.TabIndex = 6;
            // 
            // btnDashboard
            // 
            btnDashboard.BackgroundImageLayout = ImageLayout.None;
            btnDashboard.Location = new Point(7, 146);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(177, 37);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // picUser
            // 
            picUser.Image = Properties.Resources.MANABAT_GEOMETRIC1;
            picUser.InitialImage = null;
            picUser.Location = new Point(55, 3);
            picUser.Name = "picUser";
            picUser.Size = new Size(78, 114);
            picUser.SizeMode = PictureBoxSizeMode.Zoom;
            picUser.TabIndex = 4;
            picUser.TabStop = false;
            // 
            // btnPayments
            // 
            btnPayments.BackgroundImageLayout = ImageLayout.None;
            btnPayments.Location = new Point(3, 284);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(181, 37);
            btnPayments.TabIndex = 1;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnViewApartments
            // 
            btnViewApartments.BackgroundImageLayout = ImageLayout.None;
            btnViewApartments.Location = new Point(3, 241);
            btnViewApartments.Name = "btnViewApartments";
            btnViewApartments.Size = new Size(181, 37);
            btnViewApartments.TabIndex = 2;
            btnViewApartments.Text = "View Apartments";
            btnViewApartments.UseVisualStyleBackColor = true;
            btnViewApartments.Click += btnViewApartments_Click;
            // 
            // btnAddTenants
            // 
            btnAddTenants.BackgroundImageLayout = ImageLayout.None;
            btnAddTenants.Location = new Point(10, 198);
            btnAddTenants.Name = "btnAddTenants";
            btnAddTenants.Size = new Size(177, 37);
            btnAddTenants.TabIndex = 0;
            btnAddTenants.Text = "Tenants";
            btnAddTenants.UseVisualStyleBackColor = true;
            btnAddTenants.Click += btnAddTenants_Click;
            // 
            // NavigationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "NavigationControl";
            Size = new Size(204, 566);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private Panel panel1;
        private Button btnDashboard;
        private PictureBox picUser;
        private Button btnPayments;
        private Button btnViewApartments;
        private Button btnAddTenants;
    }
}
