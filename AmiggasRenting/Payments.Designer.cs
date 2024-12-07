namespace AmiggasRenting
{
    partial class Payments
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
            dataPayments = new DataGridView();
            navigationControl1 = new NavigationControl();
            ((System.ComponentModel.ISupportInitialize)dataPayments).BeginInit();
            SuspendLayout();
            // 
            // dataPayments
            // 
            dataPayments.AllowDrop = true;
            dataPayments.AllowUserToAddRows = false;
            dataPayments.AllowUserToDeleteRows = false;
            dataPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataPayments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataPayments.BackgroundColor = SystemColors.ButtonFace;
            dataPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPayments.GridColor = SystemColors.InfoText;
            dataPayments.Location = new Point(235, 42);
            dataPayments.Name = "dataPayments";
            dataPayments.ReadOnly = true;
            dataPayments.RowHeadersVisible = false;
            dataPayments.RowHeadersWidth = 51;
            dataPayments.Size = new Size(797, 574);
            dataPayments.TabIndex = 0;
            dataPayments.CellContentClick += dataPayments_CellContentClick;
            // 
            // navigationControl1
            // 
            navigationControl1.Location = new Point(12, 42);
            navigationControl1.Name = "navigationControl1";
            navigationControl1.Size = new Size(203, 562);
            navigationControl1.TabIndex = 1;
            // 
            // Payments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(navigationControl1);
            Controls.Add(dataPayments);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Payments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payments";
            FormClosed += Payments_FormClosed;
            Load += Payments_Load;
            ((System.ComponentModel.ISupportInitialize)dataPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataPayments;
        private NavigationControl navigationControl1;
    }
}