using System;
using System.Windows.Forms;

namespace StreamLineUi
{
    public partial class ControlDataGenerator : UserControl
    {
        private FormMain formMain;
        private Common common;
        private DatabaseManager database;
        private GridviewManager gridviewManager;
        private delegate void Delegate();

        public ControlDataGenerator(FormMain formMain)
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
            initialize_GridviewColumns(gridviewDefaultTable);
            initialize_GridviewColumns(gridviewCustomTable);
            initialize_ReadOnlyColumns();
            initialize_LoadDefaultUrl();
            event_LoadDefaultValuesDataTable();
        }

        private void action_CustomizeSelectedValue(object sender, EventArgs e)
        {
            try {

                DataGridViewRow defaultRow = gridviewDefaultTable.SelectedRows[0];
                string tableName = gridviewManager.event_RetrieveCellDataValue(defaultRow, 0);
                if (tableName.ToLower().Equals("main")) {
                    MessageBox.Show("'Main' table columns & values cannot be customized.");
                    return;
                }

                string columnName = gridviewManager.event_RetrieveCellDataValue(defaultRow, 1);
                if (columnName.ToLower().Equals("test_case_id")) {
                    MessageBox.Show("'Test_Case_ID' column cannot be customized.");
                    return;
                }

                string dataValue = gridviewManager.event_RetrieveCellDataValue(defaultRow, 2);
                string[] customRow = new string[] { tableName, columnName, dataValue };
                gridviewCustomTable.Rows.Add(customRow);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_RemoveCustomizedValue(object sender, EventArgs e)
        {
            gridviewManager.event_DeleteRows(gridviewCustomTable);
        }

        private void action_GenerateTestCase(object sender, EventArgs e)
        {
            string testName = textboxTestName.Text;
            string testType = textboxTestType.Text;
            string url = textboxEnvironmentUrl.Text;

            if (testName.Length == 0 || testType.Length == 0 || url.Length == 0) {
                MessageBox.Show("Please provide a test case name and type before continuing.");
                return;
            }

            buttonGenerateTestCase.Enabled = false;
            string testCaseID = "TC-" + DateTime.Now.ToString("yyMMdd-HHmmss");
            event_GenerateTestCase(testCaseID);
            MessageBox.Show("Test case '" + testCaseID + "' has been generated.");
        }

        private void action_LoadDefaultValues(object sender, EventArgs e)
        {
            gridviewManager.event_LoadDatabaseSchema(gridviewDefaultTable);
        }
    }
}