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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            navigationControl1 = new NavigationControl();
            dataApartments = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)dataApartments).BeginInit();
            SuspendLayout();
            // 
            // navigationControl1
            // 
            navigationControl1.BackColor = Color.Transparent;
            navigationControl1.Location = new Point(-6, -4);
            navigationControl1.Margin = new Padding(3, 2, 3, 2);
            navigationControl1.Name = "navigationControl1";
            navigationControl1.Size = new Size(170, 512);
            navigationControl1.TabIndex = 1;
            // 
            // dataApartments
            // 
            dataApartments.AllowCustomTheming = false;
            dataApartments.AllowUserToAddRows = false;
            dataApartments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataApartments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataApartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataApartments.BorderStyle = BorderStyle.None;
            dataApartments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataApartments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataApartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataApartments.ColumnHeadersHeight = 40;
            dataApartments.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dataApartments.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataApartments.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dataApartments.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataApartments.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dataApartments.CurrentTheme.BackColor = Color.White;
            dataApartments.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dataApartments.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dataApartments.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataApartments.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dataApartments.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataApartments.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dataApartments.CurrentTheme.Name = null;
            dataApartments.CurrentTheme.RowsStyle.BackColor = Color.White;
            dataApartments.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataApartments.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dataApartments.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataApartments.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataApartments.DefaultCellStyle = dataGridViewCellStyle6;
            dataApartments.EnableHeadersVisualStyles = false;
            dataApartments.GridColor = Color.FromArgb(221, 238, 255);
            dataApartments.HeaderBackColor = Color.DodgerBlue;
            dataApartments.HeaderBgColor = Color.Empty;
            dataApartments.HeaderForeColor = Color.White;
            dataApartments.Location = new Point(187, 28);
            dataApartments.Margin = new Padding(3, 2, 3, 2);
            dataApartments.Name = "dataApartments";
            dataApartments.ReadOnly = true;
            dataApartments.RowHeadersVisible = false;
            dataApartments.RowHeadersWidth = 51;
            dataApartments.RowTemplate.Height = 40;
            dataApartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataApartments.Size = new Size(732, 420);
            dataApartments.TabIndex = 2;
            dataApartments.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            dataApartments.CellContentClick += dataApartments_CellContentClick;
            // 
            // ViewApartments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 505);
            Controls.Add(dataApartments);
            Controls.Add(navigationControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewApartments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apartments";
            FormClosing += ViewApartments_FormClosing;
            Load += ViewApartments_Load;
            ((System.ComponentModel.ISupportInitialize)dataApartments).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private NavigationControl navigationControl1;
        private Bunifu.UI.WinForms.BunifuDataGridView dataApartments;
    }
}