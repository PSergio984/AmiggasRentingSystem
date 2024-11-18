namespace AmiggasRenting
{
    partial class AddTenants
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
            dataGridTenants = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridTenants).BeginInit();
            SuspendLayout();
            // 
            // dataGridTenants
            // 
            dataGridTenants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTenants.Location = new Point(93, 46);
            dataGridTenants.Name = "dataGridTenants";
            dataGridTenants.RowHeadersWidth = 51;
            dataGridTenants.Size = new Size(616, 439);
            dataGridTenants.TabIndex = 0;
            dataGridTenants.CellContentClick += dataGridTenants_CellContentClick;
            // 
            // AddTenants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 553);
            Controls.Add(dataGridTenants);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddTenants";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTenants";
            ((System.ComponentModel.ISupportInitialize)dataGridTenants).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridTenants;
    }
}