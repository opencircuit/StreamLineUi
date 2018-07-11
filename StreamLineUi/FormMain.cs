using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StreamLineUi
{
    public partial class FormMain : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private ControlDashboard dashboard;
        private ControlScriptEditor scriptEditor;
        private ControlComponentEditor componentEditor;
        private ControlDataGenerator dataGenerator;
        private ControlDataEditor dataEditor;
        private ControlDatabaseEditor databaseEditor;
        private ControlConfiguration configuration;
        private ControlSettings settings;
        private Common common;

        internal DatabaseManager testDatabase;
        internal DatabaseManager resultDatabase;
        internal Dictionary<string, string> settingsInfo;

        public FormMain()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Century Gothic", 10);
            materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Century Gothic", 10);
            materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Century Gothic", 10);
            materialSkinManager.ROBOTO_REGULAR_11 = new Font("Century Gothic", 10);

            common = new Common();
            testDatabase = null;
            resultDatabase = null;
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            event_ChangeUiColor("Gray");
            initialize_UserComputerName();
            initialize_SettingsControl();
            event_EnablePartialControlButtons(false);
            event_SetButtonText();
        }

        private void action_ViewDashboard(object sender, EventArgs e)
        {
            panelControlBackground.Controls.Clear();
            panelControlBackground.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
            event_SetButtonBackColor(buttonDashboard);
        }

        private void action_ViewScriptEditor(object sender, EventArgs e)
        {
            panelControlBackground.Controls.Clear();
            panelControlBackground.Controls.Add(scriptEditor);
            scriptEditor.Dock = DockStyle.Fill;
            event_SetButtonBackColor(buttonScriptEditor);
        }

        private void action_ViewComponentEditor(object sender, EventArgs e)
        {
            panelControlBackground.Controls.Clear();
            panelControlBackground.Controls.Add(componentEditor);
            componentEditor.Dock = DockStyle.Fill;
            event_SetButtonBackColor(buttonComponentBuilder);
        }

        private void action_ViewDataGenerator(object sender, EventArgs e)
        {
            panelControlBackground.Controls.Clear();
            panelControlBackground.Controls.Add(dataGenerator);
            dataGenerator.Dock = DockStyle.Fill;
            event_SetButtonBackColor(buttonDataGenerator);
        }

        private void action_ViewDataEditor(object sender, EventArgs e)
        {
            panelControlBackground.Controls.Clear();
            panelControlBackground.Controls.Add(dataEditor);
            dataEditor.Dock = DockStyle.Fill;
            event_SetButtonBackColor(buttonDataEditor);
        }

        private void action_ViewDatabaseEditor(object sender, EventArgs e)
        {
            panelControlBackground.Controls.Clear();
            panelControlBackground.Controls.Add(databaseEditor);
            databaseEditor.Dock = DockStyle.Fill;
            event_SetButtonBackColor(buttonDatabaseEditor);
        }

        private void action_ViewConfiguration(object sender, EventArgs e)
        {
            panelControlBackground.Controls.Clear();
            panelControlBackground.Controls.Add(configuration);
            configuration.Dock = DockStyle.Fill;
            event_SetButtonBackColor(buttonConfiguration);
        }

        private void action_ViewSettings(object sender, EventArgs e)
        {
            panelControlBackground.Controls.Clear();
            panelControlBackground.Controls.Add(settings);
            settings.Dock = DockStyle.Fill;
            event_SetButtonBackColor(buttonSettings);
        }

        private void action_SlimNavigation(object sender, EventArgs e)
        {
            int width;
            if (toggle.Checked) { width = 50; event_EmptyButtonText(); }
            else { width = 150; event_SetButtonText(); }
            labelComputerName.Visible = !toggle.Checked;
            labelNavigationToggleDescription.Visible = !toggle.Checked;

            panelNavigationBackground.Size = new Size(width, panelNavigationBackground.Height);
        }
    }
}