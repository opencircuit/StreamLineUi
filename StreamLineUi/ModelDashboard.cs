using System.Collections;
using System.Data;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;
using System;

namespace StreamLineUi
{
    internal class ModelDashboard
    {
    }

    public partial class ControlDashboard : UserControl
    {
        private void initialize_ChooseUiColor()
        {
            string selectedColor = settingsDictionary["UiColor"];
            uiColor = common.event_RetrieveSpecifiedColor(selectedColor);
        }

        private void initialize_ChangeUiColor()
        {
            buttonLoadTestSet.BackColor = uiColor;
            buttonLoadTestCaseDetails.BackColor = uiColor;
            gridviewTable.DefaultCellStyle.SelectionBackColor = uiColor;
        }

        private void initialize_GaugeControls()
        {
            gaugePassedTests.Uses360Mode = true;
            gaugePassedTests.From = 0;
            gaugePassedTests.Base.FromColor = System.Windows.Media.Color.FromRgb(0, 221, 14);
            gaugePassedTests.Base.ToColor = System.Windows.Media.Color.FromRgb(1, 158, 12);

            gaugeFailedTests.Uses360Mode = true;
            gaugeFailedTests.From = 0;
            gaugeFailedTests.Base.FromColor = System.Windows.Media.Color.FromRgb(255, 0, 0);
            gaugeFailedTests.Base.ToColor = System.Windows.Media.Color.FromRgb(135, 0, 0);

            gaugeSkippedTests.Uses360Mode = true;
            gaugeSkippedTests.From = 0;
            gaugeSkippedTests.Base.FromColor = System.Windows.Media.Color.FromRgb(120, 120, 120);
            gaugeSkippedTests.Base.ToColor = System.Windows.Media.Color.FromRgb(100, 100, 100);

            gaugeTotalTests.Uses360Mode = true;
            gaugeTotalTests.From = 0;
            gaugeTotalTests.Base.FromColor = System.Windows.Media.Color.FromRgb(0, 168, 255);
            gaugeTotalTests.Base.ToColor = System.Windows.Media.Color.FromRgb(1, 105, 158);
        }

        private void initialize_TestExecutionIds()
        {
            string tableName = "EXECUTION";
            string columnName = "EXECUTION_ID";

            ArrayList executionIdList = new ArrayList();
            executionIdList = database.event_SingleColumnSelectQuery(tableName, columnName);
            dropdownExecutedID.DataSource = executionIdList;
        }

        private void event_ResetStatusCount()
        {
            countPassedTests = 0;
            countFailedTests = 0;
            countSkippedTests = 0;
            countTotalTestsRan = 0;
            countTotalTests = 0;
        }

        private void event_LoadMainTableData(string executionID)
        {
            string tableName = "MAIN";
            string filterCondition = "EXECUTION_ID = '" + executionID + "'";

            DataTable dataTable;
            dataTable = database.event_LoadFilteredTable(tableName, filterCondition);
            gridviewTable.DataSource = dataTable;
        }

        private void event_LoadExecutionDetails(string executionID)
        {
            string tableName = "EXECUTION";
            string filterCondition = "EXECUTION_ID = '" + executionID + "'";

            DataTable dataTable;
            dataTable = database.event_LoadFilteredTable(tableName, filterCondition);

            string machineName = dataTable.Rows[0]["MACHINE_NAME"].ToString();
            string startDate = dataTable.Rows[0]["START_DATE"].ToString();
            string startTime = dataTable.Rows[0]["START_TIME"].ToString();
            string endDate = dataTable.Rows[0]["END_DATE"].ToString();
            string endTime = dataTable.Rows[0]["END_TIME"].ToString();
            string countTotalTestsRan = dataTable.Rows[0]["RAN_TEST_CASE_COUNT"].ToString();
            string countTotalTests = dataTable.Rows[0]["TOTAL_TEST_CASE_COUNT"].ToString();

            labelMachineName.Text = machineName;
            labelTotalTestsRanCount.Text = countTotalTestsRan;
            labelTotalTestsAvailableCount.Text = countTotalTests;
            labelStartDate.Text = startDate;
            labelStartTime.Text = startTime;
            labelEndDate.Text = endDate;
            labelEndTime.Text = endTime;
            this.countTotalTestsRan = Int32.Parse(countTotalTestsRan);
            this.countTotalTests = Int32.Parse(countTotalTests);
        }

        private void event_LoadStatusCount()
        {
            foreach (DataGridViewRow gridRow in gridviewTable.Rows) {

                var status = gridRow.Cells["STATUS"].Value;

                if (status != null) {
                    event_IncrementStatusCount(status.ToString());
                }
                else {
                    continue;
                }
            }
        }

        private void event_IncrementStatusCount(string status)
        {
            status = status.ToUpper();

            if (status.Equals("PASS")) { countPassedTests++; }
            else if (status.Equals("FAIL")) { countFailedTests++; }
            else if (status.Equals("SKIP")) { countSkippedTests++; }
        }

        private void event_SetTestCasesPassedGauge()
        {
            gaugePassedTests.To = countTotalTestsRan;
            gaugePassedTests.Value = countPassedTests;
        }

        private void event_SetTestCasesFailedGauge()
        {
            gaugeFailedTests.To = countTotalTestsRan;
            gaugeFailedTests.Value = countFailedTests;
        }

        private void event_SetTestCasesSkippedGauge()
        {
            gaugeSkippedTests.To = countTotalTestsRan;
            gaugeSkippedTests.Value = countSkippedTests;
        }

        private void event_SetTestCasesTotalGauge()
        {
            gaugeTotalTests.To = countTotalTests;
            gaugeTotalTests.Value = countTotalTestsRan;
        }

        private void event_SetTestCasesExecutionTimeChart()
        {
            chartExecutionTime.Series.Clear();
            chartExecutionTime.AxisX.Clear();
            chartExecutionTime.AxisY.Clear();

            string executionID = dropdownExecutedID.Text;
            int size = countPassedTests + countFailedTests;
            double[] executionTimes;
            executionTimes = database.event_RetrieveExecutionTimes(executionID, size);
            
            ChartValues<double> loadTimeChartValues = new ChartValues<double>(executionTimes);
            chartExecutionTime.Series.Add(new StepLineSeries { Values = loadTimeChartValues });
            chartExecutionTime.AxisX.Add(new Axis { Title = "Test Cases" });
            chartExecutionTime.AxisY.Add(new Axis { Title = "Execution Time In Seconds" });
        }
    }
}