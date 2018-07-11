using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StreamLineUi
{
    internal class ModelMain { }

    public partial class FormMain : MaterialForm
    {
        //***************************************************************************************************************
        // Initial Setup Methods
        //***************************************************************************************************************



        internal void event_ChangeUiColor(string uiColor)
        {
            Color color = common.event_RetrieveUiColor(uiColor);
            event_ChangeNavigationButtonAccent(color);
            event_ChangeButtonColor(color);
            event_ChangeMaterialFormAccent(uiColor);
        }

        private void event_ChangeNavigationButtonAccent(Color color)
        {
            panelAccentDashboard.BackColor = color;
            panelAccentScriptEditor.BackColor = color;
            panelAccentComponentEditor.BackColor = color;
            panelAccentDataGenerator.BackColor = color;
            panelAccentDataEditor.BackColor = color;
            panelAccentDatabaseEditor.BackColor = color;
            panelAccentConfiguration.BackColor = color;
            panelAccentSettings.BackColor = color;
        }

        private void event_ChangeButtonColor(Color color)
        {
            common.event_ChangeButtonColor(buttonDashboard, color);
            common.event_ChangeButtonColor(buttonScriptEditor, color);
            common.event_ChangeButtonColor(buttonComponentBuilder, color);
            common.event_ChangeButtonColor(buttonDataGenerator, color);
            common.event_ChangeButtonColor(buttonDataEditor, color);
            common.event_ChangeButtonColor(buttonDatabaseEditor, color);
            common.event_ChangeButtonColor(buttonConfiguration, color);
            common.event_ChangeButtonColor(buttonSettings, color);
        }

        private void event_ChangeMaterialFormAccent(string uiColor)
        {
            Accent accent;

            if (uiColor.Equals("Blue")) { accent = Accent.LightBlue400; }
            else if (uiColor.Equals("Orange")) { accent = Accent.Orange400; }
            else if (uiColor.Equals("Green")) { accent = Accent.Green700; }
            else if (uiColor.Equals("Purple")) { accent = Accent.Purple700; }
            else if (uiColor.Equals("Pink")) { accent = Accent.Pink100; }
            else if (uiColor.Equals("Crimson")) { accent = Accent.Red700; }
            else if (uiColor.Equals("Teal")) { accent = Accent.Teal700; }
            else { accent = Accent.LightBlue100; }

            //Configure Color Schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey900, Primary.Grey900,
                Primary.Grey900, accent,
                TextShade.WHITE
            );
        }

        private void initialize_UserComputerName()
        {
            labelComputerName.Text = common.event_GetComputerName();
        }

        private void initialize_SettingsControl()
        {
            settings = new ControlSettings(this);
            buttonSettings.Enabled = true;
        }



        //***************************************************************************************************************
        // Action Events Handler Methods
        //***************************************************************************************************************



        private void event_EnablePartialControlButtons(bool isEnabled)
        {
            buttonDashboard.Enabled = isEnabled;
            buttonScriptEditor.Enabled = isEnabled;
            buttonComponentBuilder.Enabled = isEnabled;
            buttonDataGenerator.Enabled = isEnabled;
            buttonDataEditor.Enabled = isEnabled;
            buttonDatabaseEditor.Enabled = isEnabled;
            buttonConfiguration.Enabled = isEnabled;
        }

        internal void event_InitializeDatabaseManagers()
        {
            if (testDatabase != null) { testDatabase.event_CloseConnection(); }
            if (resultDatabase != null) { resultDatabase.event_CloseConnection(); }

            testDatabase = common.event_DatabaseConnector(settingsInfo["ScriptName"], "Test");
            resultDatabase = common.event_DatabaseConnector(settingsInfo["ScriptName"], "Result");

            testDatabase.event_OpenConnection();
            resultDatabase.event_OpenConnection();
        }

        internal void event_CloseAllDatabaseConnections()
        {
            testDatabase.event_CloseConnection();
            testDatabase = null;

            resultDatabase.event_CloseConnection();
            resultDatabase = null;
        }

        internal void event_ControlInstances()
        {
            dashboard = new ControlDashboard(this);
            scriptEditor = new ControlScriptEditor(this);
            componentEditor = new ControlComponentEditor(this);
            dataGenerator = new ControlDataGenerator(this);
            dataEditor = new ControlDataEditor(this);
            databaseEditor = new ControlDatabaseEditor(this);
            configuration = new ControlConfiguration(this);
        }

        private void event_SetButtonText()
        {
            buttonDashboard.Text = "Dashboard";
            buttonScriptEditor.Text = "Script Flow";
            buttonComponentBuilder.Text = "Components";
            buttonDataGenerator.Text = "Generate Data";
            buttonDataEditor.Text = "Edit Test Data";
            buttonDatabaseEditor.Text = "Edit Database";
            buttonConfiguration.Text = "Configuration";
            buttonSettings.Text = "Settings";
        }

        private void event_EmptyButtonText()
        {
            buttonDashboard.Text = String.Empty;
            buttonScriptEditor.Text = String.Empty;
            buttonComponentBuilder.Text = String.Empty;
            buttonDataGenerator.Text = String.Empty;
            buttonDataEditor.Text = String.Empty;
            buttonDatabaseEditor.Text = String.Empty;
            buttonConfiguration.Text = String.Empty;
            buttonSettings.Text = String.Empty;
        }

        internal void event_SetButtonBackColor(Button button)
        {
            event_ResetButtonBackgroundColor();
            Color color = common.event_RetrieveUiColor(settingsInfo["UiColor"]);
            button.BackColor = color;
        }

        private void event_ResetButtonBackgroundColor()
        {
            Color color = Color.FromArgb(45, 45, 45);
            buttonDashboard.BackColor = color;
            buttonScriptEditor.BackColor = color;
            buttonComponentBuilder.BackColor = color;
            buttonDataGenerator.BackColor = color;
            buttonDataEditor.BackColor = color;
            buttonDatabaseEditor.BackColor = color;
            buttonConfiguration.BackColor = color;
            buttonSettings.BackColor = color;
        }

        internal void event_EnableAllControlButtons(bool isEnabled)
        {
            event_EnablePartialControlButtons(isEnabled);
            buttonSettings.Enabled = isEnabled;
        }
    }
}