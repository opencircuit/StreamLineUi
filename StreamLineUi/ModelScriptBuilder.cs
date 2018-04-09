using System;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Collections;
using System.Drawing;

namespace StreamLineUi
{
    internal class ModelScriptBuilder { }

    public partial class ControlScriptBuilder : UserControl
    {
        private void initialize_ChooseUiColor()
        {
            string selectedColor = settingsDictionary["UiColor"];
            uiColor = common.event_RetrieveSpecifiedColor(selectedColor);
        }

        private void initialize_ChangeUiColor()
        {
            buttonLoadScript.BackColor = uiColor;
            buttonSaveScript.BackColor = uiColor;
            buttonCreateScript.BackColor = uiColor;
            buttonDeleteScript.BackColor = uiColor;
            buttonAddStep.BackColor = uiColor;
            buttonAddStepBelowSelection.BackColor = uiColor;
            buttonMoveStepUp.BackColor = uiColor;
            buttonMoveStepDown.BackColor = uiColor;
            buttonResetDataFields.BackColor = uiColor;
            buttonDeleteStep.BackColor = uiColor;
            gridviewScript.DefaultCellStyle.SelectionBackColor = uiColor;
        }

        private void initialize_ScriptBuilderOptions(string filePath)
        {
            try {

                dropdownOperation.Items.Add("");

                XmlNodeList primaryNodes;
                primaryNodes = initialize_LoadXmlPrimaryNodes(filePath, "Operation");
                initialize_ScriptBuilderOperationAnalysis(primaryNodes);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private XmlNodeList initialize_LoadXmlPrimaryNodes(string filePath, string nodeName)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);
            XmlElement root = xmlDocument.DocumentElement;
            XmlNodeList primaryNodes = root.GetElementsByTagName(nodeName);

            return primaryNodes;
        }

        private void initialize_ScriptBuilderOperationAnalysis(XmlNodeList primaryNodes)
        {

            foreach (XmlNode primaryNode in primaryNodes) {

                string operation = primaryNode.Attributes["value"].Value;
                XmlNodeList actionNodes = primaryNode.ChildNodes;
                dropdownOperation.Items.Add(operation);

                ArrayList actionList = new ArrayList();
                actionList.Add("");

                initialize_ScriptBuilderActionAnalysis(operation, actionNodes, actionList);
                actionListDictionary.Add(operation, actionList);
            }
        }

        private void initialize_ScriptBuilderActionAnalysis(string operation, XmlNodeList actionNodes, ArrayList actionList)
        {
            foreach (XmlNode actionNode in actionNodes) {

                string action = actionNode.Attributes["value"].Value;
                actionList.Add(action);

                XmlNodeList childNodes = actionNode.ChildNodes;
                initialize_ScriptBuilderActionChildNodeAnalysis(childNodes, operation, action);
            }
        }

        private void initialize_ScriptBuilderActionChildNodeAnalysis(XmlNodeList childNodes, string operation, string action)
        {
            foreach (XmlNode childNode in childNodes) {

                string key = operation + "." + action + "." + childNode.Name;
                string value = childNode.InnerText;
                actionFieldDictionary.Add(key, value);
            }
        }

        private void initialize_DatabaseMapping()
        {
            try {

                dataTableList = database.event_RetrieveTableList();
                conditionTableList = database.event_RetrieveTableList();
                initialize_TableSchemaAnalysis();

                dropdownTestDataTable.DataSource = dataTableList;
                dropdownConditionDataTable.DataSource = conditionTableList;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void initialize_TableSchemaAnalysis()
        {
            ArrayList blankList = new ArrayList();
            blankList.Add("");

            dataTableColumnDictionary.Add("", blankList);
            conditionsTableColumnDictionary.Add("", blankList);

            for (int tableIndex = 1; tableIndex < dataTableList.Count; tableIndex++) {

                string tableName = (string)dataTableList[tableIndex];

                ArrayList testTableColumnList = new ArrayList();
                testTableColumnList = database.event_RetrieveColumnList(tableName);

                ArrayList conditionTableColumnList = new ArrayList();
                conditionTableColumnList = database.event_RetrieveColumnList(tableName);

                dataTableColumnDictionary.Add(tableName, testTableColumnList);
                conditionsTableColumnDictionary.Add(tableName, conditionTableColumnList);
            }
        }

        private void initialize_XmlNodeList()
        {
            scriptColumnList.Add("");
            scriptColumnList.Add("Description");
            scriptColumnList.Add("Operation");
            scriptColumnList.Add("Action");
            scriptColumnList.Add("OptionalStep");
            scriptColumnList.Add("ElementDescription");
            scriptColumnList.Add("IdentifierType");
            scriptColumnList.Add("IdentifierValue");
            scriptColumnList.Add("TestDataTable");
            scriptColumnList.Add("TestDataColumn");
            scriptColumnList.Add("StaticDataValue");
            scriptColumnList.Add("ConditionDataTable");
            scriptColumnList.Add("ConditionDataColumn");
            scriptColumnList.Add("ConditionDataValue");
        }

        private void initialize_ScriptTableColumns()
        {
            gridviewScript.Columns.Add("StepNumber", "Step Number");
            gridviewScript.Columns.Add("Description", "Description");
            gridviewScript.Columns.Add("Operation", "Operation");
            gridviewScript.Columns.Add("Action", "Action");
            gridviewScript.Columns.Add("OptionalStep", "Optional Step");
            gridviewScript.Columns.Add("ElementDescription", "Element Description");
            gridviewScript.Columns.Add("IdentifierType", "Identifier Type");
            gridviewScript.Columns.Add("IdentifierValue", "Identifier Value");
            gridviewScript.Columns.Add("TestDataTable", "Test Data Table");
            gridviewScript.Columns.Add("TestDataColumn", "Test Data Column");
            gridviewScript.Columns.Add("StaticDataValue", "Static Data Value");
            gridviewScript.Columns.Add("ConditionDataTable", "Condition Data Table");
            gridviewScript.Columns.Add("ConditionDataColumn", "Condition Data Column");
            gridviewScript.Columns.Add("ConditionDataValue", "Condition Data Value");
        }

        private void initialize_IdentifierTypes()
        {
            dropdownIdentifierType.Items.Add("");
            dropdownIdentifierType.Items.Add("ID");
            dropdownIdentifierType.Items.Add("Name");
            dropdownIdentifierType.Items.Add("Link-Text");
            dropdownIdentifierType.Items.Add("Partial-Link-Text");
            dropdownIdentifierType.Items.Add("Tag-Name");
            dropdownIdentifierType.Items.Add("Class-Name");
            dropdownIdentifierType.Items.Add("Css-Selector");
            dropdownIdentifierType.Items.Add("Xpath");
        }

        private void initialize_ScriptsList(string scriptsDirectory)
        {
            scriptList = common.event_GetDirectoryFileList(scriptsDirectory);
            dropdownScriptList.Items.Add("");

            foreach (string script in scriptList) {
                dropdownScriptList.Items.Add(script);
            }
        }

        private void event_LoadScriptStepsAnalysis(XmlNodeList primaryNodes)
        {
            foreach (XmlNode primaryNode in primaryNodes) {

                string stepId = primaryNode.Attributes["id"].Value;
                XmlNodeList stepNodes = primaryNode.ChildNodes;
                event_LoadScriptStep(stepId, stepNodes);
            }
        }

        private void event_LoadScriptStep(string stepId, XmlNodeList stepNodes)
        {            
            string[] row = new string[] { stepId,
                    stepNodes[0].InnerText,
                    stepNodes[1].InnerText,
                    stepNodes[2].InnerText,
                    stepNodes[3].InnerText,
                    stepNodes[4].InnerText,
                    stepNodes[5].InnerText,
                    stepNodes[6].InnerText,
                    stepNodes[7].InnerText,
                    stepNodes[8].InnerText,
                    stepNodes[9].InnerText,
                    stepNodes[10].InnerText,
                    stepNodes[11].InnerText,
                    stepNodes[12].InnerText };

            gridviewScript.Rows.Add(row);
        }

        private void event_RetrieveNewStepValues(int insertIndex)
        {
            try {

                bool validStep = true;

                string stepDescription = "";
                string operation = dropdownOperation.Text;
                string action = dropdownAction.Text;

                string elementDescription = "";
                string identifierType = "";
                string identifierValue = "";

                string staticDataValue = "";
                string testDataTable = "";
                string testDataColumn = "";

                string conditionDataValue = "";
                string conditionDataTable = "";
                string conditionDataColumn = "";
                string optionalStep = "";

                if (textboxDescription.Enabled) {
                    if (textboxDescription.Text.Length == 0) { validStep = false; }
                    else { stepDescription = textboxDescription.Text; }
                }

                if (textboxElementDescription.Enabled) {
                    if (textboxElementDescription.Text.Length == 0) { validStep = false; }
                    else { elementDescription = textboxElementDescription.Text; }
                }

                if (dropdownIdentifierType.Enabled) {
                    if (dropdownIdentifierType.Text.Length == 0) { validStep = false; }
                    else { identifierType = dropdownIdentifierType.Text; }
                }

                if (textboxIdentifierValue.Enabled) {
                    if (textboxIdentifierValue.Text.Length == 0) { validStep = false; }
                    else { identifierValue = textboxIdentifierValue.Text; }
                }

                if (textboxDataValue.Enabled) {
                    if (textboxDataValue.Text.Length == 0) { validStep = false; }
                    else { staticDataValue = textboxDataValue.Text; }
                }

                if (dropdownTestDataTable.Enabled) {
                    if (dropdownTestDataTable.Text.Length == 0) { validStep = false; }
                    else { testDataTable = dropdownTestDataTable.Text; }
                }

                if (dropdownTestDataColumn.Enabled) {
                    if (dropdownTestDataColumn.Text.Length == 0) { validStep = false; }
                    else { testDataColumn = dropdownTestDataColumn.Text; }
                }

                if (textboxConditionDataValue.Enabled) {
                    if (textboxConditionDataValue.Text.Length == 0) { validStep = false; }
                    else { conditionDataValue = textboxConditionDataValue.Text; }
                }

                if (dropdownConditionDataTable.Enabled) {
                    if (dropdownConditionDataTable.Text.Length == 0) { validStep = false; }
                    else { conditionDataTable = dropdownConditionDataTable.Text; }
                }

                if (dropdownConditionDataColumn.Enabled) {
                    if (dropdownConditionDataColumn.Text.Length == 0) { validStep = false; }
                    else { conditionDataColumn = dropdownConditionDataColumn.Text; }
                }

                if (checkboxOptionalStep.Checked) { optionalStep = "Yes"; }

                if (validStep) {

                    string[] row = new string[] { "-",
                    stepDescription,
                    operation,
                    action,
                    optionalStep,
                    elementDescription,
                    identifierType,
                    identifierValue,
                    testDataTable,
                    testDataColumn,
                    staticDataValue,
                    conditionDataTable,
                    conditionDataColumn,
                    conditionDataValue };

                    gridviewScript.Rows.Insert(insertIndex, row);
                    inProgress = true;
                }
                else {
                    MessageBox.Show("Please fill out all of the required fields before adding the step to the current script.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_GenerateNewScript()
        {
            try {

                string scriptName;
                string labelText = "New Script Name:";
                string buttonText = "Save Script";
                string messageText = "Message: Existing script with the same name will be replaced.";

                FormDataRetrieval dataRetrieval;
                dataRetrieval = new FormDataRetrieval(labelText, buttonText, messageText);
                DialogResult dialogResult = dataRetrieval.ShowDialog();

                if (dialogResult == DialogResult.OK) {

                    scriptName = dataRetrieval.dataValue.ToUpper();
                    event_SaveScript(scriptName);
                    scriptList.Add(scriptName);
                    dropdownScriptList.Items.Add(scriptName);
                    labelScript.Text = "Script: " + scriptName;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_SaveScript(string scriptName)
        {
            try {

                string scriptPath = scriptsDirectory + "\\" + scriptName + ".xml";

                XmlWriterSettings xmlSettings = new XmlWriterSettings();
                xmlSettings.Encoding = Encoding.UTF8;
                xmlSettings.Indent = true;

                xml = XmlWriter.Create(scriptPath, xmlSettings);
                xml.WriteStartDocument();
                xml.WriteStartElement("Steps");
                int stepIndex = 1;

                ArrayList nodeNames = new ArrayList();
                nodeNames.Add("StepNumber");
                nodeNames.Add("Description");
                nodeNames.Add("Operation");
                nodeNames.Add("Action");
                nodeNames.Add("OptionalStep");
                nodeNames.Add("ElementDescription");
                nodeNames.Add("IdentifierType");
                nodeNames.Add("IdentifierValue");
                nodeNames.Add("TestDataTable");
                nodeNames.Add("TestDataColumn");
                nodeNames.Add("StaticDataValue");
                nodeNames.Add("ConditionDataTable");
                nodeNames.Add("ConditionDataColumn");
                nodeNames.Add("ConditionDataValue");

                foreach (DataGridViewRow row in gridviewScript.Rows) {

                    xml.WriteStartElement("Step");
                    xml.WriteAttributeString("id", stepIndex.ToString());
                    event_CreateScriptNode(nodeNames, row);
                    xml.WriteEndElement();
                    stepIndex++;
                }

                xml.WriteEndElement();
                xml.WriteEndDocument();
                xml.Close();
                xml = null;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_CreateScriptNode(ArrayList nodeNames, DataGridViewRow row)
        {
            try {

                for (int index = 1; index < row.Cells.Count; index++) {

                    var value = row.Cells[index].Value;
                    if (value == null) { value = ""; }
                    else { value = value.ToString(); }

                    xml.WriteStartElement((string)nodeNames[index]);
                    xml.WriteString((string)value);
                    xml.WriteEndElement();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_DeleteSpecifiedScript(string scriptPath, string scriptName)
        {
            if (File.Exists(scriptPath)) {

                File.Delete(scriptPath);
                scriptList.Remove(scriptName);
                dropdownScriptList.Items.Remove(scriptName);
            }
            else {
                MessageBox.Show("ERROR: Script does not exist so it could not be deleted.");
            }
        }

        private void event_EnableActionDataControls(string operation, string action)
        {
            try {

                reset_AllLabels();
                reset_AllTextBoxes();
                reset_AllDropdowns();
                reset_AllCheckBoxes();
                reset_AllButtons(true);

                labelDescription.ForeColor = requiredLabelColor;
                textboxDescription.Enabled = true;

                checkboxOptionalStep.ForeColor = requiredLabelColor;
                checkboxOptionalStep.Enabled = true;

                checkboxApplyCondition.ForeColor = requiredLabelColor;
                checkboxApplyCondition.Enabled = true;

                objectRequired = actionFieldDictionary[operation + "." + action + ".ObjectRequired"];
                if (objectRequired.Equals("Yes")) { event_EnableElementControls(true, requiredLabelColor); }

                useDataValue = actionFieldDictionary[operation + "." + action + ".UseDataValue"];
                if (useDataValue.Equals("Yes")) { event_EnableTestDataControls(true, requiredLabelColor); }

                string description = actionFieldDictionary[operation + "." + action + ".ActionDescription"];
                labelActionDescription.Text = "Action Description: " + description;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_EnableTestDatabaseControls(bool isEnabled, Color color)
        {
            try {

                labelTestDataTable.ForeColor = color;
                labelTestDataColumn.ForeColor = color;

                dropdownTestDataTable.SelectedItem = "";
                dropdownTestDataColumn.SelectedItem = "";

                dropdownTestDataTable.Enabled = isEnabled;
                dropdownTestDataColumn.Enabled = isEnabled;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_EnableElementControls(bool isEnabled, Color color)
        {
            try {

                labelElementDescription.ForeColor = color;
                labelIdentifierType.ForeColor = color;
                labelIdentifierValue.ForeColor = color;

                textboxElementDescription.Text = "";
                dropdownIdentifierType.SelectedItem = "";
                textboxIdentifierValue.Text = "";

                textboxElementDescription.Enabled = isEnabled;
                dropdownIdentifierType.Enabled = isEnabled;
                textboxIdentifierValue.Enabled = isEnabled;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_EnableTestDataControls(bool isEnabled, Color color)
        {
            try {

                labelDataValue.ForeColor = color;
                textboxDataValue.Text = "";
                textboxDataValue.Enabled = isEnabled;

                checkboxUseTestDatabase.ForeColor = requiredLabelColor;
                checkboxUseTestDatabase.Enabled = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_EnableConditionDataControls(bool isEnabled, Color color)
        {
            try {

                labelConditionDataTable.ForeColor = color;
                labelConditionDataColumn.ForeColor = color;
                labelConditionDataValue.ForeColor = color;

                dropdownConditionDataTable.SelectedItem = "";
                dropdownConditionDataColumn.SelectedItem = "";
                textboxConditionDataValue.Text = "";

                dropdownConditionDataTable.Enabled = isEnabled;
                dropdownConditionDataColumn.Enabled = isEnabled;
                textboxConditionDataValue.Enabled = isEnabled;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void reset_AllLabels()
        {
            try {

                labelActionDescription.Text = "";
                labelDescription.ForeColor = defaultLabelColor;
                labelElementDescription.ForeColor = defaultLabelColor;
                labelIdentifierType.ForeColor = defaultLabelColor;
                labelIdentifierValue.ForeColor = defaultLabelColor;
                labelTestDataTable.ForeColor = defaultLabelColor;
                labelTestDataColumn.ForeColor = defaultLabelColor;
                labelDataValue.ForeColor = defaultLabelColor;
                labelConditionDataTable.ForeColor = defaultLabelColor;
                labelConditionDataColumn.ForeColor = defaultLabelColor;
                labelConditionDataValue.ForeColor = defaultLabelColor;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void reset_AllTextBoxes()
        {
            try {

                textboxDescription.Text = "";
                textboxElementDescription.Text = "";
                textboxIdentifierValue.Text = "";
                textboxDataValue.Text = "";
                textboxConditionDataValue.Text = "";

                textboxDescription.Enabled = false;
                textboxElementDescription.Enabled = false;
                textboxIdentifierValue.Enabled = false;
                textboxDataValue.Enabled = false;
                textboxConditionDataValue.Enabled = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void reset_AllDropdowns()
        {
            try {

                dropdownIdentifierType.SelectedItem = "";
                dropdownTestDataTable.SelectedItem = "";
                dropdownTestDataColumn.SelectedItem = "";
                dropdownConditionDataTable.SelectedItem = "";
                dropdownConditionDataColumn.SelectedItem = "";

                dropdownIdentifierType.Enabled = false;
                dropdownTestDataTable.Enabled = false;
                dropdownTestDataColumn.Enabled = false;
                dropdownConditionDataTable.Enabled = false;
                dropdownConditionDataColumn.Enabled = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void reset_AllCheckBoxes()
        {
            try {

                checkboxUseTestDatabase.Checked = false;
                checkboxUseTestDatabase.Enabled = false;
                checkboxUseTestDatabase.ForeColor = defaultLabelColor;

                checkboxApplyCondition.Checked = false;
                checkboxApplyCondition.Enabled = false;
                checkboxApplyCondition.ForeColor = defaultLabelColor;

                checkboxOptionalStep.Checked = false;
                checkboxOptionalStep.Enabled = false;
                checkboxOptionalStep.ForeColor = defaultLabelColor;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void reset_AllButtons(bool isEnabled)
        {
            try {

                buttonAddStep.Enabled = isEnabled;
                buttonAddStepBelowSelection.Enabled = isEnabled;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void reset_Everything()
        {
            reset_AllLabels();
            reset_AllTextBoxes();
            reset_AllDropdowns();
            reset_AllCheckBoxes();
            reset_AllButtons(false);
        }

        public bool event_InProgress { get => inProgress; }
    }
}