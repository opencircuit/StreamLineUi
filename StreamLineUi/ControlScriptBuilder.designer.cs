namespace StreamLineUi
{
    partial class ControlScriptBuilder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCreateScript = new System.Windows.Forms.Button();
            this.buttonLoadScript = new System.Windows.Forms.Button();
            this.panelScriptBackground = new System.Windows.Forms.Panel();
            this.gridviewScript = new MetroFramework.Controls.MetroGrid();
            this.labelScript = new System.Windows.Forms.Label();
            this.labelScriptList = new System.Windows.Forms.Label();
            this.dropdownScriptList = new MetroFramework.Controls.MetroComboBox();
            this.buttonSaveScript = new System.Windows.Forms.Button();
            this.labelOperation = new System.Windows.Forms.Label();
            this.dropdownOperation = new MetroFramework.Controls.MetroComboBox();
            this.labelAction = new System.Windows.Forms.Label();
            this.dropdownAction = new MetroFramework.Controls.MetroComboBox();
            this.textboxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.checkboxUseTestDatabase = new System.Windows.Forms.CheckBox();
            this.labelTestDataTable = new System.Windows.Forms.Label();
            this.dropdownTestDataTable = new MetroFramework.Controls.MetroComboBox();
            this.textboxDataValue = new System.Windows.Forms.TextBox();
            this.labelDataValue = new System.Windows.Forms.Label();
            this.labelTestDataColumn = new System.Windows.Forms.Label();
            this.dropdownTestDataColumn = new MetroFramework.Controls.MetroComboBox();
            this.buttonAddStepBelowSelection = new System.Windows.Forms.Button();
            this.buttonAddStep = new System.Windows.Forms.Button();
            this.buttonMoveStepUp = new System.Windows.Forms.Button();
            this.buttonMoveStepDown = new System.Windows.Forms.Button();
            this.checkboxOptionalStep = new System.Windows.Forms.CheckBox();
            this.buttonDeleteStep = new System.Windows.Forms.Button();
            this.buttonResetDataFields = new System.Windows.Forms.Button();
            this.labelConditionDataColumn = new System.Windows.Forms.Label();
            this.dropdownConditionDataColumn = new MetroFramework.Controls.MetroComboBox();
            this.labelConditionDataTable = new System.Windows.Forms.Label();
            this.dropdownConditionDataTable = new MetroFramework.Controls.MetroComboBox();
            this.textboxConditionDataValue = new System.Windows.Forms.TextBox();
            this.labelConditionDataValue = new System.Windows.Forms.Label();
            this.checkboxApplyCondition = new System.Windows.Forms.CheckBox();
            this.buttonDeleteScript = new System.Windows.Forms.Button();
            this.labelIdentifierValue = new System.Windows.Forms.Label();
            this.labelIdentifierType = new System.Windows.Forms.Label();
            this.dropdownIdentifierType = new MetroFramework.Controls.MetroComboBox();
            this.textboxElementDescription = new System.Windows.Forms.TextBox();
            this.labelElementDescription = new System.Windows.Forms.Label();
            this.textboxIdentifierValue = new System.Windows.Forms.TextBox();
            this.labelActionDescription = new System.Windows.Forms.Label();
            this.panelScriptBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewScript)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateScript
            // 
            this.buttonCreateScript.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCreateScript.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateScript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateScript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateScript.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateScript.ForeColor = System.Drawing.Color.White;
            this.buttonCreateScript.Location = new System.Drawing.Point(542, 33);
            this.buttonCreateScript.Name = "buttonCreateScript";
            this.buttonCreateScript.Size = new System.Drawing.Size(100, 29);
            this.buttonCreateScript.TabIndex = 0;
            this.buttonCreateScript.Text = "Create Script";
            this.buttonCreateScript.UseVisualStyleBackColor = false;
            this.buttonCreateScript.Click += new System.EventHandler(this.action_CreateScript);
            // 
            // buttonLoadScript
            // 
            this.buttonLoadScript.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLoadScript.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadScript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadScript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadScript.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadScript.ForeColor = System.Drawing.Color.White;
            this.buttonLoadScript.Location = new System.Drawing.Point(330, 33);
            this.buttonLoadScript.Name = "buttonLoadScript";
            this.buttonLoadScript.Size = new System.Drawing.Size(100, 29);
            this.buttonLoadScript.TabIndex = 0;
            this.buttonLoadScript.Text = "Load Script";
            this.buttonLoadScript.UseVisualStyleBackColor = false;
            this.buttonLoadScript.Click += new System.EventHandler(this.action_LoadScript);
            // 
            // panelScriptBackground
            // 
            this.panelScriptBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelScriptBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelScriptBackground.Controls.Add(this.gridviewScript);
            this.panelScriptBackground.Controls.Add(this.labelScript);
            this.panelScriptBackground.Location = new System.Drawing.Point(33, 246);
            this.panelScriptBackground.Name = "panelScriptBackground";
            this.panelScriptBackground.Padding = new System.Windows.Forms.Padding(5);
            this.panelScriptBackground.Size = new System.Drawing.Size(1394, 526);
            this.panelScriptBackground.TabIndex = 0;
            // 
            // gridviewScript
            // 
            this.gridviewScript.AllowUserToAddRows = false;
            this.gridviewScript.AllowUserToDeleteRows = false;
            this.gridviewScript.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.gridviewScript.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewScript.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridviewScript.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridviewScript.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridviewScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewScript.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridviewScript.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewScript.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewScript.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewScript.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewScript.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridviewScript.EnableHeadersVisualStyles = false;
            this.gridviewScript.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridviewScript.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridviewScript.Location = new System.Drawing.Point(5, 37);
            this.gridviewScript.Name = "gridviewScript";
            this.gridviewScript.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewScript.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridviewScript.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridviewScript.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewScript.Size = new System.Drawing.Size(1382, 482);
            this.gridviewScript.TabIndex = 21;
            // 
            // labelScript
            // 
            this.labelScript.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelScript.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScript.ForeColor = System.Drawing.Color.White;
            this.labelScript.Location = new System.Drawing.Point(5, 5);
            this.labelScript.Name = "labelScript";
            this.labelScript.Size = new System.Drawing.Size(1382, 29);
            this.labelScript.TabIndex = 0;
            this.labelScript.Text = "Script:";
            this.labelScript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScriptList
            // 
            this.labelScriptList.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScriptList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelScriptList.Location = new System.Drawing.Point(33, 33);
            this.labelScriptList.Margin = new System.Windows.Forms.Padding(0);
            this.labelScriptList.Name = "labelScriptList";
            this.labelScriptList.Size = new System.Drawing.Size(88, 29);
            this.labelScriptList.TabIndex = 0;
            this.labelScriptList.Text = "Script List:";
            this.labelScriptList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownScriptList
            // 
            this.dropdownScriptList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownScriptList.FormattingEnabled = true;
            this.dropdownScriptList.ItemHeight = 23;
            this.dropdownScriptList.Location = new System.Drawing.Point(124, 33);
            this.dropdownScriptList.Name = "dropdownScriptList";
            this.dropdownScriptList.Size = new System.Drawing.Size(200, 29);
            this.dropdownScriptList.TabIndex = 0;
            this.dropdownScriptList.UseSelectable = true;
            // 
            // buttonSaveScript
            // 
            this.buttonSaveScript.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSaveScript.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveScript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveScript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveScript.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveScript.ForeColor = System.Drawing.Color.White;
            this.buttonSaveScript.Location = new System.Drawing.Point(436, 33);
            this.buttonSaveScript.Name = "buttonSaveScript";
            this.buttonSaveScript.Size = new System.Drawing.Size(100, 29);
            this.buttonSaveScript.TabIndex = 0;
            this.buttonSaveScript.Text = "Save Script";
            this.buttonSaveScript.UseVisualStyleBackColor = false;
            this.buttonSaveScript.Click += new System.EventHandler(this.action_SaveScript);
            // 
            // labelOperation
            // 
            this.labelOperation.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelOperation.Location = new System.Drawing.Point(33, 74);
            this.labelOperation.Margin = new System.Windows.Forms.Padding(0);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(86, 26);
            this.labelOperation.TabIndex = 0;
            this.labelOperation.Text = "Operation:";
            this.labelOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownOperation
            // 
            this.dropdownOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownOperation.FormattingEnabled = true;
            this.dropdownOperation.ItemHeight = 23;
            this.dropdownOperation.Location = new System.Drawing.Point(124, 72);
            this.dropdownOperation.Name = "dropdownOperation";
            this.dropdownOperation.Size = new System.Drawing.Size(200, 29);
            this.dropdownOperation.TabIndex = 0;
            this.dropdownOperation.UseSelectable = true;
            this.dropdownOperation.SelectedIndexChanged += new System.EventHandler(this.action_SelectOperation);
            // 
            // labelAction
            // 
            this.labelAction.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAction.Location = new System.Drawing.Point(33, 107);
            this.labelAction.Margin = new System.Windows.Forms.Padding(0);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(86, 29);
            this.labelAction.TabIndex = 0;
            this.labelAction.Text = "Action:";
            this.labelAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownAction
            // 
            this.dropdownAction.Enabled = false;
            this.dropdownAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownAction.FormattingEnabled = true;
            this.dropdownAction.ItemHeight = 23;
            this.dropdownAction.Location = new System.Drawing.Point(124, 107);
            this.dropdownAction.Name = "dropdownAction";
            this.dropdownAction.Size = new System.Drawing.Size(200, 29);
            this.dropdownAction.TabIndex = 0;
            this.dropdownAction.UseSelectable = true;
            this.dropdownAction.SelectedIndexChanged += new System.EventHandler(this.action_SelectAction);
            // 
            // textboxDescription
            // 
            this.textboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxDescription.Enabled = false;
            this.textboxDescription.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDescription.Location = new System.Drawing.Point(124, 142);
            this.textboxDescription.Name = "textboxDescription";
            this.textboxDescription.Size = new System.Drawing.Size(200, 26);
            this.textboxDescription.TabIndex = 0;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDescription.Location = new System.Drawing.Point(33, 142);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(88, 26);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Description:";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkboxUseTestDatabase
            // 
            this.checkboxUseTestDatabase.AutoSize = true;
            this.checkboxUseTestDatabase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxUseTestDatabase.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxUseTestDatabase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxUseTestDatabase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxUseTestDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxUseTestDatabase.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxUseTestDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxUseTestDatabase.Location = new System.Drawing.Point(853, 38);
            this.checkboxUseTestDatabase.Name = "checkboxUseTestDatabase";
            this.checkboxUseTestDatabase.Size = new System.Drawing.Size(149, 20);
            this.checkboxUseTestDatabase.TabIndex = 0;
            this.checkboxUseTestDatabase.Text = "Use Test Database";
            this.checkboxUseTestDatabase.UseVisualStyleBackColor = true;
            this.checkboxUseTestDatabase.CheckedChanged += new System.EventHandler(this.action_UseTestDatabase);
            // 
            // labelTestDataTable
            // 
            this.labelTestDataTable.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTestDataTable.Location = new System.Drawing.Point(719, 72);
            this.labelTestDataTable.Margin = new System.Windows.Forms.Padding(0);
            this.labelTestDataTable.Name = "labelTestDataTable";
            this.labelTestDataTable.Size = new System.Drawing.Size(131, 29);
            this.labelTestDataTable.TabIndex = 0;
            this.labelTestDataTable.Text = "Test Data Table:";
            this.labelTestDataTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownTestDataTable
            // 
            this.dropdownTestDataTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownTestDataTable.FormattingEnabled = true;
            this.dropdownTestDataTable.ItemHeight = 23;
            this.dropdownTestDataTable.Location = new System.Drawing.Point(853, 72);
            this.dropdownTestDataTable.Name = "dropdownTestDataTable";
            this.dropdownTestDataTable.Size = new System.Drawing.Size(200, 29);
            this.dropdownTestDataTable.TabIndex = 0;
            this.dropdownTestDataTable.UseSelectable = true;
            this.dropdownTestDataTable.SelectedIndexChanged += new System.EventHandler(this.action_SelectDataTable);
            // 
            // textboxDataValue
            // 
            this.textboxDataValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxDataValue.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDataValue.Location = new System.Drawing.Point(853, 142);
            this.textboxDataValue.Name = "textboxDataValue";
            this.textboxDataValue.Size = new System.Drawing.Size(200, 26);
            this.textboxDataValue.TabIndex = 0;
            // 
            // labelDataValue
            // 
            this.labelDataValue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDataValue.Location = new System.Drawing.Point(719, 142);
            this.labelDataValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelDataValue.Name = "labelDataValue";
            this.labelDataValue.Size = new System.Drawing.Size(131, 26);
            this.labelDataValue.TabIndex = 0;
            this.labelDataValue.Text = "Static Data Value:";
            this.labelDataValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTestDataColumn
            // 
            this.labelTestDataColumn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestDataColumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTestDataColumn.Location = new System.Drawing.Point(719, 107);
            this.labelTestDataColumn.Margin = new System.Windows.Forms.Padding(0);
            this.labelTestDataColumn.Name = "labelTestDataColumn";
            this.labelTestDataColumn.Size = new System.Drawing.Size(131, 29);
            this.labelTestDataColumn.TabIndex = 0;
            this.labelTestDataColumn.Text = "Test Data Column:";
            this.labelTestDataColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownTestDataColumn
            // 
            this.dropdownTestDataColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownTestDataColumn.FormattingEnabled = true;
            this.dropdownTestDataColumn.ItemHeight = 23;
            this.dropdownTestDataColumn.Location = new System.Drawing.Point(853, 107);
            this.dropdownTestDataColumn.Name = "dropdownTestDataColumn";
            this.dropdownTestDataColumn.Size = new System.Drawing.Size(200, 29);
            this.dropdownTestDataColumn.TabIndex = 0;
            this.dropdownTestDataColumn.UseSelectable = true;
            // 
            // buttonAddStepBelowSelection
            // 
            this.buttonAddStepBelowSelection.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAddStepBelowSelection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddStepBelowSelection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddStepBelowSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddStepBelowSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStepBelowSelection.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStepBelowSelection.ForeColor = System.Drawing.Color.White;
            this.buttonAddStepBelowSelection.Location = new System.Drawing.Point(853, 211);
            this.buttonAddStepBelowSelection.Name = "buttonAddStepBelowSelection";
            this.buttonAddStepBelowSelection.Size = new System.Drawing.Size(200, 29);
            this.buttonAddStepBelowSelection.TabIndex = 0;
            this.buttonAddStepBelowSelection.Text = "Add Step Below Selection";
            this.buttonAddStepBelowSelection.UseVisualStyleBackColor = false;
            this.buttonAddStepBelowSelection.Click += new System.EventHandler(this.action_AddStepBelowSelection);
            // 
            // buttonAddStep
            // 
            this.buttonAddStep.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAddStep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStep.ForeColor = System.Drawing.Color.White;
            this.buttonAddStep.Location = new System.Drawing.Point(853, 176);
            this.buttonAddStep.Name = "buttonAddStep";
            this.buttonAddStep.Size = new System.Drawing.Size(200, 29);
            this.buttonAddStep.TabIndex = 0;
            this.buttonAddStep.Text = "Add Step";
            this.buttonAddStep.UseVisualStyleBackColor = false;
            this.buttonAddStep.Click += new System.EventHandler(this.action_AddStep);
            // 
            // buttonMoveStepUp
            // 
            this.buttonMoveStepUp.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonMoveStepUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveStepUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveStepUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveStepUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveStepUp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveStepUp.ForeColor = System.Drawing.Color.White;
            this.buttonMoveStepUp.Location = new System.Drawing.Point(1064, 176);
            this.buttonMoveStepUp.Name = "buttonMoveStepUp";
            this.buttonMoveStepUp.Size = new System.Drawing.Size(152, 29);
            this.buttonMoveStepUp.TabIndex = 0;
            this.buttonMoveStepUp.Text = "Move Step Up";
            this.buttonMoveStepUp.UseVisualStyleBackColor = false;
            this.buttonMoveStepUp.Click += new System.EventHandler(this.action_MoveStepUp);
            // 
            // buttonMoveStepDown
            // 
            this.buttonMoveStepDown.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonMoveStepDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveStepDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveStepDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveStepDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveStepDown.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveStepDown.ForeColor = System.Drawing.Color.White;
            this.buttonMoveStepDown.Location = new System.Drawing.Point(1064, 211);
            this.buttonMoveStepDown.Name = "buttonMoveStepDown";
            this.buttonMoveStepDown.Size = new System.Drawing.Size(152, 29);
            this.buttonMoveStepDown.TabIndex = 0;
            this.buttonMoveStepDown.Text = "Move Step Down";
            this.buttonMoveStepDown.UseVisualStyleBackColor = false;
            this.buttonMoveStepDown.Click += new System.EventHandler(this.action_MoveStepDown);
            // 
            // checkboxOptionalStep
            // 
            this.checkboxOptionalStep.AutoSize = true;
            this.checkboxOptionalStep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxOptionalStep.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxOptionalStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxOptionalStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxOptionalStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxOptionalStep.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxOptionalStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxOptionalStep.Location = new System.Drawing.Point(1064, 38);
            this.checkboxOptionalStep.Name = "checkboxOptionalStep";
            this.checkboxOptionalStep.Size = new System.Drawing.Size(114, 20);
            this.checkboxOptionalStep.TabIndex = 0;
            this.checkboxOptionalStep.Text = "Optional Step";
            this.checkboxOptionalStep.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteStep
            // 
            this.buttonDeleteStep.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDeleteStep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteStep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteStep.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteStep.Location = new System.Drawing.Point(1227, 211);
            this.buttonDeleteStep.Name = "buttonDeleteStep";
            this.buttonDeleteStep.Size = new System.Drawing.Size(200, 29);
            this.buttonDeleteStep.TabIndex = 0;
            this.buttonDeleteStep.Text = "Delete Step(s)";
            this.buttonDeleteStep.UseVisualStyleBackColor = false;
            this.buttonDeleteStep.Click += new System.EventHandler(this.action_DeleteStep);
            // 
            // buttonResetDataFields
            // 
            this.buttonResetDataFields.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonResetDataFields.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonResetDataFields.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonResetDataFields.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonResetDataFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetDataFields.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetDataFields.ForeColor = System.Drawing.Color.White;
            this.buttonResetDataFields.Location = new System.Drawing.Point(1227, 176);
            this.buttonResetDataFields.Name = "buttonResetDataFields";
            this.buttonResetDataFields.Size = new System.Drawing.Size(200, 29);
            this.buttonResetDataFields.TabIndex = 0;
            this.buttonResetDataFields.Text = "Reset Data Fields";
            this.buttonResetDataFields.UseVisualStyleBackColor = false;
            this.buttonResetDataFields.Click += new System.EventHandler(this.action_ResetDataFields);
            // 
            // labelConditionDataColumn
            // 
            this.labelConditionDataColumn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConditionDataColumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelConditionDataColumn.Location = new System.Drawing.Point(1061, 107);
            this.labelConditionDataColumn.Margin = new System.Windows.Forms.Padding(0);
            this.labelConditionDataColumn.Name = "labelConditionDataColumn";
            this.labelConditionDataColumn.Size = new System.Drawing.Size(163, 29);
            this.labelConditionDataColumn.TabIndex = 0;
            this.labelConditionDataColumn.Text = "Condition Data Column:";
            this.labelConditionDataColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownConditionDataColumn
            // 
            this.dropdownConditionDataColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownConditionDataColumn.FormattingEnabled = true;
            this.dropdownConditionDataColumn.ItemHeight = 23;
            this.dropdownConditionDataColumn.Location = new System.Drawing.Point(1227, 107);
            this.dropdownConditionDataColumn.Name = "dropdownConditionDataColumn";
            this.dropdownConditionDataColumn.Size = new System.Drawing.Size(200, 29);
            this.dropdownConditionDataColumn.TabIndex = 0;
            this.dropdownConditionDataColumn.UseSelectable = true;
            // 
            // labelConditionDataTable
            // 
            this.labelConditionDataTable.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConditionDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelConditionDataTable.Location = new System.Drawing.Point(1061, 72);
            this.labelConditionDataTable.Margin = new System.Windows.Forms.Padding(0);
            this.labelConditionDataTable.Name = "labelConditionDataTable";
            this.labelConditionDataTable.Size = new System.Drawing.Size(163, 29);
            this.labelConditionDataTable.TabIndex = 0;
            this.labelConditionDataTable.Text = "Condition Data Table:";
            this.labelConditionDataTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownConditionDataTable
            // 
            this.dropdownConditionDataTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownConditionDataTable.FormattingEnabled = true;
            this.dropdownConditionDataTable.ItemHeight = 23;
            this.dropdownConditionDataTable.Location = new System.Drawing.Point(1227, 72);
            this.dropdownConditionDataTable.Name = "dropdownConditionDataTable";
            this.dropdownConditionDataTable.Size = new System.Drawing.Size(200, 29);
            this.dropdownConditionDataTable.TabIndex = 0;
            this.dropdownConditionDataTable.UseSelectable = true;
            this.dropdownConditionDataTable.SelectedIndexChanged += new System.EventHandler(this.action_SelectConditionTable);
            // 
            // textboxConditionDataValue
            // 
            this.textboxConditionDataValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxConditionDataValue.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxConditionDataValue.Location = new System.Drawing.Point(1227, 142);
            this.textboxConditionDataValue.Name = "textboxConditionDataValue";
            this.textboxConditionDataValue.Size = new System.Drawing.Size(200, 26);
            this.textboxConditionDataValue.TabIndex = 0;
            // 
            // labelConditionDataValue
            // 
            this.labelConditionDataValue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConditionDataValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelConditionDataValue.Location = new System.Drawing.Point(1061, 142);
            this.labelConditionDataValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelConditionDataValue.Name = "labelConditionDataValue";
            this.labelConditionDataValue.Size = new System.Drawing.Size(163, 26);
            this.labelConditionDataValue.TabIndex = 0;
            this.labelConditionDataValue.Text = "Condition Data Value:";
            this.labelConditionDataValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkboxApplyCondition
            // 
            this.checkboxApplyCondition.AutoSize = true;
            this.checkboxApplyCondition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxApplyCondition.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxApplyCondition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxApplyCondition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxApplyCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxApplyCondition.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxApplyCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxApplyCondition.Location = new System.Drawing.Point(1227, 38);
            this.checkboxApplyCondition.Name = "checkboxApplyCondition";
            this.checkboxApplyCondition.Size = new System.Drawing.Size(126, 20);
            this.checkboxApplyCondition.TabIndex = 0;
            this.checkboxApplyCondition.Text = "Apply Condition";
            this.checkboxApplyCondition.UseVisualStyleBackColor = true;
            this.checkboxApplyCondition.CheckedChanged += new System.EventHandler(this.action_ApplyCondition);
            // 
            // buttonDeleteScript
            // 
            this.buttonDeleteScript.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDeleteScript.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteScript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteScript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteScript.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteScript.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteScript.Location = new System.Drawing.Point(648, 33);
            this.buttonDeleteScript.Name = "buttonDeleteScript";
            this.buttonDeleteScript.Size = new System.Drawing.Size(100, 29);
            this.buttonDeleteScript.TabIndex = 1;
            this.buttonDeleteScript.Text = "Delete Script";
            this.buttonDeleteScript.UseVisualStyleBackColor = false;
            this.buttonDeleteScript.Click += new System.EventHandler(this.action_DeleteScript);
            // 
            // labelIdentifierValue
            // 
            this.labelIdentifierValue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifierValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelIdentifierValue.Location = new System.Drawing.Point(332, 143);
            this.labelIdentifierValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelIdentifierValue.Name = "labelIdentifierValue";
            this.labelIdentifierValue.Size = new System.Drawing.Size(145, 26);
            this.labelIdentifierValue.TabIndex = 2;
            this.labelIdentifierValue.Text = "Identifier Value:";
            this.labelIdentifierValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIdentifierType
            // 
            this.labelIdentifierType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifierType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelIdentifierType.Location = new System.Drawing.Point(332, 107);
            this.labelIdentifierType.Margin = new System.Windows.Forms.Padding(0);
            this.labelIdentifierType.Name = "labelIdentifierType";
            this.labelIdentifierType.Size = new System.Drawing.Size(145, 29);
            this.labelIdentifierType.TabIndex = 4;
            this.labelIdentifierType.Text = "Identifier Type:";
            this.labelIdentifierType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownIdentifierType
            // 
            this.dropdownIdentifierType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownIdentifierType.FormattingEnabled = true;
            this.dropdownIdentifierType.ItemHeight = 23;
            this.dropdownIdentifierType.Location = new System.Drawing.Point(480, 107);
            this.dropdownIdentifierType.Name = "dropdownIdentifierType";
            this.dropdownIdentifierType.Size = new System.Drawing.Size(230, 29);
            this.dropdownIdentifierType.TabIndex = 5;
            this.dropdownIdentifierType.UseSelectable = true;
            // 
            // textboxElementDescription
            // 
            this.textboxElementDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxElementDescription.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxElementDescription.Location = new System.Drawing.Point(480, 75);
            this.textboxElementDescription.Name = "textboxElementDescription";
            this.textboxElementDescription.Size = new System.Drawing.Size(230, 26);
            this.textboxElementDescription.TabIndex = 6;
            // 
            // labelElementDescription
            // 
            this.labelElementDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElementDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelElementDescription.Location = new System.Drawing.Point(332, 74);
            this.labelElementDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelElementDescription.Name = "labelElementDescription";
            this.labelElementDescription.Size = new System.Drawing.Size(145, 26);
            this.labelElementDescription.TabIndex = 7;
            this.labelElementDescription.Text = "Element Description:";
            this.labelElementDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textboxIdentifierValue
            // 
            this.textboxIdentifierValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxIdentifierValue.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxIdentifierValue.Location = new System.Drawing.Point(480, 142);
            this.textboxIdentifierValue.Name = "textboxIdentifierValue";
            this.textboxIdentifierValue.Size = new System.Drawing.Size(230, 26);
            this.textboxIdentifierValue.TabIndex = 8;
            // 
            // labelActionDescription
            // 
            this.labelActionDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActionDescription.ForeColor = System.Drawing.Color.Gray;
            this.labelActionDescription.Location = new System.Drawing.Point(33, 184);
            this.labelActionDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelActionDescription.Name = "labelActionDescription";
            this.labelActionDescription.Size = new System.Drawing.Size(677, 56);
            this.labelActionDescription.TabIndex = 9;
            // 
            // ControlScriptBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelActionDescription);
            this.Controls.Add(this.textboxIdentifierValue);
            this.Controls.Add(this.labelIdentifierValue);
            this.Controls.Add(this.labelIdentifierType);
            this.Controls.Add(this.dropdownIdentifierType);
            this.Controls.Add(this.textboxElementDescription);
            this.Controls.Add(this.labelElementDescription);
            this.Controls.Add(this.buttonDeleteScript);
            this.Controls.Add(this.checkboxApplyCondition);
            this.Controls.Add(this.labelConditionDataColumn);
            this.Controls.Add(this.dropdownConditionDataColumn);
            this.Controls.Add(this.labelConditionDataTable);
            this.Controls.Add(this.dropdownConditionDataTable);
            this.Controls.Add(this.textboxConditionDataValue);
            this.Controls.Add(this.labelConditionDataValue);
            this.Controls.Add(this.buttonResetDataFields);
            this.Controls.Add(this.buttonDeleteStep);
            this.Controls.Add(this.checkboxOptionalStep);
            this.Controls.Add(this.buttonMoveStepDown);
            this.Controls.Add(this.buttonMoveStepUp);
            this.Controls.Add(this.buttonAddStep);
            this.Controls.Add(this.buttonAddStepBelowSelection);
            this.Controls.Add(this.labelTestDataColumn);
            this.Controls.Add(this.dropdownTestDataColumn);
            this.Controls.Add(this.labelTestDataTable);
            this.Controls.Add(this.dropdownTestDataTable);
            this.Controls.Add(this.textboxDataValue);
            this.Controls.Add(this.labelDataValue);
            this.Controls.Add(this.checkboxUseTestDatabase);
            this.Controls.Add(this.textboxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.dropdownAction);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.dropdownOperation);
            this.Controls.Add(this.buttonSaveScript);
            this.Controls.Add(this.buttonCreateScript);
            this.Controls.Add(this.buttonLoadScript);
            this.Controls.Add(this.panelScriptBackground);
            this.Controls.Add(this.labelScriptList);
            this.Controls.Add(this.dropdownScriptList);
            this.Name = "ControlScriptBuilder";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(1460, 805);
            this.Load += new System.EventHandler(this.action_FormLoad);
            this.panelScriptBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewScript)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateScript;
        private System.Windows.Forms.Button buttonLoadScript;
        private System.Windows.Forms.Panel panelScriptBackground;
        private System.Windows.Forms.Label labelScript;
        private System.Windows.Forms.Label labelScriptList;
        private MetroFramework.Controls.MetroComboBox dropdownScriptList;
        private System.Windows.Forms.Button buttonSaveScript;
        private System.Windows.Forms.Label labelOperation;
        private MetroFramework.Controls.MetroComboBox dropdownOperation;
        private System.Windows.Forms.Label labelAction;
        private MetroFramework.Controls.MetroComboBox dropdownAction;
        private System.Windows.Forms.TextBox textboxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.CheckBox checkboxUseTestDatabase;
        private System.Windows.Forms.Label labelTestDataTable;
        private MetroFramework.Controls.MetroComboBox dropdownTestDataTable;
        private System.Windows.Forms.TextBox textboxDataValue;
        private System.Windows.Forms.Label labelDataValue;
        private System.Windows.Forms.Label labelTestDataColumn;
        private MetroFramework.Controls.MetroComboBox dropdownTestDataColumn;
        private System.Windows.Forms.Button buttonAddStepBelowSelection;
        private System.Windows.Forms.Button buttonAddStep;
        private System.Windows.Forms.Button buttonMoveStepUp;
        private System.Windows.Forms.Button buttonMoveStepDown;
        private System.Windows.Forms.CheckBox checkboxOptionalStep;
        private System.Windows.Forms.Button buttonDeleteStep;
        private System.Windows.Forms.Button buttonResetDataFields;
        private System.Windows.Forms.Label labelConditionDataColumn;
        private MetroFramework.Controls.MetroComboBox dropdownConditionDataColumn;
        private System.Windows.Forms.Label labelConditionDataTable;
        private MetroFramework.Controls.MetroComboBox dropdownConditionDataTable;
        private System.Windows.Forms.TextBox textboxConditionDataValue;
        private System.Windows.Forms.Label labelConditionDataValue;
        private System.Windows.Forms.CheckBox checkboxApplyCondition;
        private System.Windows.Forms.Button buttonDeleteScript;
        private System.Windows.Forms.Label labelIdentifierValue;
        private System.Windows.Forms.Label labelIdentifierType;
        private MetroFramework.Controls.MetroComboBox dropdownIdentifierType;
        private System.Windows.Forms.TextBox textboxElementDescription;
        private System.Windows.Forms.Label labelElementDescription;
        private System.Windows.Forms.TextBox textboxIdentifierValue;
        private System.Windows.Forms.Label labelActionDescription;
        private MetroFramework.Controls.MetroGrid gridviewScript;
    }
}
