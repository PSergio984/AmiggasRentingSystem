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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTenants));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            TenantsSidePanel = new NavigationControl();
            dataGridTenants = new Bunifu.UI.WinForms.BunifuDataGridView();
            txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            ((System.ComponentModel.ISupportInitialize)dataGridTenants).BeginInit();
            SuspendLayout();
            // 
            // TenantsSidePanel
            // 
            TenantsSidePanel.BackColor = Color.Transparent;
            TenantsSidePanel.Location = new Point(-6, -4);
            TenantsSidePanel.Margin = new Padding(3, 2, 3, 2);
            TenantsSidePanel.Name = "TenantsSidePanel";
            TenantsSidePanel.Size = new Size(169, 512);
            TenantsSidePanel.TabIndex = 10;
            TenantsSidePanel.Load += navigationControl1_Load;
            // 
            // dataGridTenants
            // 
            dataGridTenants.AllowCustomTheming = false;
            dataGridTenants.AllowUserToAddRows = false;
            dataGridTenants.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridTenants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridTenants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTenants.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridTenants.BackgroundColor = Color.Khaki;
            dataGridTenants.BorderStyle = BorderStyle.None;
            dataGridTenants.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridTenants.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridTenants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridTenants.ColumnHeadersHeight = 40;
            dataGridTenants.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            dataGridTenants.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridTenants.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dataGridTenants.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridTenants.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dataGridTenants.CurrentTheme.BackColor = Color.White;
            dataGridTenants.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            dataGridTenants.CurrentTheme.HeaderStyle.BackColor = Color.Gold;
            dataGridTenants.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridTenants.CurrentTheme.HeaderStyle.ForeColor = Color.Black;
            dataGridTenants.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridTenants.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            dataGridTenants.CurrentTheme.Name = null;
            dataGridTenants.CurrentTheme.RowsStyle.BackColor = Color.White;
            dataGridTenants.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridTenants.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dataGridTenants.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridTenants.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridTenants.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridTenants.EnableHeadersVisualStyles = false;
            dataGridTenants.GridColor = Color.Yellow;
            dataGridTenants.HeaderBackColor = Color.Gold;
            dataGridTenants.HeaderBgColor = Color.Empty;
            dataGridTenants.HeaderForeColor = Color.Black;
            dataGridTenants.Location = new Point(183, 35);
            dataGridTenants.Margin = new Padding(3, 2, 3, 2);
            dataGridTenants.Name = "dataGridTenants";
            dataGridTenants.ReadOnly = true;
            dataGridTenants.RowHeadersVisible = false;
            dataGridTenants.RowHeadersWidth = 51;
            dataGridTenants.RowTemplate.Height = 40;
            dataGridTenants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTenants.Size = new Size(736, 416);
            dataGridTenants.TabIndex = 12;
            dataGridTenants.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            dataGridTenants.CellContentClick += dataGridTenants_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.AcceptsReturn = false;
            txtSearch.AcceptsTab = false;
            txtSearch.AnimationSpeed = 200;
            txtSearch.AutoCompleteMode = AutoCompleteMode.None;
            txtSearch.AutoCompleteSource = AutoCompleteSource.None;
            txtSearch.AutoSizeHeight = true;
            txtSearch.BackColor = Color.White;
            txtSearch.BackgroundImage = (Image)resources.GetObject("txtSearch.BackgroundImage");
            txtSearch.BorderColorActive = Color.Gold;
            txtSearch.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtSearch.BorderColorHover = Color.Black;
            txtSearch.BorderColorIdle = Color.Gold;
            txtSearch.BorderRadius = 1;
            txtSearch.BorderThickness = 1;
            txtSearch.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtSearch.CharacterCasing = CharacterCasing.Normal;
            txtSearch.DefaultFont = new Font("Segoe UI", 9.25F);
            txtSearch.DefaultText = "";
            txtSearch.FillColor = Color.White;
            txtSearch.HideSelection = true;
            txtSearch.IconLeft = null;
            txtSearch.IconLeftCursor = Cursors.IBeam;
            txtSearch.IconPadding = 10;
            txtSearch.IconRight = null;
            txtSearch.IconRightCursor = Cursors.IBeam;
            txtSearch.Location = new Point(183, 6);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.MaxLength = 32767;
            txtSearch.MinimumSize = new Size(1, 1);
            txtSearch.Modified = false;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = Color.Gold;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.Black;
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Gold;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            txtSearch.OnIdleState = stateProperties4;
            txtSearch.Padding = new Padding(3, 2, 3, 2);
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderForeColor = Color.Silver;
            txtSearch.PlaceholderText = "Search Here";
            txtSearch.ReadOnly = false;
            txtSearch.ScrollBars = ScrollBars.None;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.ShortcutsEnabled = true;
            txtSearch.Size = new Size(287, 25);
            txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtSearch.TabIndex = 13;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.TextMarginBottom = 0;
            txtSearch.TextMarginLeft = 3;
            txtSearch.TextMarginTop = 1;
            txtSearch.TextPlaceholder = "Search Here";
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.WordWrap = true;
            txtSearch.TextChange += txtSearch_TextChanged;
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
            btnAdd.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnAdd.IdleBorderColor = Color.Yellow;
            btnAdd.IdleBorderRadius = 19;
            btnAdd.IdleBorderThickness = 1;
            btnAdd.IdleFillColor = Color.Gold;
            btnAdd.IdleIconLeftImage = null;
            btnAdd.IdleIconRightImage = null;
            btnAdd.IndicateFocus = false;
            btnAdd.Location = new Point(662, 6);
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
            btnAdd.onHoverState.BorderColor = Color.Black;
            btnAdd.onHoverState.BorderRadius = 1;
            btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnAdd.onHoverState.BorderThickness = 1;
            btnAdd.onHoverState.FillColor = Color.FromArgb(255, 233, 114);
            btnAdd.onHoverState.ForeColor = Color.White;
            btnAdd.onHoverState.IconLeftImage = null;
            btnAdd.onHoverState.IconRightImage = null;
            btnAdd.OnIdleState.BorderColor = Color.Yellow;
            btnAdd.OnIdleState.BorderRadius = 1;
            btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnAdd.OnIdleState.BorderThickness = 1;
            btnAdd.OnIdleState.FillColor = Color.Gold;
            btnAdd.OnIdleState.ForeColor = Color.Black;
            btnAdd.OnIdleState.IconLeftImage = null;
            btnAdd.OnIdleState.IconRightImage = null;
            btnAdd.OnPressedState.BorderColor = Color.Yellow;
            btnAdd.OnPressedState.BorderRadius = 1;
            btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnAdd.OnPressedState.BorderThickness = 1;
            btnAdd.OnPressedState.FillColor = Color.Gold;
            btnAdd.OnPressedState.ForeColor = Color.White;
            btnAdd.OnPressedState.IconLeftImage = null;
            btnAdd.OnPressedState.IconRightImage = null;
            btnAdd.Size = new Size(151, 21);
            btnAdd.TabIndex = 14;
            btnAdd.TextAlign = ContentAlignment.MiddleCenter;
            btnAdd.TextAlignment = HorizontalAlignment.Center;
            btnAdd.TextMarginLeft = 0;
            btnAdd.TextPadding = new Padding(0);
            btnAdd.UseDefaultRadiusAndThickness = true;
            btnAdd.Click += btnAddTenants_Click_1;
            // 
            // AddTenants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(929, 505);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(dataGridTenants);
            Controls.Add(TenantsSidePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AddTenants";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tenants";
            FormClosing += AddTenants_FormClosing;
            FormClosed += AddTenants_FormClosed;
            Load += AddTenants_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTenants).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private NavigationControl TenantsSidePanel;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridTenants;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAdd;
    }
}