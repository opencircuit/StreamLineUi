using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace StreamLineUi
{
    public partial class ControlDashboard : UserControl
    {
        private Common common = new Common();
        private DatabaseConnector database;

        private Dictionary<string, string> settingsDictionary;
        private Color uiColor;

        private int countPassedTests;
        private int countFailedTests;
        private int countSkippedTests;
        private int countTotalTestsRan;
        private int countTotalTests;

        public ControlDashboard(Dictionary<string, string> settingsDictionary)
        {
            InitializeComponent();
            this.settingsDictionary = settingsDictionary;
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            string databaseDirectory = settingsDictionary["ResultsDatabaseDirectory"];
            string databasePath = databaseDirectory + "\\TestCaseResults.db";
            database = new DatabaseConnector(databasePath);

            initialize_ChooseUiColor();
            initialize_ChangeUiColor();
            initialize_GaugeControls();
            initialize_TestExecutionIds();
        }

        private void action_LoadSelectedExecutionDetails(object sender, EventArgs e)
        {
            string executionID = dropdownExecutedID.Text;

            if (executionID.Length > 0) {

                labelExecutionID.Text = executionID;
                event_ResetStatusCount();
                event_LoadMainTableData(executionID);
                event_LoadExecutionDetails(executionID);
                event_LoadStatusCount();
                event_SetTestCasesPassedGauge();
                event_SetTestCasesFailedGauge();
                event_SetTestCasesSkippedGauge();
                event_SetTestCasesTotalGauge();
                event_SetTestCasesExecutionTimeChart();
            }
        }

        private void action_LoadDetailedReport(object sender, EventArgs e)
        {
            try {

                string errorMessage = "The detailed report for this test case execution cannot be found.";
                int columnIndex = gridviewTable.Columns.IndexOf(gridviewTable.Columns["RESULTS_LOCATION"]);
                DataGridViewRow gridRow = gridviewTable.SelectedRows[0];

                var file = gridRow.Cells[columnIndex].Value;

                if (file == null) {
                    MessageBox.Show(errorMessage);
                    return;
                }

                string filePath = gridRow.Cells[columnIndex].Value.ToString();

                if (File.Exists(filePath)) {
                    Process.Start(filePath);
                }
                else {
                    MessageBox.Show(errorMessage);
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}