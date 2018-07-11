using System;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Collections;
using System.Drawing;
using MetroFramework.Controls;
using MaterialSkin.Controls;

namespace StreamLineUi
{
    internal class ModelComponentBuilder { }

    public partial class ControlComponentEditor : UserControl
    {
        //***************************************************************************************************************
        // Initial Setup Methods
        //***************************************************************************************************************



        private void initialize_SetComponentsDirectory()
        {
            string scriptsDirectory = Directory.GetCurrentDirectory() + "\\Resources\\Scripts\\";
            string scriptDirectory = scriptsDirectory + formMain.settingsInfo["ScriptName"];
            componentsDirectory = scriptDirectory + "\\Components";
        }

        private void initialize_ActionsList()
        {
            string resourceDirectory = Directory.GetCurrentDirectory() + "\\Resources";
            string filePath = resourceDirectory + "\\Setup\\ActionsList.xml";

            XmlNodeList primaryNodes;
            primaryNodes = common.event_LoadXmlPrimaryNodes(filePath, "Operation");
            initialize_LoadingActionsList(primaryNodes);
        }

        private void initialize_LoadingActionsList(XmlNodeList primaryNodes)
        {
            foreach (XmlNode primaryNode in primaryNodes) {

                string operation = primaryNode.Attributes["value"].Value;
                XmlNodeList actionNodes = primaryNode.ChildNodes;
                dropdownOperation.Items.Add(operation);
                initialize_AnalyzeAction(operation, actionNodes);
            }
        }

        private void initialize_AnalyzeAction(string operation, XmlNodeList actionNodes)
        {
            ArrayList actionList = new ArrayList();

            foreach (XmlNode actionNode in actionNodes) {

                string action = actionNode.Attributes["value"].Value;
                XmlNodeList childNodes = actionNode.ChildNodes;
                initialize_AnalyzeActionSettings(childNodes, operation, action);
                actionList.Add(action);
            }

            actionsDictionary.Add(operation, actionList);
        }

        private void initialize_AnalyzeActionSettings(XmlNodeList childNodes, string operation, string action)
        {
            foreach (XmlNode childNode in childNodes) {

                string key = operation + "." + action + "." + childNode.Name;
                string value = childNode.InnerText;
                actionSettings.Add(key, value);
            }
        }

        private void initialize_DatabaseMapping()
        {
            dataColumnsDictionary.Add(String.Empty, new ArrayList());
            conditionColumnsDictionary.Add(String.Empty, new ArrayList());
            dropdownTestDataTable.Items.Add(String.Empty);
            dropdownConditionDataTable.Items.Add(String.Empty);
            ArrayList tableList = database.event_RetrieveTableList();

            foreach (string tableName in tableList) {

                dropdownTestDataTable.Items.Add(tableName);
                dropdownConditionDataTable.Items.Add(tableName);

                dataColumnsDictionary.Add(tableName, database.event_RetrieveColumnList(tableName));
                conditionColumnsDictionary.Add(tableName, database.event_RetrieveColumnList(tableName));
            }
        }

        private void initialize_ComponentsList()
        {
            ArrayList componentList = new ArrayList();
            componentList = common.event_GetDirectoryFileList(componentsDirectory);

            foreach (string component in componentList) {
                dropdownComponentList.Items.Add(component);
            }
        }

        private void initialize_GridviewColumns()
        {
            gridview.Columns.Add("StepNumber", "Step Number");
            gridview.Columns.Add("Operation", "Operation");
            gridview.Columns.Add("Action", "Action");
            gridview.Columns.Add("OptionalStep", "Optional Step");
            gridview.Columns.Add("ElementName", "Element Name");
            gridview.Columns.Add("IdentifierType", "Identifier Type");
            gridview.Columns.Add("IdentifierValue", "Identifier Value");
            gridview.Columns.Add("WaitTime", "Wait Time");
            gridview.Columns.Add("TestDataTable", "Test Data Table");
            gridview.Columns.Add("TestDataColumn", "Test Data Column");
            gridview.Columns.Add("StaticDataValue", "Static Data Value");
            gridview.Columns.Add("ConditionDataTable", "Condition Data Table");
            gridview.Columns.Add("ConditionDataColumn", "Condition Data Column");
            gridview.Columns.Add("ConditionDataValue", "Condition Data Value");
            gridview.Columns["StepNumber"].Frozen = true;
        }

        private void initialize_IdentifierTypes()
        {
            dropdownIdentifierType.Items.Add(String.Empty);
            dropdownIdentifierType.Items.Add("ID");
            dropdownIdentifierType.Items.Add("Name");
            dropdownIdentifierType.Items.Add("Link-Text");
            dropdownIdentifierType.Items.Add("Partial-Link-Text");
            dropdownIdentifierType.Items.Add("Tag-Name");
            dropdownIdentifierType.Items.Add("Class-Name");
            dropdownIdentifierType.Items.Add("Css-Selector");
            dropdownIdentifierType.Items.Add("Xpath");
        }

        private void initialize_ChangeUiColor()
        {
            Color color = common.event_RetrieveUiColor(formMain.settingsInfo["UiColor"]);
            gridview.DefaultCellStyle.SelectionBackColor = color;
            common.event_ChangeButtonsColor(this, color);
        }

        private void initialize_ComponentStepsAnalysis(XmlNodeList primaryNodes)
        {
            foreach (XmlNode primaryNode in primaryNodes) {

                string stepId = primaryNode.Attributes["id"].Value;
                XmlNodeList stepNodes = primaryNode.ChildNodes;
                initialize_AddComponentStepToGridview(stepId, stepNodes);
            }
        }

        private void initialize_AddComponentStepToGridview(string stepId, XmlNodeList stepNodes)
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
                stepNodes[12].InnerText};

            gridview.Rows.Add(row);
        }



        //***************************************************************************************************************
        // Action Events Handler Methods
        //***************************************************************************************************************



        private string event_RetrieveLoadedComponentName()
        {
            string componentName;

            try {
                componentName = labelComponentName.Text.Substring(11);
            }
            catch (Exception ex) {
                string message = "Provide a new component name to save the current component steps.";
                componentName = event_RetrieveComponentName("Create Component", message);
            }

            return componentName;
        }

        private string event_RetrieveComponentName(string buttonText, string messageText)
        {
            string labelText = "Component Name:";
            FormDataRetrieval dataRetrieval;
            dataRetrieval = new FormDataRetrieval(formMain.settingsInfo["UiColor"], labelText, buttonText, messageText);
            var dialogResult = dataRetrieval.ShowDialog();

            if (dialogResult != DialogResult.OK) { return ""; }
            else { return dataRetrieval.UserSpecifiedDataValue; }
        }

        private void event_SaveComponent(string componentName)
        {
            bool componentSaved = event_CreateComponentXml(componentName);
            event_CheckComponentNameInList(componentName);
            labelComponentName.Text = "Component: " + componentName;

            if (componentSaved) { MessageBox.Show("'" + componentName + "' component has been saved."); }
            else { MessageBox.Show("'" + componentName + "' component could not be saved."); }
        }

        private bool event_CreateComponentXml(string componentName)
        {
            try {

                string filePath = componentsDirectory + "\\" + componentName + ".xml";
                ArrayList nodeNames = event_RetrieveColumnNamesList();

                XmlWriterSettings xmlSettings = new XmlWriterSettings();
                xmlSettings.Encoding = Encoding.UTF8;
                xmlSettings.Indent = true;

                XmlWriter xml = XmlWriter.Create(filePath, xmlSettings);
                xml.WriteStartDocument();
                xml.WriteStartElement("Steps");
                int stepIndex = 1;

                foreach (DataGridViewRow row in gridview.Rows) {

                    xml.WriteStartElement("Step");
                    xml.WriteAttributeString("id", stepIndex.ToString());
                    event_CreateComponentStepNodes(xml, nodeNames, row);
                    xml.WriteEndElement();
                    stepIndex++;
                }

                xml.WriteEndElement();
                xml.WriteEndDocument();
                xml.Close();
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        private ArrayList event_RetrieveColumnNamesList()
        {
            ArrayList columnNames = new ArrayList();

            foreach (DataGridViewColumn column in gridview.Columns) {
                columnNames.Add(column.Name);
            }

            return columnNames;
        }

        private void event_CreateComponentStepNodes(XmlWriter xml, ArrayList nodeNames, DataGridViewRow row)
        {
            try {

                for (int cellIndex = 1; cellIndex < row.Cells.Count; cellIndex++) {

                    string dataValue = gridviewManager.event_RetrieveCellDataValue(row, cellIndex);
                    xml.WriteStartElement((string)nodeNames[cellIndex]);
                    xml.WriteString(dataValue);
                    xml.WriteEndElement();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_CheckComponentNameInList(string componentName)
        {
            if (dropdownComponentList.FindStringExact(componentName) < 0) { }

            if (dropdownComponentList.FindStringExact(componentName) >= 0) {
                dropdownComponentList.Text = dropdownComponentList.
                    Items[dropdownComponentList.FindStringExact(componentName)].ToString();
            }
            else {
                dropdownComponentList.Items.Add(componentName);
                dropdownComponentList.Text = componentName;
            }
        }

        private void event_DeleteSpecifiedComponent(string componentPath, string componentName)
        {
            try {

                if (File.Exists(componentPath)) {
                    File.Delete(componentPath);
                    dropdownComponentList.Items.Remove(componentName);
                }
                else {
                    MessageBox.Show("ERROR: Component does not exist so it could not be deleted.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_EnableActionDataControls(string operation, string action)
        {
            string elementName = actionSettings[operation + "." + action + ".ElementName"];
            string identifierType = actionSettings[operation + "." + action + ".IdentifierType"];
            string identifierValue = actionSettings[operation + "." + action + ".IdentifierValue"];
            string waitTime = actionSettings[operation + "." + action + ".WaitTime"];
            string dataTable = actionSettings[operation + "." + action + ".DataTable"];
            string dataColumn = actionSettings[operation + "." + action + ".DataColumn"];
            string dataValue = actionSettings[operation + "." + action + ".DataValue"];
            string conditionTable = actionSettings[operation + "." + action + ".ConditionTable"];
            string conditionColumn = actionSettings[operation + "." + action + ".ConditionColumn"];
            string conditionValue = actionSettings[operation + "." + action + ".ConditionValue"];
            string description = actionSettings[operation + "." + action + ".ActionDescription"];

            event_EnableUseDatabaseCheckbox(dataTable, dataColumn);
            event_EnableElementControls(elementName.Equals("Yes") && identifierType.Equals("Yes") && identifierValue.Equals("Yes"));
            event_EnableTestDatabaseControls(dataTable.Equals("Yes") && dataColumn.Equals("Yes"));
            event_EnableWaitTimeControls(waitTime.Equals("Yes"));
            event_EnableTestDataControls(dataValue.Equals("Yes"));
            labelActionDescription.Text = "Description: " + description;
        }

        private void event_EnableUseDatabaseCheckbox(string dataTable, string dataColumn)
        {
            string useDatabase = actionSettings[dropdownOperation.Text + "." + dropdownAction.Text + ".UseDatabase"];
            string optional = actionSettings[dropdownOperation.Text + "." + dropdownAction.Text + ".Optional"];
            string applyCondition = actionSettings[dropdownOperation.Text + "." + dropdownAction.Text + ".ApplyCondition"];

            bool isChecked = dataTable.Equals("Yes") && dataColumn.Equals("Yes");
            checkboxUseDatabase.Checked = dataTable.Equals("Yes") && dataColumn.Equals("Yes");
            checkboxUseDatabase.Enabled = useDatabase.Equals("Yes") && !isChecked;
            checkboxOptionalStep.Enabled = optional.Equals("Yes");
            checkboxApplyCondition.Enabled = applyCondition.Equals("Yes");
        }

        private void event_EnableElementControls(bool isEnabled)
        {
            Color color = event_RetrieveLabelColor(isEnabled);
            labelElementName.ForeColor = color;
            labelIdentifierType.ForeColor = color;
            labelIdentifierValue.ForeColor = color;

            textboxElementName.Text = String.Empty;
            dropdownIdentifierType.ResetText();
            textboxIdentifierValue.Text = String.Empty;

            textboxElementName.Enabled = isEnabled;
            dropdownIdentifierType.Enabled = isEnabled;
            textboxIdentifierValue.Enabled = isEnabled;
        }

        private void event_EnableTestDatabaseControls(bool isEnabled)
        {
            Color color = event_RetrieveLabelColor(isEnabled);
            labelTestDataTable.ForeColor = color;
            labelTestDataColumn.ForeColor = color;

            dropdownTestDataTable.ResetText();
            dropdownTestDataColumn.ResetText();

            dropdownTestDataTable.Enabled = isEnabled;
            dropdownTestDataColumn.Enabled = isEnabled;
        }

        private void event_EnableWaitTimeControls(bool isEnabled)
        {
            labelWaitTime.ForeColor = event_RetrieveLabelColor(isEnabled);
            textboxWaitTime.Text = String.Empty;
            textboxWaitTime.Enabled = isEnabled;
        }

        private void event_EnableTestDataControls(bool isEnabled)
        {
            labelDataValue.ForeColor = event_RetrieveLabelColor(isEnabled);
            textboxDataValue.Text = String.Empty;
            textboxDataValue.Enabled = isEnabled;
        }

        private void event_EnableConditionDataControls(bool isEnabled)
        {
            Color color = event_RetrieveLabelColor(isEnabled);
            labelConditionDataTable.ForeColor = color;
            labelConditionDataColumn.ForeColor = color;
            labelConditionDataValue.ForeColor = color;

            dropdownConditionDataTable.ResetText();
            dropdownConditionDataColumn.ResetText();
            textboxConditionDataValue.Text = String.Empty;

            dropdownConditionDataTable.Enabled = isEnabled;
            dropdownConditionDataColumn.Enabled = isEnabled;
            textboxConditionDataValue.Enabled = isEnabled;
        }

        private Color event_RetrieveLabelColor(bool isEnabled)
        {
            if (isEnabled) { return Color.Red; }
            else { return Color.FromArgb(64, 64, 64); }
        }

        private void event_ResetEverything()
        {
            event_EnableElementControls(false);
            event_EnableTestDatabaseControls(false);
            event_EnableTestDataControls(false);
            event_EnableWaitTimeControls(false);
            event_ResetCheckboxControls(false);
            event_EnableConditionDataControls(false);
            labelActionDescription.Text = String.Empty;
        }

        private void event_ResetCheckboxControls(bool isActive)
        {
            checkboxUseDatabase.Enabled = isActive;
            checkboxApplyCondition.Enabled = isActive;
            checkboxOptionalStep.Enabled = isActive;

            checkboxUseDatabase.Checked = isActive;
            checkboxApplyCondition.Checked = isActive;
            checkboxOptionalStep.Checked = isActive;
        }

        private bool event_ValidateControls()
        {
            if (dropdownOperation.Text.Length == 0) { return false; }
            if (dropdownAction.Text.Length == 0) { return false; }
            
            string message = "Please fill in all of the required fields (labels colored red).";
            if (!event_ValidateTextboxControl(textboxElementName, message)) { return false; }
            if (!event_ValidateDropdownControl(dropdownIdentifierType, message)) { return false; }
            if (!event_ValidateTextboxControl(textboxIdentifierValue, message)) { return false; }
            if (!event_ValidateTextboxControl(textboxWaitTime, message)) { return false; }
            if (!event_ValidateDropdownControl(dropdownTestDataTable, message)) { return false; }
            if (!event_ValidateDropdownControl(dropdownTestDataColumn, message)) { return false; }
            if (!event_ValidateDropdownControl(dropdownConditionDataTable, message)) { return false; }
            if (!event_ValidateDropdownControl(dropdownConditionDataColumn, message)) { return false; }
            if (!event_ValidateTextboxControl(textboxConditionDataValue, message)) { return false; }

            return true;
        }

        private bool event_ValidateDropdownControl(MetroComboBox dropdown, string message)
        {
            if (dropdown.Enabled && dropdown.Text.Length > 0) { return true; }
            else if (!dropdown.Enabled) { return true; }
            else { MessageBox.Show(message); return false; }
        }

        private bool event_ValidateTextboxControl(MaterialSingleLineTextField textbox, string message)
        {
            if (textbox.Enabled && textbox.Text.Length > 0) { return true; }
            else if (!textbox.Enabled) { return true; }
            else { MessageBox.Show(message); return false; }
        }

        private void event_AddStepToGridview(int insertIndex)
        {
            try {

                string optionalStep;
                if (checkboxOptionalStep.Checked) { optionalStep = "Yes"; }
                else { optionalStep = "No"; }

                string[] row = new string[] { "-",
                    dropdownOperation.Text,
                    dropdownAction.Text,
                    optionalStep,
                    textboxElementName.Text,
                    dropdownIdentifierType.Text,
                    textboxIdentifierValue.Text,
                    textboxWaitTime.Text,
                    dropdownTestDataTable.Text,
                    dropdownTestDataColumn.Text,
                    textboxDataValue.Text,
                    dropdownConditionDataTable.Text,
                    dropdownConditionDataColumn.Text,
                    textboxConditionDataValue.Text };

                gridview.Rows.Insert(insertIndex, row);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_CopyStepAction()
        {
            DataGridViewRow row = gridview.SelectedRows[0];
            dropdownOperation.Text = gridviewManager.event_RetrieveCellDataValue(row, 1);
            dropdownAction.Text = gridviewManager.event_RetrieveCellDataValue(row, 2);
        }

        private void event_CopyStepValues()
        {
            DataGridViewRow row = gridview.SelectedRows[0];

            checkboxOptionalStep.Checked = gridviewManager.event_RetrieveCellDataValue(row, 3).Equals("Yes");
            textboxElementName.Text = gridviewManager.event_RetrieveCellDataValue(row, 4);
            dropdownIdentifierType.Text = gridviewManager.event_RetrieveCellDataValue(row, 5);
            textboxIdentifierValue.Text = gridviewManager.event_RetrieveCellDataValue(row, 6);
            textboxWaitTime.Text = gridviewManager.event_RetrieveCellDataValue(row, 7);

            string dataTable = gridviewManager.event_RetrieveCellDataValue(row, 8);
            string dataColumn = gridviewManager.event_RetrieveCellDataValue(row, 9);
            checkboxUseDatabase.Checked = dataTable.Length > 0 && dataColumn.Length > 0;

            dropdownTestDataTable.Text = dataTable;
            dropdownTestDataColumn.Text = dataColumn;
            textboxDataValue.Text = gridviewManager.event_RetrieveCellDataValue(row, 10);

            string conditionTable = gridviewManager.event_RetrieveCellDataValue(row, 11);
            string conditionColumn = gridviewManager.event_RetrieveCellDataValue(row, 12);
            checkboxApplyCondition.Checked = conditionTable.Length > 0 && conditionColumn.Length > 0;

            dropdownConditionDataTable.Text = conditionTable;
            dropdownConditionDataColumn.Text = conditionColumn;
            textboxConditionDataValue.Text = gridviewManager.event_RetrieveCellDataValue(row, 13);
        }
    }
}