namespace AmiggasRenting
{
    partial class LoadingScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            lblTitle = new Label();
            pbarLoading = new Bunifu.UI.WinForms.BunifuProgressBar();
            bunifuLoader1 = new Bunifu.UI.WinForms.BunifuLoader();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(419, 318);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(228, 28);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Amiggas Renting System";
            // 
            // pbarLoading
            // 
            pbarLoading.AllowAnimations = false;
            pbarLoading.Animation = 0;
            pbarLoading.AnimationSpeed = 220;
            pbarLoading.AnimationStep = 10;
            pbarLoading.BackColor = Color.FromArgb(223, 223, 223);
            pbarLoading.BackgroundImage = (Image)resources.GetObject("pbarLoading.BackgroundImage");
            pbarLoading.BorderColor = Color.FromArgb(223, 223, 223);
            pbarLoading.BorderRadius = 20;
            pbarLoading.BorderThickness = 1;
            pbarLoading.Location = new Point(300, 466);
            pbarLoading.Maximum = 101;
            pbarLoading.MaximumValue = 101;
            pbarLoading.Minimum = 0;
            pbarLoading.MinimumValue = 0;
            pbarLoading.Name = "pbarLoading";
            pbarLoading.Orientation = Orientation.Horizontal;
            pbarLoading.ProgressBackColor = Color.FromArgb(223, 223, 223);
            pbarLoading.ProgressColorLeft = Color.DodgerBlue;
            pbarLoading.ProgressColorRight = Color.DodgerBlue;
            pbarLoading.Size = new Size(475, 25);
            pbarLoading.TabIndex = 3;
            pbarLoading.Value = 1;
            pbarLoading.ValueByTransition = 1;
            // 
            // bunifuLoader1
            // 
            bunifuLoader1.AllowStylePresets = true;
            bunifuLoader1.BackColor = Color.Transparent;
            bunifuLoader1.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            bunifuLoader1.Color = Color.DodgerBlue;
            bunifuLoader1.Customization = "";
            bunifuLoader1.DashWidth = 0.5F;
            bunifuLoader1.Font = new Font("Segoe UI", 9F);
            bunifuLoader1.Image = null;
            bunifuLoader1.Location = new Point(443, 123);
            bunifuLoader1.Name = "bunifuLoader1";
            bunifuLoader1.NoRounding = false;
            bunifuLoader1.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            bunifuLoader1.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            bunifuLoader1.ShowText = false;
            bunifuLoader1.Size = new Size(120, 113);
            bunifuLoader1.Speed = 7;
            bunifuLoader1.TabIndex = 4;
            bunifuLoader1.Text = "bunifuLoader1";
            bunifuLoader1.TextPadding = new Padding(0);
            bunifuLoader1.Thickness = 6;
            bunifuLoader1.Transparent = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.rpVisualsTest;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1062, 673);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoadingScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(pictureBox1);
            Controls.Add(bunifuLoader1);
            Controls.Add(pbarLoading);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            FormClosed += LoadingScreen_FormClosed;
            Load += LoadingScreen_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Bunifu.UI.WinForms.BunifuProgressBar pbarLoading;
        private Bunifu.UI.WinForms.BunifuLoader bunifuLoader1;
        private PictureBox pictureBox1;
    }
}