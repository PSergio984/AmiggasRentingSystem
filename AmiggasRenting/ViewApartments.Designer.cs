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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            navigationControl1 = new NavigationControl();
            dataApartments = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)dataApartments).BeginInit();
            SuspendLayout();
            // 
            // navigationControl1
            // 
            navigationControl1.Location = new Point(-3, 38);
            navigationControl1.Name = "navigationControl1";
            navigationControl1.Size = new Size(211, 573);
            navigationControl1.TabIndex = 1;
            // 
            // dataApartments
            // 
            dataApartments.AllowCustomTheming = false;
            dataApartments.AllowUserToAddRows = false;
            dataApartments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataApartments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataApartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataApartments.BorderStyle = BorderStyle.None;
            dataApartments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataApartments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataApartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataApartments.DefaultCellStyle = dataGridViewCellStyle3;
            dataApartments.EnableHeadersVisualStyles = false;
            dataApartments.GridColor = Color.FromArgb(221, 238, 255);
            dataApartments.HeaderBackColor = Color.DodgerBlue;
            dataApartments.HeaderBgColor = Color.Empty;
            dataApartments.HeaderForeColor = Color.White;
            dataApartments.Location = new Point(214, 38);
            dataApartments.Name = "dataApartments";
            dataApartments.ReadOnly = true;
            dataApartments.RowHeadersVisible = false;
            dataApartments.RowHeadersWidth = 51;
            dataApartments.RowTemplate.Height = 40;
            dataApartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataApartments.Size = new Size(836, 560);
            dataApartments.TabIndex = 2;
            dataApartments.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            dataApartments.CellContentClick += dataApartments_CellContentClick;
            // 
            // ViewApartments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(dataApartments);
            Controls.Add(navigationControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ViewApartments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apartments";
            Load += ViewApartments_Load;
            ((System.ComponentModel.ISupportInitialize)dataApartments).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private NavigationControl navigationControl1;
        private Bunifu.UI.WinForms.BunifuDataGridView dataApartments;
    }
}