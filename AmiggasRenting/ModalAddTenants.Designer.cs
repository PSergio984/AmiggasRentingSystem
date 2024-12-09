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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
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
            lblName.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
            lblName.Location = new Point(70, 42);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 19);
            lblName.TabIndex = 4;
            lblName.Text = "Name: ";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
            lblAge.Location = new Point(70, 83);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(43, 19);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age:";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
            lblBirthday.Location = new Point(70, 127);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(75, 19);
            lblBirthday.TabIndex = 6;
            lblBirthday.Text = "Birthday:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
            lblContact.Location = new Point(70, 179);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(134, 19);
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
            lblRegistration.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
            lblRegistration.Location = new Point(70, 227);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(136, 19);
            lblRegistration.TabIndex = 13;
            lblRegistration.Text = "Registration Date";
            // 
            // numApartment
            // 
            numApartment.BackColor = Color.White;
            numApartment.Font = new Font("Roboto Black", 9F, FontStyle.Bold);
            numApartment.Location = new Point(212, 267);
            numApartment.Margin = new Padding(3, 2, 3, 2);
            numApartment.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numApartment.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numApartment.Name = "numApartment";
            numApartment.Size = new Size(241, 22);
            numApartment.TabIndex = 14;
            numApartment.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numApartment.ValueChanged += numApartment_ValueChanged;
            // 
            // lblApartment
            // 
            lblApartment.AutoSize = true;
            lblApartment.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
            lblApartment.Location = new Point(70, 267);
            lblApartment.Name = "lblApartment";
            lblApartment.Size = new Size(122, 19);
            lblApartment.TabIndex = 15;
            lblApartment.Text = "Apartment No.:";
            // 
            // numAge
            // 
            numAge.BackColor = Color.White;
            numAge.BorderStyle = BorderStyle.FixedSingle;
            numAge.Font = new Font("Roboto Black", 9F, FontStyle.Bold);
            numAge.Location = new Point(212, 79);
            numAge.Margin = new Padding(3, 2, 3, 2);
            numAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(241, 22);
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
            txtName.BorderColorActive = Color.Gold;
            txtName.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtName.BorderColorHover = Color.Black;
            txtName.BorderColorIdle = Color.FromArgb(192, 192, 0);
            txtName.BorderRadius = 1;
            txtName.BorderThickness = 1;
            txtName.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.DefaultFont = new Font("Roboto Black", 9F, FontStyle.Bold);
            txtName.DefaultText = "";
            txtName.FillColor = Color.White;
            txtName.HideSelection = true;
            txtName.IconLeft = null;
            txtName.IconLeftCursor = Cursors.IBeam;
            txtName.IconPadding = 10;
            txtName.IconRight = null;
            txtName.IconRightCursor = Cursors.IBeam;
            txtName.Location = new Point(212, 25);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.MaxLength = 32767;
            txtName.MinimumSize = new Size(1, 1);
            txtName.Modified = false;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            stateProperties1.BorderColor = Color.Gold;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            txtName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            txtName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.Black;
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            txtName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.FromArgb(192, 192, 0);
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            txtName.OnIdleState = stateProperties4;
            txtName.Padding = new Padding(3, 2, 3, 2);
            txtName.PasswordChar = '\0';
            txtName.PlaceholderForeColor = Color.Silver;
            txtName.PlaceholderText = "Enter Name";
            txtName.ReadOnly = false;
            txtName.ScrollBars = ScrollBars.None;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(241, 34);
            txtName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtName.TabIndex = 17;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TextMarginBottom = 0;
            txtName.TextMarginLeft = 3;
            txtName.TextMarginTop = 1;
            txtName.TextPlaceholder = "Enter Name";
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
            txtContact.BorderColorActive = Color.Gold;
            txtContact.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtContact.BorderColorHover = Color.Black;
            txtContact.BorderColorIdle = Color.FromArgb(192, 192, 0);
            txtContact.BorderRadius = 1;
            txtContact.BorderThickness = 1;
            txtContact.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtContact.CharacterCasing = CharacterCasing.Normal;
            txtContact.DefaultFont = new Font("Roboto Black", 9F, FontStyle.Bold);
            txtContact.DefaultText = "";
            txtContact.FillColor = Color.White;
            txtContact.HideSelection = true;
            txtContact.IconLeft = null;
            txtContact.IconLeftCursor = Cursors.IBeam;
            txtContact.IconPadding = 10;
            txtContact.IconRight = null;
            txtContact.IconRightCursor = Cursors.IBeam;
            txtContact.Location = new Point(212, 162);
            txtContact.Margin = new Padding(3, 2, 3, 2);
            txtContact.MaxLength = 32767;
            txtContact.MinimumSize = new Size(1, 1);
            txtContact.Modified = false;
            txtContact.Multiline = false;
            txtContact.Name = "txtContact";
            stateProperties5.BorderColor = Color.Gold;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            txtContact.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            txtContact.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.Black;
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            txtContact.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.FromArgb(192, 192, 0);
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            txtContact.OnIdleState = stateProperties8;
            txtContact.Padding = new Padding(3, 2, 3, 2);
            txtContact.PasswordChar = '\0';
            txtContact.PlaceholderForeColor = Color.Silver;
            txtContact.PlaceholderText = "Enter Contact Number";
            txtContact.ReadOnly = false;
            txtContact.ScrollBars = ScrollBars.None;
            txtContact.SelectedText = "";
            txtContact.SelectionLength = 0;
            txtContact.SelectionStart = 0;
            txtContact.ShortcutsEnabled = true;
            txtContact.Size = new Size(241, 34);
            txtContact.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtContact.TabIndex = 18;
            txtContact.TextAlign = HorizontalAlignment.Left;
            txtContact.TextMarginBottom = 0;
            txtContact.TextMarginLeft = 3;
            txtContact.TextMarginTop = 1;
            txtContact.TextPlaceholder = "Enter Contact Number";
            txtContact.UseSystemPasswordChar = false;
            txtContact.WordWrap = true;
            txtContact.KeyPress += txtContact_KeyPress;
            // 
            // dateBirthday
            // 
            dateBirthday.BackColor = Color.White;
            dateBirthday.BorderColor = Color.FromArgb(192, 192, 0);
            dateBirthday.BorderRadius = 1;
            dateBirthday.Color = Color.FromArgb(192, 192, 0);
            dateBirthday.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            dateBirthday.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            dateBirthday.DisabledColor = Color.Gray;
            dateBirthday.DisplayWeekNumbers = false;
            dateBirthday.DPHeight = 0;
            dateBirthday.DropDownAlign = LeftRightAlignment.Right;
            dateBirthday.FillDatePicker = false;
            dateBirthday.Font = new Font("Roboto Black", 9F, FontStyle.Bold);
            dateBirthday.ForeColor = Color.Black;
            dateBirthday.Icon = (Image)resources.GetObject("dateBirthday.Icon");
            dateBirthday.IconColor = Color.Gray;
            dateBirthday.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            dateBirthday.LeftTextMargin = 5;
            dateBirthday.Location = new Point(212, 114);
            dateBirthday.Margin = new Padding(3, 2, 3, 2);
            dateBirthday.MinimumSize = new Size(4, 32);
            dateBirthday.Name = "dateBirthday";
            dateBirthday.Size = new Size(241, 32);
            dateBirthday.TabIndex = 19;
            // 
            // dateRegistration
            // 
            dateRegistration.BackColor = Color.White;
            dateRegistration.BorderColor = Color.FromArgb(192, 192, 0);
            dateRegistration.BorderRadius = 1;
            dateRegistration.Color = Color.FromArgb(192, 192, 0);
            dateRegistration.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            dateRegistration.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            dateRegistration.DisabledColor = Color.Gray;
            dateRegistration.DisplayWeekNumbers = false;
            dateRegistration.DPHeight = 0;
            dateRegistration.DropDownAlign = LeftRightAlignment.Right;
            dateRegistration.FillDatePicker = false;
            dateRegistration.Font = new Font("Roboto Black", 9F, FontStyle.Bold);
            dateRegistration.ForeColor = Color.Black;
            dateRegistration.Icon = (Image)resources.GetObject("dateRegistration.Icon");
            dateRegistration.IconColor = Color.Gray;
            dateRegistration.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            dateRegistration.LeftTextMargin = 5;
            dateRegistration.Location = new Point(212, 221);
            dateRegistration.Margin = new Padding(3, 2, 3, 2);
            dateRegistration.MinimumSize = new Size(4, 32);
            dateRegistration.Name = "dateRegistration";
            dateRegistration.Size = new Size(241, 32);
            dateRegistration.TabIndex = 20;
            // 
            // btnAdd
            // 
            btnAdd.AllowAnimations = true;
            btnAdd.AllowMouseEffects = true;
            btnAdd.AllowToggling = false;
            btnAdd.AnimationSpeed = 200;
            btnAdd.AutoGenerateColors = false;
            btnAdd.AutoRoundBorders = true;
            btnAdd.AutoSizeLeftIcon = true;
            btnAdd.AutoSizeRightIcon = true;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackColor1 = Color.Gold;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnAdd.ButtonText = "Add";
            btnAdd.ButtonTextMarginLeft = 0;
            btnAdd.ColorContrastOnClick = 45;
            btnAdd.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnAdd.CustomizableEdges = borderEdges1;
            btnAdd.DialogResult = DialogResult.None;
            btnAdd.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnAdd.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnAdd.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = Color.Black;
            btnAdd.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnAdd.IconLeftCursor = Cursors.Default;
            btnAdd.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnAdd.IconMarginLeft = 11;
            btnAdd.IconPadding = 10;
            btnAdd.IconRightAlign = ContentAlignment.MiddleRight;
            btnAdd.IconRightCursor = Cursors.Default;
            btnAdd.IconRightPadding = new Padding(3, 3, 7, 3);
            btnAdd.IconSize = 25;
            btnAdd.IdleBorderColor = Color.FromArgb(192, 192, 0);
            btnAdd.IdleBorderRadius = 24;
            btnAdd.IdleBorderThickness = 1;
            btnAdd.IdleFillColor = Color.Gold;
            btnAdd.IdleIconLeftImage = null;
            btnAdd.IdleIconRightImage = null;
            btnAdd.IndicateFocus = false;
            btnAdd.Location = new Point(547, 220);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnAdd.OnDisabledState.BorderRadius = 1;
            btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnAdd.OnDisabledState.BorderThickness = 1;
            btnAdd.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnAdd.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnAdd.OnDisabledState.IconLeftImage = null;
            btnAdd.OnDisabledState.IconRightImage = null;
            btnAdd.onHoverState.BorderColor = Color.FromArgb(220, 220, 114);
            btnAdd.onHoverState.BorderRadius = 1;
            btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnAdd.onHoverState.BorderThickness = 1;
            btnAdd.onHoverState.FillColor = Color.FromArgb(255, 233, 114);
            btnAdd.onHoverState.ForeColor = Color.White;
            btnAdd.onHoverState.IconLeftImage = null;
            btnAdd.onHoverState.IconRightImage = null;
            btnAdd.OnIdleState.BorderColor = Color.FromArgb(192, 192, 0);
            btnAdd.OnIdleState.BorderRadius = 1;
            btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnAdd.OnIdleState.BorderThickness = 1;
            btnAdd.OnIdleState.FillColor = Color.Gold;
            btnAdd.OnIdleState.ForeColor = Color.Black;
            btnAdd.OnIdleState.IconLeftImage = null;
            btnAdd.OnIdleState.IconRightImage = null;
            btnAdd.OnPressedState.BorderColor = Color.FromArgb(192, 192, 0);
            btnAdd.OnPressedState.BorderRadius = 1;
            btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnAdd.OnPressedState.BorderThickness = 1;
            btnAdd.OnPressedState.FillColor = Color.Gold;
            btnAdd.OnPressedState.ForeColor = Color.Black;
            btnAdd.OnPressedState.IconLeftImage = null;
            btnAdd.OnPressedState.IconRightImage = null;
            btnAdd.Size = new Size(96, 26);
            btnAdd.TabIndex = 21;
            btnAdd.TextAlign = ContentAlignment.MiddleCenter;
            btnAdd.TextAlignment = HorizontalAlignment.Center;
            btnAdd.TextMarginLeft = 0;
            btnAdd.TextPadding = new Padding(0);
            btnAdd.UseDefaultRadiusAndThickness = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.AllowAnimations = true;
            btnCancel.AllowMouseEffects = true;
            btnCancel.AllowToggling = false;
            btnCancel.AnimationSpeed = 200;
            btnCancel.AutoGenerateColors = true;
            btnCancel.AutoRoundBorders = true;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnCancel.CustomizableEdges = borderEdges2;
            btnCancel.DialogResult = DialogResult.None;
            btnCancel.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnCancel.DisabledFillColor = Color.Empty;
            btnCancel.DisabledForecolor = Color.Empty;
            btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.Black;
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
            btnCancel.Location = new Point(547, 260);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnCancel.OnDisabledState.BorderRadius = 26;
            btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnCancel.OnDisabledState.BorderThickness = 1;
            btnCancel.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnCancel.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnCancel.OnDisabledState.IconLeftImage = null;
            btnCancel.OnDisabledState.IconRightImage = null;
            btnCancel.onHoverState.BorderColor = Color.Black;
            btnCancel.onHoverState.BorderRadius = 26;
            btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnCancel.onHoverState.BorderThickness = 1;
            btnCancel.onHoverState.FillColor = Color.FromArgb(255, 233, 114);
            btnCancel.onHoverState.ForeColor = Color.White;
            btnCancel.onHoverState.IconLeftImage = null;
            btnCancel.onHoverState.IconRightImage = null;
            btnCancel.OnIdleState.BorderColor = Color.FromArgb(192, 192, 0);
            btnCancel.OnIdleState.BorderRadius = 26;
            btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnCancel.OnIdleState.BorderThickness = 1;
            btnCancel.OnIdleState.FillColor = Color.Gold;
            btnCancel.OnIdleState.ForeColor = Color.Black;
            btnCancel.OnIdleState.IconLeftImage = null;
            btnCancel.OnIdleState.IconRightImage = null;
            btnCancel.OnPressedState.BorderColor = Color.Transparent;
            btnCancel.OnPressedState.BorderRadius = 26;
            btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnCancel.OnPressedState.BorderThickness = 1;
            btnCancel.OnPressedState.FillColor = Color.Transparent;
            btnCancel.OnPressedState.ForeColor = Color.Black;
            btnCancel.OnPressedState.IconLeftImage = null;
            btnCancel.OnPressedState.IconRightImage = null;
            btnCancel.Size = new Size(96, 26);
            btnCancel.TabIndex = 22;
            btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            btnCancel.TextAlignment = HorizontalAlignment.Center;
            btnCancel.TextMarginLeft = 0;
            btnCancel.TextPadding = new Padding(0);
            btnCancel.UseDefaultRadiusAndThickness = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // ModalAddTenants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
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