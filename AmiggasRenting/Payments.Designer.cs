using Bunifu.UI.WinForms;
using System.Drawing;

namespace AmiggasRenting
{
    partial class Payments
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            navigationControl1 = new NavigationControl();
            dataPayments = new BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)dataPayments).BeginInit();
            SuspendLayout();
            // 
            // navigationControl1
            // 
            navigationControl1.Location = new Point(12, 42);
            navigationControl1.Name = "navigationControl1";
            navigationControl1.Size = new Size(203, 562);
            navigationControl1.TabIndex = 1;
            // 
            // dataPayments
            // 
            dataPayments.AllowCustomTheming = true;
            dataPayments.AllowUserToAddRows = false;
            dataPayments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataPayments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataPayments.BackgroundColor = SystemColors.ActiveCaption;
            dataPayments.BorderStyle = BorderStyle.None;
            dataPayments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataPayments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataPayments.ColumnHeadersHeight = 40;
            dataPayments.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dataPayments.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataPayments.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dataPayments.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataPayments.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dataPayments.CurrentTheme.BackColor = Color.White;
            dataPayments.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dataPayments.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            dataPayments.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataPayments.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dataPayments.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataPayments.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dataPayments.CurrentTheme.Name = null;
            dataPayments.CurrentTheme.RowsStyle.BackColor = Color.White;
            dataPayments.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataPayments.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dataPayments.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataPayments.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataPayments.DefaultCellStyle = dataGridViewCellStyle3;
            dataPayments.EnableHeadersVisualStyles = false;
            dataPayments.GridColor = Color.FromArgb(221, 238, 255);
            dataPayments.HeaderBackColor = Color.DodgerBlue;
            dataPayments.HeaderBgColor = Color.Empty;
            dataPayments.HeaderForeColor = Color.White;
            dataPayments.Location = new Point(232, 28);
            dataPayments.Name = "dataPayments";
            dataPayments.ReadOnly = true;
            dataPayments.RowHeadersVisible = false;
            dataPayments.RowHeadersWidth = 51;
            dataPayments.RowTemplate.Height = 40;
            dataPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataPayments.Size = new Size(799, 602);
            dataPayments.TabIndex = 2;
            dataPayments.Theme = BunifuDataGridView.PresetThemes.Light;
            dataPayments.CellClick += dataPayments_CellContentClick;
            dataPayments.CellContentClick += dataPayments_CellContentClick_1;
            // 
            // Payments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(dataPayments);
            Controls.Add(navigationControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Payments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payments";
            FormClosing += Payments_FormClosing_1;
            FormClosed += Payments_FormClosed;
            Load += Payments_Load;
            ((System.ComponentModel.ISupportInitialize)dataPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NavigationControl navigationControl1;
        private Bunifu.UI.WinForms.BunifuDataGridView dataPayments;
    }
}
