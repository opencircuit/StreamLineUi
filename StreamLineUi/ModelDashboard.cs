using System.Data;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Drawing;

namespace StreamLineUi
{
    internal class ModelDashboard { }

    public partial class ControlDashboard : UserControl
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

        private void initialize_GuageAndChartBackColor()
        {
            gaugePassedTests.BackColor = Color.White;
            gaugeFailedTests.BackColor = Color.White;
            gaugeSkippedTests.BackColor = Color.White;
            chartExecutionTime.BackColor = Color.White;
        }

        private void initialize_GaugeSettings()
        {
            gaugePassedTests.Uses360Mode = true;
            gaugePassedTests.From = 0;

            gaugeFailedTests.Uses360Mode = true;
            gaugeFailedTests.From = 0;

            gaugeSkippedTests.Uses360Mode = true;
            gaugeSkippedTests.From = 0;
        }

        private void initialize_GaugeColors()
        {
            gaugePassedTests.Base.FromColor = System.Windows.Media.Color.FromRgb(0, 221, 14);
            gaugePassedTests.Base.ToColor = System.Windows.Media.Color.FromRgb(1, 158, 12);

            gaugeFailedTests.Base.FromColor = System.Windows.Media.Color.FromRgb(255, 0, 0);
            gaugeFailedTests.Base.ToColor = System.Windows.Media.Color.FromRgb(135, 0, 0);

            gaugeSkippedTests.Base.FromColor = System.Windows.Media.Color.FromRgb(120, 120, 120);
            gaugeSkippedTests.Base.ToColor = System.Windows.Media.Color.FromRgb(100, 100, 100);
        }



        //***************************************************************************************************************
        // Action Events Handler Methods
        //***************************************************************************************************************



        private void event_TestExecutionIds()
        {
            dropdownExecutionIds.DataSource = database
                .event_SingleColumnSelectQuery("Execution", "Execution_ID");
        }

        private void event_ResetStatusCount()
        {
            countPassedTests = 0;
            countFailedTests = 0;
            countSkippedTests = 0;
            countTestsRan = 0;
        }

        private void event_LoadMainTableData(string executionID)
        {
            string tableName = "Main";
            string filterCondition = "Execution_ID = '" + executionID + "'";
            gridview.DataSource = database.event_LoadFilteredTable(tableName, filterCondition);
        }

        private void event_LoadExecutionDetails(string executionID)
        {
            string tableName = "Execution";
            string filterCondition = "Execution_ID = '" + executionID + "'";

            DataTable dataTable;
            dataTable = database.event_LoadFilteredTable(tableName, filterCondition);           

            labelMachineName.Text = dataTable.Rows[0]["Machine_Name"].ToString();
            labelBrowserName.Text = dataTable.Rows[0]["Browser_Name"].ToString();
            labelStartDate.Text = dataTable.Rows[0]["Start_Date"].ToString();
            labelEndDate.Text = dataTable.Rows[0]["End_Date"].ToString();
            labelStartTime.Text = dataTable.Rows[0]["Start_Time"].ToString();
            labelEndTime.Text = dataTable.Rows[0]["End_Time"].ToString();

            countTestsRan = Int32.Parse(dataTable.Rows[0]["Ran_Test_Case_Count"].ToString());
            labelTotalTestsRanCount.Text = countTestsRan.ToString();
            labelTotalTestsAvailableCount.Text = dataTable.Rows[0]["Total_Test_Case_Count"].ToString();
        }

        private void event_LoadStatusCount()
        {
            int statusColumnIndex = gridview.Columns["Status"].Index;

            foreach (DataGridViewRow row in gridview.Rows) {
                event_IncrementStatusCount(gridviewManager
                    .event_RetrieveCellDataValue(row, statusColumnIndex));
            }
        }

        private void event_IncrementStatusCount(string status)
        {
            switch (status) {

                case "Passed":
                    countPassedTests++;
                    break;

                case "Failed":
                    countFailedTests++;
                    break;

                default:
                    countSkippedTests++;
                    break;
            }
        }

        private void event_SetTestCasesPassedGauge()
        {
            gaugePassedTests.To = countTestsRan;
            gaugePassedTests.Value = countPassedTests;
        }

        private void event_SetTestCasesFailedGauge()
        {
            gaugeFailedTests.To = countTestsRan;
            gaugeFailedTests.Value = countFailedTests;
        }

        private void event_SetTestCasesSkippedGauge()
        {
            gaugeSkippedTests.To = countTestsRan;
            gaugeSkippedTests.Value = countSkippedTests;
        }

        private void event_SetTestCasesExecutionTimeChart()
        {
            chartExecutionTime.Series.Clear();
            chartExecutionTime.AxisX.Clear();
            chartExecutionTime.AxisY.Clear();

            ChartValues<double> loadTimeChartValues = new ChartValues<double>(event_RetrieveExecutionTimes());
            chartExecutionTime.Series.Add(new StepLineSeries { Values = loadTimeChartValues });
            chartExecutionTime.AxisX.Add(new Axis { Title = "Test Cases" });
            chartExecutionTime.AxisY.Add(new Axis { Title = "Execution Time In Seconds" });
        }

        private double[] event_RetrieveExecutionTimes()
        {
            double[] executionTimes = new double[gridview.Rows.Count];

            try {

                int columnIndex = gridview.Columns["Execution_Time"].Index;

                for (int rowIndex = 0; rowIndex < gridview.Rows.Count; rowIndex++) {

                    double time = event_RetrieveTestCaseExecutionTime(columnIndex, rowIndex);
                    executionTimes[rowIndex] = time;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return executionTimes;
        }

        private double event_RetrieveTestCaseExecutionTime(int columnIndex, int rowIndex)
        {
            double time;

            try {

                DataGridViewRow row = gridview.Rows[rowIndex];
                Double.TryParse(gridviewManager.event_RetrieveCellDataValue(row, columnIndex), out time);
            }
            catch (Exception ex) {
                time = 0;
                MessageBox.Show(ex.Message);
            }

            return time;
        }
    }
}