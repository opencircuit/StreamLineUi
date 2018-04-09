using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace StreamLineUi
{
    public partial class ControlScriptBuilder : UserControl
    {
        private Common common = new Common();
        private DatabaseConnector database;
        private XmlWriter xml;

        private Dictionary<string, string> settingsDictionary;
        private Dictionary<string, ArrayList> actionListDictionary = new Dictionary<string, ArrayList>();
        private Dictionary<string, string> actionFieldDictionary = new Dictionary<string, string>();
        private ArrayList scriptColumnList = new ArrayList();
        private ArrayList scriptList = new ArrayList();

        private ArrayList dataTableList = new ArrayList();
        private Dictionary<string, ArrayList> dataTableColumnDictionary = new Dictionary<string, ArrayList>();

        private ArrayList conditionTableList = new ArrayList();
        private Dictionary<string, ArrayList> conditionsTableColumnDictionary = new Dictionary<string, ArrayList>();

        private Color uiColor;
        private Color defaultLabelColor;
        private Color requiredLabelColor;

        private string scriptsDirectory;
        private string useDataValue;
        private string objectRequired;
        private bool inProgress;

        public ControlScriptBuilder(Dictionary<string, string> settingsDictionary)
        {
            InitializeComponent();
            this.settingsDictionary = settingsDictionary;
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            inProgress = false;
            string resourceDirectory = common.event_GetCurrentDirectory() + "\\Resources";
            string scriptBuilderXmlPath = resourceDirectory + "\\Setup\\ScriptBuilderOptions.xml";
            string testDatabaseDirectory = settingsDictionary["TestDatabaseDirectory"];
            string testDatabasePath = testDatabaseDirectory + "\\TestCaseData.db";
            scriptsDirectory = settingsDictionary["ScriptsDirectory"];
            database = new DatabaseConnector(testDatabasePath);

            defaultLabelColor = Color.FromArgb(64, 64, 64);
            requiredLabelColor = Color.Red;

            initialize_ChooseUiColor();
            initialize_ChangeUiColor();
            initialize_ScriptBuilderOptions(scriptBuilderXmlPath);
            initialize_DatabaseMapping();
            initialize_ScriptsList(scriptsDirectory);
            initialize_XmlNodeList();
            initialize_ScriptTableColumns();
            initialize_IdentifierTypes();
            reset_Everything();
        }

        private void action_LoadScript(object sender, EventArgs e)
        {
            try {

                string scriptName = dropdownScriptList.Text;

                if (scriptName.Length > 0) {

                    gridviewScript.Rows.Clear();
                    labelScript.Text = "Script: " + scriptName;
                    dropdownOperation.SelectedItem = "";
                    dropdownAction.SelectedItem = "";

                    reset_Everything();
                    string scriptPath = scriptsDirectory + "\\" + scriptName + ".xml";

                    XmlNodeList primaryNodes;
                    primaryNodes = initialize_LoadXmlPrimaryNodes(scriptPath, "Step");
                    event_LoadScriptStepsAnalysis(primaryNodes);
                }
                else {
                    MessageBox.Show("ERROR: Select a script from the script list before trying to load it.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_SaveScript(object sender, EventArgs e)
        {
            try {

                string scriptName = dropdownScriptList.Text.ToUpper();

                if (scriptName.Length == 0) {
                    event_GenerateNewScript();
                    inProgress = false;
                }
                else {
                    event_SaveScript(scriptName);
                    inProgress = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_CreateScript(object sender, EventArgs e)
        {
            event_GenerateNewScript();
            inProgress = false;
        }

        private void action_DeleteScript(object sender, EventArgs e)
        {
            try {

                string scriptName;
                string labelText = "Script Name To Delete:";
                string buttonText = "Delete Script";
                string messageText = "Message: Deleting a script cannot be undone.";

                FormDataRetrieval dataRetrieval;
                dataRetrieval = new FormDataRetrieval(labelText, buttonText, messageText);
                var dialogResult = dataRetrieval.ShowDialog();

                if (dialogResult == DialogResult.OK) {

                    scriptName = dataRetrieval.dataValue.ToUpper();
                    string scriptPath = scriptsDirectory + "\\" + scriptName + ".xml";
                    event_DeleteSpecifiedScript(scriptPath, scriptName);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_SelectOperation(object sender, EventArgs e)
        {
            try {

                string operation = dropdownOperation.Text;
                reset_Everything();

                if (operation.Length > 0) {
                    dropdownAction.Enabled = true;
                    dropdownAction.DataSource = actionListDictionary[operation];
                }
                else {
                    dropdownAction.Text = "";
                    dropdownAction.Enabled = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_SelectAction(object sender, EventArgs e)
        {
            try {

                string operation = dropdownOperation.Text;
                string action = dropdownAction.Text;

                if (operation.Length > 0 && action.Length > 0) {
                    event_EnableActionDataControls(operation, action);
                }
                else {
                    reset_Everything();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_SelectDataTable(object sender, EventArgs e)
        {
            try {

                string tableName = dropdownTestDataTable.Text;
                dropdownTestDataColumn.DataSource = dataTableColumnDictionary[tableName];
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_SelectConditionTable(object sender, EventArgs e)
        {
            try {

                string tableName = dropdownConditionDataTable.Text;
                dropdownConditionDataColumn.DataSource = conditionsTableColumnDictionary[tableName];
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_ResetDataFields(object sender, EventArgs e)
        {
            try {

                dropdownOperation.Text = "";
                dropdownAction.Text = "";
                reset_Everything();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_UseTestDatabase(object sender, EventArgs e)
        {
            try {

                if (checkboxUseTestDatabase.Checked) {

                    event_EnableTestDatabaseControls(true, requiredLabelColor);
                    event_EnableTestDataControls(false, defaultLabelColor);
                }
                else {

                    event_EnableTestDatabaseControls(false, defaultLabelColor);

                    if (useDataValue.Equals("Yes")) {
                        event_EnableTestDataControls(true, requiredLabelColor);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_ApplyCondition(object sender, EventArgs e)
        {
            try {

                if (checkboxApplyCondition.Checked) {
                    event_EnableConditionDataControls(true, requiredLabelColor);
                }
                else {
                    event_EnableConditionDataControls(false, defaultLabelColor);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_AddStep(object sender, EventArgs e)
        {
            try {

                int insertIndex = gridviewScript.Rows.Count;
                event_RetrieveNewStepValues(insertIndex);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_AddStepBelowSelection(object sender, EventArgs e)
        {
            try {

                if (gridviewScript.SelectedRows.Count > 1) {
                    MessageBox.Show("Please select only one step before adding a new step below it.");
                    return;
                }

                DataGridViewRow selectedRow = gridviewScript.SelectedRows[0];
                int insertIndex = selectedRow.Index + 1;
                event_RetrieveNewStepValues(insertIndex);
                gridviewScript.ClearSelection();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_MoveStepUp(object sender, EventArgs e)
        {
            try {

                if (gridviewScript.SelectedRows.Count > 1) {
                    MessageBox.Show("Please select only one step to move up.");
                    return;
                }

                int removeIndex = gridviewScript.SelectedRows[0].Index;
                int insertIndex = gridviewScript.SelectedRows[0].Index - 1;

                if (insertIndex < 0) {
                    MessageBox.Show("Selected step cannot be moved up any further.");
                    return;
                }

                DataGridViewRow gridRow = gridviewScript.SelectedRows[0];
                gridviewScript.Rows.RemoveAt(removeIndex);
                gridviewScript.Rows.Insert(insertIndex, gridRow);
                gridviewScript.ClearSelection();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_MoveStepDown(object sender, EventArgs e)
        {
            try {

                if (gridviewScript.SelectedRows.Count > 1) {
                    MessageBox.Show("Please select only one step to move down.");
                    return;
                }

                int removeIndex = gridviewScript.SelectedRows[0].Index;
                int insertIndex = gridviewScript.SelectedRows[0].Index + 1;

                if (insertIndex == gridviewScript.Rows.Count) {
                    MessageBox.Show("Selected step cannot be moved down any further.");
                    return;
                }

                DataGridViewRow gridRow = gridviewScript.SelectedRows[0];
                gridviewScript.Rows.RemoveAt(removeIndex);
                gridviewScript.Rows.Insert(insertIndex, gridRow);
                gridviewScript.ClearSelection();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_DeleteStep(object sender, EventArgs e)
        {
            try {

                foreach (DataGridViewRow gridRow in gridviewScript.SelectedRows) {
                    gridviewScript.Rows.Remove(gridRow);
                }

                gridviewScript.ClearSelection();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}