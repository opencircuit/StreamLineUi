using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace StreamLineUi
{
    internal class ModelSettings { }

    public partial class ControlSettings : UserControl
    {
        //***************************************************************************************************************
        // Initial Setup Methods
        //***************************************************************************************************************



        private void initialize_GenerateDefaultSettingsXml()
        {
            string resourceDirectory = Directory.GetCurrentDirectory() + "\\Resources";
            string setupDirectory = resourceDirectory + "\\Setup";
            string filePath = setupDirectory + "\\Settings.xml";
            if (File.Exists(filePath)) { return; }

            Dictionary<string, string> defaultSettings;
            defaultSettings = new Dictionary<string, string>();

            defaultSettings.Add("EngineDirectory", Directory.GetCurrentDirectory());
            defaultSettings.Add("DriversDirectory", resourceDirectory + "\\Drivers");
            defaultSettings.Add("LogsDirectory", resourceDirectory + "\\Logs");
            defaultSettings.Add("ResultsDirectory", resourceDirectory + "\\Results");
            defaultSettings.Add("ScriptsDirectory", resourceDirectory + "\\Scripts");
            defaultSettings.Add("ExecutionID", String.Empty);
            defaultSettings.Add("ScriptName", String.Empty);
            defaultSettings.Add("UiColor", "Gray");
            //defaultSettings.Add("ExecutionID", String.Empty);
            //defaultSettings.Add("Browser", String.Empty);
            //defaultSettings.Add("DebugMode", String.Empty);

            Directory.CreateDirectory(setupDirectory);
            common.event_CreateXml(defaultSettings, filePath, "Settings");
        }

        private void initialize_LoadSettings()
        {
            string resourceDirectory = Directory.GetCurrentDirectory() + "\\Resources";
            string settingsFilePath = resourceDirectory + "\\Setup\\Settings.xml";
            formMain.settingsInfo = new Dictionary<string, string>();

            XmlNodeList nodeList;
            nodeList = common.event_LoadXmlPrimaryNodes(settingsFilePath, "Settings");
            initialize_SettingsValuesAnalysis(nodeList);
        }

        private void initialize_SettingsValuesAnalysis(XmlNodeList nodeList)
        {
            XmlNode settingsNode = nodeList[0];
            formMain.settingsInfo.Add("EngineDirectory", settingsNode["EngineDirectory"].InnerText);
            formMain.settingsInfo.Add("DriversDirectory", settingsNode["DriversDirectory"].InnerText);
            formMain.settingsInfo.Add("LogsDirectory", settingsNode["LogsDirectory"].InnerText);
            formMain.settingsInfo.Add("ResultsDirectory", settingsNode["ResultsDirectory"].InnerText);
            formMain.settingsInfo.Add("ScriptsDirectory", settingsNode["ScriptsDirectory"].InnerText);
            formMain.settingsInfo.Add("ScriptName", settingsNode["ScriptName"].InnerText);
            formMain.settingsInfo.Add("UiColor", settingsNode["UiColor"].InnerText);
        }

        private void initialize_CreateDirectories()
        {
            common.event_CreateDirectory(formMain.settingsInfo["EngineDirectory"]); 
            common.event_CreateDirectory(formMain.settingsInfo["LogsDirectory"]);
            common.event_CreateDirectory(formMain.settingsInfo["ResultsDirectory"]);
            common.event_CreateDirectory(formMain.settingsInfo["ScriptsDirectory"]);
            common.event_CreateDirectory(formMain.settingsInfo["DriversDirectory"] + "\\32-Bit");
            common.event_CreateDirectory(formMain.settingsInfo["DriversDirectory"] + "\\64-Bit");
        }

        private void initialize_VerifyResourcesExist()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string resourceDirectory = currentDirectory + "\\Resources";
            string setupDirectory = resourceDirectory + "\\Setup";
            string driversDirectory = resourceDirectory + "\\Drivers";

            common.event_ExtractResource("StreamLineEngine.jar", currentDirectory);
            common.event_ExtractResource("ActionsList.xml", setupDirectory);
            common.event_ExtractResource("chromedriver.exe", driversDirectory);
            common.event_ExtractResource("geckodriver32.exe", "geckodriver.exe", driversDirectory + "\\32-Bit");
            common.event_ExtractResource("geckodriver64.exe", "geckodriver.exe", driversDirectory + "\\64-Bit");
            common.event_ExtractResource("IEDriverServer32.exe", "IEDriverServer.exe", driversDirectory + "\\32-Bit");
            common.event_ExtractResource("IEDriverServer64.exe", "IEDriverServer.exe", driversDirectory + "\\64-Bit");
        }

        private void initialize_DisplaySettingsInformation()
        {
            textboxEngineDirectory.Text = formMain.settingsInfo["EngineDirectory"];
            textboxDriversDirectory.Text = formMain.settingsInfo["DriversDirectory"];
            textboxLogsDirectory.Text = formMain.settingsInfo["LogsDirectory"];
            textboxResultsDirectory.Text = formMain.settingsInfo["ResultsDirectory"];
            textboxScriptsDirectory.Text = formMain.settingsInfo["ScriptsDirectory"];
            dropdownDatabases.Text = formMain.settingsInfo["ScriptName"];
            dropdownDatabases.ResetText();
        }



        //***************************************************************************************************************
        // Action Events Handler Methods
        //***************************************************************************************************************



        private void event_InitializeDropdownValues()
        {
            try {

                dropdownDatabases.Items.Clear();
                string applicationsDirectory = formMain.settingsInfo["ScriptsDirectory"];
                string[] directories = Directory.GetDirectories(applicationsDirectory, "*");

                foreach (string directory in directories) {
                    dropdownDatabases.Items.Add(directory.Substring(directory.LastIndexOf("\\") + 1));
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void initialize_SetUiColorSelection()
        {
            string selectedColor = formMain.settingsInfo["UiColor"];

            if (selectedColor.Equals("Blue")) { radioColorBlue.Checked = true; }
            else if (selectedColor.Equals("Orange")) { radioColorOrange.Checked = true; }
            else if (selectedColor.Equals("Green")) { radioColorGreen.Checked = true; }
            else if (selectedColor.Equals("Purple")) { radioColorPurple.Checked = true; }
            else if (selectedColor.Equals("Pink")) { radioColorPink.Checked = true; }
            else if (selectedColor.Equals("Crimson")) { radioColorCrimson.Checked = true; }
            else if (selectedColor.Equals("Teal")) { radioColorTeal.Checked = true; }
            else { radioColorGray.Checked = true; }
        }

        private void event_ChangeUiColor()
        {
            Color color = common.event_RetrieveUiColor(formMain.settingsInfo["UiColor"]);
            common.event_ChangeButtonsColor(this, color);
            formMain.event_ChangeUiColor(formMain.settingsInfo["UiColor"]);
            formMain.event_SetButtonBackColor(formMain.buttonSettings);
        }

        private void event_SaveSettings()
        {
            try {

                string currentDirectory = Directory.GetCurrentDirectory();
                string setupDirectory = currentDirectory + "\\Resources\\Setup";
                string filePath = setupDirectory + "\\Settings.xml";

                event_CollectSettingsData();
                common.event_CreateXml(formMain.settingsInfo, filePath, "Settings");
                formMain.event_InitializeDatabaseManagers();
                formMain.event_ChangeUiColor(formMain.settingsInfo["UiColor"]);
                formMain.event_ControlInstances();
                event_ChangeUiColor();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_CollectSettingsData()
        {
            formMain.settingsInfo["EngineDirectory"] = textboxEngineDirectory.Text;
            formMain.settingsInfo["DriversDirectory"] = textboxDriversDirectory.Text;
            formMain.settingsInfo["LogsDirectory"] = textboxLogsDirectory.Text;
            formMain.settingsInfo["ResultsDirectory"] = textboxResultsDirectory.Text;
            formMain.settingsInfo["ScriptsDirectory"] = textboxScriptsDirectory.Text;
            formMain.settingsInfo["ScriptName"] = dropdownDatabases.Text;
            formMain.settingsInfo["UiColor"] = groupboxUIColor.Controls.
                OfType<RadioButton>().FirstOrDefault(radio => radio.Checked).Text;

            formMain.settingsInfo["ExecutionID"] = String.Empty;
            formMain.settingsInfo["Browser"] = String.Empty;

            string currentDirectory = Directory.GetCurrentDirectory();
            string setupDirectory = currentDirectory + "\\Resources\\Setup";
            string filePath = setupDirectory + "\\Settings.xml";
            common.event_CreateXml(formMain.settingsInfo, filePath, "Settings");
        }

        private void event_EnableSettingsControls(bool isEnabled)
        {
            buttonClearTestDatabase.Enabled = isEnabled;
            buttonResetTestDatabase.Enabled = isEnabled;
            buttonResetResultsDatabase.Enabled = isEnabled;
        }

        private string event_RetrieveScriptName(string buttonText)
        {
            string scriptName;

            try {

                FormDataRetrieval dataRetrieval = new FormDataRetrieval(
                    formMain.settingsInfo["UiColor"],
                    "Script Name:", 
                    buttonText,
                    "Message: Only use alpha-characters.");

                if (dataRetrieval.ShowDialog() != DialogResult.OK) { return String.Empty; }
                scriptName = dataRetrieval.UserSpecifiedDataValue.Trim().Replace(" ", "");
            }
            catch (Exception ex) {
                scriptName = "";
                MessageBox.Show(ex.Message);
            }

            return scriptName;
        }

        private void event_DeleteAllDirectoryFiles(string directoryPath)
        {
            try {

                MessageBox.Show(directoryPath);
                DirectoryInfo directory = new DirectoryInfo(directoryPath);
                FileInfo[] files = directory.GetFiles("*");

                foreach (FileInfo file in files) {
                    file.Delete();
                }

                foreach (DirectoryInfo subDirectory in directory.GetDirectories()) {
                    event_DeleteAllDirectoryFiles(subDirectory.FullName);
                }

                directory.Delete();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_ResetDatabase(string databaseName)
        {
            try {

                formMain.event_CloseAllDatabaseConnections();
                string directory = formMain.settingsInfo["ScriptsDirectory"] + "\\" + formMain.settingsInfo["ScriptName"];
                File.Delete(directory + "\\" + databaseName);
                common.event_ExtractResource(databaseName, directory);
                event_SaveSettings();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}