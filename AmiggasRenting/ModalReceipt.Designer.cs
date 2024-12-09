namespace AmiggasRenting
{
    partial class ModalReceipt
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTenantName = new Label();
            lblApartmentNo = new Label();
            lblContact = new Label();
            lblRegistrationDate = new Label();
            lblDate = new Label();
            label1 = new Label();
            lblOutstanding = new Label();
            lblMonthly = new Label();
            lblDatePaid = new Label();
            label5 = new Label();
            label2 = new Label();
            lblTotal = new Label();
            btnPrint = new Button();
            btnBack = new Button();
            ModalEffect_Timer = new System.Windows.Forms.Timer(components);
            dataReceipt = new Bunifu.UI.WinForms.BunifuDataGridView();
            ModalCancel_Timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataReceipt).BeginInit();
            SuspendLayout();
            // 
            // lblTenantName
            // 
            lblTenantName.AutoSize = true;
            lblTenantName.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
            lblTenantName.Location = new Point(134, 82);
            lblTenantName.Name = "lblTenantName";
            lblTenantName.Size = new Size(120, 19);
            lblTenantName.TabIndex = 0;
            lblTenantName.Text = "lblTenantName";
            lblTenantName.Click += lblTenantName_Click;
            // 
            // lblApartmentNo
            // 
            lblApartmentNo.AutoSize = true;
            lblApartmentNo.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
            lblApartmentNo.Location = new Point(134, 116);
            lblApartmentNo.Name = "lblApartmentNo";
            lblApartmentNo.Size = new Size(125, 19);
            lblApartmentNo.TabIndex = 1;
            lblApartmentNo.Text = "lblApartmentNo";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
            lblContact.Location = new Point(134, 148);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(84, 19);
            lblContact.TabIndex = 2;
            lblContact.Text = "lblContact";
            // 
            // lblRegistrationDate
            // 
            lblRegistrationDate.AutoSize = true;
            lblRegistrationDate.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
            lblRegistrationDate.Location = new Point(134, 178);
            lblRegistrationDate.Name = "lblRegistrationDate";
            lblRegistrationDate.Size = new Size(149, 19);
            lblRegistrationDate.TabIndex = 3;
            lblRegistrationDate.Text = "lblRegistrationDate";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Roboto Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(608, 26);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(55, 18);
            lblDate.TabIndex = 4;
            lblDate.Text = "lblDate";
            lblDate.Click += lblDate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 26);
            label1.Name = "label1";
            label1.Size = new Size(359, 33);
            label1.TabIndex = 5;
            label1.Text = "AMIGGAS INCORPORATION";
            label1.Click += label1_Click;
            // 
            // lblOutstanding
            // 
            lblOutstanding.AutoSize = true;
            lblOutstanding.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
            lblOutstanding.Location = new Point(414, 178);
            lblOutstanding.Name = "lblOutstanding";
            lblOutstanding.Size = new Size(115, 19);
            lblOutstanding.TabIndex = 9;
            lblOutstanding.Text = "lblOutstanding";
            // 
            // lblMonthly
            // 
            lblMonthly.AutoSize = true;
            lblMonthly.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
            lblMonthly.Location = new Point(414, 149);
            lblMonthly.Name = "lblMonthly";
            lblMonthly.Size = new Size(85, 19);
            lblMonthly.TabIndex = 8;
            lblMonthly.Text = "lblMonthly";
            // 
            // lblDatePaid
            // 
            lblDatePaid.AutoSize = true;
            lblDatePaid.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
            lblDatePaid.Location = new Point(414, 120);
            lblDatePaid.Name = "lblDatePaid";
            lblDatePaid.Size = new Size(92, 19);
            lblDatePaid.TabIndex = 7;
            lblDatePaid.Text = "lblDatePaid";
            lblDatePaid.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(357, 73);
            label5.Name = "label5";
            label5.Size = new Size(207, 28);
            label5.TabIndex = 6;
            label5.Text = "Payment Details:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Black", 15.75F, FontStyle.Bold);
            label2.Location = new Point(299, 364);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 11;
            label2.Text = "THANK YOU!";
            label2.Click += label2_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Roboto Black", 15.75F, FontStyle.Bold);
            lblTotal.Location = new Point(554, 364);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(83, 25);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "lblTotal";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gold;
            btnPrint.FlatStyle = FlatStyle.Popup;
            btnPrint.Font = new Font("Roboto Black", 9F, FontStyle.Bold);
            btnPrint.ForeColor = SystemColors.ControlText;
            btnPrint.Location = new Point(22, 368);
            btnPrint.Margin = new Padding(3, 2, 3, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(98, 22);
            btnPrint.TabIndex = 13;
            btnPrint.Text = "Print Invoice";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gold;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Roboto Black", 9F, FontStyle.Bold);
            btnBack.Location = new Point(134, 368);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 22);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ModalEffect_Timer
            // 
            ModalEffect_Timer.Interval = 1;
            // 
            // dataReceipt
            // 
            dataReceipt.AllowCustomTheming = true;
            dataReceipt.AllowUserToAddRows = false;
            dataReceipt.AllowUserToDeleteRows = false;
            dataReceipt.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataReceipt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataReceipt.BackgroundColor = SystemColors.ActiveCaption;
            dataReceipt.BorderStyle = BorderStyle.None;
            dataReceipt.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataReceipt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataReceipt.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dataReceipt.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataReceipt.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dataReceipt.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataReceipt.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dataReceipt.CurrentTheme.BackColor = Color.White;
            dataReceipt.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dataReceipt.CurrentTheme.HeaderStyle.BackColor = SystemColors.Desktop;
            dataReceipt.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataReceipt.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dataReceipt.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataReceipt.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dataReceipt.CurrentTheme.Name = null;
            dataReceipt.CurrentTheme.RowsStyle.BackColor = Color.White;
            dataReceipt.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataReceipt.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dataReceipt.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataReceipt.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataReceipt.DefaultCellStyle = dataGridViewCellStyle3;
            dataReceipt.EnableHeadersVisualStyles = false;
            dataReceipt.GridColor = Color.FromArgb(221, 238, 255);
            dataReceipt.HeaderBackColor = SystemColors.Desktop;
            dataReceipt.HeaderBgColor = Color.Empty;
            dataReceipt.HeaderForeColor = Color.White;
            dataReceipt.Location = new Point(40, 205);
            dataReceipt.Margin = new Padding(3, 2, 3, 2);
            dataReceipt.Name = "dataReceipt";
            dataReceipt.RowHeadersVisible = false;
            dataReceipt.RowHeadersWidth = 51;
            dataReceipt.RowTemplate.Height = 40;
            dataReceipt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataReceipt.Size = new Size(658, 128);
            dataReceipt.TabIndex = 15;
            dataReceipt.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            dataReceipt.CellContentClick += dataReceipt_CellContentClick_1;
            // 
            // ModalReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(737, 404);
            Controls.Add(dataReceipt);
            Controls.Add(btnBack);
            Controls.Add(btnPrint);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(lblOutstanding);
            Controls.Add(lblMonthly);
            Controls.Add(lblDatePaid);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(lblDate);
            Controls.Add(lblRegistrationDate);
            Controls.Add(lblContact);
            Controls.Add(lblApartmentNo);
            Controls.Add(lblTenantName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ModalReceipt";
            Text = "ModalReceipt";
            Load += ModalReceipt_Load;
            ((System.ComponentModel.ISupportInitialize)dataReceipt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label5;
        private Label label2;
        public Label lblTenantName;
        public Label lblApartmentNo;
        public Label lblContact;
        public Label lblRegistrationDate;
        public Label lblDate;
        public Label lblOutstanding;
        public Label lblMonthly;
        public Label lblDatePaid;
        public Label lblTotal;
        public Button btnPrint;
        public Button btnBack;
        private System.Windows.Forms.Timer ModalEffect_Timer;
        public Bunifu.UI.WinForms.BunifuDataGridView dataReceipt;
        private System.Windows.Forms.Timer ModalCancel_Timer;
    }
}