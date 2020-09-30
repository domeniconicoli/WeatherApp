namespace WeatherApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties29 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties30 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties31 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties32 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.mainContaiener = new System.Windows.Forms.SplitContainer();
            this.filtersPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.locationTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.commandsContainer = new System.Windows.Forms.SplitContainer();
            this.graphButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.forecastButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.mainPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.currentWeatherLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.currentTemp = new Bunifu.UI.WinForms.BunifuLabel();
            this.humidityLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.pressureLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.currentWindLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.day5TempLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.day4TempLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.day3TempLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.day2TempLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.day1TempLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.day5Label = new Bunifu.UI.WinForms.BunifuLabel();
            this.day4Label = new Bunifu.UI.WinForms.BunifuLabel();
            this.day3Label = new Bunifu.UI.WinForms.BunifuLabel();
            this.day2Label = new Bunifu.UI.WinForms.BunifuLabel();
            this.day1Label = new Bunifu.UI.WinForms.BunifuLabel();
            this.day5WeatherImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.day4WeatherImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.day3WeatherImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.day2WeatherImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.day1WeatherImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.currentWeatherImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.locationLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.graphPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.datavizForecastGraph = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced();
            ((System.ComponentModel.ISupportInitialize)(this.mainContaiener)).BeginInit();
            this.mainContaiener.Panel1.SuspendLayout();
            this.mainContaiener.Panel2.SuspendLayout();
            this.mainContaiener.SuspendLayout();
            this.filtersPanel.SuspendLayout();
            this.controlsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandsContainer)).BeginInit();
            this.commandsContainer.Panel1.SuspendLayout();
            this.commandsContainer.Panel2.SuspendLayout();
            this.commandsContainer.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day5WeatherImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day4WeatherImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day3WeatherImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day2WeatherImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day1WeatherImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentWeatherImage)).BeginInit();
            this.graphPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContaiener
            // 
            this.mainContaiener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContaiener.Location = new System.Drawing.Point(0, 0);
            this.mainContaiener.Name = "mainContaiener";
            this.mainContaiener.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainContaiener.Panel1
            // 
            this.mainContaiener.Panel1.Controls.Add(this.filtersPanel);
            // 
            // mainContaiener.Panel2
            // 
            this.mainContaiener.Panel2.Controls.Add(this.commandsContainer);
            this.mainContaiener.Size = new System.Drawing.Size(584, 350);
            this.mainContaiener.SplitterDistance = 69;
            this.mainContaiener.TabIndex = 1;
            // 
            // filtersPanel
            // 
            this.filtersPanel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.filtersPanel.BorderRadius = 1;
            this.filtersPanel.BorderThickness = 1;
            this.filtersPanel.Controls.Add(this.controlsGroupBox);
            this.filtersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtersPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.filtersPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.filtersPanel.Location = new System.Drawing.Point(0, 0);
            this.filtersPanel.Name = "filtersPanel";
            this.filtersPanel.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.filtersPanel.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.filtersPanel.ShadowColor = System.Drawing.Color.DarkGray;
            this.filtersPanel.ShadowDept = 2;
            this.filtersPanel.ShadowDepth = 5;
            this.filtersPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.filtersPanel.ShadowTopLeftVisible = false;
            this.filtersPanel.Size = new System.Drawing.Size(584, 69);
            this.filtersPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.filtersPanel.TabIndex = 0;
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.searchButton);
            this.controlsGroupBox.Controls.Add(this.locationTextBox);
            this.controlsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(584, 69);
            this.controlsGroupBox.TabIndex = 1;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Filters";
            // 
            // searchButton
            // 
            this.searchButton.AllowToggling = false;
            this.searchButton.AnimationSpeed = 200;
            this.searchButton.AutoGenerateColors = false;
            this.searchButton.AutoSizeLeftIcon = true;
            this.searchButton.AutoSizeRightIcon = true;
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchButton.ButtonText = "Find";
            this.searchButton.ButtonTextMarginLeft = 0;
            this.searchButton.ColorContrastOnClick = 45;
            this.searchButton.ColorContrastOnHover = 45;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.searchButton.CustomizableEdges = borderEdges8;
            this.searchButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.searchButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.searchButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.searchButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.searchButton.IconMarginLeft = 11;
            this.searchButton.IconPadding = 10;
            this.searchButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.searchButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.searchButton.IconSize = 25;
            this.searchButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.IdleBorderRadius = 25;
            this.searchButton.IdleBorderThickness = 1;
            this.searchButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.IdleIconLeftImage = null;
            this.searchButton.IdleIconRightImage = null;
            this.searchButton.IndicateFocus = false;
            this.searchButton.Location = new System.Drawing.Point(343, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.searchButton.OnDisabledState.BorderRadius = 25;
            this.searchButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchButton.OnDisabledState.BorderThickness = 1;
            this.searchButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.searchButton.OnDisabledState.IconLeftImage = null;
            this.searchButton.OnDisabledState.IconRightImage = null;
            this.searchButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchButton.onHoverState.BorderRadius = 25;
            this.searchButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchButton.onHoverState.BorderThickness = 1;
            this.searchButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.searchButton.onHoverState.IconLeftImage = null;
            this.searchButton.onHoverState.IconRightImage = null;
            this.searchButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.OnIdleState.BorderRadius = 25;
            this.searchButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchButton.OnIdleState.BorderThickness = 1;
            this.searchButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.searchButton.OnIdleState.IconLeftImage = null;
            this.searchButton.OnIdleState.IconRightImage = null;
            this.searchButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.searchButton.OnPressedState.BorderRadius = 25;
            this.searchButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchButton.OnPressedState.BorderThickness = 1;
            this.searchButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.searchButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.searchButton.OnPressedState.IconLeftImage = null;
            this.searchButton.OnPressedState.IconRightImage = null;
            this.searchButton.Size = new System.Drawing.Size(229, 37);
            this.searchButton.TabIndex = 2;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchButton.TextMarginLeft = 0;
            this.searchButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.searchButton.UseDefaultRadiusAndThickness = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.AcceptsReturn = false;
            this.locationTextBox.AcceptsTab = false;
            this.locationTextBox.AnimationSpeed = 200;
            this.locationTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.locationTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.locationTextBox.BackColor = System.Drawing.Color.Transparent;
            this.locationTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("locationTextBox.BackgroundImage")));
            this.locationTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.locationTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.locationTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.locationTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.locationTextBox.BorderRadius = 1;
            this.locationTextBox.BorderThickness = 1;
            this.locationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.locationTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.locationTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.locationTextBox.DefaultText = "";
            this.locationTextBox.FillColor = System.Drawing.Color.White;
            this.locationTextBox.HideSelection = true;
            this.locationTextBox.IconLeft = null;
            this.locationTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.locationTextBox.IconPadding = 10;
            this.locationTextBox.IconRight = null;
            this.locationTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.locationTextBox.Lines = new string[0];
            this.locationTextBox.Location = new System.Drawing.Point(6, 14);
            this.locationTextBox.MaxLength = 32767;
            this.locationTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.locationTextBox.Modified = false;
            this.locationTextBox.Multiline = false;
            this.locationTextBox.Name = "locationTextBox";
            stateProperties29.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties29.FillColor = System.Drawing.Color.Empty;
            stateProperties29.ForeColor = System.Drawing.Color.Empty;
            stateProperties29.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.locationTextBox.OnActiveState = stateProperties29;
            stateProperties30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties30.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.locationTextBox.OnDisabledState = stateProperties30;
            stateProperties31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties31.FillColor = System.Drawing.Color.Empty;
            stateProperties31.ForeColor = System.Drawing.Color.Empty;
            stateProperties31.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.locationTextBox.OnHoverState = stateProperties31;
            stateProperties32.BorderColor = System.Drawing.Color.Silver;
            stateProperties32.FillColor = System.Drawing.Color.White;
            stateProperties32.ForeColor = System.Drawing.Color.Empty;
            stateProperties32.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.locationTextBox.OnIdleState = stateProperties32;
            this.locationTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.locationTextBox.PasswordChar = '\0';
            this.locationTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.locationTextBox.PlaceholderText = "Enter location..";
            this.locationTextBox.ReadOnly = false;
            this.locationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.locationTextBox.SelectedText = "";
            this.locationTextBox.SelectionLength = 0;
            this.locationTextBox.SelectionStart = 0;
            this.locationTextBox.ShortcutsEnabled = true;
            this.locationTextBox.Size = new System.Drawing.Size(331, 37);
            this.locationTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.locationTextBox.TabIndex = 0;
            this.locationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.locationTextBox.TextMarginBottom = 0;
            this.locationTextBox.TextMarginLeft = 3;
            this.locationTextBox.TextMarginTop = 0;
            this.locationTextBox.TextPlaceholder = "Enter location..";
            this.locationTextBox.UseSystemPasswordChar = false;
            this.locationTextBox.WordWrap = true;
            // 
            // commandsContainer
            // 
            this.commandsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandsContainer.IsSplitterFixed = true;
            this.commandsContainer.Location = new System.Drawing.Point(0, 0);
            this.commandsContainer.Name = "commandsContainer";
            // 
            // commandsContainer.Panel1
            // 
            this.commandsContainer.Panel1.Controls.Add(this.graphButton);
            this.commandsContainer.Panel1.Controls.Add(this.forecastButton);
            // 
            // commandsContainer.Panel2
            // 
            this.commandsContainer.Panel2.Controls.Add(this.mainPanel);
            this.commandsContainer.Panel2.Controls.Add(this.graphPanel);
            this.commandsContainer.Size = new System.Drawing.Size(584, 277);
            this.commandsContainer.SplitterDistance = 94;
            this.commandsContainer.TabIndex = 0;
            // 
            // graphButton
            // 
            this.graphButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.graphButton.color = System.Drawing.Color.RoyalBlue;
            this.graphButton.colorActive = System.Drawing.Color.SteelBlue;
            this.graphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphButton.ForeColor = System.Drawing.Color.White;
            this.graphButton.Image = ((System.Drawing.Image)(resources.GetObject("graphButton.Image")));
            this.graphButton.ImagePosition = 18;
            this.graphButton.ImageZoom = 50;
            this.graphButton.LabelPosition = 36;
            this.graphButton.LabelText = "Graph";
            this.graphButton.Location = new System.Drawing.Point(6, 61);
            this.graphButton.Margin = new System.Windows.Forms.Padding(6);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(82, 43);
            this.graphButton.TabIndex = 1;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // forecastButton
            // 
            this.forecastButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.forecastButton.color = System.Drawing.Color.RoyalBlue;
            this.forecastButton.colorActive = System.Drawing.Color.SteelBlue;
            this.forecastButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forecastButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastButton.ForeColor = System.Drawing.Color.White;
            this.forecastButton.Image = ((System.Drawing.Image)(resources.GetObject("forecastButton.Image")));
            this.forecastButton.ImagePosition = 18;
            this.forecastButton.ImageZoom = 50;
            this.forecastButton.LabelPosition = 36;
            this.forecastButton.LabelText = "Forecast";
            this.forecastButton.Location = new System.Drawing.Point(6, 6);
            this.forecastButton.Margin = new System.Windows.Forms.Padding(6);
            this.forecastButton.Name = "forecastButton";
            this.forecastButton.Size = new System.Drawing.Size(82, 43);
            this.forecastButton.TabIndex = 0;
            this.forecastButton.Click += new System.EventHandler(this.forecastButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.BorderRadius = 1;
            this.mainPanel.BorderThickness = 1;
            this.mainPanel.Controls.Add(this.currentWeatherLabel);
            this.mainPanel.Controls.Add(this.currentTemp);
            this.mainPanel.Controls.Add(this.humidityLabel);
            this.mainPanel.Controls.Add(this.pressureLabel);
            this.mainPanel.Controls.Add(this.currentWindLabel);
            this.mainPanel.Controls.Add(this.day5TempLabel);
            this.mainPanel.Controls.Add(this.day4TempLabel);
            this.mainPanel.Controls.Add(this.day3TempLabel);
            this.mainPanel.Controls.Add(this.day2TempLabel);
            this.mainPanel.Controls.Add(this.day1TempLabel);
            this.mainPanel.Controls.Add(this.day5Label);
            this.mainPanel.Controls.Add(this.day4Label);
            this.mainPanel.Controls.Add(this.day3Label);
            this.mainPanel.Controls.Add(this.day2Label);
            this.mainPanel.Controls.Add(this.day1Label);
            this.mainPanel.Controls.Add(this.day5WeatherImage);
            this.mainPanel.Controls.Add(this.day4WeatherImage);
            this.mainPanel.Controls.Add(this.day3WeatherImage);
            this.mainPanel.Controls.Add(this.day2WeatherImage);
            this.mainPanel.Controls.Add(this.day1WeatherImage);
            this.mainPanel.Controls.Add(this.currentWeatherImage);
            this.mainPanel.Controls.Add(this.locationLabel);
            this.mainPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.mainPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.ShadowColor = System.Drawing.Color.DarkGray;
            this.mainPanel.ShadowDept = 2;
            this.mainPanel.ShadowDepth = 5;
            this.mainPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Dropped;
            this.mainPanel.ShadowTopLeftVisible = false;
            this.mainPanel.Size = new System.Drawing.Size(486, 277);
            this.mainPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.mainPanel.TabIndex = 0;
            // 
            // currentWeatherLabel
            // 
            this.currentWeatherLabel.AllowParentOverrides = false;
            this.currentWeatherLabel.AutoEllipsis = false;
            this.currentWeatherLabel.CursorType = null;
            this.currentWeatherLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWeatherLabel.Location = new System.Drawing.Point(118, 137);
            this.currentWeatherLabel.Name = "currentWeatherLabel";
            this.currentWeatherLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentWeatherLabel.Size = new System.Drawing.Size(65, 21);
            this.currentWeatherLabel.TabIndex = 70;
            this.currentWeatherLabel.Text = "Weather";
            this.currentWeatherLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.currentWeatherLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // currentTemp
            // 
            this.currentTemp.AllowParentOverrides = false;
            this.currentTemp.AutoEllipsis = false;
            this.currentTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.currentTemp.CursorType = System.Windows.Forms.Cursors.Default;
            this.currentTemp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTemp.Location = new System.Drawing.Point(339, 126);
            this.currentTemp.Name = "currentTemp";
            this.currentTemp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentTemp.Size = new System.Drawing.Size(49, 30);
            this.currentTemp.TabIndex = 69;
            this.currentTemp.Text = "{0}°C";
            this.currentTemp.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.currentTemp.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // humidityLabel
            // 
            this.humidityLabel.AllowParentOverrides = false;
            this.humidityLabel.AutoEllipsis = false;
            this.humidityLabel.CursorType = null;
            this.humidityLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.Location = new System.Drawing.Point(339, 74);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.humidityLabel.Size = new System.Drawing.Size(102, 20);
            this.humidityLabel.TabIndex = 68;
            this.humidityLabel.Text = "Humidity: {0} %";
            this.humidityLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.humidityLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pressureLabel
            // 
            this.pressureLabel.AllowParentOverrides = false;
            this.pressureLabel.AutoEllipsis = false;
            this.pressureLabel.CursorType = null;
            this.pressureLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureLabel.Location = new System.Drawing.Point(339, 100);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pressureLabel.Size = new System.Drawing.Size(105, 20);
            this.pressureLabel.TabIndex = 67;
            this.pressureLabel.Text = "Pressure: {0} bar";
            this.pressureLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pressureLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // currentWindLabel
            // 
            this.currentWindLabel.AllowParentOverrides = false;
            this.currentWindLabel.AutoEllipsis = false;
            this.currentWindLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.currentWindLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.currentWindLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWindLabel.Location = new System.Drawing.Point(339, 48);
            this.currentWindLabel.Name = "currentWindLabel";
            this.currentWindLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentWindLabel.Size = new System.Drawing.Size(94, 20);
            this.currentWindLabel.TabIndex = 66;
            this.currentWindLabel.Text = "Wind: {0} mph";
            this.currentWindLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.currentWindLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // day5TempLabel
            // 
            this.day5TempLabel.AllowParentOverrides = false;
            this.day5TempLabel.AutoEllipsis = false;
            this.day5TempLabel.CursorType = null;
            this.day5TempLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.day5TempLabel.Location = new System.Drawing.Point(429, 245);
            this.day5TempLabel.Name = "day5TempLabel";
            this.day5TempLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.day5TempLabel.Size = new System.Drawing.Size(6, 15);
            this.day5TempLabel.TabIndex = 65;
            this.day5TempLabel.Text = "0";
            this.day5TempLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.day5TempLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // day4TempLabel
            // 
            this.day4TempLabel.AllowParentOverrides = false;
            this.day4TempLabel.AutoEllipsis = false;
            this.day4TempLabel.CursorType = null;
            this.day4TempLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.day4TempLabel.Location = new System.Drawing.Point(332, 245);
            this.day4TempLabel.Name = "day4TempLabel";
            this.day4TempLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.day4TempLabel.Size = new System.Drawing.Size(6, 15);
            this.day4TempLabel.TabIndex = 64;
            this.day4TempLabel.Text = "0";
            this.day4TempLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.day4TempLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // day3TempLabel
            // 
            this.day3TempLabel.AllowParentOverrides = false;
            this.day3TempLabel.AutoEllipsis = false;
            this.day3TempLabel.CursorType = null;
            this.day3TempLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.day3TempLabel.Location = new System.Drawing.Point(236, 245);
            this.day3TempLabel.Name = "day3TempLabel";
            this.day3TempLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.day3TempLabel.Size = new System.Drawing.Size(6, 15);
            this.day3TempLabel.TabIndex = 63;
            this.day3TempLabel.Text = "0";
            this.day3TempLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.day3TempLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // day2TempLabel
            // 
            this.day2TempLabel.AllowParentOverrides = false;
            this.day2TempLabel.AutoEllipsis = false;
            this.day2TempLabel.CursorType = null;
            this.day2TempLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.day2TempLabel.Location = new System.Drawing.Point(145, 245);
            this.day2TempLabel.Name = "day2TempLabel";
            this.day2TempLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.day2TempLabel.Size = new System.Drawing.Size(6, 15);
            this.day2TempLabel.TabIndex = 62;
            this.day2TempLabel.Text = "0";
            this.day2TempLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.day2TempLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // day1TempLabel
            // 
            this.day1TempLabel.AllowParentOverrides = false;
            this.day1TempLabel.AutoEllipsis = false;
            this.day1TempLabel.CursorType = null;
            this.day1TempLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.day1TempLabel.Location = new System.Drawing.Point(51, 245);
            this.day1TempLabel.Name = "day1TempLabel";
            this.day1TempLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.day1TempLabel.Size = new System.Drawing.Size(6, 15);
            this.day1TempLabel.TabIndex = 61;
            this.day1TempLabel.Text = "0";
            this.day1TempLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.day1TempLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // day5Label
            // 
            this.day5Label.AllowParentOverrides = false;
            this.day5Label.AutoEllipsis = false;
            this.day5Label.CursorType = null;
            this.day5Label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.day5Label.Location = new System.Drawing.Point(399, 179);
            this.day5Label.Name = "day5Label";
            this.day5Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.day5Label.Size = new System.Drawing.Size(29, 15);
            this.day5Label.TabIndex = 60;
            this.day5Label.Text = "Day 5";
            this.day5Label.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.day5Label.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // day4Label
            // 
            this.day4Label.AllowParentOverrides = false;
            this.day4Label.AutoEllipsis = false;
            this.day4Label.CursorType = null;
            this.day4Label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.day4Label.Location = new System.Drawing.Point(303, 179);
            this.day4Label.Name = "day4Label";
            this.day4Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.day4Label.Size = new System.Drawing.Size(29, 15);
            this.day4Label.TabIndex = 59;
            this.day4Label.Text = "Day 4";
            this.day4Label.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.day4Label.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // day3Label
            // 
            this.day3Label.AllowParentOverrides = false;
            this.day3Label.AutoEllipsis = false;
            this.day3Label.CursorType = null;
            this.day3Label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.day3Label.Location = new System.Drawing.Point(210, 180);
            this.day3Label.Name = "day3Label";
            this.day3Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.day3Label.Size = new System.Drawing.Size(29, 15);
            this.day3Label.TabIndex = 58;
            this.day3Label.Text = "Day 3";
            this.day3Label.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.day3Label.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // day2Label
            // 
            this.day2Label.AllowParentOverrides = false;
            this.day2Label.AutoEllipsis = false;
            this.day2Label.CursorType = null;
            this.day2Label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.day2Label.Location = new System.Drawing.Point(119, 179);
            this.day2Label.Name = "day2Label";
            this.day2Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.day2Label.Size = new System.Drawing.Size(29, 15);
            this.day2Label.TabIndex = 57;
            this.day2Label.Text = "Day 2";
            this.day2Label.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.day2Label.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // day1Label
            // 
            this.day1Label.AllowParentOverrides = false;
            this.day1Label.AutoEllipsis = false;
            this.day1Label.CursorType = null;
            this.day1Label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.day1Label.Location = new System.Drawing.Point(33, 179);
            this.day1Label.Name = "day1Label";
            this.day1Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.day1Label.Size = new System.Drawing.Size(29, 15);
            this.day1Label.TabIndex = 56;
            this.day1Label.Text = "Day 1";
            this.day1Label.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.day1Label.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // day5WeatherImage
            // 
            this.day5WeatherImage.AllowFocused = false;
            this.day5WeatherImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day5WeatherImage.AutoSizeHeight = true;
            this.day5WeatherImage.BorderRadius = 19;
            this.day5WeatherImage.Image = ((System.Drawing.Image)(resources.GetObject("day5WeatherImage.Image")));
            this.day5WeatherImage.IsCircle = true;
            this.day5WeatherImage.Location = new System.Drawing.Point(412, 201);
            this.day5WeatherImage.Name = "day5WeatherImage";
            this.day5WeatherImage.Size = new System.Drawing.Size(38, 38);
            this.day5WeatherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.day5WeatherImage.TabIndex = 55;
            this.day5WeatherImage.TabStop = false;
            this.day5WeatherImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // day4WeatherImage
            // 
            this.day4WeatherImage.AllowFocused = false;
            this.day4WeatherImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day4WeatherImage.AutoSizeHeight = true;
            this.day4WeatherImage.BorderRadius = 19;
            this.day4WeatherImage.Image = ((System.Drawing.Image)(resources.GetObject("day4WeatherImage.Image")));
            this.day4WeatherImage.IsCircle = true;
            this.day4WeatherImage.Location = new System.Drawing.Point(316, 201);
            this.day4WeatherImage.Name = "day4WeatherImage";
            this.day4WeatherImage.Size = new System.Drawing.Size(38, 38);
            this.day4WeatherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.day4WeatherImage.TabIndex = 54;
            this.day4WeatherImage.TabStop = false;
            this.day4WeatherImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // day3WeatherImage
            // 
            this.day3WeatherImage.AllowFocused = false;
            this.day3WeatherImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day3WeatherImage.AutoSizeHeight = true;
            this.day3WeatherImage.BorderRadius = 19;
            this.day3WeatherImage.Image = ((System.Drawing.Image)(resources.GetObject("day3WeatherImage.Image")));
            this.day3WeatherImage.IsCircle = true;
            this.day3WeatherImage.Location = new System.Drawing.Point(222, 201);
            this.day3WeatherImage.Name = "day3WeatherImage";
            this.day3WeatherImage.Size = new System.Drawing.Size(38, 38);
            this.day3WeatherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.day3WeatherImage.TabIndex = 53;
            this.day3WeatherImage.TabStop = false;
            this.day3WeatherImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // day2WeatherImage
            // 
            this.day2WeatherImage.AllowFocused = false;
            this.day2WeatherImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day2WeatherImage.AutoSizeHeight = true;
            this.day2WeatherImage.BorderRadius = 19;
            this.day2WeatherImage.Image = ((System.Drawing.Image)(resources.GetObject("day2WeatherImage.Image")));
            this.day2WeatherImage.IsCircle = true;
            this.day2WeatherImage.Location = new System.Drawing.Point(127, 201);
            this.day2WeatherImage.Name = "day2WeatherImage";
            this.day2WeatherImage.Size = new System.Drawing.Size(38, 38);
            this.day2WeatherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.day2WeatherImage.TabIndex = 52;
            this.day2WeatherImage.TabStop = false;
            this.day2WeatherImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // day1WeatherImage
            // 
            this.day1WeatherImage.AllowFocused = false;
            this.day1WeatherImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day1WeatherImage.AutoSizeHeight = true;
            this.day1WeatherImage.BorderRadius = 19;
            this.day1WeatherImage.Image = ((System.Drawing.Image)(resources.GetObject("day1WeatherImage.Image")));
            this.day1WeatherImage.IsCircle = true;
            this.day1WeatherImage.Location = new System.Drawing.Point(37, 201);
            this.day1WeatherImage.Name = "day1WeatherImage";
            this.day1WeatherImage.Size = new System.Drawing.Size(38, 38);
            this.day1WeatherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.day1WeatherImage.TabIndex = 51;
            this.day1WeatherImage.TabStop = false;
            this.day1WeatherImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // currentWeatherImage
            // 
            this.currentWeatherImage.AllowFocused = false;
            this.currentWeatherImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentWeatherImage.AutoSizeHeight = true;
            this.currentWeatherImage.BorderRadius = 44;
            this.currentWeatherImage.Image = ((System.Drawing.Image)(resources.GetObject("currentWeatherImage.Image")));
            this.currentWeatherImage.IsCircle = true;
            this.currentWeatherImage.Location = new System.Drawing.Point(106, 43);
            this.currentWeatherImage.Name = "currentWeatherImage";
            this.currentWeatherImage.Size = new System.Drawing.Size(88, 88);
            this.currentWeatherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.currentWeatherImage.TabIndex = 50;
            this.currentWeatherImage.TabStop = false;
            this.currentWeatherImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // locationLabel
            // 
            this.locationLabel.AllowParentOverrides = false;
            this.locationLabel.AutoEllipsis = false;
            this.locationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.locationLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.locationLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.locationLabel.Location = new System.Drawing.Point(16, 7);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.locationLabel.Size = new System.Drawing.Size(77, 25);
            this.locationLabel.TabIndex = 49;
            this.locationLabel.Text = "Location";
            this.locationLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.locationLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // graphPanel
            // 
            this.graphPanel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.graphPanel.BorderRadius = 1;
            this.graphPanel.BorderThickness = 1;
            this.graphPanel.Controls.Add(this.datavizForecastGraph);
            this.graphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.graphPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.graphPanel.Location = new System.Drawing.Point(0, 0);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.graphPanel.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.graphPanel.ShadowColor = System.Drawing.Color.DarkGray;
            this.graphPanel.ShadowDept = 2;
            this.graphPanel.ShadowDepth = 5;
            this.graphPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Dropped;
            this.graphPanel.ShadowTopLeftVisible = false;
            this.graphPanel.Size = new System.Drawing.Size(486, 277);
            this.graphPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.graphPanel.TabIndex = 71;
            // 
            // datavizForecastGraph
            // 
            this.datavizForecastGraph.animationEnabled = false;
            this.datavizForecastGraph.AxisLineColor = System.Drawing.Color.LightGray;
            this.datavizForecastGraph.AxisXFontColor = System.Drawing.Color.Gray;
            this.datavizForecastGraph.AxisXGridColor = System.Drawing.Color.Gray;
            this.datavizForecastGraph.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.datavizForecastGraph.AxisYFontColor = System.Drawing.Color.Gray;
            this.datavizForecastGraph.AxisYGridColor = System.Drawing.Color.Gray;
            this.datavizForecastGraph.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.datavizForecastGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.datavizForecastGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datavizForecastGraph.Location = new System.Drawing.Point(0, 0);
            this.datavizForecastGraph.Name = "datavizForecastGraph";
            this.datavizForecastGraph.Size = new System.Drawing.Size(486, 277);
            this.datavizForecastGraph.TabIndex = 0;
            this.datavizForecastGraph.Theme = Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced._theme.theme1;
            this.datavizForecastGraph.Title = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 350);
            this.Controls.Add(this.mainContaiener);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 389);
            this.MinimumSize = new System.Drawing.Size(600, 389);
            this.Name = "MainForm";
            this.Text = "Weather App";
            this.mainContaiener.Panel1.ResumeLayout(false);
            this.mainContaiener.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContaiener)).EndInit();
            this.mainContaiener.ResumeLayout(false);
            this.filtersPanel.ResumeLayout(false);
            this.controlsGroupBox.ResumeLayout(false);
            this.commandsContainer.Panel1.ResumeLayout(false);
            this.commandsContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commandsContainer)).EndInit();
            this.commandsContainer.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day5WeatherImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day4WeatherImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day3WeatherImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day2WeatherImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day1WeatherImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentWeatherImage)).EndInit();
            this.graphPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContaiener;
        private Bunifu.UI.WinForms.BunifuShadowPanel filtersPanel;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton searchButton;
        private Bunifu.UI.WinForms.BunifuTextBox locationTextBox;
        private Bunifu.UI.WinForms.BunifuShadowPanel mainPanel;
        private System.Windows.Forms.SplitContainer commandsContainer;
        private Bunifu.Framework.UI.BunifuTileButton graphButton;
        private Bunifu.Framework.UI.BunifuTileButton forecastButton;
        private Bunifu.UI.WinForms.BunifuLabel currentWeatherLabel;
        private Bunifu.UI.WinForms.BunifuLabel currentTemp;
        private Bunifu.UI.WinForms.BunifuLabel humidityLabel;
        private Bunifu.UI.WinForms.BunifuLabel pressureLabel;
        private Bunifu.UI.WinForms.BunifuLabel currentWindLabel;
        private Bunifu.UI.WinForms.BunifuLabel day5TempLabel;
        private Bunifu.UI.WinForms.BunifuLabel day4TempLabel;
        private Bunifu.UI.WinForms.BunifuLabel day3TempLabel;
        private Bunifu.UI.WinForms.BunifuLabel day2TempLabel;
        private Bunifu.UI.WinForms.BunifuLabel day1TempLabel;
        private Bunifu.UI.WinForms.BunifuLabel day5Label;
        private Bunifu.UI.WinForms.BunifuLabel day4Label;
        private Bunifu.UI.WinForms.BunifuLabel day3Label;
        private Bunifu.UI.WinForms.BunifuLabel day2Label;
        private Bunifu.UI.WinForms.BunifuLabel day1Label;
        private Bunifu.UI.WinForms.BunifuPictureBox day5WeatherImage;
        private Bunifu.UI.WinForms.BunifuPictureBox day4WeatherImage;
        private Bunifu.UI.WinForms.BunifuPictureBox day3WeatherImage;
        private Bunifu.UI.WinForms.BunifuPictureBox day2WeatherImage;
        private Bunifu.UI.WinForms.BunifuPictureBox day1WeatherImage;
        private Bunifu.UI.WinForms.BunifuPictureBox currentWeatherImage;
        private Bunifu.UI.WinForms.BunifuLabel locationLabel;
        private Bunifu.UI.WinForms.BunifuShadowPanel graphPanel;
        private Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced datavizForecastGraph;
    }
}

