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
            dataReceipt = new DataGridView();
            label2 = new Label();
            lblTotal = new Label();
            btnPrint = new Button();
            btnBack = new Button();
            ModalEffect_Timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataReceipt).BeginInit();
            SuspendLayout();
            // 
            // lblTenantName
            // 
            lblTenantName.AutoSize = true;
            lblTenantName.Location = new Point(335, 110);
            lblTenantName.Name = "lblTenantName";
            lblTenantName.Size = new Size(110, 20);
            lblTenantName.TabIndex = 0;
            lblTenantName.Text = "lblTenantName";
            lblTenantName.Click += lblTenantName_Click;
            // 
            // lblApartmentNo
            // 
            lblApartmentNo.AutoSize = true;
            lblApartmentNo.Location = new Point(335, 160);
            lblApartmentNo.Name = "lblApartmentNo";
            lblApartmentNo.Size = new Size(117, 20);
            lblApartmentNo.TabIndex = 1;
            lblApartmentNo.Text = "lblApartmentNo";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(335, 199);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(77, 20);
            lblContact.TabIndex = 2;
            lblContact.Text = "lblContact";
            // 
            // lblRegistrationDate
            // 
            lblRegistrationDate.AutoSize = true;
            lblRegistrationDate.Location = new Point(335, 238);
            lblRegistrationDate.Name = "lblRegistrationDate";
            lblRegistrationDate.Size = new Size(138, 20);
            lblRegistrationDate.TabIndex = 3;
            lblRegistrationDate.Text = "lblRegistrationDate";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(695, 35);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(58, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "lblDate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 18);
            label1.Name = "label1";
            label1.Size = new Size(390, 41);
            label1.TabIndex = 5;
            label1.Text = "AMIGGAS INCORPORATION";
            label1.Click += label1_Click;
            // 
            // lblOutstanding
            // 
            lblOutstanding.AutoSize = true;
            lblOutstanding.Location = new Point(657, 238);
            lblOutstanding.Name = "lblOutstanding";
            lblOutstanding.Size = new Size(107, 20);
            lblOutstanding.TabIndex = 9;
            lblOutstanding.Text = "lblOutstanding";
            // 
            // lblMonthly
            // 
            lblMonthly.AutoSize = true;
            lblMonthly.Location = new Point(657, 199);
            lblMonthly.Name = "lblMonthly";
            lblMonthly.Size = new Size(80, 20);
            lblMonthly.TabIndex = 8;
            lblMonthly.Text = "lblMonthly";
            // 
            // lblDatePaid
            // 
            lblDatePaid.AutoSize = true;
            lblDatePaid.Location = new Point(657, 160);
            lblDatePaid.Name = "lblDatePaid";
            lblDatePaid.Size = new Size(86, 20);
            lblDatePaid.TabIndex = 7;
            lblDatePaid.Text = "lblDatePaid";
            lblDatePaid.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(614, 92);
            label5.Name = "label5";
            label5.Size = new Size(216, 38);
            label5.TabIndex = 6;
            label5.Text = "Payment Details";
            // 
            // dataReceipt
            // 
            dataReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataReceipt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataReceipt.BackgroundColor = SystemColors.ActiveCaption;
            dataReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataReceipt.Location = new Point(25, 273);
            dataReceipt.Name = "dataReceipt";
            dataReceipt.RowHeadersVisible = false;
            dataReceipt.RowHeadersWidth = 51;
            dataReceipt.Size = new Size(783, 188);
            dataReceipt.TabIndex = 10;
            dataReceipt.CellContentClick += dataReceipt_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 490);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 11;
            label2.Text = "THANK YOU!";
            label2.Click += label2_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(646, 490);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 20);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "lblTotal";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(25, 490);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(112, 29);
            btnPrint.TabIndex = 13;
            btnPrint.Text = "Print Invoice";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(153, 490);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ModalEffect_Timer
            // 
            ModalEffect_Timer.Interval = 1;
            // 
            // ModalReceipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 539);
            Controls.Add(btnBack);
            Controls.Add(btnPrint);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(dataReceipt);
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
        public DataGridView dataReceipt;
        private System.Windows.Forms.Timer ModalEffect_Timer;
    }
}