namespace AmiggasRenting
{
    partial class ModalAddTenants
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
            txtName = new TextBox();
            txtContact = new TextBox();
            lblName = new Label();
            lblAge = new Label();
            lblBirthday = new Label();
            lblContact = new Label();
            btnAdd = new Button();
            ModalEffect_Timer = new System.Windows.Forms.Timer(components);
            btnCancel = new Button();
            dateBirthday = new DateTimePicker();
            dateRegistration = new DateTimePicker();
            lblRegistration = new Label();
            numApartment = new NumericUpDown();
            lblApartment = new Label();
            numAge = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numApartment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(236, 63);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 34);
            txtName.TabIndex = 0;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(236, 286);
            txtContact.Multiline = true;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(125, 34);
            txtContact.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(123, 77);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Name: ";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(123, 156);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(39, 20);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age:";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(123, 233);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(67, 20);
            lblBirthday.TabIndex = 6;
            lblBirthday.Text = "Birthday:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(109, 300);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(121, 20);
            lblContact.TabIndex = 7;
            lblContact.Text = "Contact Number:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(485, 398);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ModalEffect_Timer
            // 
            ModalEffect_Timer.Interval = 1;
            ModalEffect_Timer.Tick += ModalEffect_Timer_Tick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(634, 398);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // dateBirthday
            // 
            dateBirthday.Location = new Point(236, 228);
            dateBirthday.Name = "dateBirthday";
            dateBirthday.Size = new Size(250, 27);
            dateBirthday.TabIndex = 11;
            // 
            // dateRegistration
            // 
            dateRegistration.Location = new Point(236, 350);
            dateRegistration.Name = "dateRegistration";
            dateRegistration.Size = new Size(250, 27);
            dateRegistration.TabIndex = 12;
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Location = new Point(93, 355);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(125, 20);
            lblRegistration.TabIndex = 13;
            lblRegistration.Text = "Registration Date";
            // 
            // numApartment
            // 
            numApartment.Location = new Point(584, 90);
            numApartment.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numApartment.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numApartment.Name = "numApartment";
            numApartment.Size = new Size(150, 27);
            numApartment.TabIndex = 14;
            numApartment.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numApartment.ValueChanged += numApartment_ValueChanged;
            // 
            // lblApartment
            // 
            lblApartment.AutoSize = true;
            lblApartment.Location = new Point(471, 92);
            lblApartment.Name = "lblApartment";
            lblApartment.Size = new Size(110, 20);
            lblApartment.TabIndex = 15;
            lblApartment.Text = "Apartment No.:";
            // 
            // numAge
            // 
            numAge.Location = new Point(224, 156);
            numAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(150, 27);
            numAge.TabIndex = 16;
            numAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ModalAddTenants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numAge);
            Controls.Add(lblApartment);
            Controls.Add(numApartment);
            Controls.Add(lblRegistration);
            Controls.Add(dateRegistration);
            Controls.Add(dateBirthday);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(lblContact);
            Controls.Add(lblBirthday);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModalAddTenants";
            Opacity = 0D;
            Load += ModalAddTenants_Load;
            ((System.ComponentModel.ISupportInitialize)numApartment).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtContact;
        private Label lblName;
        private Label lblAge;
        private Label lblBirthday;
        private Label lblContact;
        private Button btnAdd;
        private System.Windows.Forms.Timer ModalEffect_Timer;
        private Button btnCancel;
        public MonthCalendar monthCalendar1;
        private DateTimePicker dateBirthday;
        private DateTimePicker dateRegistration;
        private Label lblRegistration;
        private NumericUpDown numApartment;
        private Label lblApartment;
        private NumericUpDown numAge;
    }
}