using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StreamLineUi
{
    public partial class ControlConfiguration : UserControl
    {
        private Common common = new Common();
        private FormMain formMain;

        private Dictionary<string, string> settingsDictionary;
        private ArrayList testCaseList = new ArrayList();
        private ArrayList insertQueryList = new ArrayList();
        private Color uiColor;
        private DateTime startDateTime;
        private delegate void noParameterDelegate();

        private string executionID;
        private string testCaseID;
        private bool inProgress;
        private bool terminateExecution;

        public ControlConfiguration(FormMain formMain, Dictionary<string, string> settingsDictionary)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.settingsDictionary = settingsDictionary;
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            inProgress = false;
            initialize_ChooseUiColor();
            initialize_ChangeUiColor();
            initialize_ColumnList();
        }

        private void action_ApplyFilter(object sender, EventArgs e)
        {
            string testDatabaseDirectory = settingsDictionary["TestDatabaseDirectory"];
            string testDatabasePath = testDatabaseDirectory + "\\TestCaseData.db";
            string columnName = dropdownColumns.Text;

            if (columnName.Length > 0) {

                string dataValue = textboxDataValue.Text;
                string queryConditions = "[" + columnName + "] = '" + dataValue + "'";
                string tableName = "MAIN";

                DatabaseConnector database;
                database = new DatabaseConnector(testDatabasePath);

                DataTable dataTable;
                dataTable = database.event_LoadFilteredTable(tableName, queryConditions);
                gridviewTable.DataSource = dataTable;
            }
        }

        private void action_LoadTable(object sender, EventArgs e)
        {
            event_LoadAllTestCases();
        }

        private void action_RemoveSelections(object sender, EventArgs e)
        {
            event_RemoveSelectedTestCasesFromList();
            string queryCondition = event_GenerateTableFilterQueryConditions();
            string tableName = "MAIN";

            string testDatabaseDirectory = settingsDictionary["TestDatabaseDirectory"];
            string testDatabasePath = testDatabaseDirectory + "\\TestCaseData.db";

            DatabaseConnector database;
            database = new DatabaseConnector(testDatabasePath);

            DataTable dataTable;
            dataTable = database.event_LoadFilteredTable(tableName, queryCondition);
            gridviewTable.DataSource = dataTable;
        }

        private void action_ClearFilter(object sender, EventArgs e)
        {
            event_LoadAllTestCases();
        }

        private void action_DebugModeChanged(object sender, EventArgs e)
        {
            if (checkboxDebugMode.Checked) {
                labelDebugModeDescription.Visible = true;
            }
            else {
                labelDebugModeDescription.Visible = false;
            }
        }

        private void action_StartExecution(object sender, EventArgs e)
        {
            if (gridviewTable.Rows.Count == 0) { return; }
            bool debugMode = checkboxDebugMode.Checked;
            testCaseList.Clear();
            insertQueryList.Clear();
            event_ExecutionInProgress();
            event_ExecutionInProgress();

            if (!debugMode) {

                executionID = event_GenerateExecutionId();
                event_GenerateMainTableInsertQueries();
                event_GenerateExecutionTableInsertQuery();
                event_GenerateExecutionDirectory();
                event_InsertQueriesIntoResultsDatabase();
            }
            else {
                event_RetrieveSelectedTestCaseId();
            }

            event_GenerateExecutionInformationXml();
            event_InitiateTestCasesExecution(testCaseList);
        }

        private void action_StopExecution(object sender, EventArgs e)
        {
            event_ExecutionComplete();
        }
    }
}
