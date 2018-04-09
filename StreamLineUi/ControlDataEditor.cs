using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace StreamLineUi
{
    public partial class ControlDataEditor : UserControl
    {
        private Common common = new Common();
        private DatabaseConnector database;

        private Dictionary<string, ArrayList> tableColumnDictionary = new Dictionary<string, ArrayList>();
        private Dictionary<string, string> settingsDictionary;
        private ArrayList tableList = new ArrayList();
        private Color uiColor;
        
        private bool inProgress;

        public ControlDataEditor(Dictionary<string, string> settingsDictionary)
        {
            InitializeComponent();
            this.settingsDictionary = settingsDictionary;
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            inProgress = false;
            string testDatabaseDirectory = settingsDictionary["TestDatabaseDirectory"];
            string testDatabasePath = testDatabaseDirectory + "\\TestCaseData.db";
            database = new DatabaseConnector(testDatabasePath);

            initialize_ChooseUiColor();
            initialize_ChangeUiColor();
            initialize_DatabaseMapping();
        }

        private void action_LoadTable(object sender, EventArgs e)
        {
            string tableName = dropdownTableList.Text;

            if (tableName.Length > 0) {

                labelTableName.Text = "Table: " + tableName;
                event_LoadTable(tableName);
            }
            else {
                MessageBox.Show("Please select a table from the list to load.");
            }
        }

        private void action_EditTable(object sender, EventArgs e)
        {
            event_EnableModificationControls(false);
            inProgress = true;
        }

        private void action_SaveTable(object sender, EventArgs e)
        {
            string tableName = labelTableName.Text;
            tableName = tableName.Substring(7);
            gridviewTable.EndEdit();

            DataTable dataTable;
            dataTable = (DataTable)gridviewTable.DataSource;
            database.event_CommitDataTableChanges(tableName, dataTable);

            event_EnableModificationControls(true);
            inProgress = false;
        }

        private void action_CreateTable(object sender, EventArgs e)
        {
            try {

                string tableName;
                string labelText = "New Table Name:";
                string buttonText = "Create Table";
                string messageText = "Message: A new table will be created with 'TestCaseID' as the only column.";

                FormDataRetrieval dataRetrieval;
                dataRetrieval = new FormDataRetrieval(labelText, buttonText, messageText);
                DialogResult dialogResult = dataRetrieval.ShowDialog();

                if (dialogResult == DialogResult.OK) {

                    tableName = dataRetrieval.dataValue.ToUpper();
                    event_GenerateNewTable(tableName);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: action_CreateTable" + "\n" + ex.Message);
            }
        }

        private void action_DeleteTable(object sender, EventArgs e)
        {
            try {

                string tableName;
                string labelText = "Name of Table to Delete:";
                string buttonText = "Delete Table";
                string messageText = "Message: The specified table will be deleted. This action cannot be undone.";

                FormDataRetrieval dataRetrieval;
                dataRetrieval = new FormDataRetrieval(labelText, buttonText, messageText);
                DialogResult dialogResult = dataRetrieval.ShowDialog();

                if (dialogResult == DialogResult.OK) {

                    tableName = dataRetrieval.dataValue.ToUpper();
                    event_DeleteExistingTable(tableName);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: action_DeleteTable" + "\n" + ex.Message);
            }
        }

        private void action_AddColumn(object sender, EventArgs e)
        {
            try {

                string tableName = labelTableName.Text;
                tableName = tableName.Substring(7);
                ArrayList columnList = tableColumnDictionary[tableName];

                string columnName = textboxColumnName.Text.ToUpper();
                columnName = columnName.Replace(" ", "");

                if (columnName.Length == 0) {
                    MessageBox.Show("Please provide a column name before trying to add it.");
                    return;
                }

                if (columnList.Contains(columnName)) {
                    MessageBox.Show("This column already exists in the table.");
                    return;
                }

                string title = "Add Column To Table";
                string message = "Are you sure you want to add this column to the currenly loaded table.";

                DialogResult dialogResult;
                dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes) {
                    event_ModifyTableColumns(tableName, columnName, "Add");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: action_AddColumn" + "\n" + ex.Message);
            }
        }

        private void action_DeleteColumn(object sender, EventArgs e)
        {
            try {

                string tableName = labelTableName.Text;
                tableName = tableName.Substring(7);
                ArrayList columnList = tableColumnDictionary[tableName];

                string columnName = textboxColumnName.Text.ToUpper();
                columnName = columnName.Replace(" ", "");

                if (columnName.Length == 0) {
                    MessageBox.Show("Please provide a column name before trying to remove it.");
                    return;
                }

                if (!columnList.Contains(columnName)) {
                    MessageBox.Show("This column does not exist in the table.");
                    return;
                }

                string title = "Delete Column From Table";
                string message = "Are you sure you want to delete this column from the currenly loaded table.";

                DialogResult dialogResult;
                dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes) {
                    event_ModifyTableColumns(tableName, columnName, "Delete");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: action_DeleteColumn" + "\n" + ex.Message);
            }
        }

        private void action_DeleteTestCase(object sender, EventArgs e)
        {
            try {

                ArrayList testCaseList = new ArrayList();

                foreach (DataGridViewRow gridRow in gridviewTable.SelectedRows) {

                    var value = gridRow.Cells["TEST_CASE_ID"].Value;
                    if (value == null) { continue; }
                    testCaseList.Add(value.ToString());
                    MessageBox.Show("Test Case Deleted: " + value.ToString());
                }

                if (testCaseList.Count == 0) { return; }

                foreach (string tableName in tableList) {
                    database.event_DeleteTestCase(tableName, testCaseList);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}