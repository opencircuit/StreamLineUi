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
            this.panelNavigationBackground = new System.Windows.Forms.Panel();
            this.labelComputerName = new System.Windows.Forms.Label();
            this.pictureboxPenguin = new System.Windows.Forms.PictureBox();
            this.panelButtonSettings = new System.Windows.Forms.Panel();
            this.panelAccentSettings = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelButtonConfiguration = new System.Windows.Forms.Panel();
            this.panelAccentConfiguration = new System.Windows.Forms.Panel();
            this.buttonConfiguration = new System.Windows.Forms.Button();
            this.panelButtonScriptBuilder = new System.Windows.Forms.Panel();
            this.panelAccentScriptBuilder = new System.Windows.Forms.Panel();
            this.buttonScriptBuilder = new System.Windows.Forms.Button();
            this.panelButtonDataEditor = new System.Windows.Forms.Panel();
            this.panelAccentDataEditor = new System.Windows.Forms.Panel();
            this.buttonDataEditor = new System.Windows.Forms.Button();
            this.panelButtonDashboard = new System.Windows.Forms.Panel();
            this.panelAccentDashboard = new System.Windows.Forms.Panel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panelBackground.SuspendLayout();
            this.panelNavigationBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPenguin)).BeginInit();
            this.panelButtonSettings.SuspendLayout();
            this.panelButtonConfiguration.SuspendLayout();
            this.panelButtonScriptBuilder.SuspendLayout();
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
            this.panelBackground.TabIndex = 3;
            // 
            // panelControlBackground
            // 
            this.panelControlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlBackground.BackgroundImage = global::StreamLineUi.Properties.Resources.backsplash;
            this.panelControlBackground.Location = new System.Drawing.Point(126, -1);
            this.panelControlBackground.Name = "panelControlBackground";
            this.panelControlBackground.Size = new System.Drawing.Size(1462, 789);
            this.panelControlBackground.TabIndex = 3;
            // 
            // panelNavigationBackground
            // 
            this.panelNavigationBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelNavigationBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigationBackground.Controls.Add(this.labelComputerName);
            this.panelNavigationBackground.Controls.Add(this.pictureboxPenguin);
            this.panelNavigationBackground.Controls.Add(this.panelButtonSettings);
            this.panelNavigationBackground.Controls.Add(this.panelButtonConfiguration);
            this.panelNavigationBackground.Controls.Add(this.panelButtonScriptBuilder);
            this.panelNavigationBackground.Controls.Add(this.panelButtonDataEditor);
            this.panelNavigationBackground.Controls.Add(this.panelButtonDashboard);
            this.panelNavigationBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigationBackground.Location = new System.Drawing.Point(0, 0);
            this.panelNavigationBackground.Name = "panelNavigationBackground";
            this.panelNavigationBackground.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panelNavigationBackground.Size = new System.Drawing.Size(123, 788);
            this.panelNavigationBackground.TabIndex = 2;
            // 
            // labelComputerName
            // 
            this.labelComputerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelComputerName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerName.ForeColor = System.Drawing.Color.White;
            this.labelComputerName.Location = new System.Drawing.Point(0, 84);
            this.labelComputerName.Name = "labelComputerName";
            this.labelComputerName.Size = new System.Drawing.Size(121, 78);
            this.labelComputerName.TabIndex = 10;
            this.labelComputerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureboxPenguin
            // 
            this.pictureboxPenguin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureboxPenguin.Image = global::StreamLineUi.Properties.Resources.penguin;
            this.pictureboxPenguin.Location = new System.Drawing.Point(0, 20);
            this.pictureboxPenguin.Name = "pictureboxPenguin";
            this.pictureboxPenguin.Size = new System.Drawing.Size(121, 64);
            this.pictureboxPenguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureboxPenguin.TabIndex = 9;
            this.pictureboxPenguin.TabStop = false;
            // 
            // panelButtonSettings
            // 
            this.panelButtonSettings.Controls.Add(this.panelAccentSettings);
            this.panelButtonSettings.Controls.Add(this.buttonSettings);
            this.panelButtonSettings.Location = new System.Drawing.Point(0, 533);
            this.panelButtonSettings.Name = "panelButtonSettings";
            this.panelButtonSettings.Size = new System.Drawing.Size(119, 90);
            this.panelButtonSettings.TabIndex = 8;
            // 
            // panelAccentSettings
            // 
            this.panelAccentSettings.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAccentSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccentSettings.Location = new System.Drawing.Point(0, 0);
            this.panelAccentSettings.Name = "panelAccentSettings";
            this.panelAccentSettings.Size = new System.Drawing.Size(5, 90);
            this.panelAccentSettings.TabIndex = 3;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSettings.Location = new System.Drawing.Point(0, 0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.buttonSettings.Size = new System.Drawing.Size(119, 90);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.action_ViewSettings);
            // 
            // panelButtonConfiguration
            // 
            this.panelButtonConfiguration.Controls.Add(this.panelAccentConfiguration);
            this.panelButtonConfiguration.Controls.Add(this.buttonConfiguration);
            this.panelButtonConfiguration.Location = new System.Drawing.Point(0, 441);
            this.panelButtonConfiguration.Name = "panelButtonConfiguration";
            this.panelButtonConfiguration.Size = new System.Drawing.Size(119, 90);
            this.panelButtonConfiguration.TabIndex = 7;
            // 
            // panelAccentConfiguration
            // 
            this.panelAccentConfiguration.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAccentConfiguration.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccentConfiguration.Location = new System.Drawing.Point(0, 0);
            this.panelAccentConfiguration.Name = "panelAccentConfiguration";
            this.panelAccentConfiguration.Size = new System.Drawing.Size(5, 90);
            this.panelAccentConfiguration.TabIndex = 3;
            // 
            // buttonConfiguration
            // 
            this.buttonConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonConfiguration.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonConfiguration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonConfiguration.FlatAppearance.BorderSize = 0;
            this.buttonConfiguration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonConfiguration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfiguration.ForeColor = System.Drawing.Color.White;
            this.buttonConfiguration.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfiguration.Image")));
            this.buttonConfiguration.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonConfiguration.Location = new System.Drawing.Point(0, 0);
            this.buttonConfiguration.Name = "buttonConfiguration";
            this.buttonConfiguration.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.buttonConfiguration.Size = new System.Drawing.Size(119, 90);
            this.buttonConfiguration.TabIndex = 0;
            this.buttonConfiguration.Text = "Configuration";
            this.buttonConfiguration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConfiguration.UseVisualStyleBackColor = false;
            this.buttonConfiguration.Click += new System.EventHandler(this.action_ViewConfiguration);
            // 
            // panelButtonScriptBuilder
            // 
            this.panelButtonScriptBuilder.Controls.Add(this.panelAccentScriptBuilder);
            this.panelButtonScriptBuilder.Controls.Add(this.buttonScriptBuilder);
            this.panelButtonScriptBuilder.Location = new System.Drawing.Point(0, 257);
            this.panelButtonScriptBuilder.Name = "panelButtonScriptBuilder";
            this.panelButtonScriptBuilder.Size = new System.Drawing.Size(119, 90);
            this.panelButtonScriptBuilder.TabIndex = 5;
            // 
            // panelAccentScriptBuilder
            // 
            this.panelAccentScriptBuilder.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAccentScriptBuilder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccentScriptBuilder.Location = new System.Drawing.Point(0, 0);
            this.panelAccentScriptBuilder.Name = "panelAccentScriptBuilder";
            this.panelAccentScriptBuilder.Size = new System.Drawing.Size(5, 90);
            this.panelAccentScriptBuilder.TabIndex = 3;
            // 
            // buttonScriptBuilder
            // 
            this.buttonScriptBuilder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonScriptBuilder.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonScriptBuilder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonScriptBuilder.FlatAppearance.BorderSize = 0;
            this.buttonScriptBuilder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonScriptBuilder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonScriptBuilder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScriptBuilder.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScriptBuilder.ForeColor = System.Drawing.Color.White;
            this.buttonScriptBuilder.Image = ((System.Drawing.Image)(resources.GetObject("buttonScriptBuilder.Image")));
            this.buttonScriptBuilder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonScriptBuilder.Location = new System.Drawing.Point(0, 0);
            this.buttonScriptBuilder.Name = "buttonScriptBuilder";
            this.buttonScriptBuilder.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.buttonScriptBuilder.Size = new System.Drawing.Size(119, 90);
            this.buttonScriptBuilder.TabIndex = 0;
            this.buttonScriptBuilder.Text = "Script Builder";
            this.buttonScriptBuilder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonScriptBuilder.UseVisualStyleBackColor = false;
            this.buttonScriptBuilder.Click += new System.EventHandler(this.action_ViewScriptBuilder);
            // 
            // panelButtonDataEditor
            // 
            this.panelButtonDataEditor.Controls.Add(this.panelAccentDataEditor);
            this.panelButtonDataEditor.Controls.Add(this.buttonDataEditor);
            this.panelButtonDataEditor.Location = new System.Drawing.Point(0, 349);
            this.panelButtonDataEditor.Name = "panelButtonDataEditor";
            this.panelButtonDataEditor.Size = new System.Drawing.Size(119, 90);
            this.panelButtonDataEditor.TabIndex = 6;
            // 
            // panelAccentDataEditor
            // 
            this.panelAccentDataEditor.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAccentDataEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccentDataEditor.Location = new System.Drawing.Point(0, 0);
            this.panelAccentDataEditor.Name = "panelAccentDataEditor";
            this.panelAccentDataEditor.Size = new System.Drawing.Size(5, 90);
            this.panelAccentDataEditor.TabIndex = 3;
            // 
            // buttonDataEditor
            // 
            this.buttonDataEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDataEditor.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDataEditor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDataEditor.FlatAppearance.BorderSize = 0;
            this.buttonDataEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDataEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDataEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDataEditor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataEditor.ForeColor = System.Drawing.Color.White;
            this.buttonDataEditor.Image = ((System.Drawing.Image)(resources.GetObject("buttonDataEditor.Image")));
            this.buttonDataEditor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDataEditor.Location = new System.Drawing.Point(0, 0);
            this.buttonDataEditor.Name = "buttonDataEditor";
            this.buttonDataEditor.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.buttonDataEditor.Size = new System.Drawing.Size(119, 90);
            this.buttonDataEditor.TabIndex = 0;
            this.buttonDataEditor.Text = "Data Editor";
            this.buttonDataEditor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDataEditor.UseVisualStyleBackColor = false;
            this.buttonDataEditor.Click += new System.EventHandler(this.action_ViewDataEditor);
            // 
            // panelButtonDashboard
            // 
            this.panelButtonDashboard.Controls.Add(this.panelAccentDashboard);
            this.panelButtonDashboard.Controls.Add(this.buttonDashboard);
            this.panelButtonDashboard.Location = new System.Drawing.Point(0, 165);
            this.panelButtonDashboard.Name = "panelButtonDashboard";
            this.panelButtonDashboard.Size = new System.Drawing.Size(119, 90);
            this.panelButtonDashboard.TabIndex = 4;
            // 
            // panelAccentDashboard
            // 
            this.panelAccentDashboard.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAccentDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccentDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelAccentDashboard.Name = "panelAccentDashboard";
            this.panelAccentDashboard.Size = new System.Drawing.Size(5, 90);
            this.panelAccentDashboard.TabIndex = 3;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 0);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.buttonDashboard.Size = new System.Drawing.Size(119, 90);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StreamLine";
            this.Load += new System.EventHandler(this.action_FormLoad);
            this.panelBackground.ResumeLayout(false);
            this.panelNavigationBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPenguin)).EndInit();
            this.panelButtonSettings.ResumeLayout(false);
            this.panelButtonConfiguration.ResumeLayout(false);
            this.panelButtonScriptBuilder.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelButtonConfiguration;
        private System.Windows.Forms.Panel panelAccentConfiguration;
        private System.Windows.Forms.Button buttonConfiguration;
        private System.Windows.Forms.Panel panelButtonScriptBuilder;
        private System.Windows.Forms.Panel panelAccentScriptBuilder;
        private System.Windows.Forms.Button buttonScriptBuilder;
        private System.Windows.Forms.Panel panelButtonDataEditor;
        private System.Windows.Forms.Panel panelAccentDataEditor;
        private System.Windows.Forms.Button buttonDataEditor;
        private System.Windows.Forms.Panel panelButtonDashboard;
        private System.Windows.Forms.Panel panelAccentDashboard;
        private System.Windows.Forms.Button buttonDashboard;
    }
}