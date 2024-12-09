namespace AmiggasRenting
{
    partial class NavigationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationControl));
            toolStrip1 = new ToolStrip();
            panel1 = new Panel();
            btnPayments = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            btnApartments = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            btnTenants = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            btnDashboard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(178, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(bunifuLabel2);
            panel1.Controls.Add(bunifuLabel1);
            panel1.Controls.Add(btnPayments);
            panel1.Controls.Add(btnApartments);
            panel1.Controls.Add(btnTenants);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(bunifuPictureBox1);
            panel1.Location = new Point(7, 5);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 544);
            panel1.TabIndex = 6;
            // 
            // btnPayments
            // 
            btnPayments.AllowAnimations = true;
            btnPayments.AllowMouseEffects = true;
            btnPayments.AllowToggling = false;
            btnPayments.AnimationSpeed = 200;
            btnPayments.AutoGenerateColors = true;
            btnPayments.AutoRoundBorders = true;
            btnPayments.AutoSizeLeftIcon = true;
            btnPayments.AutoSizeRightIcon = true;
            btnPayments.BackColor = Color.Transparent;
            btnPayments.BackColor1 = Color.FromArgb(255, 255, 192);
            btnPayments.BackgroundImage = (Image)resources.GetObject("btnPayments.BackgroundImage");
            btnPayments.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnPayments.ButtonText = "Payment";
            btnPayments.ButtonTextMarginLeft = 0;
            btnPayments.ColorContrastOnClick = 45;
            btnPayments.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnPayments.CustomizableEdges = borderEdges1;
            btnPayments.DialogResult = DialogResult.None;
            btnPayments.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnPayments.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnPayments.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnPayments.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnPayments.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayments.ForeColor = Color.Black;
            btnPayments.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnPayments.IconLeftCursor = Cursors.Default;
            btnPayments.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnPayments.IconMarginLeft = 11;
            btnPayments.IconPadding = 10;
            btnPayments.IconRightAlign = ContentAlignment.BottomCenter;
            btnPayments.IconRightCursor = Cursors.Default;
            btnPayments.IconRightPadding = new Padding(3, 3, 7, 3);
            btnPayments.IconSize = 25;
            btnPayments.IdleBorderColor = Color.FromArgb(192, 192, 0);
            btnPayments.IdleBorderRadius = 78;
            btnPayments.IdleBorderThickness = 1;
            btnPayments.IdleFillColor = Color.FromArgb(255, 255, 192);
            btnPayments.IdleIconLeftImage = null;
            btnPayments.IdleIconRightImage = null;
            btnPayments.IndicateFocus = false;
            btnPayments.Location = new Point(18, 402);
            btnPayments.Margin = new Padding(3, 2, 3, 2);
            btnPayments.Name = "btnPayments";
            btnPayments.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnPayments.OnDisabledState.BorderRadius = 1;
            btnPayments.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnPayments.OnDisabledState.BorderThickness = 1;
            btnPayments.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnPayments.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnPayments.OnDisabledState.IconLeftImage = null;
            btnPayments.OnDisabledState.IconRightImage = null;
            btnPayments.onHoverState.BorderColor = Color.FromArgb(220, 220, 114);
            btnPayments.onHoverState.BorderRadius = 1;
            btnPayments.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnPayments.onHoverState.BorderThickness = 1;
            btnPayments.onHoverState.FillColor = Color.FromArgb(255, 255, 220);
            btnPayments.onHoverState.ForeColor = Color.White;
            btnPayments.onHoverState.IconLeftImage = null;
            btnPayments.onHoverState.IconRightImage = null;
            btnPayments.OnIdleState.BorderColor = Color.FromArgb(192, 192, 0);
            btnPayments.OnIdleState.BorderRadius = 1;
            btnPayments.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnPayments.OnIdleState.BorderThickness = 1;
            btnPayments.OnIdleState.FillColor = Color.FromArgb(255, 255, 192);
            btnPayments.OnIdleState.ForeColor = Color.Black;
            btnPayments.OnIdleState.IconLeftImage = null;
            btnPayments.OnIdleState.IconRightImage = null;
            btnPayments.OnPressedState.BorderColor = Color.FromArgb(105, 105, 0);
            btnPayments.OnPressedState.BorderRadius = 1;
            btnPayments.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnPayments.OnPressedState.BorderThickness = 1;
            btnPayments.OnPressedState.FillColor = Color.FromArgb(140, 140, 105);
            btnPayments.OnPressedState.ForeColor = Color.White;
            btnPayments.OnPressedState.IconLeftImage = null;
            btnPayments.OnPressedState.IconRightImage = null;
            btnPayments.Size = new Size(128, 80);
            btnPayments.TabIndex = 11;
            btnPayments.TextAlign = ContentAlignment.MiddleCenter;
            btnPayments.TextAlignment = HorizontalAlignment.Center;
            btnPayments.TextMarginLeft = 0;
            btnPayments.TextPadding = new Padding(0);
            btnPayments.UseDefaultRadiusAndThickness = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnApartments
            // 
            btnApartments.AllowAnimations = true;
            btnApartments.AllowMouseEffects = true;
            btnApartments.AllowToggling = false;
            btnApartments.AnimationSpeed = 200;
            btnApartments.AutoGenerateColors = true;
            btnApartments.AutoRoundBorders = true;
            btnApartments.AutoSizeLeftIcon = true;
            btnApartments.AutoSizeRightIcon = true;
            btnApartments.BackColor = Color.Transparent;
            btnApartments.BackColor1 = Color.FromArgb(255, 255, 192);
            btnApartments.BackgroundImage = (Image)resources.GetObject("btnApartments.BackgroundImage");
            btnApartments.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnApartments.ButtonText = "View Apartments";
            btnApartments.ButtonTextMarginLeft = 0;
            btnApartments.ColorContrastOnClick = 45;
            btnApartments.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnApartments.CustomizableEdges = borderEdges2;
            btnApartments.DialogResult = DialogResult.None;
            btnApartments.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnApartments.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnApartments.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnApartments.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnApartments.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApartments.ForeColor = Color.Black;
            btnApartments.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnApartments.IconLeftCursor = Cursors.Default;
            btnApartments.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnApartments.IconMarginLeft = 11;
            btnApartments.IconPadding = 10;
            btnApartments.IconRightAlign = ContentAlignment.MiddleRight;
            btnApartments.IconRightCursor = Cursors.Default;
            btnApartments.IconRightPadding = new Padding(3, 3, 7, 3);
            btnApartments.IconSize = 25;
            btnApartments.IdleBorderColor = Color.FromArgb(192, 192, 0);
            btnApartments.IdleBorderRadius = 78;
            btnApartments.IdleBorderThickness = 1;
            btnApartments.IdleFillColor = Color.FromArgb(255, 255, 192);
            btnApartments.IdleIconLeftImage = null;
            btnApartments.IdleIconRightImage = null;
            btnApartments.IndicateFocus = false;
            btnApartments.Location = new Point(18, 318);
            btnApartments.Margin = new Padding(3, 2, 3, 2);
            btnApartments.Name = "btnApartments";
            btnApartments.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnApartments.OnDisabledState.BorderRadius = 1;
            btnApartments.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnApartments.OnDisabledState.BorderThickness = 1;
            btnApartments.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnApartments.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnApartments.OnDisabledState.IconLeftImage = null;
            btnApartments.OnDisabledState.IconRightImage = null;
            btnApartments.onHoverState.BorderColor = Color.FromArgb(220, 220, 114);
            btnApartments.onHoverState.BorderRadius = 1;
            btnApartments.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnApartments.onHoverState.BorderThickness = 1;
            btnApartments.onHoverState.FillColor = Color.FromArgb(255, 255, 220);
            btnApartments.onHoverState.ForeColor = Color.White;
            btnApartments.onHoverState.IconLeftImage = null;
            btnApartments.onHoverState.IconRightImage = null;
            btnApartments.OnIdleState.BorderColor = Color.FromArgb(192, 192, 0);
            btnApartments.OnIdleState.BorderRadius = 1;
            btnApartments.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnApartments.OnIdleState.BorderThickness = 1;
            btnApartments.OnIdleState.FillColor = Color.FromArgb(255, 255, 192);
            btnApartments.OnIdleState.ForeColor = Color.Black;
            btnApartments.OnIdleState.IconLeftImage = null;
            btnApartments.OnIdleState.IconRightImage = null;
            btnApartments.OnPressedState.BorderColor = Color.FromArgb(105, 105, 0);
            btnApartments.OnPressedState.BorderRadius = 1;
            btnApartments.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnApartments.OnPressedState.BorderThickness = 1;
            btnApartments.OnPressedState.FillColor = Color.FromArgb(140, 140, 105);
            btnApartments.OnPressedState.ForeColor = Color.White;
            btnApartments.OnPressedState.IconLeftImage = null;
            btnApartments.OnPressedState.IconRightImage = null;
            btnApartments.Size = new Size(128, 80);
            btnApartments.TabIndex = 10;
            btnApartments.TextAlign = ContentAlignment.MiddleCenter;
            btnApartments.TextAlignment = HorizontalAlignment.Center;
            btnApartments.TextMarginLeft = 0;
            btnApartments.TextPadding = new Padding(0);
            btnApartments.UseDefaultRadiusAndThickness = true;
            btnApartments.Click += btnViewApartments_Click;
            // 
            // btnTenants
            // 
            btnTenants.AllowAnimations = true;
            btnTenants.AllowMouseEffects = true;
            btnTenants.AllowToggling = false;
            btnTenants.AnimationSpeed = 200;
            btnTenants.AutoGenerateColors = true;
            btnTenants.AutoRoundBorders = true;
            btnTenants.AutoSizeLeftIcon = true;
            btnTenants.AutoSizeRightIcon = true;
            btnTenants.BackColor = Color.Transparent;
            btnTenants.BackColor1 = Color.FromArgb(255, 255, 192);
            btnTenants.BackgroundImage = (Image)resources.GetObject("btnTenants.BackgroundImage");
            btnTenants.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnTenants.ButtonText = "Tenants";
            btnTenants.ButtonTextMarginLeft = 0;
            btnTenants.ColorContrastOnClick = 45;
            btnTenants.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnTenants.CustomizableEdges = borderEdges3;
            btnTenants.DialogResult = DialogResult.None;
            btnTenants.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnTenants.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnTenants.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnTenants.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnTenants.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTenants.ForeColor = Color.Black;
            btnTenants.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnTenants.IconLeftCursor = Cursors.Default;
            btnTenants.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnTenants.IconMarginLeft = 11;
            btnTenants.IconPadding = 10;
            btnTenants.IconRightAlign = ContentAlignment.MiddleRight;
            btnTenants.IconRightCursor = Cursors.Default;
            btnTenants.IconRightPadding = new Padding(3, 3, 7, 3);
            btnTenants.IconSize = 25;
            btnTenants.IdleBorderColor = Color.FromArgb(192, 192, 0);
            btnTenants.IdleBorderRadius = 78;
            btnTenants.IdleBorderThickness = 1;
            btnTenants.IdleFillColor = Color.FromArgb(255, 255, 192);
            btnTenants.IdleIconLeftImage = null;
            btnTenants.IdleIconRightImage = null;
            btnTenants.IndicateFocus = false;
            btnTenants.Location = new Point(18, 234);
            btnTenants.Margin = new Padding(3, 2, 3, 2);
            btnTenants.Name = "btnTenants";
            btnTenants.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnTenants.OnDisabledState.BorderRadius = 1;
            btnTenants.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnTenants.OnDisabledState.BorderThickness = 1;
            btnTenants.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnTenants.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnTenants.OnDisabledState.IconLeftImage = null;
            btnTenants.OnDisabledState.IconRightImage = null;
            btnTenants.onHoverState.BorderColor = Color.FromArgb(220, 220, 114);
            btnTenants.onHoverState.BorderRadius = 1;
            btnTenants.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnTenants.onHoverState.BorderThickness = 1;
            btnTenants.onHoverState.FillColor = Color.FromArgb(255, 255, 220);
            btnTenants.onHoverState.ForeColor = Color.White;
            btnTenants.onHoverState.IconLeftImage = null;
            btnTenants.onHoverState.IconRightImage = null;
            btnTenants.OnIdleState.BorderColor = Color.FromArgb(192, 192, 0);
            btnTenants.OnIdleState.BorderRadius = 1;
            btnTenants.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnTenants.OnIdleState.BorderThickness = 1;
            btnTenants.OnIdleState.FillColor = Color.FromArgb(255, 255, 192);
            btnTenants.OnIdleState.ForeColor = Color.Black;
            btnTenants.OnIdleState.IconLeftImage = null;
            btnTenants.OnIdleState.IconRightImage = null;
            btnTenants.OnPressedState.BorderColor = Color.FromArgb(105, 105, 0);
            btnTenants.OnPressedState.BorderRadius = 1;
            btnTenants.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnTenants.OnPressedState.BorderThickness = 1;
            btnTenants.OnPressedState.FillColor = Color.FromArgb(140, 140, 105);
            btnTenants.OnPressedState.ForeColor = Color.White;
            btnTenants.OnPressedState.IconLeftImage = null;
            btnTenants.OnPressedState.IconRightImage = null;
            btnTenants.Size = new Size(128, 80);
            btnTenants.TabIndex = 9;
            btnTenants.TextAlign = ContentAlignment.MiddleCenter;
            btnTenants.TextAlignment = HorizontalAlignment.Center;
            btnTenants.TextMarginLeft = 0;
            btnTenants.TextPadding = new Padding(0);
            btnTenants.UseDefaultRadiusAndThickness = true;
            btnTenants.Click += btnAddTenants_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.AllowAnimations = true;
            btnDashboard.AllowMouseEffects = true;
            btnDashboard.AllowToggling = false;
            btnDashboard.AnimationSpeed = 200;
            btnDashboard.AutoGenerateColors = true;
            btnDashboard.AutoRoundBorders = true;
            btnDashboard.AutoSizeLeftIcon = true;
            btnDashboard.AutoSizeRightIcon = true;
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BackColor1 = Color.FromArgb(255, 255, 192);
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnDashboard.ButtonText = "Dashboard";
            btnDashboard.ButtonTextMarginLeft = 0;
            btnDashboard.ColorContrastOnClick = 45;
            btnDashboard.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            btnDashboard.CustomizableEdges = borderEdges4;
            btnDashboard.DialogResult = DialogResult.None;
            btnDashboard.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnDashboard.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnDashboard.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnDashboard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnDashboard.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnDashboard.IconLeftCursor = Cursors.Default;
            btnDashboard.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnDashboard.IconMarginLeft = 11;
            btnDashboard.IconPadding = 10;
            btnDashboard.IconRightAlign = ContentAlignment.BottomCenter;
            btnDashboard.IconRightCursor = Cursors.Default;
            btnDashboard.IconRightPadding = new Padding(3, 3, 7, 3);
            btnDashboard.IconSize = 25;
            btnDashboard.IdleBorderColor = Color.FromArgb(192, 192, 0);
            btnDashboard.IdleBorderRadius = 78;
            btnDashboard.IdleBorderThickness = 1;
            btnDashboard.IdleFillColor = Color.FromArgb(255, 255, 192);
            btnDashboard.IdleIconLeftImage = null;
            btnDashboard.IdleIconRightImage = null;
            btnDashboard.IndicateFocus = false;
            btnDashboard.Location = new Point(18, 150);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnDashboard.OnDisabledState.BorderRadius = 1;
            btnDashboard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnDashboard.OnDisabledState.BorderThickness = 1;
            btnDashboard.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnDashboard.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnDashboard.OnDisabledState.IconLeftImage = null;
            btnDashboard.OnDisabledState.IconRightImage = null;
            btnDashboard.onHoverState.BorderColor = Color.FromArgb(220, 220, 114);
            btnDashboard.onHoverState.BorderRadius = 1;
            btnDashboard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnDashboard.onHoverState.BorderThickness = 1;
            btnDashboard.onHoverState.FillColor = Color.FromArgb(255, 255, 220);
            btnDashboard.onHoverState.ForeColor = Color.White;
            btnDashboard.onHoverState.IconLeftImage = null;
            btnDashboard.onHoverState.IconRightImage = null;
            btnDashboard.OnIdleState.BorderColor = Color.FromArgb(192, 192, 0);
            btnDashboard.OnIdleState.BorderRadius = 1;
            btnDashboard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnDashboard.OnIdleState.BorderThickness = 1;
            btnDashboard.OnIdleState.FillColor = Color.FromArgb(255, 255, 192);
            btnDashboard.OnIdleState.ForeColor = Color.Black;
            btnDashboard.OnIdleState.IconLeftImage = null;
            btnDashboard.OnIdleState.IconRightImage = null;
            btnDashboard.OnPressedState.BorderColor = Color.FromArgb(105, 105, 0);
            btnDashboard.OnPressedState.BorderRadius = 1;
            btnDashboard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnDashboard.OnPressedState.BorderThickness = 1;
            btnDashboard.OnPressedState.FillColor = Color.FromArgb(140, 140, 105);
            btnDashboard.OnPressedState.ForeColor = Color.White;
            btnDashboard.OnPressedState.IconLeftImage = null;
            btnDashboard.OnPressedState.IconRightImage = null;
            btnDashboard.Size = new Size(128, 80);
            btnDashboard.TabIndex = 8;
            btnDashboard.TextAlign = ContentAlignment.MiddleCenter;
            btnDashboard.TextAlignment = HorizontalAlignment.Center;
            btnDashboard.TextMarginLeft = 0;
            btnDashboard.TextPadding = new Padding(0);
            btnDashboard.UseDefaultRadiusAndThickness = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // bunifuPictureBox1
            // 
            bunifuPictureBox1.AllowFocused = false;
            bunifuPictureBox1.Anchor = AnchorStyles.None;
            bunifuPictureBox1.AutoSizeHeight = true;
            bunifuPictureBox1.BackColor = Color.FromArgb(192, 192, 0);
            bunifuPictureBox1.BorderRadius = 38;
            bunifuPictureBox1.Image = (Image)resources.GetObject("bunifuPictureBox1.Image");
            bunifuPictureBox1.IsCircle = true;
            bunifuPictureBox1.Location = new Point(43, 6);
            bunifuPictureBox1.Margin = new Padding(3, 2, 3, 2);
            bunifuPictureBox1.Name = "bunifuPictureBox1";
            bunifuPictureBox1.Size = new Size(77, 77);
            bunifuPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            bunifuPictureBox1.TabIndex = 7;
            bunifuPictureBox1.TabStop = false;
            bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            bunifuPictureBox1.Click += bunifuPictureBox1_Click;
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuLabel1.Location = new Point(10, 90);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(91, 25);
            bunifuLabel1.TabIndex = 12;
            bunifuLabel1.Text = "AMIGGAS";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            bunifuLabel1.Click += bunifuLabel1_Click;
            // 
            // bunifuLabel2
            // 
            bunifuLabel2.AllowParentOverrides = false;
            bunifuLabel2.AutoEllipsis = false;
            bunifuLabel2.CursorType = Cursors.Default;
            bunifuLabel2.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuLabel2.Location = new Point(74, 119);
            bunifuLabel2.Name = "bunifuLabel2";
            bunifuLabel2.RightToLeft = RightToLeft.No;
            bunifuLabel2.Size = new Size(78, 25);
            bunifuLabel2.TabIndex = 13;
            bunifuLabel2.Text = " RENTAL";
            bunifuLabel2.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NavigationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NavigationControl";
            Size = new Size(178, 544);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private Panel panel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnDashboard;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnTenants;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnApartments;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnPayments;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}
