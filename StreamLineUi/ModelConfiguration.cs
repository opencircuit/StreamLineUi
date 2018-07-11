using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

namespace StreamLineUi
{
    internal class ModelConfiguration { }

    public partial class ControlConfiguration : UserControl
    {
        //***************************************************************************************************************
        // Initial Setup Methods
        //***************************************************************************************************************



        private void initialize_ChangeUiColor()
        {
            Color color = common.event_RetrieveUiColor(formMain.settingsInfo["UiColor"]);
            gridview.DefaultCellStyle.SelectionBackColor = color;
            common.event_ChangeButtonsColor(this, color);
        }

        private void initialize_ColumnList()
        {
            dropdownColumns.DataSource = testDatabase.event_RetrieveColumnList("MAIN");
        }

        private void initialize_BrowserList()
        {
            dropdownBrowsers.Items.Add("Chrome");
            dropdownBrowsers.Items.Add("Firefox 32-Bit");
            dropdownBrowsers.Items.Add("Firefox 64-Bit");
            dropdownBrowsers.Items.Add("Internet Explorer 32-Bit");
            dropdownBrowsers.Items.Add("Internet Explorer 64-Bit");
        }



        //***************************************************************************************************************
        // Action Events Handler Methods
        //***************************************************************************************************************



        private void event_LoadAllTestCases()
        {
            string query = "SELECT * FROM [Main] WHERE [Test_Case_ID] != 'Default'";
            gridview.DataSource = testDatabase.event_LoadTable(query);
        }

        private void event_InitializeExecutionSetup()
        {
            testCaseList.Clear();
            event_CreateExecutionXml();
            event_GenerateTestCaseList();
            if (testCaseList.Count == 0) { return; }
            if (dropdownBrowsers.Text.Length == 0) { return; }

            executionInProgress = true;
            event_EnableControls();
            event_InsertExecutionDetails();
            gridview.Refresh();
        }

        private void event_CreateExecutionXml()
        {
            string scriptsDirectory = Directory.GetCurrentDirectory() + "\\Resources\\Scripts\\";
            string scriptDirectory = scriptsDirectory + formMain.settingsInfo["ScriptName"];
            string executionSettingsPath = scriptDirectory + "\\ExecutionSettings.xml";

            Dictionary<string, string> executionSettings = formMain.settingsInfo;
            executionSettings.Add("ExecutionID", "E-" + DateTime.Now.ToString("yyMMdd-HHmmss"));
            executionSettings.Add("Browser", dropdownBrowsers.Text);
            executionSettings.Add("DebugMode", checkboxDebugMode.Checked.ToString());

            common.event_CreateXml(executionSettings, executionSettingsPath, "Settings");
        }

        private void event_GenerateTestCaseList()
        {
            int testCaseIdIndex = gridview.Columns["Test_Case_ID"].Index;
            int testNameIndex = gridview.Columns["Test_Name"].Index;
            int testTypeIndex = gridview.Columns["Test_Type"].Index;
            int statusIndex = gridview.Columns["Status"].Index;
            int urlIndex = gridview.Columns["Url"].Index;

            foreach (DataGridViewRow row in gridview.Rows) {

                string testCaseID = gridviewManager.event_RetrieveCellDataValue(row, testCaseIdIndex);
                string testName = gridviewManager.event_RetrieveCellDataValue(row, testNameIndex);
                string testType = gridviewManager.event_RetrieveCellDataValue(row, testTypeIndex);
                string url = gridviewManager.event_RetrieveCellDataValue(row, urlIndex);

                testCaseList.Add(testCaseID);
                if (checkboxDebugMode.Checked) { return; }
                event_InsertTestCaseToExecutionTable(testCaseID, testName, testType, url);
                row.Cells[statusIndex].Value = "Skipped";
            }
        }

        private void event_InsertTestCaseToExecutionTable(string testCaseID, string testName, string testType, string url)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO [Main] (");
            query.Append("[Execution_ID], ");
            query.Append("[Test_Case_ID], ");
            query.Append("[Test_Name], ");
            query.Append("[Test_Type], ");
            query.Append("[Script_Name], ");
            query.Append("[Status], ");
            query.Append("[Url], ");
            query.Append("[Failed_Step], ");
            query.Append("[Execution_Time], ");
            query.Append("[Results_Location]) ");
            query.Append("VALUES (");
            query.Append("'").Append(formMain.settingsInfo["ExecutionID"]).Append("', ");
            query.Append("'").Append(testCaseID).Append("', ");
            query.Append("'").Append(testName).Append("', ");
            query.Append("'").Append(testType).Append("', ");
            query.Append("'").Append(formMain.settingsInfo["ScriptName"]).Append("', ");
            query.Append("'").Append("Skipped").Append("', ");
            query.Append("'").Append(url).Append("', ");
            query.Append("'', ");
            query.Append("'0', ");
            query.Append("'')");

            resultsDatabase.event_ExecuteNonSelectQuery(query.ToString());
        }

        private void event_InsertExecutionDetails()
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO [Execution] (");
            query.Append("[Execution_ID], ");
            query.Append("[Machine_Name], ");
            query.Append("[Browser_Name], ");
            query.Append("[Start_Date], ");
            query.Append("[End_Date], ");
            query.Append("[Start_Time], ");
            query.Append("[End_Time], ");
            query.Append("[Ran_Test_Case_Count], ");
            query.Append("[Total_Test_Case_Count]) ");
            query.Append("VALUES (");
            query.Append("'").Append(formMain.settingsInfo["ExecutionID"]).Append("', ");
            query.Append("'").Append(common.event_GetComputerName()).Append("', ");
            query.Append("'").Append(formMain.settingsInfo["Browser"]).Append("', ");
            query.Append("'").Append(DateTime.Now.ToString("dd-MM-yyyy")).Append("', ");
            query.Append("'', ");
            query.Append("'").Append(DateTime.Now.ToString("hh:mm:ss tt")).Append("', ");
            query.Append("'', ");
            query.Append("'").Append(gridview.Rows.Count.ToString()).Append("', ");
            query.Append("'").Append(testDatabase.event_RetrieveRecordCount("Main", "Test_Case_ID")).Append("')");

            resultsDatabase.event_ExecuteNonSelectQuery(query.ToString());
        }

        private void event_StartExecution()
        {
            if (!executionInProgress) { return; }

            Thread thread = new Thread(() => {

                Thread.Sleep(1000);
                event_TestCaseExecutionLoop(formMain.settingsInfo["ScriptName"]);
                Thread.Sleep(1000);
                event_ExecutionEndDateTimeStamp();
                executionInProgress = false;
                Delegate controlDelegate = new Delegate(event_EnableControls);
                Invoke(controlDelegate);
            });

            thread.Start();
        }

        private void event_TestCaseExecutionLoop(string scriptName)
        {
            Delegate gridviewDelegate = new Delegate(event_RefreshGridview);

            for (int rowIndex = 0; rowIndex < testCaseList.Count; rowIndex++) {

                if (!executionInProgress) { break; }
                string testCaseID = (string)testCaseList[rowIndex];
                Process process = event_InitiateJarProcess(testCaseID, scriptName);
                event_MonitorProcessStatus(process);
                event_UpdateTestCaseStatus(rowIndex, testCaseID);
                Invoke(gridviewDelegate);
            }
        }

        private Process event_InitiateJarProcess(string testCaseID, string scriptName)
        {
            Process process = new Process();

            StringBuilder processArguments = new StringBuilder();
            processArguments.Append("-jar \"");
            processArguments.Append(Directory.GetCurrentDirectory());
            processArguments.Append("\\StreamLineEngine.jar\"");
            processArguments.Append(" \"").Append(testCaseID).Append("\"");
            processArguments.Append(" \"").Append(scriptName).Append("\"");

            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.UseShellExecute = true;
            processInfo.CreateNoWindow = true;
            processInfo.FileName = "java.exe";
            processInfo.Arguments = processArguments.ToString();
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo = processInfo;

            return process;
        }

        private void event_MonitorProcessStatus(Process process)
        {
            try {

                process.Start();

                while (!process.HasExited) {
                    if (!executionInProgress) { process.Kill(); }
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_RefreshGridview()
        {
            gridview.Refresh();
        }

        private void event_UpdateTestCaseStatus(int rowIndex, string testCaseID)
        {
            try {

                string query = "SELECT [Status] FROM [Main] "
                    + "WHERE [Execution_ID] = '" + formMain.settingsInfo["ExecutionID"] + "' "
                    + "AND [Test_Case_ID] = '" + testCaseID + "'";

                string status = resultsDatabase.event_SingleValueSelectQuery(query);
                int statusColumnIndex = gridview.Columns["Status"].Index;
                DataGridViewRow row = gridview.Rows[rowIndex];
                row.Cells[statusColumnIndex].Value = status;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_ExecutionEndDateTimeStamp()
        {
            string endDateQuery = "UPDATE [Execution] SET [End_Date] = '"
                + DateTime.Now.ToString("dd-MM-yyyy") + "' "
                + "WHERE [Execution_ID] = '" + formMain.settingsInfo["ExecutionID"] + "'";

            string endTimeQuery = "UPDATE [Execution] SET [End_Time] = '"
                + DateTime.Now.ToString("hh:mm:ss tt") + "' "
                + "WHERE [Execution_ID] = '" + formMain.settingsInfo["ExecutionID"] + "'";

            resultsDatabase.event_ExecuteNonSelectQuery(endDateQuery);
            resultsDatabase.event_ExecuteNonSelectQuery(endTimeQuery);
        }

        private void event_EnableControls()
        {
            bool isEnabled = !executionInProgress;

            buttonLoadTable.Enabled = isEnabled;
            buttonRemoveSelections.Enabled = isEnabled;
            buttonApplyFilter.Enabled = isEnabled;
            buttonClearFilter.Enabled = isEnabled;
            buttonStartExecution.Enabled = isEnabled;
            buttonStopExecution.Enabled = !isEnabled;

            dropdownColumns.Enabled = isEnabled;
            textboxDataValue.Enabled = isEnabled;
            dropdownBrowsers.Enabled = isEnabled;
            checkboxDebugMode.Enabled = isEnabled;

            formMain.event_EnableAllControlButtons(isEnabled);
        }
    }
}