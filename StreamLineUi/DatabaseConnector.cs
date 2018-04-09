using System;
using System.Data.SQLite;
using System.Data;
using System.Collections;
using System.Text;
using System.Windows;

namespace StreamLineUi
{
    internal class DatabaseConnector
    {
        private SQLiteConnection connection;
        private string databasePath;

        internal DatabaseConnector(string databasePath) {
            this.databasePath = databasePath;
        }

        internal void event_OpenConnection()
        {
            string connectionString = "Data Source=" + databasePath + ";Version=3;";
            connection = new SQLiteConnection(connectionString);
            connection.Open();
        }

        internal ArrayList event_RetrieveTableList()
        {
            event_OpenConnection();

            DataTable databaseSchema = connection.GetSchema("Tables");
            ArrayList tableList = new ArrayList();
            tableList.Add("");

            foreach (DataRow tableRow in databaseSchema.Rows) {

                string tableName = tableRow[2].ToString().ToUpper();

                if (tableName.Equals("SQLITE_SEQUENCE")) { continue; }
                else if (tableName.Equals("SQLITE_STAT1")) { continue; }
                else { tableList.Add(tableName); }
            }

            databaseSchema.Dispose();
            event_CloseConnection();

            return tableList;
        }

        internal ArrayList event_RetrieveColumnList(string tableName)
        {
            event_OpenConnection();
            ArrayList columnList = new ArrayList();

            try {

                string query = "SELECT * FROM [" + tableName + "]";
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM [" + tableName + "]", connection);
                SQLiteDataReader dataResults = command.ExecuteReader();                
                columnList.Add("");

                for (int columnIndex = 0; columnIndex < dataResults.FieldCount; columnIndex++) {

                    string columnName = dataResults.GetName(columnIndex).ToUpper();
                    columnList.Add(columnName);
                }

                dataResults.Close();
                command.Dispose();
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: event_RetrieveColumnList" + "\n" + ex.Message);
            }

            event_CloseConnection();

            return columnList;
        }

        internal void event_CreateTable(string tableName)
        {
            event_OpenConnection();

            try {

                string query = "CREATE TABLE [" + tableName + "] ([TEST_CASE_ID] VARCHAR(255) PRIMARY KEY NOT NULL)";
                event_ExecutionNonSelectQuery(query);
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: event_CreateTable" + "\n" + ex.Message);
            }

            event_CloseConnection();
        }

        internal void event_DeleteTable(string tableName)
        {
            event_OpenConnection();

            try {

                string query = "DROP TABLE [" + tableName + "]";
                event_ExecutionNonSelectQuery(query);
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: event_DeleteTable" + "\n" + ex.Message);
            }

            event_CloseConnection();
        }

        internal void event_AddColumn(string tableName, string columnName)
        {
            event_OpenConnection();

            try {

                string query = "ALTER TABLE [" + tableName + "] ADD [" + columnName + "] VARCHAR(255)";
                event_ExecutionNonSelectQuery(query);
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: event_DeleteTable" + "\n" + ex.Message);
            }

            event_CloseConnection();
        }

        internal void event_DeleteColumn(string tableName, string columnNameToDelete, ArrayList columnList)
        {
            event_OpenConnection();

            try {

                columnList.Remove(columnNameToDelete);
                string temporaryTable = "Temporary_" + tableName;

                string createTableQuery = event_CreateTableQuery(temporaryTable, columnList);
                event_ExecutionNonSelectQuery(createTableQuery);

                string insertQuery = event_CopyTableDataQuery(tableName, temporaryTable, columnList);
                event_ExecutionNonSelectQuery(insertQuery);

                string dropTableQuery = "DROP TABLE [" + tableName + "]";
                event_ExecutionNonSelectQuery(dropTableQuery);

                string renameTableQuery = "ALTER TABLE [" + temporaryTable + "] RENAME TO [" + tableName + "]";
                event_ExecutionNonSelectQuery(renameTableQuery);
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: event_DeleteColumn" + "\n" + ex.Message);
            }

            event_CloseConnection();
        }

        private string event_CreateTableQuery(string tableName, ArrayList columnList)
        {
            StringBuilder createTableQuery = new StringBuilder();
            createTableQuery.Append("CREATE TABLE [");
            createTableQuery.Append(tableName);
            createTableQuery.Append("] (");

            for (int columnIndex = 0; columnIndex < columnList.Count; columnIndex++) {

                string columnName = (string)columnList[columnIndex];
                createTableQuery.Append("[");
                createTableQuery.Append(columnName);
                createTableQuery.Append("] VARCHAR(255)");

                if (columnName.Equals("TEST_CASE_ID")) {
                    createTableQuery.Append(" PRIMARY KEY NOT NULL");
                }

                if (columnIndex < (columnList.Count - 1)) {
                    createTableQuery.Append(", ");
                }
            }

            createTableQuery.Append(")");

            return createTableQuery.ToString();
        }

        private string event_CopyTableDataQuery(string tableName, string temporaryTable, ArrayList columnList)
        {
            StringBuilder insertQuery = new StringBuilder();
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

            return insertQuery.ToString();
        }

        internal void event_ExecutionNonSelectQuery(string query)
        {
            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = query;
            command.Connection = connection;
            command.ExecuteNonQuery();
            command.Dispose();
        }

        internal void event_ExecuteNonSelectListOfQueries(ArrayList queryList)
        {
            event_OpenConnection();

            foreach (string query in queryList) {
                event_ExecutionNonSelectQuery(query);
            }

            event_CloseConnection();
        }

        internal DataTable event_LoadTable(string tableName)
        {
            event_OpenConnection();

            string query = "SELECT * FROM [" + tableName + "]";
            
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dataAdapter;
            dataAdapter = new SQLiteDataAdapter(query, connection);
            dataAdapter.Fill(dataTable);

            dataAdapter.Dispose();
            event_CloseConnection();

            return dataTable;
        }

        internal DataTable event_LoadFilteredTable(string tableName, string queryConditions)
        {
            event_OpenConnection();

            string query = "SELECT * FROM [" + tableName + "] WHERE " + queryConditions;

            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dataAdapter;
            dataAdapter = new SQLiteDataAdapter(query, connection);
            dataAdapter.Fill(dataTable);

            dataAdapter.Dispose();
            event_CloseConnection();

            return dataTable;
        }

        internal void event_CommitDataTableChanges(string tableName, DataTable dataTable)
        {
            event_OpenConnection();

            string query = "SELECT * FROM [" + tableName + "]";

            SQLiteDataAdapter dataAdapter;
            dataAdapter = new SQLiteDataAdapter(query, connection);

            SQLiteCommandBuilder commandBuilder;
            commandBuilder = new SQLiteCommandBuilder(dataAdapter);

            dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
            dataAdapter.Update(dataTable);

            commandBuilder.Dispose();
            dataAdapter.Dispose();
            event_CloseConnection();
        }

        internal void event_ClearDatabase(ArrayList tableList)
        {
            event_OpenConnection();

            foreach (string tableName in tableList) {

                string deleteRecordsQuery = "DELETE FROM [" + tableName + "]";
                event_ExecutionNonSelectQuery(deleteRecordsQuery);
            }

            event_CloseConnection();
        }

        internal ArrayList event_SingleColumnSelectQuery(string tableName, string columnName)
        {
            event_OpenConnection();

            string selectQuery = "SELECT [" + columnName + "] FROM [" + tableName + "]";
            ArrayList dataValueList = new ArrayList();
            dataValueList.Add("");

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
            event_CloseConnection();

            return dataValueList;
        }

        internal int event_RetrieveRecordCount(string tableName, string columnName)
        {
            event_OpenConnection();

            string selectQuery = "SELECT COUNT([" + columnName + "]) FROM [" + tableName + "]";

            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = selectQuery;
            command.Connection = connection;
            int recordCount = Convert.ToInt32(command.ExecuteScalar());

            command.Dispose();
            event_CloseConnection();

            return recordCount;
        }

        internal double[] event_RetrieveExecutionTimes(string executionID, int size)
        {
            double[] executionTimes = new double[size];

            try {

                event_OpenConnection();

                string selectQuery = "SELECT [EXECUTION_TIME] FROM [MAIN] WHERE [EXECUTION_ID] = '" + executionID + "'";

                SQLiteCommand command = new SQLiteCommand();
                command.CommandText = selectQuery;
                command.Connection = connection;

                SQLiteDataReader dataReader;
                dataReader = command.ExecuteReader();
                int index = 0;

                while (dataReader.Read()) {

                    string dataValue = dataReader[0].ToString();
                    double executionTime;

                    if (dataValue.Length > 0) {
                        executionTime = Double.Parse(dataValue);
                        executionTimes[index] = executionTime;
                    }
                    else {
                        executionTimes[index] = 0;
                    }

                    index++;
                    if (index == size) { break; }
                }

                dataReader.Close();
                command.Dispose();
                event_CloseConnection();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return executionTimes;
        }

        internal void event_DeleteTestCase(string tableName, ArrayList testCaseList)
        {
            event_OpenConnection();
            
            string primaryQuery = "DELETE FROM [" + tableName + "] WHERE [TEST_CASE_ID] = '";

            foreach (string testCaseID in testCaseList) {

                string query = primaryQuery + testCaseID + "'";
                event_ExecutionNonSelectQuery(query);
            }

            event_CloseConnection();
        }

        internal void event_CloseConnection()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}