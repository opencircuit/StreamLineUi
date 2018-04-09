using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace StreamLineUi
{
    internal class ModelConfiguration
    {
    }

    public partial class ControlConfiguration : UserControl
    {
        private void initialize_ChooseUiColor()
        {
            string selectedColor = settingsDictionary["UiColor"];
            uiColor = common.event_RetrieveSpecifiedColor(selectedColor);
        }

        private void initialize_ChangeUiColor()
        {
            buttonApplyFilter.BackColor = uiColor;
            buttonClearFilter.BackColor = uiColor;
            buttonLoadTable.BackColor = uiColor;
            buttonRemoveSelections.BackColor = uiColor;
            buttonStartExecution.BackColor = uiColor;
            buttonStopExecution.BackColor = uiColor;
            gridviewTable.DefaultCellStyle.SelectionBackColor = uiColor;
        }

        private void initialize_ColumnList()
        {
            string testDatabaseDirectory = settingsDictionary["TestDatabaseDirectory"];
            string testDatabasePath = testDatabaseDirectory + "\\TestCaseData.db";

            DatabaseConnector database;
            database = new DatabaseConnector(testDatabasePath);

            ArrayList columnList;
            columnList = database.event_RetrieveColumnList("MAIN");
            columnList.Remove("");
            dropdownColumns.DataSource = columnList;
        }

        private void event_LoadAllTestCases()
        {
            string testDatabaseDirectory = settingsDictionary["TestDatabaseDirectory"];
            string testDatabasePath = testDatabaseDirectory + "\\TestCaseData.db";

            DatabaseConnector database;
            database = new DatabaseConnector(testDatabasePath);

            string tableName = "MAIN";
            DataTable dataTable;
            dataTable = database.event_LoadTable(tableName);
            gridviewTable.DataSource = dataTable;
            gridviewTable.DefaultCellStyle.SelectionBackColor = uiColor;
        }

        private void event_RemoveSelectedTestCasesFromList() {

            try {

                foreach (DataGridViewRow gridRow in gridviewTable.SelectedRows) {
                    gridviewTable.Rows.Remove(gridRow);
                }

                gridviewTable.ClearSelection();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private string event_GenerateTableFilterQueryConditions()
        {
            StringBuilder queryConditions = new StringBuilder();
            int testCaseIdCount = 1;

            foreach (DataGridViewRow gridRow in gridviewTable.Rows) {

                var testCaseID = gridRow.Cells["TEST_CASE_ID"];
                if (testCaseID.Value == null) { continue; }

                if (testCaseIdCount > 1) {
                    queryConditions.Append(" OR ");
                }

                queryConditions.Append("[TEST_CASE_ID] = '");
                queryConditions.Append(testCaseID.Value.ToString());
                queryConditions.Append("'");

                testCaseIdCount++;
            }

            return queryConditions.ToString();
        }

        private void event_EnableTableModificationControls(bool isEnabled)
        {
            dropdownColumns.Enabled = isEnabled;
            textboxDataValue.Enabled = isEnabled;
            buttonApplyFilter.Enabled = isEnabled;
            buttonClearFilter.Enabled = isEnabled;

            buttonLoadTable.Enabled = isEnabled;
            buttonRemoveSelections.Enabled = isEnabled;

            radioChrome.Enabled = isEnabled;
            radioFirefox32.Enabled = isEnabled;
            radioFirefox64.Enabled = isEnabled;
            radioIE32.Enabled = isEnabled;
            radioIE64.Enabled = isEnabled;
            checkboxDebugMode.Enabled = isEnabled;

            buttonStartExecution.Enabled = isEnabled;
            buttonStopExecution.Enabled = !isEnabled;
        }

        private string event_GenerateExecutionId()
        {
            startDateTime = DateTime.Now;
            string date = startDateTime.ToString("dd-MM-yyyy");
            string time = startDateTime.ToString("HH-mm-ss");
            string executionId = "E-" + date + "-" + time;

            return executionId;
        }

        private void event_GenerateMainTableInsertQueries()
        {
            foreach (DataGridViewRow gridRow in gridviewTable.Rows) {

                StringBuilder insertQuery = new StringBuilder();
                insertQuery.Append("INSERT INTO [MAIN] (");
                insertQuery.Append("[EXECUTION_ID], ");
                insertQuery.Append("[TEST_CASE_ID], ");
                insertQuery.Append("[TEST_NAME], ");
                insertQuery.Append("[SCRIPT_NAME], ");
                insertQuery.Append("[STATUS]) VALUES (");
                insertQuery.Append("'").Append(executionID).Append("', ");

                var testCaseID = gridRow.Cells["TEST_CASE_ID"].Value;

                if (testCaseID != null) {
                    testCaseList.Add(testCaseID.ToString());
                    insertQuery.Append("'");
                    insertQuery.Append(testCaseID.ToString());
                    insertQuery.Append("', ");
                }
                else {
                    continue;
                }

                var testName = gridRow.Cells["TEST_NAME"].Value;

                if (testCaseID != null) {
                    insertQuery.Append("'");
                    insertQuery.Append(testName.ToString());
                    insertQuery.Append("', ");
                }
                else {
                    insertQuery.Append("'', ");
                }

                var scriptName = gridRow.Cells["SCRIPT_NAME"].Value;

                if (testCaseID != null) {
                    insertQuery.Append("'");
                    insertQuery.Append(scriptName.ToString());
                    insertQuery.Append("', ");
                }
                else {
                    insertQuery.Append("'', ");
                }

                insertQuery.Append("'Skip')");
                insertQueryList.Add(insertQuery.ToString());
            }
        }

        private void event_RetrieveSelectedTestCaseId()
        {
            foreach (DataGridViewRow gridRow in gridviewTable.SelectedRows) {

                var testCaseID = gridRow.Cells["TEST_CASE_ID"].Value;

                if (testCaseID != null) {
                    testCaseList.Add(testCaseID.ToString());
                    break;
                } 
            }

            if (testCaseList.Count == 0) {

                var testCaseID = gridviewTable.Rows[0].Cells["TEST_CASE_ID"].Value;
                testCaseList.Add(testCaseID.ToString());
            }
        }

        private void event_GenerateExecutionTableInsertQuery()
        {
            string testDatabaseDirectory = settingsDictionary["TestDatabaseDirectory"];
            string testDatabasePath = testDatabaseDirectory + "\\TestCaseData.db";

            DatabaseConnector database;
            database = new DatabaseConnector(testDatabasePath);

            string machineName = Environment.MachineName;
            string startDate = startDateTime.ToString("dd/MM/yyyy");
            string startTime = startDateTime.ToString("hh.mm.ss tt");

            string tableName = "MAIN";
            string columnName = "TEST_CASE_ID";
            int totalTestCasesRunning = testCaseList.Count;
            int totalTestCases = database.event_RetrieveRecordCount(tableName, columnName);

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("INSERT INTO [EXECUTION] (");
            insertQuery.Append("[EXECUTION_ID], ");
            insertQuery.Append("[MACHINE_NAME], ");
            insertQuery.Append("[START_DATE], ");
            insertQuery.Append("[START_TIME], ");
            insertQuery.Append("[RAN_TEST_CASE_COUNT], ");
            insertQuery.Append("[TOTAL_TEST_CASE_COUNT]) VALUES (");
            insertQuery.Append("'").Append(executionID).Append("', ");
            insertQuery.Append("'").Append(machineName).Append("', ");
            insertQuery.Append("'").Append(startDate).Append("', ");
            insertQuery.Append("'").Append(startTime).Append("', ");
            insertQuery.Append("'").Append(totalTestCasesRunning).Append("', ");
            insertQuery.Append("'").Append(totalTestCases).Append("')");
            insertQueryList.Add(insertQuery.ToString());
        }

        private void event_GenerateExecutionDirectory()
        {
            string resultsDirectory = settingsDictionary["ResultsFileDirectory"];
            string executionDirectory = resultsDirectory + "\\" + executionID;
            string screenshotsDirectory = executionDirectory + "\\Screenshots";

            common.event_CreateDirectory(executionDirectory);
            common.event_CreateDirectory(screenshotsDirectory);
        }

        private void event_InsertQueriesIntoResultsDatabase()
        {
            string resultsDatabaseDirectory = settingsDictionary["ResultsDatabaseDirectory"];
            string resultsDatabasePath = resultsDatabaseDirectory + "\\TestCaseResults.db";

            DatabaseConnector database;
            database = new DatabaseConnector(resultsDatabasePath);
            database.event_ExecuteNonSelectListOfQueries(insertQueryList);
            database = null;
        }

        private void event_GenerateExecutionInformationXml()
        {
            var selectedBrowser = groupboxBrowsers.Controls.OfType<RadioButton>().
                FirstOrDefault(radio => radio.Checked);

            string debugModeOn;
            if (checkboxDebugMode.Checked) { debugModeOn = "Yes"; }
            else { debugModeOn = "No";  }

            string scriptsDirectory = settingsDictionary["ScriptsDirectory"];
            string testDatabaseDirectory = settingsDictionary["TestDatabaseDirectory"];
            string resultsDatabaseDirectory = settingsDictionary["ResultsDatabaseDirectory"];
            string resultsFileDirectory = settingsDictionary["ResultsFileDirectory"];
            string browserName = selectedBrowser.Text;

            Dictionary<string, string> executionDictionary;
            executionDictionary = new Dictionary<string, string>();
            executionDictionary.Add("ScriptsDirectory", scriptsDirectory);
            executionDictionary.Add("TestDatabaseDirectory", testDatabaseDirectory);
            executionDictionary.Add("ResultsDatabaseDirectory", resultsDatabaseDirectory);
            executionDictionary.Add("ResultsFileDirectory", resultsFileDirectory);
            executionDictionary.Add("BrowserName", browserName);
            executionDictionary.Add("ExecutionID", executionID);
            executionDictionary.Add("DebugModeOn", debugModeOn);

            string currentDirectory = common.event_GetCurrentDirectory();
            string setupDirectory = currentDirectory + "\\Resources\\Setup";
            string filePath = setupDirectory + "\\ExecutionInformation.xml";
            common.event_GenerateXml(executionDictionary, filePath, "Execution");
        }

        private void event_InitiateTestCasesExecution(ArrayList testCaseList)
        {
            Thread mainExecutionThread = new Thread(() => {

                foreach (string testCaseID in testCaseList) {

                    this.testCaseID = testCaseID;

                    noParameterDelegate displayCurrentTestCase;
                    displayCurrentTestCase = new noParameterDelegate(event_DisplayCurrentTestCase);
                    Invoke(displayCurrentTestCase);

                    event_ExecuteIndividualTestCase();
                    if (terminateExecution) { break; }
                }

                noParameterDelegate exeuctionComplete;
                exeuctionComplete = new noParameterDelegate(event_ExecutionComplete);
                Invoke(exeuctionComplete);
            });

            mainExecutionThread.Start();
        }

        private void event_DisplayCurrentTestCase()
        {
            labelExecutingTestCaseId.Text = "Currently Executing Test Case: " + testCaseID;
        }

        private void event_ExecuteIndividualTestCase()
        {
            Process engineProcess;
            engineProcess = common.event_CreateJarProcess(testCaseID);
            engineProcess.Start();

            while (!engineProcess.HasExited) {
                if (terminateExecution) { engineProcess.Kill(); }
                else { Thread.Sleep(1000); }
            }
        }

        private void event_ExecutionInProgress()
        {
            inProgress = true;
            terminateExecution = false;
            event_EnableTableModificationControls(false);
            formMain.event_EnableControlButtons(false);
        }

        private void event_ExecutionComplete()
        {
            inProgress = false;
            terminateExecution = true;
            event_UpdateExecutionEndDateTime();
            event_EnableTableModificationControls(true);
            formMain.event_EnableControlButtons(true);
            labelExecutingTestCaseId.Text = string.Empty;
        }

        private void event_UpdateExecutionEndDateTime()
        {
            string resultsDatabaseDirectory = settingsDictionary["ResultsDatabaseDirectory"];
            string resultsDatabasePath = resultsDatabaseDirectory + "\\TestCaseResults.db";

            DateTime endDateTime = DateTime.Now;
            string endDate = endDateTime.ToString("dd/MM/yyyy");
            string endTime = endDateTime.ToString("hh.mm.ss tt");

            StringBuilder updateQuery = new StringBuilder();
            updateQuery.Append("UPDATE [EXECUTION] SET ");
            updateQuery.Append("[END_DATE] = '");
            updateQuery.Append(endDate);
            updateQuery.Append("', ");
            updateQuery.Append("[END_TIME] = '");
            updateQuery.Append(endTime);
            updateQuery.Append("' WHERE [EXECUTION_ID] = '");
            updateQuery.Append(executionID);
            updateQuery.Append("'");

            DatabaseConnector database;
            database = new DatabaseConnector(resultsDatabasePath);
            database.event_OpenConnection();
            database.event_ExecutionNonSelectQuery(updateQuery.ToString());
            database.event_CloseConnection();
            database = null;
        }

        public bool event_InProgress { get => inProgress; }
    }
}