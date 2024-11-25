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
            pbarLoading = new ProgressBar();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // pbarLoading
            // 
            pbarLoading.BackColor = SystemColors.ActiveCaption;
            pbarLoading.ForeColor = SystemColors.MenuHighlight;
            pbarLoading.Location = new Point(300, 414);
            pbarLoading.Name = "pbarLoading";
            pbarLoading.Size = new Size(475, 29);
            pbarLoading.TabIndex = 0;
            pbarLoading.Click += pbarLoading_Click;
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
            // LoadingScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(lblTitle);
            Controls.Add(pbarLoading);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingScreen";
            
            FormClosed += LoadingScreen_FormClosed;
            Load += LoadingScreen_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pbarLoading;
        private Label lblTitle;
    }
}