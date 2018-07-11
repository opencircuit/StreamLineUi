using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace StreamLineUi
{
    internal class GridviewManager
    {
        private DatabaseManager database;
        private char[] rowSplitter = { '\r', '\n' };
        private char[] columnSplitter = { '\t' };



        //***************************************************************************************************************
        // Internally Accessible Methods
        //***************************************************************************************************************



        internal GridviewManager() { }

        internal GridviewManager(DatabaseManager database) { this.database = database; }

        internal void event_CopyPasteToGridview(DataGridView gridview, KeyEventArgs e)
        {
            try {

                if (e.Control && e.KeyCode == Keys.V) {

                    string dataValues = (string)Clipboard.GetData(DataFormats.Text);
                    string[] rows = dataValues.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);
                    int selectedRow = gridview.CurrentRow.Index;
                    int selectedColumn = gridview.CurrentCell.ColumnIndex;
                    event_CopyPasteRowLoop(gridview, rows, selectedRow, selectedColumn);
                }
                else if (e.KeyCode == Keys.Delete) {

                    foreach (DataGridViewCell cell in gridview.SelectedCells) {
                        cell.Value = String.Empty;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        internal bool event_SingleRowSelected(DataGridView gridview)
        {
            string message = "Please select a single row before performing this action.";

            int rowsCount = gridview.SelectedRows.Count;
            if (rowsCount != 1) { MessageBox.Show(message); }
            return rowsCount == 1;
        }

        internal void event_LoadDatabaseSchema(DataGridView gridview)
        {
            try {

                gridview.Rows.Clear();
                ArrayList tableList = database.event_RetrieveTableList();

                foreach (string tableName in tableList) {
                    event_LoadTableSchema(gridview, tableName);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        internal string event_RetrieveCellDataValue(DataGridViewRow row, int cellIndex)
        {
            string dataValue;

            try {

                var cell = row.Cells[cellIndex].Value;
                if (cell == null) { dataValue = String.Empty; }
                else { dataValue = cell.ToString(); }
            }
            catch (Exception ex) {
                dataValue = String.Empty;
            }

            return dataValue;
        }

        internal void event_MoveRowUp(DataGridView gridview, string rowDescription)
        {
            try {

                if (!event_SingleRowSelected(gridview)) { return; }
                int removeIndex = gridview.SelectedRows[0].Index;
                int insertIndex = gridview.SelectedRows[0].Index - 1;

                if (insertIndex >= 0) {
                    event_MoveRow(gridview, removeIndex, insertIndex);
                }
                else {
                    MessageBox.Show("Selected " + rowDescription + " cannot be moved up any further.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        internal void event_MoveRowDown(DataGridView gridview, string rowDescription)
        {
            try {

                if (!event_SingleRowSelected(gridview)) { return; }
                int removeIndex = gridview.SelectedRows[0].Index;
                int insertIndex = gridview.SelectedRows[0].Index + 1;

                if (insertIndex != gridview.Rows.Count) {
                    event_MoveRow(gridview, removeIndex, insertIndex);
                }
                else {
                    MessageBox.Show("Selected " + rowDescription + " cannot be moved down any further.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }
        }

        internal void event_DeleteRows(DataGridView gridview)
        {
            try {

                foreach (DataGridViewRow row in gridview.SelectedRows) {
                    gridview.Rows.Remove(row);
                }

                gridview.ClearSelection();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }



        //***************************************************************************************************************
        // Private Methods
        //***************************************************************************************************************



        private void event_CopyPasteRowLoop(DataGridView gridview, string[] rows, int selectedRow, int selectedColumn)
        {
            for (int rowIndex = 0; rowIndex < rows.Length; rowIndex++) {
                string[] columns = rows[rowIndex].Split(columnSplitter);
                event_CopyPasteColumnLoop(gridview, selectedRow, selectedColumn, rowIndex, columns);
            }
        }

        private void event_CopyPasteColumnLoop(DataGridView gridview, int selectedRow, int selectedColumn, int rowIndex, string[] columns)
        {
            for (int columnIndex = 0; columnIndex < columns.Length; columnIndex++) {

                gridview
                    .Rows[selectedRow + rowIndex]
                    .Cells[selectedColumn + columnIndex]
                    .Value = columns[columnIndex];
            }
        }

        private void event_LoadTableSchema(DataGridView gridview, string tableName)
        {
            string queryCondition = "[Test_Case_ID] = 'Default'";
            DataTable dataTable = database.event_LoadFilteredTable(tableName, queryCondition);

            foreach (DataColumn column in dataTable.Columns) {

                string[] row = new string[] {
                        tableName,
                        column.ColumnName,
                        dataTable.Rows[0][column.ColumnName].ToString()
                };

                gridview.Rows.Add(row);
            }
        }

        private void event_MoveRow(DataGridView gridview, int removeIndex, int insertIndex)
        {
            try {

                DataGridViewRow row = gridview.SelectedRows[0];
                gridview.Rows.RemoveAt(removeIndex);
                gridview.Rows.Insert(insertIndex, row);
                gridview.ClearSelection();
                gridview.Rows[insertIndex].Selected = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}