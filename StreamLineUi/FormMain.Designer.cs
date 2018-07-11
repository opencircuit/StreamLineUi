namespace StreamLineUi
{
    partial class FormMain
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelControlBackground = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panelNavigationBackground = new System.Windows.Forms.Panel();
            this.labelNavigationToggleDescription = new System.Windows.Forms.Label();
            this.panelButtonDatabaseEditor = new System.Windows.Forms.Panel();
            this.panelAccentDatabaseEditor = new System.Windows.Forms.Panel();
            this.buttonDatabaseEditor = new System.Windows.Forms.Button();
            this.panelButtonDataGenerator = new System.Windows.Forms.Panel();
            this.panelAccentDataGenerator = new System.Windows.Forms.Panel();
            this.buttonDataGenerator = new System.Windows.Forms.Button();
            this.panelButtonScriptEditor = new System.Windows.Forms.Panel();
            this.panelAccentScriptEditor = new System.Windows.Forms.Panel();
            this.buttonScriptEditor = new System.Windows.Forms.Button();
            this.toggle = new MetroFramework.Controls.MetroToggle();
            this.labelComputerName = new System.Windows.Forms.Label();
            this.pictureboxPenguin = new System.Windows.Forms.PictureBox();
            this.panelButtonSettings = new System.Windows.Forms.Panel();
            this.panelAccentSettings = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelButtonConfiguration = new System.Windows.Forms.Panel();
            this.panelAccentConfiguration = new System.Windows.Forms.Panel();
            this.buttonConfiguration = new System.Windows.Forms.Button();
            this.panelButtonComponentEditor = new System.Windows.Forms.Panel();
            this.panelAccentComponentEditor = new System.Windows.Forms.Panel();
            this.buttonComponentBuilder = new System.Windows.Forms.Button();
            this.panelButtonDataEditor = new System.Windows.Forms.Panel();
            this.panelAccentDataEditor = new System.Windows.Forms.Panel();
            this.buttonDataEditor = new System.Windows.Forms.Button();
            this.panelButtonDashboard = new System.Windows.Forms.Panel();
            this.panelAccentDashboard = new System.Windows.Forms.Panel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panelBackground.SuspendLayout();
            this.panelControlBackground.SuspendLayout();
            this.panelNavigationBackground.SuspendLayout();
            this.panelButtonDatabaseEditor.SuspendLayout();
            this.panelButtonDataGenerator.SuspendLayout();
            this.panelButtonScriptEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPenguin)).BeginInit();
            this.panelButtonSettings.SuspendLayout();
            this.panelButtonConfiguration.SuspendLayout();
            this.panelButtonComponentEditor.SuspendLayout();
            this.panelButtonDataEditor.SuspendLayout();
            this.panelButtonDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackground.Controls.Add(this.panelControlBackground);
            this.panelBackground.Controls.Add(this.panelNavigationBackground);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 60);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1590, 790);
            this.panelBackground.TabIndex = 0;
            // 
            // panelControlBackground
            // 
            this.panelControlBackground.BackgroundImage = global::StreamLineUi.Properties.Resources.backsplash;
            this.panelControlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControlBackground.Controls.Add(this.labelName);
            this.panelControlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlBackground.Location = new System.Drawing.Point(150, 0);
            this.panelControlBackground.Name = "panelControlBackground";
            this.panelControlBackground.Size = new System.Drawing.Size(1438, 788);
            this.panelControlBackground.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.DarkGray;
            this.labelName.Location = new System.Drawing.Point(0, 751);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(5);
            this.labelName.Size = new System.Drawing.Size(1436, 35);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "By: Prince Choudhury";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelNavigationBackground
            // 
            this.panelNavigationBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelNavigationBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigationBackground.Controls.Add(this.labelNavigationToggleDescription);
            this.panelNavigationBackground.Controls.Add(this.panelButtonDatabaseEditor);
            this.panelNavigationBackground.Controls.Add(this.panelButtonDataGenerator);
            this.panelNavigationBackground.Controls.Add(this.panelButtonScriptEditor);
            this.panelNavigationBackground.Controls.Add(this.toggle);
            this.panelNavigationBackground.Controls.Add(this.labelComputerName);
            this.panelNavigationBackground.Controls.Add(this.pictureboxPenguin);
            this.panelNavigationBackground.Controls.Add(this.panelButtonSettings);
            this.panelNavigationBackground.Controls.Add(this.panelButtonConfiguration);
            this.panelNavigationBackground.Controls.Add(this.panelButtonComponentEditor);
            this.panelNavigationBackground.Controls.Add(this.panelButtonDataEditor);
            this.panelNavigationBackground.Controls.Add(this.panelButtonDashboard);
            this.panelNavigationBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigationBackground.Location = new System.Drawing.Point(0, 0);
            this.panelNavigationBackground.Name = "panelNavigationBackground";
            this.panelNavigationBackground.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panelNavigationBackground.Size = new System.Drawing.Size(150, 788);
            this.panelNavigationBackground.TabIndex = 0;
            // 
            // labelNavigationToggleDescription
            // 
            this.labelNavigationToggleDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.labelNavigationToggleDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelNavigationToggleDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNavigationToggleDescription.ForeColor = System.Drawing.Color.DarkGray;
            this.labelNavigationToggleDescription.Location = new System.Drawing.Point(0, 743);
            this.labelNavigationToggleDescription.Name = "labelNavigationToggleDescription";
            this.labelNavigationToggleDescription.Padding = new System.Windows.Forms.Padding(5);
            this.labelNavigationToggleDescription.Size = new System.Drawing.Size(148, 26);
            this.labelNavigationToggleDescription.TabIndex = 1;
            this.labelNavigationToggleDescription.Text = "Clean Navigation";
            this.labelNavigationToggleDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtonDatabaseEditor
            // 
            this.panelButtonDatabaseEditor.Controls.Add(this.panelAccentDatabaseEditor);
            this.panelButtonDatabaseEditor.Controls.Add(this.buttonDatabaseEditor);
            this.panelButtonDatabaseEditor.Location = new System.Drawing.Point(0, 482);
            this.panelButtonDatabaseEditor.Name = "panelButtonDatabaseEditor";
            this.panelButtonDatabaseEditor.Size = new System.Drawing.Size(148, 70);
            this.panelButtonDatabaseEditor.TabIndex = 0;
            // 
            // panelAccentDatabaseEditor
            // 
            this.panelAccentDatabaseEditor.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAccentDatabaseEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccentDatabaseEditor.Location = new System.Drawing.Point(0, 0);
            this.panelAccentDatabaseEditor.Name = "panelAccentDatabaseEditor";
            this.panelAccentDatabaseEditor.Size = new System.Drawing.Size(5, 70);
            this.panelAccentDatabaseEditor.TabIndex = 0;
            // 
            // buttonDatabaseEditor
            // 
            this.buttonDatabaseEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDatabaseEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDatabaseEditor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDatabaseEditor.FlatAppearance.BorderSize = 0;
            this.buttonDatabaseEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDatabaseEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDatabaseEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDatabaseEditor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDatabaseEditor.ForeColor = System.Drawing.Color.White;
            this.buttonDatabaseEditor.Image = global::StreamLineUi.Properties.Resources.database;
            this.buttonDatabaseEditor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDatabaseEditor.Location = new System.Drawing.Point(0, 0);
            this.buttonDatabaseEditor.Name = "buttonDatabaseEditor";
            this.buttonDatabaseEditor.Size = new System.Drawing.Size(148, 70);
            this.buttonDatabaseEditor.TabIndex = 0;
            this.buttonDatabaseEditor.Text = "Edit Database";
            this.buttonDatabaseEditor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDatabaseEditor.UseVisualStyleBackColor = false;
            this.buttonDatabaseEditor.Click += new System.EventHandler(this.action_ViewDatabaseEditor);
            // 
            // panelButtonDataGenerator
            // 
            this.panelButtonDataGenerator.Controls.Add(this.panelAccentDataGenerator);
            this.panelButtonDataGenerator.Controls.Add(this.buttonDataGenerator);
            this.panelButtonDataGenerator.Location = new System.Drawing.Point(0, 340);
            this.panelButtonDataGenerator.Name = "panelButtonDataGenerator";
            this.panelButtonDataGenerator.Size = new System.Drawing.Size(148, 70);
            this.panelButtonDataGenerator.TabIndex = 0;
            // 
            // panelAccentDataGenerator
            // 
            this.panelAccentDataGenerator.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAccentDataGenerator.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccentDataGenerator.Location = new System.Drawing.Point(0, 0);
            this.panelAccentDataGenerator.Name = "panelAccentDataGenerator";
            this.panelAccentDataGenerator.Size = new System.Drawing.Size(5, 70);
            this.panelAccentDataGenerator.TabIndex = 0;
            // 
            // buttonDataGenerator
            // 
            this.buttonDataGenerator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDataGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDataGenerator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDataGenerator.FlatAppearance.BorderSize = 0;
            this.buttonDataGenerator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDataGenerator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDataGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDataGenerator.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataGenerator.ForeColor = System.Drawing.Color.White;
            this.buttonDataGenerator.Image = global::StreamLineUi.Properties.Resources.random_data;
            this.buttonDataGenerator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDataGenerator.Location = new System.Drawing.Point(0, 0);
            this.buttonDataGenerator.Name = "buttonDataGenerator";
            this.buttonDataGenerator.Size = new System.Drawing.Size(148, 70);
            this.buttonDataGenerator.TabIndex = 0;
            this.buttonDataGenerator.Text = "Generate Data";
            this.buttonDataGenerator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDataGenerator.UseVisualStyleBackColor = false;
            this.buttonDataGenerator.Click += new System.EventHandler(this.action_ViewDataGenerator);
            // 
            // panelButtonScriptEditor
            // 
            this.panelButtonScriptEditor.Controls.Add(this.panelAccentScriptEditor);
            this.panelButtonScriptEditor.Controls.Add(this.buttonScriptEditor);
            this.panelButtonScriptEditor.Location = new System.Drawing.Point(0, 198);
            this.panelButtonScriptEditor.Name = "panelButtonScriptEditor";
            this.panelButtonScriptEditor.Size = new System.Drawing.Size(148, 70);
            this.panelButtonScriptEditor.TabIndex = 0;
            // 
            // panelAccentScriptEditor
            // 
            this.panelAccentScriptEditor.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAccentScriptEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccentScriptEditor.Location = new System.Drawing.Point(0, 0);
            this.panelAccentScriptEditor.Name = "panelAccentScriptEditor";
            this.panelAccentScriptEditor.Size = new System.Drawing.Size(5, 70);
            this.panelAccentScriptEditor.TabIndex = 0;
            // 
            // buttonScriptEditor
            // 
            this.buttonScriptEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonScriptEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonScriptEditor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonScriptEditor.FlatAppearance.BorderSize = 0;
            this.buttonScriptEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonScriptEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonScriptEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScriptEditor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScriptEditor.ForeColor = System.Drawing.Color.White;
            this.buttonScriptEditor.Image = global::StreamLineUi.Properties.Resources.script_builder;
            this.buttonScriptEditor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonScriptEditor.Location = new System.Drawing.Point(0, 0);
            this.buttonScriptEditor.Name = "buttonScriptEditor";
            this.buttonScriptEditor.Size = new System.Drawing.Size(148, 70);
            this.buttonScriptEditor.TabIndex = 0;
            this.buttonScriptEditor.Text = "Script Flow";
            this.buttonScriptEditor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonScriptEditor.UseVisualStyleBackColor = false;
            this.buttonScriptEditor.Click += new System.EventHandler(this.action_ViewScriptEditor);
            // 
            // toggle
            // 
            this.toggle.AutoSize = true;
            this.toggle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toggle.Location = new System.Drawing.Point(0, 769);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(148, 17);
            this.toggle.TabIndex = 0;
            this.toggle.Text = "Off";
            this.toggle.UseSelectable = true;
            this.toggle.CheckedChanged += new System.EventHandler(this.action_SlimNavigation);
            // 
            // labelComputerName
            // 
            this.labelComputerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelComputerName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerName.ForeColor = System.Drawing.Color.White;
            this.labelComputerName.Location = new System.Drawing.Point(0, 51);
            this.labelComputerName.Name = "labelComputerName";
            this.labelComputerName.Size = new System.Drawing.Size(148, 53);
            this.labelComputerName.TabIndex = 0;
            this.labelComputerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureboxPenguin
            // 
            this.pictureboxPenguin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureboxPenguin.Image = global::StreamLineUi.Properties.Resources.logo;
            this.pictureboxPenguin.Location = new System.Drawing.Point(0, 20);
            this.pictureboxPenguin.Name = "pictureboxPenguin";
            this.pictureboxPenguin.Size = new System.Drawing.Size(148, 31);
            this.pictureboxPenguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureboxPenguin.TabIndex = 9;
            this.pictureboxPenguin.TabStop = false;
            // 
            // panelButtonSettings
            // 
            this.panelButtonSettings.Controls.Add(this.panelAccentSettings);
            this.panelButtonSettings.Controls.Add(this.buttonSettings);
            this.panelButtonSettings.Location = new System.Drawing.Point(0, 624);
            this.panelButtonSettings.Name = "panelButtonSettings";
            this.panelButtonSettings.Size = new System.Drawing.Size(148, 70);
            this.panelButtonSettings.TabIndex = 0;
            // 
            // panelAccentSettings
            // 
            this.panelAccentSettings.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAccentSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccentSettings.Location = new System.Drawing.Point(0, 0);
            this.panelAccentSettings.Name = "panelAccentSettings";
            this.panelAccentSettings.Size = new System.Drawing.Size(5, 70);
            this.panelAccentSettings.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = global::StreamLineUi.Properties.Resources.settings;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(148, 70);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.action_ViewSettings);
            // 
            // panelButtonConfiguration
            // 
            this.panelButtonConfiguration.Controls.Add(this.panelAccentConfiguration);
            this.panelButtonConfiguration.Controls.Add(this.buttonConfiguration);
            this.panelButtonConfiguration.Location = new System.Drawing.Point(0, 553);
            this.panelButtonConfiguration.Name = "panelButtonConfiguration";
            this.panelButtonConfiguration.Size = new System.Drawing.Size(148, 70);
            this.panelButtonConfiguration.TabIndex = 0;
            // 
            // panelAccentConfiguration
            // 
            this.panelAccentConfiguration.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAccentConfiguration.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccentConfiguration.Location = new System.Drawing.Point(0, 0);
            this.panelAccentConfiguration.Name = "panelAccentConfiguration";
            this.panelAccentConfiguration.Size = new System.Drawing.Size(5, 70);
            this.panelAccentConfiguration.TabIndex = 0;
            // 
            // buttonConfiguration
            // 
            this.buttonConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConfiguration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonConfiguration.FlatAppearance.BorderSize = 0;
            this.buttonConfiguration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonConfiguration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfiguration.ForeColor = System.Drawing.Color.White;
            this.buttonConfiguration.Image = global::StreamLineUi.Properties.Resources.configuration;
            this.buttonConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfiguration.Location = new System.Drawing.Point(0, 0);
            this.buttonConfiguration.Name = "buttonConfiguration";
            this.buttonConfiguration.Size = new System.Drawing.Size(148, 70);
            this.buttonConfiguration.TabIndex = 0;
            this.buttonConfiguration.Text = "Configuration";
            this.buttonConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfiguration.UseVisualStyleBackColor = false;
            this.buttonConfiguration.Click += new System.EventHandler(this.action_ViewConfiguration);
            // 
            // panelButtonComponentEditor
            // 
            this.panelButtonComponentEditor.Controls.Add(this.panelAccentComponentEditor);
            this.panelButtonComponentEditor.Controls.Add(this.buttonComponentBuilder);
            this.panelButtonComponentEditor.Location = new System.Drawing.Point(0, 269);
            this.panelButtonComponentEditor.Name = "panelButtonComponentEditor";
            this.panelButtonComponentEditor.Size = new System.Drawing.Size(148, 70);
            this.panelButtonComponentEditor.TabIndex = 0;
            // 
            // panelAccentComponentEditor
            // 
            this.panelAccentComponentEditor.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAccentComponentEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccentComponentEditor.Location = new System.Drawing.Point(0, 0);
            this.panelAccentComponentEditor.Name = "panelAccentComponentEditor";
            this.panelAccentComponentEditor.Size = new System.Drawing.Size(5, 70);
            this.panelAccentComponentEditor.TabIndex = 0;
            // 
            // buttonComponentBuilder
            // 
            this.buttonComponentBuilder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonComponentBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonComponentBuilder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonComponentBuilder.FlatAppearance.BorderSize = 0;
            this.buttonComponentBuilder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonComponentBuilder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonComponentBuilder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComponentBuilder.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComponentBuilder.ForeColor = System.Drawing.Color.White;
            this.buttonComponentBuilder.Image = global::StreamLineUi.Properties.Resources.component_builder;
            this.buttonComponentBuilder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComponentBuilder.Location = new System.Drawing.Point(0, 0);
            this.buttonComponentBuilder.Name = "buttonComponentBuilder";
            this.buttonComponentBuilder.Size = new System.Drawing.Size(148, 70);
            this.buttonComponentBuilder.TabIndex = 0;
            this.buttonComponentBuilder.Text = "Components";
            this.buttonComponentBuilder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonComponentBuilder.UseVisualStyleBackColor = false;
            this.buttonComponentBuilder.Click += new System.EventHandler(this.action_ViewComponentEditor);
            // 
            // panelButtonDataEditor
            // 
            this.panelButtonDataEditor.Controls.Add(this.panelAccentDataEditor);
            this.panelButtonDataEditor.Controls.Add(this.buttonDataEditor);
            this.panelButtonDataEditor.Location = new System.Drawing.Point(0, 411);
            this.panelButtonDataEditor.Name = "panelButtonDataEditor";
            this.panelButtonDataEditor.Size = new System.Drawing.Size(148, 70);
            this.panelButtonDataEditor.TabIndex = 0;
            // 
            // panelAccentDataEditor
            // 
            this.panelAccentDataEditor.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAccentDataEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccentDataEditor.Location = new System.Drawing.Point(0, 0);
            this.panelAccentDataEditor.Name = "panelAccentDataEditor";
            this.panelAccentDataEditor.Size = new System.Drawing.Size(5, 70);
            this.panelAccentDataEditor.TabIndex = 0;
            // 
            // buttonDataEditor
            // 
            this.buttonDataEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDataEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDataEditor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDataEditor.FlatAppearance.BorderSize = 0;
            this.buttonDataEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDataEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDataEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDataEditor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataEditor.ForeColor = System.Drawing.Color.White;
            this.buttonDataEditor.Image = global::StreamLineUi.Properties.Resources.test_data;
            this.buttonDataEditor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDataEditor.Location = new System.Drawing.Point(0, 0);
            this.buttonDataEditor.Name = "buttonDataEditor";
            this.buttonDataEditor.Size = new System.Drawing.Size(148, 70);
            this.buttonDataEditor.TabIndex = 0;
            this.buttonDataEditor.Text = "Edit Test Data";
            this.buttonDataEditor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDataEditor.UseVisualStyleBackColor = false;
            this.buttonDataEditor.Click += new System.EventHandler(this.action_ViewDataEditor);
            // 
            // panelButtonDashboard
            // 
            this.panelButtonDashboard.Controls.Add(this.panelAccentDashboard);
            this.panelButtonDashboard.Controls.Add(this.buttonDashboard);
            this.panelButtonDashboard.Location = new System.Drawing.Point(0, 127);
            this.panelButtonDashboard.Name = "panelButtonDashboard";
            this.panelButtonDashboard.Size = new System.Drawing.Size(148, 70);
            this.panelButtonDashboard.TabIndex = 0;
            // 
            // panelAccentDashboard
            // 
            this.panelAccentDashboard.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAccentDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccentDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelAccentDashboard.Name = "panelAccentDashboard";
            this.panelAccentDashboard.Size = new System.Drawing.Size(5, 70);
            this.panelAccentDashboard.TabIndex = 0;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = global::StreamLineUi.Properties.Resources.dashboard;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 0);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(148, 70);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.action_ViewDashboard);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 850);
            this.Controls.Add(this.panelBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StreamLine";
            this.Load += new System.EventHandler(this.action_FormLoad);
            this.panelBackground.ResumeLayout(false);
            this.panelControlBackground.ResumeLayout(false);
            this.panelNavigationBackground.ResumeLayout(false);
            this.panelNavigationBackground.PerformLayout();
            this.panelButtonDatabaseEditor.ResumeLayout(false);
            this.panelButtonDataGenerator.ResumeLayout(false);
            this.panelButtonScriptEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPenguin)).EndInit();
            this.panelButtonSettings.ResumeLayout(false);
            this.panelButtonConfiguration.ResumeLayout(false);
            this.panelButtonComponentEditor.ResumeLayout(false);
            this.panelButtonDataEditor.ResumeLayout(false);
            this.panelButtonDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelControlBackground;
        private System.Windows.Forms.Panel panelNavigationBackground;
        private System.Windows.Forms.Label labelComputerName;
        private System.Windows.Forms.PictureBox pictureboxPenguin;
        private System.Windows.Forms.Panel panelButtonSettings;
        private System.Windows.Forms.Panel panelAccentSettings;
        private System.Windows.Forms.Panel panelButtonConfiguration;
        private System.Windows.Forms.Panel panelAccentConfiguration;
        private System.Windows.Forms.Button buttonConfiguration;
        private System.Windows.Forms.Panel panelButtonComponentEditor;
        private System.Windows.Forms.Panel panelAccentComponentEditor;
        private System.Windows.Forms.Button buttonComponentBuilder;
        private System.Windows.Forms.Panel panelButtonDataEditor;
        private System.Windows.Forms.Panel panelAccentDataEditor;
        private System.Windows.Forms.Button buttonDataEditor;
        private System.Windows.Forms.Panel panelButtonDashboard;
        private System.Windows.Forms.Panel panelAccentDashboard;
        private System.Windows.Forms.Button buttonDashboard;
        private MetroFramework.Controls.MetroToggle toggle;
        private System.Windows.Forms.Panel panelButtonScriptEditor;
        private System.Windows.Forms.Panel panelAccentScriptEditor;
        private System.Windows.Forms.Button buttonScriptEditor;
        private System.Windows.Forms.Panel panelButtonDatabaseEditor;
        private System.Windows.Forms.Panel panelAccentDatabaseEditor;
        private System.Windows.Forms.Button buttonDatabaseEditor;
        private System.Windows.Forms.Panel panelButtonDataGenerator;
        private System.Windows.Forms.Panel panelAccentDataGenerator;
        private System.Windows.Forms.Button buttonDataGenerator;
        internal System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNavigationToggleDescription;
    }
}