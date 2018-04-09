using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StreamLineUi
{
    public partial class ControlSettings : UserControl
    {
        private Common common = new Common();
        private FormMain formMain;

        private Dictionary<string, string> settingsDictionary;
        private Color uiColor;

        public ControlSettings(FormMain formMain, Dictionary<string, string> settingsDictionary)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.settingsDictionary = settingsDictionary;
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            initialize_ChooseUiColor();
            initialize_ChangeUiColor();
            initialize_LoadSettings();
        }

        private void action_SelectScriptsDirectory(object sender, EventArgs e)
        {
            dialogBrowseForFolder.ShowDialog();
            textboxScriptsDirectory.Text = dialogBrowseForFolder.SelectedPath;
        }

        private void action_DefaultScriptsDirectory(object sender, EventArgs e)
        {
            string currentDirectory = common.event_GetCurrentDirectory();
            string resourceDirectory = currentDirectory + "\\Resources";
            string scriptsDirectory = resourceDirectory + "\\Scripts";
            textboxScriptsDirectory.Text = scriptsDirectory;
        }

        private void action_SelectTestDatabaseDirectory(object sender, EventArgs e)
        {
            dialogBrowseForFolder.ShowDialog();
            textboxTestDatabaseDirectory.Text = dialogBrowseForFolder.SelectedPath;
            string testDatabaseDirectory = textboxTestDatabaseDirectory.Text;
            string testDatabaseName = "TestCaseData.db";
            string projectName = "StreamLineUi";

            if (!File.Exists(testDatabaseDirectory + "\\TestCaseData.db")) {
                MessageBox.Show("No test database found in the selected directory. One will be created now.");
                common.event_ExtractEmbeddedResource(projectName, testDatabaseName, testDatabaseDirectory);
            }
        }

        private void action_DefaultTestDatabaseDirectory(object sender, EventArgs e)
        {
            string currentDirectory = common.event_GetCurrentDirectory();
            string resourceDirectory = currentDirectory + "\\Resources";
            string testDatabaseDirectory = resourceDirectory + "\\Databases";
            textboxTestDatabaseDirectory.Text = testDatabaseDirectory;
        }

        private void action_SelectResultsDatabaseDirectory(object sender, EventArgs e)
        {
            dialogBrowseForFolder.ShowDialog();
            textboxResultsDatabaseDirectory.Text = dialogBrowseForFolder.SelectedPath;
            string resultsDatabaseDirectory = textboxResultsDatabaseDirectory.Text;
            string resultsDatabaseName = "TestCaseResults.db";
            string projectName = "StreamLineUi";

            if (!File.Exists(resultsDatabaseDirectory + "\\TestCaseResults.db")) {
                MessageBox.Show("No results database found in the selected directory. One will be created now.");
                common.event_ExtractEmbeddedResource(projectName, resultsDatabaseName, resultsDatabaseDirectory);
            }
        }

        private void action_DefaultResultsDatabaseDirectory(object sender, EventArgs e)
        {
            string currentDirectory = common.event_GetCurrentDirectory();
            string resourceDirectory = currentDirectory + "\\Resources";
            string resultsDatabaseDirectory = resourceDirectory + "\\Databases";
            textboxResultsDatabaseDirectory.Text = resultsDatabaseDirectory;
        }

        private void action_SelectResultsFileDirectory(object sender, EventArgs e)
        {
            dialogBrowseForFolder.ShowDialog();
            textboxResultsFileDirectory.Text = dialogBrowseForFolder.SelectedPath;
        }

        private void action_DefaultResultsFileDirectory(object sender, EventArgs e)
        {
            string currentDirectory = common.event_GetCurrentDirectory();
            string resourceDirectory = currentDirectory + "\\Resources";
            string resultsFileDirectory = resourceDirectory + "\\Results";
            textboxResultsFileDirectory.Text = resultsFileDirectory;
        }

        private void action_ResetResultsDatabase(object sender, EventArgs e)
        {
            string projectName = "StreamLineUi";
            string resultsDatabaseDirectory = settingsDictionary["ResultsDatabaseDirectory"];
            string resultsDatabasePath = resultsDatabaseDirectory + "\\TestCaseResults.db";

            File.Delete(resultsDatabasePath);
            common.event_ExtractEmbeddedResource(projectName, "TestCaseResults.db", resultsDatabaseDirectory);
        }

        private void action_ResetTestDatabase(object sender, EventArgs e)
        {
            string projectName = "StreamLineUi";
            string testCaseDatabaseDirectory = settingsDictionary["TestDatabaseDirectory"];
            string testCaseDatabasePath = testCaseDatabaseDirectory + "\\TestCaseData.db";

            File.Delete(testCaseDatabasePath);
            common.event_ExtractEmbeddedResource(projectName, "TestCaseData.db", testCaseDatabaseDirectory);
        }

        private void action_ClearTestDatabase(object sender, EventArgs e)
        {
            string testCaseDatabaseDirectory = settingsDictionary["TestDatabaseDirectory"];
            string testCaseDatabase = testCaseDatabaseDirectory + "\\TestCaseData.db";
            DatabaseConnector database = new DatabaseConnector(testCaseDatabase);

            ArrayList tableList = database.event_RetrieveTableList();
            tableList.Remove("");

            database.event_ClearDatabase(tableList);
        }

        private void action_SaveSettings(object sender, EventArgs e)
        {
            event_CollectSettingsData();
            string currentDirectory = common.event_GetCurrentDirectory();
            string setupDirectory = currentDirectory + "\\Resources\\Setup";
            string filePath = setupDirectory + "\\Settings.xml";
            common.event_GenerateXml(settingsDictionary, filePath, "Settings");

            string selectedColor = settingsDictionary["UiColor"];
            formMain.initialize_ChangeUiColor(selectedColor);
        }
    }
}