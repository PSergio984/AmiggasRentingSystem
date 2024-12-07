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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalAddTenants));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            lblName = new Label();
            lblAge = new Label();
            lblBirthday = new Label();
            lblContact = new Label();
            ModalEffect_Timer = new System.Windows.Forms.Timer(components);
            lblRegistration = new Label();
            numApartment = new NumericUpDown();
            lblApartment = new Label();
            numAge = new NumericUpDown();
            ModalCancel_Timer = new System.Windows.Forms.Timer(components);
            txtName = new Bunifu.UI.WinForms.BunifuTextBox();
            txtContact = new Bunifu.UI.WinForms.BunifuTextBox();
            dateBirthday = new Bunifu.UI.WinForms.BunifuDatePicker();
            dateRegistration = new Bunifu.UI.WinForms.BunifuDatePicker();
            btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)numApartment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
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
            // ModalEffect_Timer
            // 
            ModalEffect_Timer.Interval = 1;
            ModalEffect_Timer.Tick += ModalEffect_Timer_Tick;
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
            // txtName
            // 
            txtName.AcceptsReturn = false;
            txtName.AcceptsTab = false;
            txtName.AnimationSpeed = 200;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.AutoSizeHeight = true;
            txtName.BackColor = Color.Transparent;
            txtName.BackgroundImage = (Image)resources.GetObject("txtName.BackgroundImage");
            txtName.BorderColorActive = Color.DodgerBlue;
            txtName.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtName.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtName.BorderColorIdle = Color.Silver;
            txtName.BorderRadius = 1;
            txtName.BorderThickness = 1;
            txtName.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.DefaultFont = new Font("Segoe UI", 9.25F);
            txtName.DefaultText = "";
            txtName.FillColor = Color.White;
            txtName.HideSelection = true;
            txtName.IconLeft = null;
            txtName.IconLeftCursor = Cursors.IBeam;
            txtName.IconPadding = 10;
            txtName.IconRight = null;
            txtName.IconRightCursor = Cursors.IBeam;
            txtName.Location = new Point(192, 77);
            txtName.MaxLength = 32767;
            txtName.MinimumSize = new Size(1, 1);
            txtName.Modified = false;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            stateProperties9.BorderColor = Color.DodgerBlue;
            stateProperties9.FillColor = Color.Empty;
            stateProperties9.ForeColor = Color.Empty;
            stateProperties9.PlaceholderForeColor = Color.Empty;
            txtName.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties10.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties10.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties10.PlaceholderForeColor = Color.DarkGray;
            txtName.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties11.FillColor = Color.Empty;
            stateProperties11.ForeColor = Color.Empty;
            stateProperties11.PlaceholderForeColor = Color.Empty;
            txtName.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = Color.Silver;
            stateProperties12.FillColor = Color.White;
            stateProperties12.ForeColor = Color.Empty;
            stateProperties12.PlaceholderForeColor = Color.Empty;
            txtName.OnIdleState = stateProperties12;
            txtName.Padding = new Padding(3);
            txtName.PasswordChar = '\0';
            txtName.PlaceholderForeColor = Color.Silver;
            txtName.PlaceholderText = "Enter text";
            txtName.ReadOnly = false;
            txtName.ScrollBars = ScrollBars.None;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(169, 35);
            txtName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtName.TabIndex = 17;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TextMarginBottom = 0;
            txtName.TextMarginLeft = 3;
            txtName.TextMarginTop = 1;
            txtName.TextPlaceholder = "Enter text";
            txtName.UseSystemPasswordChar = false;
            txtName.WordWrap = true;
            // 
            // txtContact
            // 
            txtContact.AcceptsReturn = false;
            txtContact.AcceptsTab = false;
            txtContact.AnimationSpeed = 200;
            txtContact.AutoCompleteMode = AutoCompleteMode.None;
            txtContact.AutoCompleteSource = AutoCompleteSource.None;
            txtContact.AutoSizeHeight = true;
            txtContact.BackColor = Color.Transparent;
            txtContact.BackgroundImage = (Image)resources.GetObject("txtContact.BackgroundImage");
            txtContact.BorderColorActive = Color.DodgerBlue;
            txtContact.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtContact.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtContact.BorderColorIdle = Color.Silver;
            txtContact.BorderRadius = 1;
            txtContact.BorderThickness = 1;
            txtContact.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtContact.CharacterCasing = CharacterCasing.Normal;
            txtContact.DefaultFont = new Font("Segoe UI", 9.25F);
            txtContact.DefaultText = "";
            txtContact.FillColor = Color.White;
            txtContact.HideSelection = true;
            txtContact.IconLeft = null;
            txtContact.IconLeftCursor = Cursors.IBeam;
            txtContact.IconPadding = 10;
            txtContact.IconRight = null;
            txtContact.IconRightCursor = Cursors.IBeam;
            txtContact.Location = new Point(252, 289);
            txtContact.MaxLength = 32767;
            txtContact.MinimumSize = new Size(1, 1);
            txtContact.Modified = false;
            txtContact.Multiline = false;
            txtContact.Name = "txtContact";
            stateProperties13.BorderColor = Color.DodgerBlue;
            stateProperties13.FillColor = Color.Empty;
            stateProperties13.ForeColor = Color.Empty;
            stateProperties13.PlaceholderForeColor = Color.Empty;
            txtContact.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties14.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties14.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties14.PlaceholderForeColor = Color.DarkGray;
            txtContact.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties15.FillColor = Color.Empty;
            stateProperties15.ForeColor = Color.Empty;
            stateProperties15.PlaceholderForeColor = Color.Empty;
            txtContact.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = Color.Silver;
            stateProperties16.FillColor = Color.White;
            stateProperties16.ForeColor = Color.Empty;
            stateProperties16.PlaceholderForeColor = Color.Empty;
            txtContact.OnIdleState = stateProperties16;
            txtContact.Padding = new Padding(3);
            txtContact.PasswordChar = '\0';
            txtContact.PlaceholderForeColor = Color.Silver;
            txtContact.PlaceholderText = "Enter text";
            txtContact.ReadOnly = false;
            txtContact.ScrollBars = ScrollBars.None;
            txtContact.SelectedText = "";
            txtContact.SelectionLength = 0;
            txtContact.SelectionStart = 0;
            txtContact.ShortcutsEnabled = true;
            txtContact.Size = new Size(160, 31);
            txtContact.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtContact.TabIndex = 18;
            txtContact.TextAlign = HorizontalAlignment.Left;
            txtContact.TextMarginBottom = 0;
            txtContact.TextMarginLeft = 3;
            txtContact.TextMarginTop = 1;
            txtContact.TextPlaceholder = "Enter text";
            txtContact.UseSystemPasswordChar = false;
            txtContact.WordWrap = true;
            // 
            // dateBirthday
            // 
            dateBirthday.BackColor = Color.Transparent;
            dateBirthday.BorderColor = Color.Silver;
            dateBirthday.BorderRadius = 1;
            dateBirthday.Color = Color.Silver;
            dateBirthday.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            dateBirthday.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            dateBirthday.DisabledColor = Color.Gray;
            dateBirthday.DisplayWeekNumbers = false;
            dateBirthday.DPHeight = 0;
            dateBirthday.FillDatePicker = false;
            dateBirthday.Font = new Font("Segoe UI", 9F);
            dateBirthday.ForeColor = Color.Black;
            dateBirthday.Icon = (Image)resources.GetObject("dateBirthday.Icon");
            dateBirthday.IconColor = Color.Gray;
            dateBirthday.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            dateBirthday.LeftTextMargin = 5;
            dateBirthday.Location = new Point(224, 233);
            dateBirthday.MinimumSize = new Size(0, 32);
            dateBirthday.Name = "dateBirthday";
            dateBirthday.Size = new Size(275, 32);
            dateBirthday.TabIndex = 19;
            // 
            // dateRegistration
            // 
            dateRegistration.BackColor = Color.Transparent;
            dateRegistration.BorderColor = Color.Silver;
            dateRegistration.BorderRadius = 1;
            dateRegistration.Color = Color.Silver;
            dateRegistration.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            dateRegistration.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            dateRegistration.DisabledColor = Color.Gray;
            dateRegistration.DisplayWeekNumbers = false;
            dateRegistration.DPHeight = 0;
            dateRegistration.FillDatePicker = false;
            dateRegistration.Font = new Font("Segoe UI", 9F);
            dateRegistration.ForeColor = Color.Black;
            dateRegistration.Icon = (Image)resources.GetObject("dateRegistration.Icon");
            dateRegistration.IconColor = Color.Gray;
            dateRegistration.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            dateRegistration.LeftTextMargin = 5;
            dateRegistration.Location = new Point(235, 355);
            dateRegistration.MinimumSize = new Size(0, 32);
            dateRegistration.Name = "dateRegistration";
            dateRegistration.Size = new Size(275, 32);
            dateRegistration.TabIndex = 20;
            // 
            // btnAdd
            // 
            btnAdd.AllowAnimations = true;
            btnAdd.AllowMouseEffects = true;
            btnAdd.AllowToggling = false;
            btnAdd.AnimationSpeed = 200;
            btnAdd.AutoGenerateColors = false;
            btnAdd.AutoRoundBorders = false;
            btnAdd.AutoSizeLeftIcon = true;
            btnAdd.AutoSizeRightIcon = true;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackColor1 = Color.DodgerBlue;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnAdd.ButtonText = "Add";
            btnAdd.ButtonTextMarginLeft = 0;
            btnAdd.ColorContrastOnClick = 45;
            btnAdd.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnAdd.CustomizableEdges = borderEdges3;
            btnAdd.DialogResult = DialogResult.None;
            btnAdd.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnAdd.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnAdd.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnAdd.IconLeftCursor = Cursors.Default;
            btnAdd.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnAdd.IconMarginLeft = 11;
            btnAdd.IconPadding = 10;
            btnAdd.IconRightAlign = ContentAlignment.MiddleRight;
            btnAdd.IconRightCursor = Cursors.Default;
            btnAdd.IconRightPadding = new Padding(3, 3, 7, 3);
            btnAdd.IconSize = 25;
            btnAdd.IdleBorderColor = Color.DodgerBlue;
            btnAdd.IdleBorderRadius = 1;
            btnAdd.IdleBorderThickness = 1;
            btnAdd.IdleFillColor = Color.DodgerBlue;
            btnAdd.IdleIconLeftImage = null;
            btnAdd.IdleIconRightImage = null;
            btnAdd.IndicateFocus = false;
            btnAdd.Location = new Point(489, 404);
            btnAdd.Name = "btnAdd";
            btnAdd.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnAdd.OnDisabledState.BorderRadius = 1;
            btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnAdd.OnDisabledState.BorderThickness = 1;
            btnAdd.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnAdd.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnAdd.OnDisabledState.IconLeftImage = null;
            btnAdd.OnDisabledState.IconRightImage = null;
            btnAdd.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            btnAdd.onHoverState.BorderRadius = 1;
            btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnAdd.onHoverState.BorderThickness = 1;
            btnAdd.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
            btnAdd.onHoverState.ForeColor = Color.White;
            btnAdd.onHoverState.IconLeftImage = null;
            btnAdd.onHoverState.IconRightImage = null;
            btnAdd.OnIdleState.BorderColor = Color.DodgerBlue;
            btnAdd.OnIdleState.BorderRadius = 1;
            btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnAdd.OnIdleState.BorderThickness = 1;
            btnAdd.OnIdleState.FillColor = Color.DodgerBlue;
            btnAdd.OnIdleState.ForeColor = Color.White;
            btnAdd.OnIdleState.IconLeftImage = null;
            btnAdd.OnIdleState.IconRightImage = null;
            btnAdd.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnAdd.OnPressedState.BorderRadius = 1;
            btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnAdd.OnPressedState.BorderThickness = 1;
            btnAdd.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btnAdd.OnPressedState.ForeColor = Color.White;
            btnAdd.OnPressedState.IconLeftImage = null;
            btnAdd.OnPressedState.IconRightImage = null;
            btnAdd.Size = new Size(103, 34);
            btnAdd.TabIndex = 21;
            btnAdd.TextAlign = ContentAlignment.MiddleCenter;
            btnAdd.TextAlignment = HorizontalAlignment.Center;
            btnAdd.TextMarginLeft = 0;
            btnAdd.TextPadding = new Padding(0);
            btnAdd.UseDefaultRadiusAndThickness = true;
            btnAdd.Click += this.btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.AllowAnimations = true;
            btnCancel.AllowMouseEffects = true;
            btnCancel.AllowToggling = false;
            btnCancel.AnimationSpeed = 200;
            btnCancel.AutoGenerateColors = false;
            btnCancel.AutoRoundBorders = false;
            btnCancel.AutoSizeLeftIcon = true;
            btnCancel.AutoSizeRightIcon = true;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackColor1 = Color.FromArgb(51, 122, 183);
            btnCancel.BackgroundImage = (Image)resources.GetObject("btnCancel.BackgroundImage");
            btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnCancel.ButtonText = "Cancel";
            btnCancel.ButtonTextMarginLeft = 0;
            btnCancel.ColorContrastOnClick = 45;
            btnCancel.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            btnCancel.CustomizableEdges = borderEdges4;
            btnCancel.DialogResult = DialogResult.None;
            btnCancel.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnCancel.DisabledFillColor = Color.Empty;
            btnCancel.DisabledForecolor = Color.Empty;
            btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.IconLeft = null;
            btnCancel.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnCancel.IconLeftCursor = Cursors.Default;
            btnCancel.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnCancel.IconMarginLeft = 11;
            btnCancel.IconPadding = 10;
            btnCancel.IconRight = null;
            btnCancel.IconRightAlign = ContentAlignment.MiddleRight;
            btnCancel.IconRightCursor = Cursors.Default;
            btnCancel.IconRightPadding = new Padding(3, 3, 7, 3);
            btnCancel.IconSize = 25;
            btnCancel.IdleBorderColor = Color.Empty;
            btnCancel.IdleBorderRadius = 0;
            btnCancel.IdleBorderThickness = 0;
            btnCancel.IdleFillColor = Color.Empty;
            btnCancel.IdleIconLeftImage = null;
            btnCancel.IdleIconRightImage = null;
            btnCancel.IndicateFocus = false;
            btnCancel.Location = new Point(638, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnCancel.OnDisabledState.BorderRadius = 1;
            btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnCancel.OnDisabledState.BorderThickness = 1;
            btnCancel.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnCancel.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnCancel.OnDisabledState.IconLeftImage = null;
            btnCancel.OnDisabledState.IconRightImage = null;
            btnCancel.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnCancel.onHoverState.BorderRadius = 1;
            btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnCancel.onHoverState.BorderThickness = 1;
            btnCancel.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnCancel.onHoverState.ForeColor = Color.White;
            btnCancel.onHoverState.IconLeftImage = null;
            btnCancel.onHoverState.IconRightImage = null;
            btnCancel.OnIdleState.BorderColor = Color.DodgerBlue;
            btnCancel.OnIdleState.BorderRadius = 1;
            btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnCancel.OnIdleState.BorderThickness = 1;
            btnCancel.OnIdleState.FillColor = Color.DodgerBlue;
            btnCancel.OnIdleState.ForeColor = Color.White;
            btnCancel.OnIdleState.IconLeftImage = null;
            btnCancel.OnIdleState.IconRightImage = null;
            btnCancel.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnCancel.OnPressedState.BorderRadius = 1;
            btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnCancel.OnPressedState.BorderThickness = 1;
            btnCancel.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btnCancel.OnPressedState.ForeColor = Color.White;
            btnCancel.OnPressedState.IconLeftImage = null;
            btnCancel.OnPressedState.IconRightImage = null;
            btnCancel.Size = new Size(110, 34);
            btnCancel.TabIndex = 22;
            btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            btnCancel.TextAlignment = HorizontalAlignment.Center;
            btnCancel.TextMarginLeft = 0;
            btnCancel.TextPadding = new Padding(0);
            btnCancel.UseDefaultRadiusAndThickness = true;
            btnCancel.Click += this.btnCancel_Click_1;
            // 
            // ModalAddTenants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(dateRegistration);
            Controls.Add(dateBirthday);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Controls.Add(numAge);
            Controls.Add(lblApartment);
            Controls.Add(numApartment);
            Controls.Add(lblRegistration);
            Controls.Add(lblContact);
            Controls.Add(lblBirthday);
            Controls.Add(lblAge);
            Controls.Add(lblName);
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

      
        private Label lblName;
        private Label lblAge;
        private Label lblBirthday;
        private Label lblContact;
        
        private System.Windows.Forms.Timer ModalEffect_Timer;
    
        public MonthCalendar monthCalendar1;
    
        private Label lblRegistration;
        private NumericUpDown numApartment;
        private Label lblApartment;
        private NumericUpDown numAge;
        private System.Windows.Forms.Timer ModalCancel_Timer;
        private Bunifu.UI.WinForms.BunifuTextBox txtName;
        private Bunifu.UI.WinForms.BunifuTextBox txtContact;
        private Bunifu.UI.WinForms.BunifuDatePicker dateBirthday;
        private Bunifu.UI.WinForms.BunifuDatePicker dateRegistration;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAdd;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
    }
}