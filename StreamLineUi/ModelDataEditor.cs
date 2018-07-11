using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace StreamLineUi
{
    internal class ModelDataEditor { }

    public partial class ControlDataEditor : UserControl
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



        //***************************************************************************************************************
        // Action Events Handler Methods
        //***************************************************************************************************************



        private void event_LoadTableList()
        {
            dropdownTableList.DataSource = database.event_RetrieveTableList();
        }

        private void event_LoadTable(string tableName)
        {
            string query = "SELECT * FROM [" + tableName + "]";
            gridview.DataSource = database.event_LoadTable(query);
            gridview.Columns["Test_Case_ID"].ReadOnly = true;
            gridview.Columns["Test_Case_ID"].Frozen = true;
        }

        private string event_RetrieveLoadedTableName()
        {
            string tableName;

            try { tableName = labelTableName.Text.Substring(7); }
            catch (Exception ex) { tableName = String.Empty; }

            return tableName;
        }

        private void event_DeleteEachSeletedTestCases()
        {
            int columnIndex = gridview.Columns["TEST_CASE_ID"].Index;
            ArrayList tableList = database.event_RetrieveTableList();

            foreach (DataGridViewRow row in gridview.SelectedRows) {

                string testCaseID = gridviewManager.event_RetrieveCellDataValue(row, columnIndex);
                if (testCaseID.Length == 0) { continue; }
                if (testCaseID.ToLower().Equals("default")) { continue; }
                event_DeleteTestCaseFromAllTables(tableList, testCaseID); 
            }
        }

        private void event_DeleteTestCaseFromAllTables(ArrayList tableList, string testCaseID)
        {
            foreach (string tableName in tableList) {

                string query = "DELETE FROM [" + tableName + "] WHERE [TEST_CASE_ID] = '" + testCaseID + "'";
                database.event_ExecuteNonSelectQuery(query);
            }

            MessageBox.Show("Test Case Deleted: " + testCaseID);
        }
    }
}