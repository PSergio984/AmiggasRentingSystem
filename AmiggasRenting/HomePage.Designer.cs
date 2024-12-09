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
            label1.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 7);
            label1.Name = "label1";
            label1.Size = new Size(267, 24);
            label1.TabIndex = 3;
            label1.Text = "AMIGGAS RENTING SYSTEM";
            // 
            // lblTenants
            // 
            lblTenants.Location = new Point(259, 84);
            lblTenants.Name = "lblTenants";
            lblTenants.Size = new Size(172, 52);
            lblTenants.TabIndex = 6;
            lblTenants.Text = ":Total Number of Tenants";
            // 
            // picTenants
            // 
            picTenants.Image = Properties.Resources.apartment;
            picTenants.Location = new Point(559, 111);
            picTenants.Margin = new Padding(3, 2, 3, 2);
            picTenants.Name = "picTenants";
            picTenants.Size = new Size(108, 82);
            picTenants.SizeMode = PictureBoxSizeMode.StretchImage;
            picTenants.TabIndex = 7;
            picTenants.TabStop = false;
            // 
            // lblApartments
            // 
            lblApartments.Location = new Point(520, 84);
            lblApartments.Name = "lblApartments";
            lblApartments.Size = new Size(212, 30);
            lblApartments.TabIndex = 8;
            lblApartments.Text = "Number of available Apartments";
            // 
            // lblOccupied
            // 
            lblOccupied.Location = new Point(366, 238);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(212, 30);
            lblOccupied.TabIndex = 10;
            lblOccupied.Text = "Number of Occupied Apartments";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.occupied;
            pictureBox1.Location = new Point(406, 283);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // homePageSidePanel
            // 
            homePageSidePanel.BackColor = Color.Transparent;
            homePageSidePanel.Location = new Point(-6, -4);
            homePageSidePanel.Margin = new Padding(3, 2, 3, 2);
            homePageSidePanel.Name = "homePageSidePanel";
            homePageSidePanel.Size = new Size(170, 512);
            homePageSidePanel.TabIndex = 12;
            homePageSidePanel.Load += navigationControl1_Load;
            // 
            // lblTenantCount
            // 
            lblTenantCount.AutoSize = true;
            lblTenantCount.Location = new Point(210, 84);
            lblTenantCount.Name = "lblTenantCount";
            lblTenantCount.Size = new Size(38, 15);
            lblTenantCount.TabIndex = 13;
            lblTenantCount.Text = "label2";
            // 
            // lblOccApartments
            // 
            lblOccApartments.AutoSize = true;
            lblOccApartments.Location = new Point(317, 238);
            lblOccApartments.Name = "lblOccApartments";
            lblOccApartments.Size = new Size(38, 15);
            lblOccApartments.TabIndex = 14;
            lblOccApartments.Text = "label3";
            // 
            // lblAvlApartment
            // 
            lblAvlApartment.AutoSize = true;
            lblAvlApartment.ImageAlign = ContentAlignment.TopLeft;
            lblAvlApartment.Location = new Point(471, 84);
            lblAvlApartment.Name = "lblAvlApartment";
            lblAvlApartment.Size = new Size(38, 15);
            lblAvlApartment.TabIndex = 15;
            lblAvlApartment.Text = "label4";
            // 
            // bunifuPictureBox1
            // 
            bunifuPictureBox1.AllowFocused = false;
            bunifuPictureBox1.Anchor = AnchorStyles.None;
            bunifuPictureBox1.AutoSizeHeight = true;
            bunifuPictureBox1.BorderRadius = 56;
            bunifuPictureBox1.Image = Properties.Resources.occupied;
            bunifuPictureBox1.IsCircle = true;
            bunifuPictureBox1.Location = new Point(366, 118);
            bunifuPictureBox1.Margin = new Padding(3, 2, 3, 2);
            bunifuPictureBox1.Name = "bunifuPictureBox1";
            bunifuPictureBox1.Size = new Size(113, 113);
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
            bunifuPictureBox3.BorderRadius = 38;
            bunifuPictureBox3.Image = (Image)resources.GetObject("bunifuPictureBox3.Image");
            bunifuPictureBox3.IsCircle = true;
            bunifuPictureBox3.Location = new Point(694, 140);
            bunifuPictureBox3.Margin = new Padding(3, 2, 3, 2);
            bunifuPictureBox3.Name = "bunifuPictureBox3";
            bunifuPictureBox3.Size = new Size(77, 77);
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
            bunifuPictureBox4.BorderRadius = 38;
            bunifuPictureBox4.Image = (Image)resources.GetObject("bunifuPictureBox4.Image");
            bunifuPictureBox4.IsCircle = true;
            bunifuPictureBox4.Location = new Point(259, 140);
            bunifuPictureBox4.Margin = new Padding(3, 2, 3, 2);
            bunifuPictureBox4.Name = "bunifuPictureBox4";
            bunifuPictureBox4.Size = new Size(77, 77);
            bunifuPictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            bunifuPictureBox4.TabIndex = 19;
            bunifuPictureBox4.TabStop = false;
            bunifuPictureBox4.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(424, 38);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(84, 21);
            lblUser.TabIndex = 20;
            lblUser.Text = "UserName";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 505);
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
            Margin = new Padding(3, 2, 3, 2);
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