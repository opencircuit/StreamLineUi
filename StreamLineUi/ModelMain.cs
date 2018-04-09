using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace StreamLineUi
{
    internal class ModelMain
    {
    }

    public partial class FormMain : MaterialForm
    {
        private void initialize_CreatePrimaryDirectories()
        {
            string resourceDirectory = common.event_GetCurrentDirectory() + "\\Resources";
            string databaseDirectory = resourceDirectory + "\\Databases";
            string resultsDirectory = resourceDirectory + "\\Results";
            string scriptsDirectory = resourceDirectory + "\\Scripts";
            string setupDirectory = resourceDirectory + "\\Setup";

            common.event_CreateDirectory(resourceDirectory);
            common.event_CreateDirectory(databaseDirectory);
            common.event_CreateDirectory(resultsDirectory);
            common.event_CreateDirectory(scriptsDirectory);
            common.event_CreateDirectory(setupDirectory);
        }

        private void initialize_GenerateDefaultSettingsXml()
        {
            string resourceDirectory = common.event_GetCurrentDirectory() + "\\Resources";
            string settingsFile = resourceDirectory + "\\Setup\\Settings.xml";
            if (File.Exists(settingsFile)) { return; }

            string scriptsDirectory = resourceDirectory + "\\Scripts";
            string databaseDirectory = resourceDirectory + "\\Databases";
            string resultsDirectory = resourceDirectory + "\\Results";

            Dictionary<string, string> defaultSettingsValues;
            defaultSettingsValues = new Dictionary<string, string>();

            defaultSettingsValues.Add("ScriptsDirectory", scriptsDirectory);
            defaultSettingsValues.Add("TestDatabaseDirectory", databaseDirectory);
            defaultSettingsValues.Add("ResultsDatabaseDirectory", databaseDirectory);
            defaultSettingsValues.Add("ResultsFileDirectory", resultsDirectory);
            defaultSettingsValues.Add("UiColor", "");

            string currentDirectory = common.event_GetCurrentDirectory();
            string setupDirectory = currentDirectory + "\\Resources\\Setup";
            string filePath = setupDirectory + "\\Settings.xml";
            common.event_GenerateXml(defaultSettingsValues, filePath, "Settings");
        }

        private void initialize_LoadSettings()
        {
            string resourceDirectory = common.event_GetCurrentDirectory() + "\\Resources";
            string settingsFilePath = resourceDirectory + "\\Setup\\Settings.xml";
            settingsDictionary = new Dictionary<string, string>();

            XmlNodeList primaryNodes;
            primaryNodes = common.event_LoadXmlPrimaryNodes(settingsFilePath, "Settings");
            initialize_SettingsValuesAnalysis(primaryNodes);
        }

        private void initialize_SettingsValuesAnalysis(XmlNodeList primaryNodes)
        {
            XmlNode settingsNode = primaryNodes[0];

            string scriptsDirectory = settingsNode["ScriptsDirectory"].InnerText;
            string testDatabaseDirectory = settingsNode["TestDatabaseDirectory"].InnerText;
            string resultsDatabaseDirectory = settingsNode["ResultsDatabaseDirectory"].InnerText;
            string resultsFileDirectory = settingsNode["ResultsFileDirectory"].InnerText;
            string colorSelection = settingsNode["UiColor"].InnerText;

            settingsDictionary.Add("ScriptsDirectory", scriptsDirectory);
            settingsDictionary.Add("TestDatabaseDirectory", testDatabaseDirectory);
            settingsDictionary.Add("ResultsDatabaseDirectory", resultsDatabaseDirectory);
            settingsDictionary.Add("ResultsFileDirectory", resultsFileDirectory);
            settingsDictionary.Add("UiColor", colorSelection);
        }

        private void initialize_CreateSettingsDirectories()
        {
            common.event_CreateDirectory(settingsDictionary["ScriptsDirectory"]);
            common.event_CreateDirectory(settingsDictionary["TestDatabaseDirectory"]);
            common.event_CreateDirectory(settingsDictionary["ResultsDatabaseDirectory"]);
            common.event_CreateDirectory(settingsDictionary["ResultsFileDirectory"]);
        }

        private void initialize_VerifyResourcesExist()
        {
            string currentDirectory = common.event_GetCurrentDirectory();
            string resourceDirectory = currentDirectory + "\\Resources";
            string setupDirectory = resourceDirectory + "\\Setup";
            string testDatabaseDirectory = settingsDictionary["TestDatabaseDirectory"];
            string resultsDatabaseDirectory = settingsDictionary["ResultsDatabaseDirectory"];

            string projectName = "StreamLineUi";

            if (!File.Exists(setupDirectory + "\\ScriptBuilderOptions.xml")) {
                common.event_ExtractEmbeddedResource(projectName, "ScriptBuilderOptions.xml", setupDirectory);
            }

            if (!File.Exists(testDatabaseDirectory + "\\TestCaseData.db")) {
                common.event_ExtractEmbeddedResource(projectName, "TestCaseData.db", testDatabaseDirectory);
            }

            if (!File.Exists(resultsDatabaseDirectory + "\\TestCaseResults.db")) {
                common.event_ExtractEmbeddedResource(projectName, "TestCaseResults.db", resultsDatabaseDirectory);
            }

            if (!File.Exists(currentDirectory + "\\StreamLineEngine.jar")) {
                common.event_ExtractEmbeddedResource(projectName, "StreamLineEngine.jar", currentDirectory);
            }
        }

        internal void initialize_ChangeUiColor(string selectedColor)
        {
            uiColor = common.event_RetrieveSpecifiedColor(selectedColor);

            panelAccentDashboard.BackColor = uiColor;
            panelAccentScriptBuilder.BackColor = uiColor;
            panelAccentDataEditor.BackColor = uiColor;
            panelAccentConfiguration.BackColor = uiColor;
            panelAccentSettings.BackColor = uiColor;

            buttonDashboard.FlatAppearance.MouseDownBackColor = uiColor;
            buttonScriptBuilder.FlatAppearance.MouseDownBackColor = uiColor;
            buttonDataEditor.FlatAppearance.MouseDownBackColor = uiColor;
            buttonConfiguration.FlatAppearance.MouseDownBackColor = uiColor;
            buttonSettings.FlatAppearance.MouseDownBackColor = uiColor;

            buttonDashboard.FlatAppearance.MouseOverBackColor = uiColor;
            buttonScriptBuilder.FlatAppearance.MouseOverBackColor = uiColor;
            buttonDataEditor.FlatAppearance.MouseOverBackColor = uiColor;
            buttonConfiguration.FlatAppearance.MouseOverBackColor = uiColor;
            buttonSettings.FlatAppearance.MouseOverBackColor = uiColor;
        }

        internal void event_EnableControlButtons(bool isEnabled)
        {
            buttonDashboard.Enabled = isEnabled;
            buttonScriptBuilder.Enabled = isEnabled;
            buttonDataEditor.Enabled = isEnabled;
            buttonConfiguration.Enabled = isEnabled;
            buttonSettings.Enabled = isEnabled;
        }

        private void event_ResetForm()
        {
            panelControlBackground.Controls.Clear();
            buttonDashboard.BackColor = Color.FromArgb(60, 60, 60);
            buttonScriptBuilder.BackColor = Color.FromArgb(60, 60, 60);
            buttonDataEditor.BackColor = Color.FromArgb(60, 60, 60);
            buttonConfiguration.BackColor = Color.FromArgb(60, 60, 60);
            buttonSettings.BackColor = Color.FromArgb(60, 60, 60);
        }

        private bool event_ProgressCheck()
        {
            bool inProgress = false;
            bool switchView = true;

            if (currentViewName.Equals("Dashboard")) {
                inProgress = false;
                switchView = event_DetermineSwitchViewStatus(inProgress);
            }
            else if (currentViewName.Equals("ScriptBuilder")) {
                inProgress = scriptBuilder.event_InProgress;
                switchView = event_DetermineSwitchViewStatus(inProgress);
            }
            else if (currentViewName.Equals("DataEditor")) {
                inProgress = dataEditor.event_InProgress;
                switchView = event_DetermineSwitchViewStatus(inProgress);
            }
            else if (currentViewName.Equals("Configuration")) {
                inProgress = configuration.event_InProgress;
                switchView = event_DetermineSwitchViewStatus(inProgress);
            }
            else if (currentViewName.Equals("Settings")) {
                inProgress = false;
                switchView = event_DetermineSwitchViewStatus(inProgress);
            }
            else {
                switchView = true;
            }

            return switchView;
        }

        private bool event_DetermineSwitchViewStatus(bool inProgress)
        {
            bool switchView = true;

            if (inProgress) {

                string title = "Unfinished Work";
                string messagePart1 = "You seem to have unfinished processes in this module.\n";
                string messagePart2 = "If you switch modules now you will lose all of your work.\n";
                string messagePart3 = "Are you sure you want to switch to another module?";
                string fullMessage = messagePart1 + messagePart2 + messagePart3;

                DialogResult dialogResult;
                dialogResult = MessageBox.Show(fullMessage, title, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No) {
                    switchView = false;
                }
            }

            return switchView;
        }
    }
}