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
            ModalCancel_Timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numAmountPaid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReceipt).BeginInit();
            SuspendLayout();
            // 
            // lblTenantName
            // 
            lblTenantName.AutoSize = true;
            lblTenantName.Font = new Font("Roboto Black", 14.25F, FontStyle.Bold);
            lblTenantName.Location = new Point(179, 36);
            lblTenantName.Name = "lblTenantName";
            lblTenantName.Size = new Size(62, 23);
            lblTenantName.TabIndex = 0;
            lblTenantName.Text = "label1";
            // 
            // lblApartmentNo
            // 
            lblApartmentNo.AutoSize = true;
            lblApartmentNo.Font = new Font("Roboto Black", 14.25F, FontStyle.Bold);
            lblApartmentNo.Location = new Point(179, 79);
            lblApartmentNo.Name = "lblApartmentNo";
            lblApartmentNo.Size = new Size(62, 23);
            lblApartmentNo.TabIndex = 1;
            lblApartmentNo.Text = "label1";
            // 
            // lblTotalPaid
            // 
            lblTotalPaid.AutoSize = true;
            lblTotalPaid.Font = new Font("Roboto Black", 14.25F, FontStyle.Bold);
            lblTotalPaid.Location = new Point(179, 120);
            lblTotalPaid.Name = "lblTotalPaid";
            lblTotalPaid.Size = new Size(62, 23);
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
            lblReceipt.Font = new Font("Roboto Black", 14.25F, FontStyle.Bold);
            lblReceipt.Location = new Point(179, 162);
            lblReceipt.Name = "lblReceipt";
            lblReceipt.Size = new Size(115, 23);
            lblReceipt.TabIndex = 3;
            lblReceipt.Text = "Receipt No :";
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Font = new Font("Roboto Black", 14.25F, FontStyle.Bold);
            lblAmountPaid.Location = new Point(179, 209);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(128, 23);
            lblAmountPaid.TabIndex = 3;
            lblAmountPaid.Text = "Amount Paid:";
            lblAmountPaid.Click += lblAmountPaid_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gold;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Roboto Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(347, 272);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 32);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gold;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Roboto Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(212, 272);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 32);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // numAmountPaid
            // 
            numAmountPaid.Font = new Font("Roboto Black", 9F, FontStyle.Bold);
            numAmountPaid.Location = new Point(313, 209);
            numAmountPaid.Margin = new Padding(3, 2, 3, 2);
            numAmountPaid.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            numAmountPaid.Name = "numAmountPaid";
            numAmountPaid.Size = new Size(193, 22);
            numAmountPaid.TabIndex = 12;
            numAmountPaid.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numReceipt
            // 
            numReceipt.BackColor = SystemColors.HighlightText;
            numReceipt.Font = new Font("Roboto Black", 9F, FontStyle.Bold);
            numReceipt.Location = new Point(313, 166);
            numReceipt.Margin = new Padding(3, 2, 3, 2);
            numReceipt.Name = "numReceipt";
            numReceipt.Size = new Size(193, 22);
            numReceipt.TabIndex = 13;
            numReceipt.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // modalTakeFee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Timer ModalCancel_Timer;
    }
}