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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridTenants = new DataGridView();
            txtSearch = new TextBox();
            TenantsSidePanel = new NavigationControl();
            btnAddTenants = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridTenants).BeginInit();
            SuspendLayout();
            // 
            // dataGridTenants
            // 
            dataGridTenants.AllowUserToAddRows = false;
            dataGridTenants.AllowUserToDeleteRows = false;
            dataGridTenants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTenants.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridTenants.BackgroundColor = SystemColors.ActiveCaption;
            dataGridTenants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Info;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridTenants.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridTenants.Location = new Point(218, 43);
            dataGridTenants.Name = "dataGridTenants";
            dataGridTenants.ReadOnly = true;
            dataGridTenants.RowHeadersVisible = false;
            dataGridTenants.RowHeadersWidth = 51;
            dataGridTenants.Size = new Size(832, 550);
            dataGridTenants.TabIndex = 0;
            dataGridTenants.CellContentClick += dataGridTenants_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(451, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(283, 27);
            txtSearch.TabIndex = 7;
            txtSearch.Text = "Search";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // TenantsSidePanel
            // 
            TenantsSidePanel.Location = new Point(3, 43);
            TenantsSidePanel.Name = "TenantsSidePanel";
            TenantsSidePanel.Size = new Size(200, 570);
            TenantsSidePanel.TabIndex = 10;
            TenantsSidePanel.Load += navigationControl1_Load;
            // 
            // btnAddTenants
            // 
            btnAddTenants.Location = new Point(785, 12);
            btnAddTenants.Name = "btnAddTenants";
            btnAddTenants.Size = new Size(94, 29);
            btnAddTenants.TabIndex = 11;
            btnAddTenants.Text = "Add Tenants";
            btnAddTenants.UseVisualStyleBackColor = true;
            btnAddTenants.Click += btnAddTenants_Click_1;
            // 
            // AddTenants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(btnAddTenants);
            Controls.Add(TenantsSidePanel);
            Controls.Add(txtSearch);
            Controls.Add(dataGridTenants);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddTenants";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTenants";
            FormClosed += AddTenants_FormClosed;
            Load += AddTenants_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTenants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridTenants;
        private TextBox txtSearch;
        private NavigationControl TenantsSidePanel;
        private Button btnAddTenants;
    }
}