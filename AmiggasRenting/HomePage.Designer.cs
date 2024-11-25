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
            label1 = new Label();
            lblTenants = new Label();
            picTenants = new PictureBox();
            lblApartments = new Label();
            picApartments = new PictureBox();
            lblOccupied = new Label();
            pictureBox1 = new PictureBox();
            homePageSidePanel = new NavigationControl();
            ((System.ComponentModel.ISupportInitialize)picTenants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picApartments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Slate Pro Condensed", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(432, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 3;
            label1.Text = "AMIGGAS RENTING SYSTEM";
            // 
            // lblTenants
            // 
            lblTenants.Location = new Point(285, 112);
            lblTenants.Name = "lblTenants";
            lblTenants.Size = new Size(196, 69);
            lblTenants.TabIndex = 6;
            lblTenants.Text = ":Total Number of Tenants";
            // 
            // picTenants
            // 
            picTenants.Image = Properties.Resources.apartment;
            picTenants.Location = new Point(526, 148);
            picTenants.Name = "picTenants";
            picTenants.Size = new Size(123, 110);
            picTenants.SizeMode = PictureBoxSizeMode.StretchImage;
            picTenants.TabIndex = 7;
            picTenants.TabStop = false;
            // 
            // lblApartments
            // 
            lblApartments.Location = new Point(487, 112);
            lblApartments.Name = "lblApartments";
            lblApartments.Size = new Size(242, 40);
            lblApartments.TabIndex = 8;
            lblApartments.Text = "Number of available Apartments";
            // 
            // picApartments
            // 
            picApartments.Image = Properties.Resources.tenants;
            picApartments.Location = new Point(315, 148);
            picApartments.Name = "picApartments";
            picApartments.Size = new Size(108, 110);
            picApartments.SizeMode = PictureBoxSizeMode.StretchImage;
            picApartments.TabIndex = 9;
            picApartments.TabStop = false;
            // 
            // lblOccupied
            // 
            lblOccupied.Location = new Point(315, 313);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(242, 40);
            lblOccupied.TabIndex = 10;
            lblOccupied.Text = "Number of Occupied Apartments";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.occupied;
            pictureBox1.Location = new Point(326, 404);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // homePageSidePanel
            // 
            homePageSidePanel.Location = new Point(12, 24);
            homePageSidePanel.Name = "homePageSidePanel";
            homePageSidePanel.Size = new Size(203, 565);
            homePageSidePanel.TabIndex = 12;
            homePageSidePanel.Load += navigationControl1_Load;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(homePageSidePanel);
            Controls.Add(pictureBox1);
            Controls.Add(lblOccupied);
            Controls.Add(picApartments);
            Controls.Add(lblApartments);
            Controls.Add(picTenants);
            Controls.Add(lblTenants);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            
            FormClosed += HomePage_FormClosed;
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)picTenants).EndInit();
            ((System.ComponentModel.ISupportInitialize)picApartments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblTenants;
        private PictureBox picTenants;
        private Label lblApartments;
        private PictureBox picApartments;
        private Label lblOccupied;
        private PictureBox pictureBox1;
        private NavigationControl homePageSidePanel;
    }
}