using System;
using System.Collections;
using System.Windows.Forms;

namespace StreamLineUi
{
    public partial class ControlDatabaseEditor : UserControl
    {
        private FormMain formMain;
        private Common common;
        private DatabaseManager database;
        private GridviewManager gridviewManager;

        public ControlDatabaseEditor(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            common = new Common();
            database = this.formMain.testDatabase;
            gridviewManager = new GridviewManager(database);
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            initialize_ChangeUiColor();
            initialize_GridviewColumns();
            initialize_TableList();
            gridviewManager.event_LoadDatabaseSchema(gridview);
        }

        private void action_CreateOrDropTable(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string tableName = event_RetrieveName(button.Text);
            bool validTable = event_ValidTableValue(tableName);
            if (!validTable) { return; }
            event_CreateOrDropTable(button, tableName);
        }

        private void action_AddOrDeleteColumn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string tableName = dropdownTableList.Text;
            string columnName = event_RetrieveName(button.Text);
            bool validTable = event_ValidTableValue(tableName);
            bool validColumn = event_ValidColumnValue(columnName);
            if (!validTable || !validColumn) { return; }
            string dataValue = textboxDefaultValue.Text;
            event_AddOrDeleteColumn(button, tableName, columnName, dataValue);
        }

        private void action_ApplyFilter(object sender, EventArgs e)
        {
            string columnName = textboxColumnName.Text;
            if (columnName.Length == 0) { return; }

            gridview.Rows.Clear();
            ArrayList tableList = database.event_RetrieveTableList();

            foreach (string tableName in tableList) {
                event_FindFilteredColumnInTable(tableName, columnName);
            }
        }

        private void action_ReloadDatabaseSchema(object sender, EventArgs e)
        {
            gridviewManager.event_LoadDatabaseSchema(gridview);
        }
    }
}