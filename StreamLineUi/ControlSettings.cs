using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace StreamLineUi
{
    public partial class ControlSettings : UserControl
    {
        private FormMain formMain;
        private Common common;

        public ControlSettings(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            common = new Common();
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            initialize_GenerateDefaultSettingsXml();
            initialize_LoadSettings();
            initialize_CreateDirectories();
            initialize_VerifyResourcesExist();
            initialize_DisplaySettingsInformation();
            initialize_SetUiColorSelection();
            event_ChangeUiColor();
            event_InitializeDropdownValues();

        }

        private void action_SelectDirectory(object sender, EventArgs e)
        {
            if (browseDirectory.ShowDialog() != DialogResult.OK) { return; }

            Button button = (Button)sender;

            if (button.Text.Equals("Select Results Directory")) {
                textboxResultsDirectory.Text = browseDirectory.SelectedPath;
            }
            else if (button.Text.Equals("Select Scripts Directory")) {
                textboxScriptsDirectory.Text = browseDirectory.SelectedPath;
            }

            event_InitializeDropdownValues();
        }

        private void action_ConnectToDatabase(object sender, EventArgs e)
        {
            if (dropdownDatabases.Text.Length == 0) { return; }
            event_SaveSettings();
            event_EnableSettingsControls(true);
            formMain.event_EnableAllControlButtons(true);
        }

        private void action_CreateScript(object sender, EventArgs e)
        {
            string scriptName = event_RetrieveScriptName("Create Script && Database");
            if (scriptName.Length == 0) { return; }
            if (dropdownDatabases.FindStringExact(scriptName) >= 0) {
                MessageBox.Show("This script & database already exists.");
                return;
            }

            string scriptDirectory = formMain.settingsInfo["ScriptsDirectory"] + "\\" + scriptName;
            Directory.CreateDirectory(scriptDirectory + "\\Components");

            common.event_ExtractResource("TestCaseData.db", scriptDirectory);
            common.event_ExtractResource("TestCaseResults.db", scriptDirectory);
            common.event_ExtractResource("sqlite3.exe", scriptDirectory);
            common.event_ExtractResource("Script.xml", scriptDirectory);
            common.event_ExtractResource("InitialLandingPage.xml", scriptDirectory + "\\Components");
            dropdownDatabases.Items.Add(scriptName);

            MessageBox.Show("Scirpt & database has been created.");
        }

        private void action_DeleteScript(object sender, EventArgs e)
        {
            string scriptName = event_RetrieveScriptName("Delete Script && Database");
            if (scriptName.Length == 0) { return; }
            if (scriptName.Equals(formMain.settingsInfo["ScriptName"])) {
                MessageBox.Show("Cannot delete currently connected script & database.");
                return;
            }

            string scriptDirectory = formMain.settingsInfo["ScriptsDirectory"] + "\\" + scriptName;

            if (!Directory.Exists(scriptDirectory)) {
                MessageBox.Show("Script & datbase could not be deleted. It does not exist.");
                return;
            }

            event_DeleteAllDirectoryFiles(scriptDirectory);
            dropdownDatabases.Items.Remove(scriptName);
            MessageBox.Show("Scirpt & database has been deleted.");
        }

        private void action_ClearTestDatabase(object sender, EventArgs e)
        {
            ArrayList tableList = formMain.testDatabase.event_RetrieveTableList();

            foreach (string tableName in tableList) {
                string query = "DELETE FROM [" + tableName + "] WHERE [Test_Case_ID] != 'Default'";
                formMain.testDatabase.event_ExecuteNonSelectQuery(query);
            }
        }

        private void action_ResetTestDatabase(object sender, EventArgs e)
        {
            event_ResetDatabase("TestCaseData.db");
        }

        private void action_ResetResultsDatabase(object sender, EventArgs e)
        {
            event_ResetDatabase("TestCaseResults.db");
        }

        private void action_SaveSettings(object sender, EventArgs e)
        {
            event_SaveSettings();
        }
    }
}