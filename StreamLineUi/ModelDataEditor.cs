using System;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace StreamLineUi
{
    internal class ModelDataEditor { }

    public partial class ControlDataEditor : UserControl
    {
        private void initialize_ChooseUiColor()
        {
            string selectedColor = settingsDictionary["UiColor"];
            uiColor = common.event_RetrieveSpecifiedColor(selectedColor);
        }

        private void initialize_ChangeUiColor()
        {
            buttonLoadTable.BackColor = uiColor;
            buttonCreateTable.BackColor = uiColor;
            buttonDeleteTable.BackColor = uiColor;
            buttonEditTable.BackColor = uiColor;
            buttonSaveTable.BackColor = uiColor;
            buttonDeleteTestCase.BackColor = uiColor;
            buttonAddColumn.BackColor = uiColor;
            buttonDeleteColumn.BackColor = uiColor;
            gridviewTable.DefaultCellStyle.SelectionBackColor = uiColor;
        }

        private void initialize_DatabaseMapping()
        {
            try {

                tableList = database.event_RetrieveTableList();
                tableList.Remove("");
                initialize_TableSchemaAnalysis();

                foreach (string tableName in tableList) {
                    dropdownTableList.Items.Add(tableName);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void initialize_TableSchemaAnalysis()
        {
            ArrayList blankList = new ArrayList();
            blankList.Add("");

            tableColumnDictionary.Add("", blankList);

            for (int tableIndex = 1; tableIndex < tableList.Count; tableIndex++) {

                string tableName = (string)tableList[tableIndex];

                ArrayList columnList = new ArrayList();
                columnList = database.event_RetrieveColumnList(tableName);
                columnList.Remove("");

                tableColumnDictionary.Add(tableName, columnList);
            }
        }

        private void event_EnableModificationControls(bool isEnabled)
        {
            dropdownTableList.Enabled = isEnabled;
            buttonLoadTable.Enabled = isEnabled;
            buttonCreateTable.Enabled = isEnabled;
            buttonDeleteTable.Enabled = isEnabled;
            buttonEditTable.Enabled = isEnabled;
            buttonSaveTable.Enabled = !isEnabled;
            buttonDeleteTestCase.Enabled = isEnabled;

            textboxColumnName.Text = "";
            textboxColumnName.Enabled = isEnabled;
            buttonAddColumn.Enabled = isEnabled;
            buttonDeleteColumn.Enabled = isEnabled;

            gridviewTable.ReadOnly = isEnabled;
        }

        private void event_LoadTable(string tableName)
        {
            DataTable dataTable;
            dataTable = database.event_LoadTable(tableName);

            gridviewTable.DataSource = dataTable;
            event_EnableModificationControls(true);
        }

        private void event_GenerateNewTable(string tableName)
        {
            try {

                if (!dropdownTableList.Items.Contains(tableName)) {

                    database.event_CreateTable(tableName);
                    ArrayList columnList = new ArrayList();
                    columnList.Add("TEST_CASE_ID");
                    dropdownTableList.Items.Add(tableName);
                    tableColumnDictionary.Add(tableName, columnList);
                }
                else {
                    MessageBox.Show("Table with this name already exists in the database.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_DeleteExistingTable(string tableName)
        {
            try {

                if (tableName.Equals("MAIN")) {
                    MessageBox.Show("The 'Main' table cannot be deleted.");
                    return;
                }

                if (!dropdownTableList.Items.Contains(tableName)) {

                    database.event_DeleteTable(tableName);
                    dropdownTableList.Items.Remove(tableName);
                    tableColumnDictionary.Remove(tableName);
                }
                else {
                    MessageBox.Show("Table does not exist in the database.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_ModifyTableColumns(string tableName, string columnName, string action)
        {
            try {

                ArrayList columnList = tableColumnDictionary[tableName];

                if (action.Equals("Add")) {
                    
                    database.event_AddColumn(tableName, columnName);
                    columnList.Add(columnName);
                }
                else if (action.Equals("Delete")) {

                    bool isValidModification = event_ValidateColumnModification(columnName);
                    if (!isValidModification) { return; }
                    database.event_DeleteColumn(tableName, columnName, columnList);
                    columnList.Remove(columnName);
                }

                tableColumnDictionary[tableName] = columnList;
                event_LoadTable(tableName);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private bool event_ValidateColumnModification(string columnName)
        {
            bool isValidModification = true;

            string message = "The column '" + columnName + "' cannot be deleted.";

            switch (columnName) {

                case "TEST_CASE_ID":
                    isValidModification = false;
                    break;

                case "TEST_NAME":
                    isValidModification = false;
                    break;

                case "TEST_TYPE":
                    isValidModification = false;
                    break;

                case "SCRIPT_NAME":
                    isValidModification = false;
                    break;

                default:
                    break;
            }

            if (!isValidModification) {
                MessageBox.Show(message);
            }

            return isValidModification;
        }

        public bool event_InProgress { get => inProgress; }
    }
}