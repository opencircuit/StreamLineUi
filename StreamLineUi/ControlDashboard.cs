using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace StreamLineUi
{
    public partial class ControlDashboard : UserControl
    {
        private FormMain formMain;
        private Common common;
        private DatabaseManager database;
        private GridviewManager gridviewManager;

        private int countPassedTests;
        private int countFailedTests;
        private int countSkippedTests;
        private int countTestsRan;

        public ControlDashboard(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            common = new Common();
            database = this.formMain.resultDatabase;
            gridviewManager = new GridviewManager(database);
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            initialize_ChangeUiColor();
            initialize_GuageAndChartBackColor();
            initialize_GaugeSettings();
            initialize_GaugeColors();
            event_TestExecutionIds();
        }

        private void action_LoadExecution(object sender, EventArgs e)
        {
            string executionID = dropdownExecutionIds.Text;
            if (executionID.Length == 0) { return; }

            labelExecutionId.Text = executionID;
            event_ResetStatusCount();
            event_LoadMainTableData(executionID);
            event_LoadExecutionDetails(executionID);
            event_LoadStatusCount();
            event_SetTestCasesPassedGauge();
            event_SetTestCasesFailedGauge();
            event_SetTestCasesSkippedGauge();
            event_SetTestCasesExecutionTimeChart();
        }

        private void action_ReloadExecutionIdList(object sender, EventArgs e)
        {
            event_TestExecutionIds();
        }

        private void action_DeleteLoadedExecution(object sender, EventArgs e)
        {
            string executionID = labelExecutionId.Text;
            if (executionID.Length == 0) { return; }

            string mainDeleteQuery = "DELETE FROM [Main] WHERE [Execution_ID] = '" + executionID + "'";
            string executionDeleteQuery = "DELETE FROM [Execution] WHERE [Execution_ID] = '" + executionID + "'";

            database.event_ExecuteNonSelectQuery(mainDeleteQuery);
            database.event_ExecuteNonSelectQuery(executionDeleteQuery);
            event_TestExecutionIds();
        }

        private void action_LoadDetailedReport(object sender, EventArgs e)
        {
            int columnIndex = gridview.Columns.IndexOf(gridview.Columns["Results_Location"]);
            string filePath = gridview.SelectedRows[0].Cells[columnIndex].Value.ToString();

            if (File.Exists(filePath)) { Process.Start(filePath); }
            else { MessageBox.Show("The detailed report for this test case execution cannot be found."); }
        }

        private void action_LaunchHtmlReport(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0) { return; }

            DataGridViewRow row = gridview.SelectedRows[0];
            int columnIndex = gridview.Columns["Results_Location"].Index;
            string filePath = gridviewManager
                .event_RetrieveCellDataValue
                (gridview.SelectedRows[0],
                gridview.Columns["Results_Location"].Index);

            if (File.Exists(filePath)) { Process.Start(filePath); }
            else { MessageBox.Show("HTML results file could not be found."); }            
        }
    }
}