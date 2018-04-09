using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamLineUi
{
    public partial class FormMain : MaterialForm
    {
        private Common common = new Common();
        private ControlDashboard dashboard;
        private ControlScriptBuilder scriptBuilder;
        private ControlDataEditor dataEditor;
        private ControlConfiguration configuration;
        private ControlSettings settings;

        private Dictionary<string, string> settingsDictionary;
        private Color uiColor;

        private string currentViewName;

        public FormMain()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey800,
                Primary.Grey800, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            initialize_CreatePrimaryDirectories();
            initialize_GenerateDefaultSettingsXml();
            initialize_LoadSettings();
            initialize_CreateSettingsDirectories();
            initialize_VerifyResourcesExist();

            string selectedColor = settingsDictionary["UiColor"];
            initialize_ChangeUiColor(selectedColor);

            labelComputerName.Text = common.event_GetComputerName();
            currentViewName = "";
        }

        private void action_ViewDashboard(object sender, EventArgs e)
        {
            bool switchView = event_ProgressCheck();

            if (switchView) {

                event_ResetForm();
                dashboard = new ControlDashboard(settingsDictionary);
                panelControlBackground.Controls.Add(dashboard);
                event_ResetForm();
                panelControlBackground.Controls.Add(dashboard);
                dashboard.Dock = DockStyle.Fill;
                buttonDashboard.BackColor = uiColor;
                currentViewName = "Dashboard";
            }
        }

        private void action_ViewScriptBuilder(object sender, EventArgs e)
        {
            bool switchView = event_ProgressCheck();

            if (switchView) {

                event_ResetForm();
                scriptBuilder = new ControlScriptBuilder(settingsDictionary);
                panelControlBackground.Controls.Add(scriptBuilder);
                scriptBuilder.Dock = DockStyle.Fill;
                buttonScriptBuilder.BackColor = uiColor;
                currentViewName = "ScriptBuilder";
            }
        }

        private void action_ViewDataEditor(object sender, EventArgs e)
        {
            bool switchView = event_ProgressCheck();

            if (switchView) {

                event_ResetForm();
                dataEditor = new ControlDataEditor(settingsDictionary);
                panelControlBackground.Controls.Add(dataEditor);
                dataEditor.Dock = DockStyle.Fill;
                buttonDataEditor.BackColor = uiColor;
                currentViewName = "DataEditor";
            }
        }

        private void action_ViewConfiguration(object sender, EventArgs e)
        {
            bool switchView = event_ProgressCheck();

            if (switchView) {

                event_ResetForm();
                configuration = new ControlConfiguration(this, settingsDictionary);
                panelControlBackground.Controls.Add(configuration);
                configuration.Dock = DockStyle.Fill;
                buttonConfiguration.BackColor = uiColor;
                currentViewName = "Configuration";
            }
        }

        private void action_ViewSettings(object sender, EventArgs e)
        {
            bool switchView = event_ProgressCheck();

            if (switchView) {

                event_ResetForm();
                settings = new ControlSettings(this, settingsDictionary);
                panelControlBackground.Controls.Add(settings);
                settings.Dock = DockStyle.Fill;
                buttonSettings.BackColor = uiColor;
                currentViewName = "Settings";
            }
        }
    }
}
