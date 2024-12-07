namespace LoginPage
{
    partial class LoginPageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPageForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            txtEmail = new Bunifu.UI.WinForms.BunifuTextBox();
            btnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            btnShow = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            btnHide = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(433, 204);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 270);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.AcceptsReturn = false;
            txtPassword.AcceptsTab = false;
            txtPassword.AnimationSpeed = 200;
            txtPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtPassword.AutoSizeHeight = true;
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BackgroundImage = (Image)resources.GetObject("txtPassword.BackgroundImage");
            txtPassword.BorderColorActive = Color.DodgerBlue;
            txtPassword.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtPassword.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtPassword.BorderColorIdle = Color.Silver;
            txtPassword.BorderRadius = 20;
            txtPassword.BorderThickness = 1;
            txtPassword.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.DefaultFont = new Font("Segoe UI", 9.25F);
            txtPassword.DefaultText = "";
            txtPassword.FillColor = Color.White;
            txtPassword.HideSelection = true;
            txtPassword.IconLeft = null;
            txtPassword.IconLeftCursor = Cursors.IBeam;
            txtPassword.IconPadding = 10;
            txtPassword.IconRight = null;
            txtPassword.IconRightCursor = Cursors.IBeam;
            txtPassword.Location = new Point(532, 256);
            txtPassword.MaxLength = 32767;
            txtPassword.MinimumSize = new Size(1, 1);
            txtPassword.Modified = false;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            txtPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            txtPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            txtPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            txtPassword.OnIdleState = stateProperties4;
            txtPassword.Padding = new Padding(3);
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderForeColor = Color.Silver;
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.ReadOnly = false;
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(146, 48);
            txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtPassword.TabIndex = 6;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TextMarginBottom = 0;
            txtPassword.TextMarginLeft = 3;
            txtPassword.TextMarginTop = 1;
            txtPassword.TextPlaceholder = "Enter Password";
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.WordWrap = true;
            // 
            // txtEmail
            // 
            txtEmail.AcceptsReturn = false;
            txtEmail.AcceptsTab = false;
            txtEmail.AnimationSpeed = 200;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.AutoSizeHeight = true;
            txtEmail.BackColor = Color.Transparent;
            txtEmail.BackgroundImage = (Image)resources.GetObject("txtEmail.BackgroundImage");
            txtEmail.BorderColorActive = Color.DodgerBlue;
            txtEmail.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtEmail.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtEmail.BorderColorIdle = Color.Silver;
            txtEmail.BorderRadius = 20;
            txtEmail.BorderThickness = 1;
            txtEmail.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.DefaultFont = new Font("Segoe UI", 9.25F);
            txtEmail.DefaultText = "";
            txtEmail.FillColor = Color.White;
            txtEmail.HideSelection = true;
            txtEmail.IconLeft = null;
            txtEmail.IconLeftCursor = Cursors.IBeam;
            txtEmail.IconPadding = 10;
            txtEmail.IconRight = null;
            txtEmail.IconRightCursor = Cursors.IBeam;
            txtEmail.Location = new Point(532, 195);
            txtEmail.MaxLength = 32767;
            txtEmail.MinimumSize = new Size(1, 1);
            txtEmail.Modified = false;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            txtEmail.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            txtEmail.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            txtEmail.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            txtEmail.OnIdleState = stateProperties8;
            txtEmail.Padding = new Padding(3);
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderForeColor = Color.Silver;
            txtEmail.PlaceholderText = "Enter Username";
            txtEmail.ReadOnly = false;
            txtEmail.ScrollBars = ScrollBars.None;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(154, 41);
            txtEmail.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtEmail.TabIndex = 7;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TextMarginBottom = 0;
            txtEmail.TextMarginLeft = 3;
            txtEmail.TextMarginTop = 1;
            txtEmail.TextPlaceholder = "Enter Username";
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.WordWrap = true;
            // 
            // btnLogin
            // 
            btnLogin.AllowAnimations = true;
            btnLogin.AllowMouseEffects = true;
            btnLogin.AllowToggling = true;
            btnLogin.AnimationSpeed = 200;
            btnLogin.AutoGenerateColors = true;
            btnLogin.AutoRoundBorders = true;
            btnLogin.AutoSizeLeftIcon = true;
            btnLogin.AutoSizeRightIcon = true;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackColor1 = Color.DodgerBlue;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnLogin.ButtonText = "Login";
            btnLogin.ButtonTextMarginLeft = 0;
            btnLogin.ColorContrastOnClick = 45;
            btnLogin.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnLogin.CustomizableEdges = borderEdges1;
            btnLogin.DialogResult = DialogResult.None;
            btnLogin.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnLogin.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnLogin.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnLogin.Font = new Font("Segoe UI", 9F);
            btnLogin.ForeColor = Color.White;
            btnLogin.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnLogin.IconLeftCursor = Cursors.Default;
            btnLogin.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnLogin.IconMarginLeft = 11;
            btnLogin.IconPadding = 10;
            btnLogin.IconRightAlign = ContentAlignment.MiddleRight;
            btnLogin.IconRightCursor = Cursors.Default;
            btnLogin.IconRightPadding = new Padding(3, 3, 7, 3);
            btnLogin.IconSize = 25;
            btnLogin.IdleBorderColor = Color.Cyan;
            btnLogin.IdleBorderRadius = 34;
            btnLogin.IdleBorderThickness = 1;
            btnLogin.IdleFillColor = Color.DodgerBlue;
            btnLogin.IdleIconLeftImage = null;
            btnLogin.IdleIconRightImage = null;
            btnLogin.IndicateFocus = true;
            btnLogin.Location = new Point(527, 325);
            btnLogin.Name = "btnLogin";
            btnLogin.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnLogin.OnDisabledState.BorderRadius = 20;
            btnLogin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnLogin.OnDisabledState.BorderThickness = 1;
            btnLogin.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnLogin.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnLogin.OnDisabledState.IconLeftImage = null;
            btnLogin.OnDisabledState.IconRightImage = null;
            btnLogin.onHoverState.BorderColor = Color.FromArgb(114, 255, 255);
            btnLogin.onHoverState.BorderRadius = 20;
            btnLogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnLogin.onHoverState.BorderThickness = 1;
            btnLogin.onHoverState.FillColor = Color.FromArgb(131, 193, 255);
            btnLogin.onHoverState.ForeColor = Color.White;
            btnLogin.onHoverState.IconLeftImage = null;
            btnLogin.onHoverState.IconRightImage = null;
            btnLogin.OnIdleState.BorderColor = Color.Cyan;
            btnLogin.OnIdleState.BorderRadius = 20;
            btnLogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnLogin.OnIdleState.BorderThickness = 1;
            btnLogin.OnIdleState.FillColor = Color.DodgerBlue;
            btnLogin.OnIdleState.ForeColor = Color.White;
            btnLogin.OnIdleState.IconLeftImage = null;
            btnLogin.OnIdleState.IconRightImage = null;
            btnLogin.OnPressedState.BorderColor = Color.FromArgb(0, 140, 140);
            btnLogin.OnPressedState.BorderRadius = 20;
            btnLogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnLogin.OnPressedState.BorderThickness = 1;
            btnLogin.OnPressedState.FillColor = Color.FromArgb(16, 79, 140);
            btnLogin.OnPressedState.ForeColor = Color.GhostWhite;
            btnLogin.OnPressedState.IconLeftImage = null;
            btnLogin.OnPressedState.IconRightImage = null;
            btnLogin.Size = new Size(159, 36);
            btnLogin.TabIndex = 8;
            btnLogin.TextAlign = ContentAlignment.MiddleCenter;
            btnLogin.TextAlignment = HorizontalAlignment.Center;
            btnLogin.TextMarginLeft = 0;
            btnLogin.TextPadding = new Padding(0);
            btnLogin.UseDefaultRadiusAndThickness = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnShow
            // 
            btnShow.AllowAnimations = true;
            btnShow.AllowBorderColorChanges = true;
            btnShow.AllowMouseEffects = true;
            btnShow.AnimationSpeed = 200;
            btnShow.BackColor = Color.Transparent;
            btnShow.BackgroundColor = Color.DodgerBlue;
            btnShow.BorderColor = Color.DodgerBlue;
            btnShow.BorderRadius = 1;
            btnShow.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            btnShow.BorderThickness = 1;
            btnShow.ColorContrastOnClick = 30;
            btnShow.ColorContrastOnHover = 30;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnShow.CustomizableEdges = borderEdges2;
            btnShow.DialogResult = DialogResult.None;
            btnShow.Image = AmiggasRenting.Properties.Resources.view;
            btnShow.ImageMargin = new Padding(0);
            btnShow.Location = new Point(687, 263);
            btnShow.Name = "btnShow";
            btnShow.RoundBorders = true;
            btnShow.ShowBorders = true;
            btnShow.Size = new Size(44, 44);
            btnShow.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            btnShow.TabIndex = 9;
            btnShow.Click += btnShow_Click_1;
            // 
            // btnHide
            // 
            btnHide.AllowAnimations = true;
            btnHide.AllowBorderColorChanges = true;
            btnHide.AllowMouseEffects = true;
            btnHide.AnimationSpeed = 200;
            btnHide.BackColor = Color.Transparent;
            btnHide.BackgroundColor = Color.DodgerBlue;
            btnHide.BorderColor = Color.DodgerBlue;
            btnHide.BorderRadius = 1;
            btnHide.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            btnHide.BorderThickness = 1;
            btnHide.ColorContrastOnClick = 30;
            btnHide.ColorContrastOnHover = 30;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnHide.CustomizableEdges = borderEdges3;
            btnHide.DialogResult = DialogResult.None;
            btnHide.Image = AmiggasRenting.Properties.Resources.eye_password;
            btnHide.ImageMargin = new Padding(0);
            btnHide.Location = new Point(684, 260);
            btnHide.Name = "btnHide";
            btnHide.RoundBorders = true;
            btnHide.ShowBorders = true;
            btnHide.Size = new Size(48, 48);
            btnHide.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            btnHide.TabIndex = 10;
            btnHide.Click += btnHide_Click;
            // 
            // LoginPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(btnShow);
            Controls.Add(btnHide);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            FormClosing += LoginPageForm_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuTextBox txtEmail;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnLogin;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnShow;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnHide;
    }
}
