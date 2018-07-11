using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StreamLineUi
{
    internal class ModelDatabaseEditor { }

    public partial class ControlDatabaseEditor : UserControl
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

        private void initialize_GridviewColumns()
        {
            gridview.Columns.Add("TableName", "Table Name");
            gridview.Columns.Add("ColumnName", "Column Name");
            gridview.Columns.Add("DefaultValue", "Default Value");
        }

        private void initialize_TableList()
        {
            ArrayList tableList = database.event_RetrieveTableList();

            foreach (string tableName in tableList) {
                dropdownTableList.Items.Add(tableName);
            }
        }



        //***************************************************************************************************************
        // Action Events Handler Methods
        //***************************************************************************************************************



        private string event_RetrieveName(string buttonText)
        {
            string labelText = "Name:";
            FormDataRetrieval dataRetrieval;
            dataRetrieval = new FormDataRetrieval(formMain.settingsInfo["UiColor"], labelText, buttonText, String.Empty);
            DialogResult dialogResult = dataRetrieval.ShowDialog();

            if (dialogResult != DialogResult.OK) { return String.Empty; }
            else { return dataRetrieval.UserSpecifiedDataValue.Replace(" ", "_"); }
        }

        private void event_CreateOrDropTable(Button button, string tableName)
        {
            bool querySuccessful;

            if (button.Text.Equals("Create Table")) {

                querySuccessful = database.event_CreateTable(tableName);
                if (!querySuccessful) { return; }
                dropdownTableList.Items.Add(tableName);
            }
            else {

                querySuccessful = database.event_DropTable(tableName);
                if (!querySuccessful) { return; }
                dropdownTableList.Items.Remove(tableName);
            }

            gridviewManager.event_LoadDatabaseSchema(gridview);
        }

        private bool event_ValidTableValue(string tableName)
        {
            string selectTable = "The provided table name is invalid.";
            string mainTable = "Cannot add/delete the 'Main' table";

            if (tableName.Length == 0) { MessageBox.Show(selectTable); return false; }
            if (tableName.ToLower().Equals("main")) { MessageBox.Show(mainTable); return false; }

            return true;
        }

        private bool event_ValidColumnValue(string columnName)
        {
            string columnNameLength = "The provided column name is invalid.";
            string testCaseColumn = "Cannot add/delete the 'Test_Case_ID' column.'";

            if (columnName.Length == 0) { MessageBox.Show(columnNameLength); return false; }
            if (columnName.ToLower().Equals("test_case_id")) { MessageBox.Show(testCaseColumn); return false; }

            return true;
        }

        private void event_AddOrDeleteColumn(Button button, string tableName, string columnName, string dataValue)
        {
            bool querySuccessful;
            if (button.Text.Equals("Add Column")) { querySuccessful = database.event_AddColumn(tableName, columnName, dataValue); }
            else { querySuccessful = database.event_DeleteColumn(tableName, columnName); }

            if (!querySuccessful) { return; }
            gridviewManager.event_LoadDatabaseSchema(gridview);
        }

        private void event_FindFilteredColumnInTable(string tableName, string columnName)
        {
            string query = "SELECT * FROM [" + tableName + "] WHERE [Test_Case_ID] = 'Default'";
            DataTable dataTable = database.event_LoadTable(query);

            foreach (DataColumn column in dataTable.Columns) {

                if (!column.ColumnName.ToLower().Contains(columnName.ToLower())) { continue; }
                string dataValue = dataTable.Rows[0][column.ColumnName].ToString();
                string[] row = new string[] { tableName, column.ColumnName, dataValue };
                gridview.Rows.Add(row);
            }
        }
    }
}