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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            label1 = new Label();
            lblTenants = new Label();
            picTenants = new PictureBox();
            lblApartments = new Label();
            lblOccupied = new Label();
            pictureBox1 = new PictureBox();
            homePageSidePanel = new NavigationControl();
            lblTenantCount = new Label();
            lblOccApartments = new Label();
            lblAvlApartment = new Label();
            bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            bunifuPictureBox3 = new Bunifu.UI.WinForms.BunifuPictureBox();
            bunifuPictureBox4 = new Bunifu.UI.WinForms.BunifuPictureBox();
            lblUser = new Label();
            ((System.ComponentModel.ISupportInitialize)picTenants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox4).BeginInit();
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
            lblTenants.Location = new Point(296, 112);
            lblTenants.Name = "lblTenants";
            lblTenants.Size = new Size(196, 69);
            lblTenants.TabIndex = 6;
            lblTenants.Text = ":Total Number of Tenants";
            // 
            // picTenants
            // 
            picTenants.Image = Properties.Resources.apartment;
            picTenants.Location = new Point(639, 148);
            picTenants.Name = "picTenants";
            picTenants.Size = new Size(123, 110);
            picTenants.SizeMode = PictureBoxSizeMode.StretchImage;
            picTenants.TabIndex = 7;
            picTenants.TabStop = false;
            // 
            // lblApartments
            // 
            lblApartments.Location = new Point(594, 112);
            lblApartments.Name = "lblApartments";
            lblApartments.Size = new Size(242, 40);
            lblApartments.TabIndex = 8;
            lblApartments.Text = "Number of available Apartments";
            // 
            // lblOccupied
            // 
            lblOccupied.Location = new Point(418, 318);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(242, 40);
            lblOccupied.TabIndex = 10;
            lblOccupied.Text = "Number of Occupied Apartments";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.occupied;
            pictureBox1.Location = new Point(464, 377);
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
            // lblTenantCount
            // 
            lblTenantCount.AutoSize = true;
            lblTenantCount.Location = new Point(240, 112);
            lblTenantCount.Name = "lblTenantCount";
            lblTenantCount.Size = new Size(50, 20);
            lblTenantCount.TabIndex = 13;
            lblTenantCount.Text = "label2";
            // 
            // lblOccApartments
            // 
            lblOccApartments.AutoSize = true;
            lblOccApartments.Location = new Point(362, 318);
            lblOccApartments.Name = "lblOccApartments";
            lblOccApartments.Size = new Size(50, 20);
            lblOccApartments.TabIndex = 14;
            lblOccApartments.Text = "label3";
            // 
            // lblAvlApartment
            // 
            lblAvlApartment.AutoSize = true;
            lblAvlApartment.ImageAlign = ContentAlignment.TopLeft;
            lblAvlApartment.Location = new Point(538, 112);
            lblAvlApartment.Name = "lblAvlApartment";
            lblAvlApartment.Size = new Size(50, 20);
            lblAvlApartment.TabIndex = 15;
            lblAvlApartment.Text = "label4";
            // 
            // bunifuPictureBox1
            // 
            bunifuPictureBox1.AllowFocused = false;
            bunifuPictureBox1.Anchor = AnchorStyles.None;
            bunifuPictureBox1.AutoSizeHeight = true;
            bunifuPictureBox1.BorderRadius = 64;
            bunifuPictureBox1.Image = Properties.Resources.occupied;
            bunifuPictureBox1.IsCircle = true;
            bunifuPictureBox1.Location = new Point(418, 158);
            bunifuPictureBox1.Name = "bunifuPictureBox1";
            bunifuPictureBox1.Size = new Size(129, 129);
            bunifuPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            bunifuPictureBox1.TabIndex = 16;
            bunifuPictureBox1.TabStop = false;
            bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuPictureBox3
            // 
            bunifuPictureBox3.AllowFocused = false;
            bunifuPictureBox3.Anchor = AnchorStyles.None;
            bunifuPictureBox3.AutoSizeHeight = true;
            bunifuPictureBox3.BorderRadius = 44;
            bunifuPictureBox3.Image = (Image)resources.GetObject("bunifuPictureBox3.Image");
            bunifuPictureBox3.IsCircle = true;
            bunifuPictureBox3.Location = new Point(793, 186);
            bunifuPictureBox3.Name = "bunifuPictureBox3";
            bunifuPictureBox3.Size = new Size(88, 88);
            bunifuPictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            bunifuPictureBox3.TabIndex = 18;
            bunifuPictureBox3.TabStop = false;
            bunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuPictureBox4
            // 
            bunifuPictureBox4.AllowFocused = false;
            bunifuPictureBox4.Anchor = AnchorStyles.None;
            bunifuPictureBox4.AutoSizeHeight = true;
            bunifuPictureBox4.BorderRadius = 44;
            bunifuPictureBox4.Image = (Image)resources.GetObject("bunifuPictureBox4.Image");
            bunifuPictureBox4.IsCircle = true;
            bunifuPictureBox4.Location = new Point(296, 186);
            bunifuPictureBox4.Name = "bunifuPictureBox4";
            bunifuPictureBox4.Size = new Size(88, 88);
            bunifuPictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            bunifuPictureBox4.TabIndex = 19;
            bunifuPictureBox4.TabStop = false;
            bunifuPictureBox4.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(485, 50);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(103, 28);
            lblUser.TabIndex = 20;
            lblUser.Text = "UserName";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(lblUser);
            Controls.Add(bunifuPictureBox4);
            Controls.Add(bunifuPictureBox3);
            Controls.Add(bunifuPictureBox1);
            Controls.Add(lblAvlApartment);
            Controls.Add(lblOccApartments);
            Controls.Add(lblTenantCount);
            Controls.Add(homePageSidePanel);
            Controls.Add(pictureBox1);
            Controls.Add(lblOccupied);
            Controls.Add(lblApartments);
            Controls.Add(picTenants);
            Controls.Add(lblTenants);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Page";
            FormClosing += HomePage_FormClosing;
            FormClosed += HomePage_FormClosed;
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)picTenants).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label label1;
        private Label lblTenants;
        private PictureBox picTenants;
        private Label lblApartments;
        private Label lblOccupied;
        private PictureBox pictureBox1;
        private NavigationControl homePageSidePanel;
        private Label lblTenantCount;
        private Label lblOccApartments;
        private Label lblAvlApartment;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox3;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox4;
        public Label lblUser;

    }
}