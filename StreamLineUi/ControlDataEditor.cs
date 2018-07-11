using System;
using System.Data;
using System.Windows.Forms;

namespace StreamLineUi
{
    public partial class ControlDataEditor : UserControl
    {
        private FormMain formMain;
        private Common common;
        private DatabaseManager database;
        private GridviewManager gridviewManager;

        public ControlDataEditor(FormMain formMain)
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
            event_LoadTableList();
        }

        private void action_LoadTable(object sender, EventArgs e)
        {
            string tableName = dropdownTableList.Text;
            if (tableName.Length == 0) { return; }
            labelTableName.Text = "Table: " + tableName;
            event_LoadTable(tableName);
        }

        private void action_SaveTable(object sender, EventArgs e)
        {
            string tableName = event_RetrieveLoadedTableName();
            if (tableName.Length == 0) { return; }

            gridview.EndEdit();
            DataTable dataTable = (DataTable)gridview.DataSource;
            database.event_CommitDataTableChanges(tableName, dataTable);
            MessageBox.Show("'" + tableName + "' table has been saved.");
        }

        private void action_ReloadTableList(object sender, EventArgs e)
        {
            event_LoadTableList();
        }

        private void action_DeleteTestCases(object sender, EventArgs e)
        {
            string tableName = event_RetrieveLoadedTableName();
            if (tableName.Length == 0) { return; }
            event_DeleteEachSeletedTestCases();
            event_LoadTable(tableName);
        }

        private void action_CopyPasteData(object sender, KeyEventArgs e)
        {
            gridviewManager.event_CopyPasteToGridview(gridview, e);
        }
    }
}