namespace AmiggasRenting
{
    partial class modalTakeFee
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
            lblTotalPaid = new Label();
            ModalEffect_Timer = new System.Windows.Forms.Timer(components);
            lblReceipt = new Label();
            lblAmountPaid = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            numAmountPaid = new NumericUpDown();
            numReceipt = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numAmountPaid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReceipt).BeginInit();
            SuspendLayout();
            // 
            // lblTenantName
            // 
            lblTenantName.AutoSize = true;
            lblTenantName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenantName.Location = new Point(94, 61);
            lblTenantName.Name = "lblTenantName";
            lblTenantName.Size = new Size(76, 31);
            lblTenantName.TabIndex = 0;
            lblTenantName.Text = "label1";
            // 
            // lblApartmentNo
            // 
            lblApartmentNo.AutoSize = true;
            lblApartmentNo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApartmentNo.Location = new Point(94, 119);
            lblApartmentNo.Name = "lblApartmentNo";
            lblApartmentNo.Size = new Size(76, 31);
            lblApartmentNo.TabIndex = 1;
            lblApartmentNo.Text = "label1";
            // 
            // lblTotalPaid
            // 
            lblTotalPaid.AutoSize = true;
            lblTotalPaid.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPaid.Location = new Point(94, 174);
            lblTotalPaid.Name = "lblTotalPaid";
            lblTotalPaid.Size = new Size(76, 31);
            lblTotalPaid.TabIndex = 2;
            lblTotalPaid.Text = "label1";
            // 
            // ModalEffect_Timer
            // 
            ModalEffect_Timer.Interval = 1;
            // 
            // lblReceipt
            // 
            lblReceipt.AutoSize = true;
            lblReceipt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReceipt.Location = new Point(94, 230);
            lblReceipt.Name = "lblReceipt";
            lblReceipt.Size = new Size(137, 31);
            lblReceipt.TabIndex = 3;
            lblReceipt.Text = "Receipt No :";
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmountPaid.Location = new Point(94, 319);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(151, 31);
            lblAmountPaid.TabIndex = 3;
            lblAmountPaid.Text = "Amount Paid:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Lime;
            btnCancel.Location = new Point(681, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(532, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // numAmountPaid
            // 
            numAmountPaid.Location = new Point(105, 374);
            numAmountPaid.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            numAmountPaid.Name = "numAmountPaid";
            numAmountPaid.Size = new Size(430, 27);
            numAmountPaid.TabIndex = 12;
            numAmountPaid.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numReceipt
            // 
            numReceipt.BackColor = SystemColors.HighlightText;
            numReceipt.Location = new Point(105, 278);
            numReceipt.Name = "numReceipt";
            numReceipt.Size = new Size(430, 27);
            numReceipt.TabIndex = 13;
            numReceipt.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // modalTakeFee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(numReceipt);
            Controls.Add(numAmountPaid);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(lblAmountPaid);
            Controls.Add(lblReceipt);
            Controls.Add(lblTotalPaid);
            Controls.Add(lblApartmentNo);
            Controls.Add(lblTenantName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "modalTakeFee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "modalTakeFee";
            Load += modalTakeFee_Load;
            ((System.ComponentModel.ISupportInitialize)numAmountPaid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReceipt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTotalPaid;
        public Label lblTenantName;
        public Label lblApartmentNo;
        private System.Windows.Forms.Timer ModalEffect_Timer;
        private Label lblReceipt;
        private Label lblAmountPaid;
        private Button btnCancel;
        private Button btnAdd;
        private NumericUpDown numAmountPaid;
        private NumericUpDown numReceipt;
    }
}