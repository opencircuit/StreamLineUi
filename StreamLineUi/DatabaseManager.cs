using System;
using System.Data.SQLite;
using System.Data;
using System.Collections;
using System.Text;
using System.Windows;

namespace StreamLineUi
{
    internal class DatabaseManager
    {
        private SQLiteConnection connection;
        private string databasePath;



        //***************************************************************************************************************
        // Internally Accessible Methods
        //***************************************************************************************************************



        internal DatabaseManager(string databasePath) {
            this.databasePath = databasePath;
        }

        internal void event_OpenConnection()
        {
            try {

                if (event_RetrieveConnectionStatus().Equals("Open")) { return; }
                string connectionString = "Data Source=" + databasePath + ";Version=3;";
                connection = new SQLiteConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        internal ArrayList event_RetrieveTableList()
        {
            ArrayList tableList = new ArrayList();

            try {

                event_OpenConnection();
                DataTable databaseSchema = connection.GetSchema("Tables");

                foreach (DataRow tableRow in databaseSchema.Rows) {
                    tableList.Add(tableRow[2].ToString());
                }

                databaseSchema.Dispose();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return tableList;
        }

        internal ArrayList event_RetrieveColumnList(string tableName)
        {
            ArrayList columnList = new ArrayList();

            try {

                event_OpenConnection();
                string query = "SELECT * FROM [" + tableName + "]";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader dataResults = command.ExecuteReader();                

                for (int columnIndex = 0; columnIndex < dataResults.FieldCount; columnIndex++) {

                    string columnName = dataResults.GetName(columnIndex);
                    columnList.Add(columnName);
                }

                dataResults.Close();
                command.Dispose();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return columnList;
        }

        internal bool event_CreateTable(string tableName)
        {
            bool querySuccessful;

            try {

                event_OpenConnection();
                string createQuery = "CREATE TABLE [" + tableName + "] ([Test_Case_ID] VARCHAR(255) PRIMARY KEY NOT NULL)";
                string insertQuery = "INSERT INTO [" + tableName + "] ([Test_Case_ID]) SELECT [Test_Case_ID] FROM [Main]";

                event_ExecuteNonSelectQuery(createQuery);
                querySuccessful = event_ExecuteNonSelectQuery(insertQuery);
            }
            catch (Exception ex) {
                querySuccessful = false;
                MessageBox.Show(ex.Message);
            }

            return querySuccessful;
        }

        internal bool event_DropTable(string tableName)
        {
            bool querySuccessful;

            try {

                event_OpenConnection();
                string query = "DROP TABLE [" + tableName + "]";
                querySuccessful = event_ExecuteNonSelectQuery(query);
            }
            catch (Exception ex) {
                querySuccessful = false;
                MessageBox.Show(ex.Message);
            }

            return querySuccessful;
        }

        internal bool event_AddColumn(string tableName, string columnName, string dataValue)
        {
            bool querySuccessful;

            try {

                event_OpenConnection();

                string addQuery = "ALTER TABLE [" + tableName + "] ADD [" + columnName + "] VARCHAR(255)";
                string updateQuery = "UPDATE [" + tableName + "] SET [" + columnName + "] = '" + dataValue + "'";

                event_ExecuteNonSelectQuery(addQuery);
                querySuccessful = event_ExecuteNonSelectQuery(updateQuery);
            }
            catch (Exception ex) {
                querySuccessful = false;
                MessageBox.Show(ex.Message);
            }

            return querySuccessful;
        }

        internal bool event_DeleteColumn(string tableName, string columnName)
        {
            bool querySuccessful;

            try {

                event_OpenConnection();
                ArrayList columnList = event_RetrieveColumnList(tableName);
                columnList.Remove(columnName);

                string temporaryTable = "Temporary_" + tableName;
                string createTableQuery = event_CreateTableQuery(temporaryTable, columnList);
                event_ExecuteNonSelectQuery(createTableQuery);

                string insertQuery = event_CopyTableDataQuery(tableName, temporaryTable, columnList);
                event_ExecuteNonSelectQuery(insertQuery);

                string dropTableQuery = "DROP TABLE [" + tableName + "]";
                event_ExecuteNonSelectQuery(dropTableQuery);

                string renameTableQuery = "ALTER TABLE [" + temporaryTable + "] RENAME TO [" + tableName + "]";
                querySuccessful = event_ExecuteNonSelectQuery(renameTableQuery);
            }
            catch (Exception ex) {
                querySuccessful = false;
                MessageBox.Show(ex.Message);
            }

            return querySuccessful;
        }

        internal bool event_ExecuteNonSelectQuery(string query)
        {
            bool querySuccessful;

            try {

                event_OpenConnection();
                SQLiteCommand command = new SQLiteCommand();
                command.CommandText = query;
                command.Connection = connection;
                command.ExecuteNonQuery();
                command.Dispose();
                querySuccessful = true;
            }
            catch (Exception ex) {
                querySuccessful = false;
                MessageBox.Show(ex.Message);
            }

            return querySuccessful;
        }

        internal DataTable event_LoadTable(string query)
        {
            DataTable dataTable = new DataTable();

            try {

                event_OpenConnection();
                SQLiteDataAdapter dataAdapter;
                dataAdapter = new SQLiteDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
                dataAdapter.Dispose();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        internal DataTable event_LoadFilteredTable(string tableName, string queryConditions)
        {
            DataTable dataTable = new DataTable();

            try {

                event_OpenConnection();
                string query = "SELECT * FROM [" + tableName + "] WHERE " + queryConditions;

                SQLiteDataAdapter dataAdapter;
                dataAdapter = new SQLiteDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
                dataAdapter.Dispose();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        internal void event_CommitDataTableChanges(string tableName, DataTable dataTable)
        {
            try {

                event_OpenConnection();
                string query = "SELECT * FROM [" + tableName + "]";

                SQLiteDataAdapter dataAdapter;
                dataAdapter = new SQLiteDataAdapter(query, connection);

                SQLiteCommandBuilder commandBuilder;
                commandBuilder = new SQLiteCommandBuilder(dataAdapter);
                commandBuilder.QuotePrefix = "[";
                commandBuilder.QuoteSuffix = "]";

                dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();
                dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
                dataAdapter.Update(dataTable);
                commandBuilder.Dispose();
                dataAdapter.Dispose();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        internal int event_RetrieveRecordCount(string tableName, string columnName)
        {
            int recordCount;

            try {

                event_OpenConnection();
                string selectQuery = "SELECT COUNT([" + columnName + "]) FROM [" + tableName + "]";

                SQLiteCommand command = new SQLiteCommand();
                command.CommandText = selectQuery;
                command.Connection = connection;
                recordCount = Convert.ToInt32(command.ExecuteScalar());
                command.Dispose();
            }
            catch (Exception ex) {
                recordCount = 0;
                MessageBox.Show(ex.Message);
            }

            return recordCount;
        }

        internal ArrayList event_SingleColumnSelectQuery(string tableName, string columnName)
        {
            ArrayList dataValueList = new ArrayList();

            try {

                event_OpenConnection();
                string selectQuery = "SELECT [" + columnName + "] FROM [" + tableName + "]";

                SQLiteCommand command = new SQLiteCommand();
                command.CommandText = selectQuery;
                command.Connection = connection;

                SQLiteDataReader dataReader;
                dataReader = command.ExecuteReader();

                while (dataReader.Read()) {
                    dataValueList.Add(dataReader[0].ToString());
                }

                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return dataValueList;
        }

        internal string event_SingleValueSelectQuery(string query)
        {
            string retrievedDataValue = String.Empty;

            try {

                event_OpenConnection();
                SQLiteCommand command = new SQLiteCommand();
                command.CommandText = query;
                command.Connection = connection;

                SQLiteDataReader dataReader;
                dataReader = command.ExecuteReader();

                while (dataReader.Read()) {
                    retrievedDataValue = dataReader[0].ToString();
                    break;
                }

                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return retrievedDataValue;
        }

        internal void event_CloseConnection()
        {
            try {

                if (event_RetrieveConnectionStatus().Equals("Closed")) { return; }
                connection.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }



        //***************************************************************************************************************
        // Private Methods
        //***************************************************************************************************************



        private string event_CreateTableQuery(string tableName, ArrayList columnList)
        {
            StringBuilder createTableQuery = new StringBuilder();

            try {

                createTableQuery.Append("CREATE TABLE [");
                createTableQuery.Append(tableName);
                createTableQuery.Append("] (");

                for (int columnIndex = 0; columnIndex < columnList.Count; columnIndex++) {

                    string columnName = (string)columnList[columnIndex];
                    createTableQuery.Append("[");
                    createTableQuery.Append(columnName);
                    createTableQuery.Append("] VARCHAR(255)");

                    if (columnName.Equals("Test_Case_ID")) { createTableQuery.Append(" PRIMARY KEY NOT NULL"); }
                    if (columnIndex < (columnList.Count - 1)) { createTableQuery.Append(", "); }
                }

                createTableQuery.Append(")");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return createTableQuery.ToString();
        }

        private string event_CopyTableDataQuery(string tableName, string temporaryTable, ArrayList columnList)
        {
            StringBuilder insertQuery = new StringBuilder();

            try {

                insertQuery.Append("INSERT INTO [");
                insertQuery.Append(temporaryTable);
                insertQuery.Append("] (");

                StringBuilder columns = new StringBuilder();

                for (int columnIndex = 0; columnIndex < columnList.Count; columnIndex++) {

                    string columnName = (string)columnList[columnIndex];
                    columns.Append("[");
                    columns.Append(columnName);
                    columns.Append("]");

                    if (columnIndex < (columnList.Count - 1)) {
                        columns.Append(", ");
                    }
                }

                insertQuery.Append(columns.ToString());
                insertQuery.Append(") SELECT ");
                insertQuery.Append(columns.ToString());
                insertQuery.Append(" FROM [");
                insertQuery.Append(tableName);
                insertQuery.Append("]");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return insertQuery.ToString();
        }

        private string event_RetrieveConnectionStatus()
        {
            try { return connection.State.ToString(); }
            catch (Exception ex) { return "Closed"; }
        }
    }
}