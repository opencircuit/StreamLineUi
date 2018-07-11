using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StreamLineUi
{
    public partial class ControlConfiguration : UserControl
    {
        private FormMain formMain;
        private Common common;
        private DatabaseManager testDatabase;
        private DatabaseManager resultsDatabase;
        private GridviewManager gridviewManager;
        private delegate void Delegate();

        private ArrayList testCaseList;
        private bool executionInProgress;

        public ControlConfiguration(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            common = new Common();
            testDatabase = this.formMain.testDatabase;
            resultsDatabase = this.formMain.resultDatabase;
            gridviewManager = new GridviewManager(testDatabase);
            testCaseList = new ArrayList();
            executionInProgress = false;
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            initialize_ChangeUiColor();
            initialize_ColumnList();
            initialize_BrowserList();
            event_LoadAllTestCases();
        }

        private void action_ApplyFilter(object sender, EventArgs e)
        {
            if (dropdownColumns.Text.Length == 0) { return; }
            string queryCondition = "[" + dropdownColumns.Text + "] = '" + textboxDataValue.Text + "'";
            gridview.DataSource = testDatabase.event_LoadFilteredTable("Main", queryCondition);
        }

        private void action_LoadTable(object sender, EventArgs e)
        {
            event_LoadAllTestCases();
        }

        private void action_RemoveSelections(object sender, EventArgs e)
        {
            gridviewManager.event_DeleteRows(gridview);
        }

        private void action_ClearFilter(object sender, EventArgs e)
        {
            event_LoadAllTestCases();
        }

        private void action_DebugModeChanged(object sender, EventArgs e)
        {
            labelDebugModeDescription.Visible = checkboxDebugMode.Checked;
        }

        private void action_StartExecution(object sender, EventArgs e)
        {
            event_InitializeExecutionSetup();
            event_EnableControls();
            event_StartExecution();
        }

        private void action_StopExecution(object sender, EventArgs e)
        {
            executionInProgress = false;
        }
    }
}