using System;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace StreamLineUi
{
    internal class ModelDataGenerator { }

    public partial class ControlDataGenerator : UserControl
    {
        //***************************************************************************************************************
        // Initial Setup Methods
        //***************************************************************************************************************



        private void initialize_ChangeUiColor()
        {
            Color color = common.event_RetrieveUiColor(formMain.settingsInfo["UiColor"]);
            gridviewDefaultTable.DefaultCellStyle.SelectionBackColor = color;
            gridviewCustomTable.DefaultCellStyle.SelectionBackColor = color;
            common.event_ChangeButtonsColor(this, color);
        }

        private void initialize_GridviewColumns(DataGridView gridview)
        {
            gridview.Columns.Add("TableName", "Table Name");
            gridview.Columns.Add("ColumnName", "Column Name");
            gridview.Columns.Add("DataValue", "Data Value");
        }

        private void initialize_ReadOnlyColumns()
        {
            gridviewCustomTable.Columns["TableName"].ReadOnly = true;
            gridviewCustomTable.Columns["ColumnName"].ReadOnly = true;
        }

        private void initialize_LoadDefaultUrl()
        {
            string query = "SELECT [Url] FROM [Main] WHERE [Test_Case_ID] = 'Default'";
            textboxEnvironmentUrl.Text = database.event_SingleValueSelectQuery(query);
        }



        //***************************************************************************************************************
        // Action Events Handler Methods
        //***************************************************************************************************************



        private void event_LoadDefaultValuesDataTable()
        {
            gridviewManager.event_LoadDatabaseSchema(gridviewDefaultTable);
        }

        private void event_GenerateTestCase(string testCaseID)
        {
            Thread thread = new Thread(() => {

                ArrayList tableList = database.event_RetrieveTableList();
                string queryCondition = " WHERE [Test_Case_ID] = '" + testCaseID + "'";

                event_InsertTestCaseIntoEachTable(tableList, testCaseID);
                event_UpdateMainTable(testCaseID, queryCondition);
                event_UpdateTestCase(testCaseID, queryCondition);

                Thread.Sleep(1000);
                Delegate controlDelegate = new Delegate(event_EnableGenerateTestCaseButton);
                Invoke(controlDelegate);
            });

            thread.Start();
        }

        private void event_InsertTestCaseIntoEachTable(ArrayList tableList, string testCaseID)
        {
            foreach (string tableName in tableList) {

                ArrayList columnList = database.event_RetrieveColumnList(tableName);
                string query = event_GenerateInsertQuery(tableName, columnList, testCaseID);
                database.event_ExecuteNonSelectQuery(query);
            }
        }

        private string event_GenerateInsertQuery(string tableName, ArrayList columnList, string testCaseID)
        {
            StringBuilder query = new StringBuilder();

            try {

                string insertColumns = event_RetrieveInsertQueryColumns(columnList);
                string selectColumns = event_RetrieveSelectQueryColumns(columnList);

                query.Append("INSERT INTO [").Append(tableName).Append("] (");
                query.Append(insertColumns).Append(") SELECT ");
                query.Append("'").Append(testCaseID).Append("'");
                if (selectColumns.Length > 0) { query.Append(", "); }
                query.Append(selectColumns).Append(" FROM ");
                query.Append("[").Append(tableName).Append("] ");
                query.Append("WHERE [Test_Case_ID] = 'Default'");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return query.ToString();
        }

        private string event_RetrieveInsertQueryColumns(ArrayList columnList)
        {
            StringBuilder insertColumns = new StringBuilder();

            try {

                for (int columnIndex = 0; columnIndex < columnList.Count; columnIndex++) {

                    string column = (string)columnList[columnIndex];
                    insertColumns.Append("[").Append(column).Append("]");
                    if (columnIndex < (columnList.Count - 1)) { insertColumns.Append(", "); }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return insertColumns.ToString();
        }

        private string event_RetrieveSelectQueryColumns(ArrayList columnList)
        {
            StringBuilder selectColumns = new StringBuilder();

            try {

                for (int columnIndex = 0; columnIndex < columnList.Count; columnIndex++) {

                    string column = (string)columnList[columnIndex];
                    if (column.Equals("Test_Case_ID")) { continue; }
                    selectColumns.Append("[").Append(column).Append("]");
                    if (columnIndex < (columnList.Count - 1)) { selectColumns.Append(", "); }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return selectColumns.ToString();
        }

        private void event_UpdateMainTable(string testCaseID, string queryCondition)
        {
            string testNameQuery = "UPDATE [Main] SET [Test_Name] = '" + textboxTestName.Text + "'" + queryCondition;
            string testTypeQuery = "UPDATE [Main] SET [Test_Type] = '" + textboxTestType.Text + "'" + queryCondition;

            string scriptNameQuery = "UPDATE [Main] SET [Script_Name] = '" +
                formMain.settingsInfo["ScriptName"] + "'" + queryCondition;

            string statusQuery = "UPDATE [Main] SET [Status] = 'No Run'" + queryCondition;

            string urlStatus = "UPDATE [Main] SET [Url] = '" + 
                textboxEnvironmentUrl.Text + "'" + queryCondition;

            string customValueQuery = "UPDATE [Main] SET [Custom_Value] = '" + 
                textboxCustomValue.Text + "'" + queryCondition;

            database.event_ExecuteNonSelectQuery(testNameQuery);
            database.event_ExecuteNonSelectQuery(testTypeQuery);
            database.event_ExecuteNonSelectQuery(scriptNameQuery);
            database.event_ExecuteNonSelectQuery(statusQuery);
            database.event_ExecuteNonSelectQuery(urlStatus);
            database.event_ExecuteNonSelectQuery(customValueQuery);
        }

        private void event_UpdateTestCase(string testCaseID, string queryCondition)
        {
            foreach (DataGridViewRow row in gridviewCustomTable.Rows) {

                string tableName = gridviewManager
                    .event_RetrieveCellDataValue(row, gridviewCustomTable.Columns["TableName"].Index);
                string columnName = gridviewManager
                    .event_RetrieveCellDataValue(row, gridviewCustomTable.Columns["ColumnName"].Index);
                string dataValue = gridviewManager
                    .event_RetrieveCellDataValue(row, gridviewCustomTable.Columns["DataValue"].Index);

                string query = "UPDATE [" + tableName + "] " +
                    "SET [" + columnName + "] = '" + dataValue + "'" + queryCondition;

                database.event_ExecuteNonSelectQuery(query);
            }
        }

        private void event_EnableGenerateTestCaseButton()
        {
            buttonGenerateTestCase.Enabled = true;
        }
    }
}