using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace StreamLineUi
{
    public partial class ControlComponentEditor : UserControl
    {
        private FormMain formMain;
        private Common common;
        private DatabaseManager database;
        private GridviewManager gridviewManager;

        private Dictionary<string, ArrayList> actionsDictionary;
        private Dictionary<string, string> actionSettings;
        private Dictionary<string, ArrayList> dataColumnsDictionary;
        private Dictionary<string, ArrayList> conditionColumnsDictionary;

        private string componentsDirectory;

        public ControlComponentEditor(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            common = new Common();
            database = this.formMain.testDatabase;
            gridviewManager = new GridviewManager(database);
            actionsDictionary = new Dictionary<string, ArrayList>();
            actionSettings = new Dictionary<string, string>();
            dataColumnsDictionary = new Dictionary<string, ArrayList>();
            conditionColumnsDictionary = new Dictionary<string, ArrayList>();
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            initialize_SetComponentsDirectory();
            initialize_ActionsList();
            initialize_DatabaseMapping();
            initialize_ComponentsList();
            initialize_GridviewColumns();
            initialize_IdentifierTypes();
            initialize_ChangeUiColor();
            event_ResetEverything();
        }

        private void action_LoadComponent(object sender, EventArgs e)
        {
            string componentName = dropdownComponentList.Text;
            if (componentName.Length == 0) { return; }

            string componentPath = componentsDirectory + "\\" + componentName + ".xml";
            labelComponentName.Text = "Component: " + componentName;
            gridview.Rows.Clear();

            XmlNodeList primaryNodes;
            primaryNodes = common.event_LoadXmlPrimaryNodes(componentPath, "Step");
            initialize_ComponentStepsAnalysis(primaryNodes);
        }

        private void action_SaveComponent(object sender, EventArgs e)
        {
            string componentName = event_RetrieveLoadedComponentName();
            if (componentName.Length == 0) { return; }
            event_SaveComponent(componentName);
        }

        private void action_CreateComponent(object sender, EventArgs e)
        {
            string message = "Existing component with the same name will be replaced.";
            string componentName = event_RetrieveComponentName("Create Component", message);
            if (componentName.Length == 0) { return; }
            event_SaveComponent(componentName);
        }

        private void action_DeleteComponent(object sender, EventArgs e)
        {
            string message = "Deleting a component cannot be undone.";
            string componentName = event_RetrieveComponentName("Delete Component", message);
            if (componentName.Length == 0) { return; }

            string componentPath = componentsDirectory + "\\" + componentName + ".xml";
            event_DeleteSpecifiedComponent(componentPath, componentName);
        }

        private void action_ReloadTableList(object sender, EventArgs e)
        {
            dataColumnsDictionary.Clear();
            conditionColumnsDictionary.Clear();
            dropdownTestDataTable.Items.Clear();
            dropdownTestDataColumn.DataSource = null;
            dropdownConditionDataTable.Items.Clear();
            dropdownConditionDataColumn.DataSource = null;
            initialize_DatabaseMapping();
        }

        private void action_SelectOperation(object sender, EventArgs e)
        {
            event_ResetEverything();
            string operation = dropdownOperation.Text;
            dropdownAction.DataSource = actionsDictionary[operation];
            dropdownAction.Enabled = true;
        }

        private void action_SelectAction(object sender, EventArgs e)
        {
            event_ResetEverything();
            string operation = dropdownOperation.Text;
            string action = dropdownAction.Text;
            if (operation.Length == 0 || action.Length == 0) { return; }
            event_EnableActionDataControls(operation, action);
        }

        private void action_SelectDataTable(object sender, EventArgs e)
        {
            string tableName = dropdownTestDataTable.Text;
            dropdownTestDataColumn.DataSource = dataColumnsDictionary[tableName];
        }

        private void action_SelectConditionTable(object sender, EventArgs e)
        {
            string tableName = dropdownConditionDataTable.Text;
            dropdownConditionDataColumn.DataSource = conditionColumnsDictionary[tableName];
        }

        private void action_UseDatabase(object sender, EventArgs e)
        {
            event_EnableTestDatabaseControls(checkboxUseDatabase.Checked);
            event_EnableTestDataControls(!checkboxUseDatabase.Checked);
        }

        private void action_ApplyCondition(object sender, EventArgs e)
        {
            event_EnableConditionDataControls(checkboxApplyCondition.Checked);
        }

        private void action_AddStep(object sender, EventArgs e)
        {
            if (!event_ValidateControls()) { return; }
            int insertIndex = gridview.Rows.Count;
            event_AddStepToGridview(insertIndex);
        }

        private void action_AddStepBelowSelection(object sender, EventArgs e)
        {
            if (!gridviewManager.event_SingleRowSelected(gridview)) { return; }
            if (!event_ValidateControls()) { return; }

            DataGridViewRow row = gridview.SelectedRows[0];
            int insertIndex = row.Index + 1;
            event_AddStepToGridview(insertIndex);
            gridview.ClearSelection();
        }

        private void action_MoveStepUp(object sender, EventArgs e)
        {
            gridviewManager.event_MoveRowUp(gridview, "step");
        }

        private void action_MoveStepDown(object sender, EventArgs e)
        {
            gridviewManager.event_MoveRowDown(gridview, "step");
        }

        private void action_CopyStep(object sender, EventArgs e)
        {
            if (!gridviewManager.event_SingleRowSelected(gridview)) { return; }
            dropdownOperation.Text = String.Empty;
            dropdownAction.Text = String.Empty;
            event_ResetEverything();
            event_CopyStepAction();

            string operation = dropdownOperation.Text;
            string action = dropdownAction.Text;
            event_EnableActionDataControls(operation, action);
            event_CopyStepValues();
        }

        private void action_DeleteStep(object sender, EventArgs e)
        {
            gridviewManager.event_DeleteRows(gridview);
        }

        private void action_CopyPasteData(object sender, KeyEventArgs e)
        {
            gridviewManager.event_CopyPasteToGridview(gridview, e);
        }
    }
}