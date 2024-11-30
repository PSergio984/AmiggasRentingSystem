namespace AmiggasRenting
{
    partial class ViewApartments
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataApartments = new DataGridView();
            navigationControl1 = new NavigationControl();
            ((System.ComponentModel.ISupportInitialize)dataApartments).BeginInit();
            SuspendLayout();
            // 
            // dataApartments
            // 
            dataApartments.AllowUserToAddRows = false;
            dataApartments.AllowUserToDeleteRows = false;
            dataApartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataApartments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataApartments.BackgroundColor = SystemColors.ActiveCaption;
            dataApartments.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Info;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataApartments.DefaultCellStyle = dataGridViewCellStyle1;
            dataApartments.GridColor = SystemColors.Info;
            dataApartments.Location = new Point(228, 53);
            dataApartments.Name = "dataApartments";
            dataApartments.RowHeadersVisible = false;
            dataApartments.RowHeadersWidth = 51;
            dataApartments.Size = new Size(724, 550);
            dataApartments.TabIndex = 0;
       
            // 
            // navigationControl1
            // 
            navigationControl1.Location = new Point(-3, 38);
            navigationControl1.Name = "navigationControl1";
            navigationControl1.Size = new Size(211, 573);
            navigationControl1.TabIndex = 1;
            // 
            // ViewApartments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(navigationControl1);
            Controls.Add(dataApartments);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ViewApartments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewApartments";
            Load += ViewApartments_Load;
            ((System.ComponentModel.ISupportInitialize)dataApartments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataApartments;
        private NavigationControl navigationControl1;
    }
}