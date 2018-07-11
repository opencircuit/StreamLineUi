namespace StreamLineUi
{
    partial class ControlComponentEditor
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
            this.buttonCreateComponent = new System.Windows.Forms.Button();
            this.buttonLoadComponent = new System.Windows.Forms.Button();
            this.panelScriptBackground = new System.Windows.Forms.Panel();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.labelComponentName = new System.Windows.Forms.Label();
            this.labelComponentList = new System.Windows.Forms.Label();
            this.dropdownComponentList = new MetroFramework.Controls.MetroComboBox();
            this.buttonSaveComponent = new System.Windows.Forms.Button();
            this.labelOperation = new System.Windows.Forms.Label();
            this.dropdownOperation = new MetroFramework.Controls.MetroComboBox();
            this.labelAction = new System.Windows.Forms.Label();
            this.dropdownAction = new MetroFramework.Controls.MetroComboBox();
            this.labelTestDataTable = new System.Windows.Forms.Label();
            this.dropdownTestDataTable = new MetroFramework.Controls.MetroComboBox();
            this.labelDataValue = new System.Windows.Forms.Label();
            this.labelTestDataColumn = new System.Windows.Forms.Label();
            this.dropdownTestDataColumn = new MetroFramework.Controls.MetroComboBox();
            this.buttonAddStepBelowSelection = new System.Windows.Forms.Button();
            this.buttonAddStep = new System.Windows.Forms.Button();
            this.buttonMoveStepUp = new System.Windows.Forms.Button();
            this.buttonMoveStepDown = new System.Windows.Forms.Button();
            this.buttonDeleteStep = new System.Windows.Forms.Button();
            this.labelConditionDataColumn = new System.Windows.Forms.Label();
            this.dropdownConditionDataColumn = new MetroFramework.Controls.MetroComboBox();
            this.labelConditionDataTable = new System.Windows.Forms.Label();
            this.dropdownConditionDataTable = new MetroFramework.Controls.MetroComboBox();
            this.labelConditionDataValue = new System.Windows.Forms.Label();
            this.buttonDeleteComponent = new System.Windows.Forms.Button();
            this.labelIdentifierValue = new System.Windows.Forms.Label();
            this.labelIdentifierType = new System.Windows.Forms.Label();
            this.dropdownIdentifierType = new MetroFramework.Controls.MetroComboBox();
            this.labelElementName = new System.Windows.Forms.Label();
            this.labelActionDescription = new System.Windows.Forms.Label();
            this.checkboxUseDatabase = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkboxApplyCondition = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkboxOptionalStep = new MaterialSkin.Controls.MaterialCheckBox();
            this.textboxConditionDataValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxDataValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxElementName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxIdentifierValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxWaitTime = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelWaitTime = new System.Windows.Forms.Label();
            this.buttonCopyStep = new System.Windows.Forms.Button();
            this.buttonReloadTableList = new System.Windows.Forms.Button();
            this.panelScriptBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateComponent
            // 
            this.buttonCreateComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonCreateComponent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateComponent.FlatAppearance.BorderSize = 2;
            this.buttonCreateComponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateComponent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateComponent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateComponent.ForeColor = System.Drawing.Color.White;
            this.buttonCreateComponent.Location = new System.Drawing.Point(708, 24);
            this.buttonCreateComponent.Name = "buttonCreateComponent";
            this.buttonCreateComponent.Size = new System.Drawing.Size(150, 29);
            this.buttonCreateComponent.TabIndex = 4;
            this.buttonCreateComponent.Text = "Create Component";
            this.buttonCreateComponent.UseVisualStyleBackColor = false;
            this.buttonCreateComponent.Click += new System.EventHandler(this.action_CreateComponent);
            // 
            // buttonLoadComponent
            // 
            this.buttonLoadComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonLoadComponent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadComponent.FlatAppearance.BorderSize = 2;
            this.buttonLoadComponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadComponent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadComponent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadComponent.ForeColor = System.Drawing.Color.White;
            this.buttonLoadComponent.Location = new System.Drawing.Point(394, 24);
            this.buttonLoadComponent.Name = "buttonLoadComponent";
            this.buttonLoadComponent.Size = new System.Drawing.Size(150, 29);
            this.buttonLoadComponent.TabIndex = 2;
            this.buttonLoadComponent.Text = "Load Component";
            this.buttonLoadComponent.UseVisualStyleBackColor = false;
            this.buttonLoadComponent.Click += new System.EventHandler(this.action_LoadComponent);
            // 
            // panelScriptBackground
            // 
            this.panelScriptBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScriptBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelScriptBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelScriptBackground.Controls.Add(this.gridview);
            this.panelScriptBackground.Controls.Add(this.labelComponentName);
            this.panelScriptBackground.Location = new System.Drawing.Point(33, 277);
            this.panelScriptBackground.Name = "panelScriptBackground";
            this.panelScriptBackground.Padding = new System.Windows.Forms.Padding(3);
            this.panelScriptBackground.Size = new System.Drawing.Size(1379, 485);
            this.panelScriptBackground.TabIndex = 0;
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToDeleteRows = false;
            this.gridview.AllowUserToResizeColumns = false;
            this.gridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridview.BackgroundColor = System.Drawing.Color.White;
            this.gridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridview.EnableHeadersVisualStyles = false;
            this.gridview.GridColor = System.Drawing.Color.Gainsboro;
            this.gridview.Location = new System.Drawing.Point(3, 32);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridview.Size = new System.Drawing.Size(1371, 448);
            this.gridview.TabIndex = 0;
            this.gridview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.action_CopyPasteData);
            // 
            // labelComponentName
            // 
            this.labelComponentName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelComponentName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComponentName.ForeColor = System.Drawing.Color.White;
            this.labelComponentName.Location = new System.Drawing.Point(3, 3);
            this.labelComponentName.Name = "labelComponentName";
            this.labelComponentName.Size = new System.Drawing.Size(1371, 29);
            this.labelComponentName.TabIndex = 0;
            this.labelComponentName.Text = "Component:";
            this.labelComponentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelComponentList
            // 
            this.labelComponentList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComponentList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelComponentList.Location = new System.Drawing.Point(30, 24);
            this.labelComponentList.Margin = new System.Windows.Forms.Padding(0);
            this.labelComponentList.Name = "labelComponentList";
            this.labelComponentList.Size = new System.Drawing.Size(117, 29);
            this.labelComponentList.TabIndex = 0;
            this.labelComponentList.Text = "Component List:";
            this.labelComponentList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownComponentList
            // 
            this.dropdownComponentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownComponentList.FormattingEnabled = true;
            this.dropdownComponentList.ItemHeight = 23;
            this.dropdownComponentList.Location = new System.Drawing.Point(150, 24);
            this.dropdownComponentList.Name = "dropdownComponentList";
            this.dropdownComponentList.Size = new System.Drawing.Size(236, 29);
            this.dropdownComponentList.TabIndex = 1;
            this.dropdownComponentList.UseSelectable = true;
            // 
            // buttonSaveComponent
            // 
            this.buttonSaveComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSaveComponent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveComponent.FlatAppearance.BorderSize = 2;
            this.buttonSaveComponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveComponent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveComponent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveComponent.ForeColor = System.Drawing.Color.White;
            this.buttonSaveComponent.Location = new System.Drawing.Point(551, 24);
            this.buttonSaveComponent.Name = "buttonSaveComponent";
            this.buttonSaveComponent.Size = new System.Drawing.Size(150, 29);
            this.buttonSaveComponent.TabIndex = 3;
            this.buttonSaveComponent.Text = "Save Component";
            this.buttonSaveComponent.UseVisualStyleBackColor = false;
            this.buttonSaveComponent.Click += new System.EventHandler(this.action_SaveComponent);
            // 
            // labelOperation
            // 
            this.labelOperation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelOperation.Location = new System.Drawing.Point(30, 70);
            this.labelOperation.Margin = new System.Windows.Forms.Padding(0);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(117, 29);
            this.labelOperation.TabIndex = 0;
            this.labelOperation.Text = "Operation:";
            this.labelOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownOperation
            // 
            this.dropdownOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownOperation.FormattingEnabled = true;
            this.dropdownOperation.ItemHeight = 23;
            this.dropdownOperation.Location = new System.Drawing.Point(150, 70);
            this.dropdownOperation.Name = "dropdownOperation";
            this.dropdownOperation.Size = new System.Drawing.Size(236, 29);
            this.dropdownOperation.TabIndex = 7;
            this.dropdownOperation.UseSelectable = true;
            this.dropdownOperation.SelectedIndexChanged += new System.EventHandler(this.action_SelectOperation);
            // 
            // labelAction
            // 
            this.labelAction.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAction.Location = new System.Drawing.Point(30, 105);
            this.labelAction.Margin = new System.Windows.Forms.Padding(0);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(117, 29);
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
            this.dropdownAction.Location = new System.Drawing.Point(150, 105);
            this.dropdownAction.Name = "dropdownAction";
            this.dropdownAction.Size = new System.Drawing.Size(236, 29);
            this.dropdownAction.TabIndex = 8;
            this.dropdownAction.UseSelectable = true;
            this.dropdownAction.SelectedIndexChanged += new System.EventHandler(this.action_SelectAction);
            // 
            // labelTestDataTable
            // 
            this.labelTestDataTable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTestDataTable.Location = new System.Drawing.Point(808, 70);
            this.labelTestDataTable.Margin = new System.Windows.Forms.Padding(0);
            this.labelTestDataTable.Name = "labelTestDataTable";
            this.labelTestDataTable.Size = new System.Drawing.Size(135, 29);
            this.labelTestDataTable.TabIndex = 0;
            this.labelTestDataTable.Text = "Test Data Table:";
            this.labelTestDataTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownTestDataTable
            // 
            this.dropdownTestDataTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownTestDataTable.FormattingEnabled = true;
            this.dropdownTestDataTable.ItemHeight = 23;
            this.dropdownTestDataTable.Location = new System.Drawing.Point(946, 70);
            this.dropdownTestDataTable.Name = "dropdownTestDataTable";
            this.dropdownTestDataTable.Size = new System.Drawing.Size(226, 29);
            this.dropdownTestDataTable.TabIndex = 13;
            this.dropdownTestDataTable.UseSelectable = true;
            this.dropdownTestDataTable.SelectedIndexChanged += new System.EventHandler(this.action_SelectDataTable);
            // 
            // labelDataValue
            // 
            this.labelDataValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDataValue.Location = new System.Drawing.Point(808, 139);
            this.labelDataValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelDataValue.Name = "labelDataValue";
            this.labelDataValue.Size = new System.Drawing.Size(135, 23);
            this.labelDataValue.TabIndex = 0;
            this.labelDataValue.Text = "Static Data Value:";
            this.labelDataValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTestDataColumn
            // 
            this.labelTestDataColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestDataColumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTestDataColumn.Location = new System.Drawing.Point(808, 105);
            this.labelTestDataColumn.Margin = new System.Windows.Forms.Padding(0);
            this.labelTestDataColumn.Name = "labelTestDataColumn";
            this.labelTestDataColumn.Size = new System.Drawing.Size(135, 29);
            this.labelTestDataColumn.TabIndex = 0;
            this.labelTestDataColumn.Text = "Test Data Column:";
            this.labelTestDataColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownTestDataColumn
            // 
            this.dropdownTestDataColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownTestDataColumn.FormattingEnabled = true;
            this.dropdownTestDataColumn.ItemHeight = 23;
            this.dropdownTestDataColumn.Location = new System.Drawing.Point(946, 105);
            this.dropdownTestDataColumn.Name = "dropdownTestDataColumn";
            this.dropdownTestDataColumn.Size = new System.Drawing.Size(226, 29);
            this.dropdownTestDataColumn.TabIndex = 14;
            this.dropdownTestDataColumn.UseSelectable = true;
            // 
            // buttonAddStepBelowSelection
            // 
            this.buttonAddStepBelowSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddStepBelowSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonAddStepBelowSelection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddStepBelowSelection.FlatAppearance.BorderSize = 2;
            this.buttonAddStepBelowSelection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddStepBelowSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddStepBelowSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStepBelowSelection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStepBelowSelection.ForeColor = System.Drawing.Color.White;
            this.buttonAddStepBelowSelection.Location = new System.Drawing.Point(1197, 59);
            this.buttonAddStepBelowSelection.Name = "buttonAddStepBelowSelection";
            this.buttonAddStepBelowSelection.Size = new System.Drawing.Size(215, 29);
            this.buttonAddStepBelowSelection.TabIndex = 20;
            this.buttonAddStepBelowSelection.Text = "Add Step Below Selection";
            this.buttonAddStepBelowSelection.UseVisualStyleBackColor = false;
            this.buttonAddStepBelowSelection.Click += new System.EventHandler(this.action_AddStepBelowSelection);
            // 
            // buttonAddStep
            // 
            this.buttonAddStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonAddStep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddStep.FlatAppearance.BorderSize = 2;
            this.buttonAddStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStep.ForeColor = System.Drawing.Color.White;
            this.buttonAddStep.Location = new System.Drawing.Point(1197, 24);
            this.buttonAddStep.Name = "buttonAddStep";
            this.buttonAddStep.Size = new System.Drawing.Size(215, 29);
            this.buttonAddStep.TabIndex = 19;
            this.buttonAddStep.Text = "Add Step";
            this.buttonAddStep.UseVisualStyleBackColor = false;
            this.buttonAddStep.Click += new System.EventHandler(this.action_AddStep);
            // 
            // buttonMoveStepUp
            // 
            this.buttonMoveStepUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveStepUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonMoveStepUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveStepUp.FlatAppearance.BorderSize = 2;
            this.buttonMoveStepUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveStepUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveStepUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveStepUp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveStepUp.ForeColor = System.Drawing.Color.White;
            this.buttonMoveStepUp.Location = new System.Drawing.Point(1197, 94);
            this.buttonMoveStepUp.Name = "buttonMoveStepUp";
            this.buttonMoveStepUp.Size = new System.Drawing.Size(215, 29);
            this.buttonMoveStepUp.TabIndex = 21;
            this.buttonMoveStepUp.Text = "Move Step Up";
            this.buttonMoveStepUp.UseVisualStyleBackColor = false;
            this.buttonMoveStepUp.Click += new System.EventHandler(this.action_MoveStepUp);
            // 
            // buttonMoveStepDown
            // 
            this.buttonMoveStepDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveStepDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonMoveStepDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveStepDown.FlatAppearance.BorderSize = 2;
            this.buttonMoveStepDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveStepDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveStepDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveStepDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveStepDown.ForeColor = System.Drawing.Color.White;
            this.buttonMoveStepDown.Location = new System.Drawing.Point(1197, 129);
            this.buttonMoveStepDown.Name = "buttonMoveStepDown";
            this.buttonMoveStepDown.Size = new System.Drawing.Size(215, 29);
            this.buttonMoveStepDown.TabIndex = 22;
            this.buttonMoveStepDown.Text = "Move Step Down";
            this.buttonMoveStepDown.UseVisualStyleBackColor = false;
            this.buttonMoveStepDown.Click += new System.EventHandler(this.action_MoveStepDown);
            // 
            // buttonDeleteStep
            // 
            this.buttonDeleteStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDeleteStep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteStep.FlatAppearance.BorderSize = 2;
            this.buttonDeleteStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteStep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteStep.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteStep.Location = new System.Drawing.Point(1197, 243);
            this.buttonDeleteStep.Name = "buttonDeleteStep";
            this.buttonDeleteStep.Size = new System.Drawing.Size(215, 29);
            this.buttonDeleteStep.TabIndex = 24;
            this.buttonDeleteStep.Text = "Delete Step(s)";
            this.buttonDeleteStep.UseVisualStyleBackColor = false;
            this.buttonDeleteStep.Click += new System.EventHandler(this.action_DeleteStep);
            // 
            // labelConditionDataColumn
            // 
            this.labelConditionDataColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConditionDataColumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelConditionDataColumn.Location = new System.Drawing.Point(808, 213);
            this.labelConditionDataColumn.Margin = new System.Windows.Forms.Padding(0);
            this.labelConditionDataColumn.Name = "labelConditionDataColumn";
            this.labelConditionDataColumn.Size = new System.Drawing.Size(135, 29);
            this.labelConditionDataColumn.TabIndex = 0;
            this.labelConditionDataColumn.Text = "Condition Column:";
            this.labelConditionDataColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownConditionDataColumn
            // 
            this.dropdownConditionDataColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownConditionDataColumn.FormattingEnabled = true;
            this.dropdownConditionDataColumn.ItemHeight = 23;
            this.dropdownConditionDataColumn.Location = new System.Drawing.Point(946, 213);
            this.dropdownConditionDataColumn.Name = "dropdownConditionDataColumn";
            this.dropdownConditionDataColumn.Size = new System.Drawing.Size(226, 29);
            this.dropdownConditionDataColumn.TabIndex = 17;
            this.dropdownConditionDataColumn.UseSelectable = true;
            // 
            // labelConditionDataTable
            // 
            this.labelConditionDataTable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConditionDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelConditionDataTable.Location = new System.Drawing.Point(808, 177);
            this.labelConditionDataTable.Margin = new System.Windows.Forms.Padding(0);
            this.labelConditionDataTable.Name = "labelConditionDataTable";
            this.labelConditionDataTable.Size = new System.Drawing.Size(135, 29);
            this.labelConditionDataTable.TabIndex = 0;
            this.labelConditionDataTable.Text = "Condition Table:";
            this.labelConditionDataTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownConditionDataTable
            // 
            this.dropdownConditionDataTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownConditionDataTable.FormattingEnabled = true;
            this.dropdownConditionDataTable.ItemHeight = 23;
            this.dropdownConditionDataTable.Location = new System.Drawing.Point(946, 178);
            this.dropdownConditionDataTable.Name = "dropdownConditionDataTable";
            this.dropdownConditionDataTable.Size = new System.Drawing.Size(226, 29);
            this.dropdownConditionDataTable.TabIndex = 16;
            this.dropdownConditionDataTable.UseSelectable = true;
            this.dropdownConditionDataTable.SelectedIndexChanged += new System.EventHandler(this.action_SelectConditionTable);
            // 
            // labelConditionDataValue
            // 
            this.labelConditionDataValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConditionDataValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelConditionDataValue.Location = new System.Drawing.Point(808, 247);
            this.labelConditionDataValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelConditionDataValue.Name = "labelConditionDataValue";
            this.labelConditionDataValue.Size = new System.Drawing.Size(135, 23);
            this.labelConditionDataValue.TabIndex = 0;
            this.labelConditionDataValue.Text = "Condition Value:";
            this.labelConditionDataValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDeleteComponent
            // 
            this.buttonDeleteComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDeleteComponent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteComponent.FlatAppearance.BorderSize = 2;
            this.buttonDeleteComponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteComponent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteComponent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteComponent.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteComponent.Location = new System.Drawing.Point(865, 24);
            this.buttonDeleteComponent.Name = "buttonDeleteComponent";
            this.buttonDeleteComponent.Size = new System.Drawing.Size(150, 29);
            this.buttonDeleteComponent.TabIndex = 5;
            this.buttonDeleteComponent.Text = "Delete Component";
            this.buttonDeleteComponent.UseVisualStyleBackColor = false;
            this.buttonDeleteComponent.Click += new System.EventHandler(this.action_DeleteComponent);
            // 
            // labelIdentifierValue
            // 
            this.labelIdentifierValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifierValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelIdentifierValue.Location = new System.Drawing.Point(414, 177);
            this.labelIdentifierValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelIdentifierValue.Name = "labelIdentifierValue";
            this.labelIdentifierValue.Size = new System.Drawing.Size(117, 23);
            this.labelIdentifierValue.TabIndex = 0;
            this.labelIdentifierValue.Text = "Identifier Value:";
            this.labelIdentifierValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIdentifierType
            // 
            this.labelIdentifierType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifierType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelIdentifierType.Location = new System.Drawing.Point(414, 141);
            this.labelIdentifierType.Margin = new System.Windows.Forms.Padding(0);
            this.labelIdentifierType.Name = "labelIdentifierType";
            this.labelIdentifierType.Size = new System.Drawing.Size(117, 29);
            this.labelIdentifierType.TabIndex = 0;
            this.labelIdentifierType.Text = "Identifier Type:";
            this.labelIdentifierType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownIdentifierType
            // 
            this.dropdownIdentifierType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownIdentifierType.FormattingEnabled = true;
            this.dropdownIdentifierType.ItemHeight = 23;
            this.dropdownIdentifierType.Location = new System.Drawing.Point(534, 141);
            this.dropdownIdentifierType.Name = "dropdownIdentifierType";
            this.dropdownIdentifierType.Size = new System.Drawing.Size(248, 29);
            this.dropdownIdentifierType.TabIndex = 10;
            this.dropdownIdentifierType.UseSelectable = true;
            // 
            // labelElementName
            // 
            this.labelElementName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElementName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelElementName.Location = new System.Drawing.Point(414, 108);
            this.labelElementName.Margin = new System.Windows.Forms.Padding(0);
            this.labelElementName.Name = "labelElementName";
            this.labelElementName.Size = new System.Drawing.Size(117, 23);
            this.labelElementName.TabIndex = 0;
            this.labelElementName.Text = "Element Name:";
            this.labelElementName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelActionDescription
            // 
            this.labelActionDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActionDescription.ForeColor = System.Drawing.Color.Gray;
            this.labelActionDescription.Location = new System.Drawing.Point(33, 164);
            this.labelActionDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelActionDescription.Name = "labelActionDescription";
            this.labelActionDescription.Size = new System.Drawing.Size(353, 108);
            this.labelActionDescription.TabIndex = 0;
            // 
            // checkboxUseDatabase
            // 
            this.checkboxUseDatabase.AutoSize = true;
            this.checkboxUseDatabase.Depth = 0;
            this.checkboxUseDatabase.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkboxUseDatabase.Location = new System.Drawing.Point(515, 68);
            this.checkboxUseDatabase.Margin = new System.Windows.Forms.Padding(0);
            this.checkboxUseDatabase.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkboxUseDatabase.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkboxUseDatabase.Name = "checkboxUseDatabase";
            this.checkboxUseDatabase.Ripple = true;
            this.checkboxUseDatabase.Size = new System.Drawing.Size(115, 30);
            this.checkboxUseDatabase.TabIndex = 0;
            this.checkboxUseDatabase.Text = "Use Database";
            this.checkboxUseDatabase.UseVisualStyleBackColor = true;
            this.checkboxUseDatabase.CheckedChanged += new System.EventHandler(this.action_UseDatabase);
            // 
            // checkboxApplyCondition
            // 
            this.checkboxApplyCondition.AutoSize = true;
            this.checkboxApplyCondition.Depth = 0;
            this.checkboxApplyCondition.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkboxApplyCondition.Location = new System.Drawing.Point(649, 68);
            this.checkboxApplyCondition.Margin = new System.Windows.Forms.Padding(0);
            this.checkboxApplyCondition.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkboxApplyCondition.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkboxApplyCondition.Name = "checkboxApplyCondition";
            this.checkboxApplyCondition.Ripple = true;
            this.checkboxApplyCondition.Size = new System.Drawing.Size(127, 30);
            this.checkboxApplyCondition.TabIndex = 0;
            this.checkboxApplyCondition.Text = "Apply Condition";
            this.checkboxApplyCondition.UseVisualStyleBackColor = true;
            this.checkboxApplyCondition.CheckedChanged += new System.EventHandler(this.action_ApplyCondition);
            // 
            // checkboxOptionalStep
            // 
            this.checkboxOptionalStep.AutoSize = true;
            this.checkboxOptionalStep.Depth = 0;
            this.checkboxOptionalStep.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkboxOptionalStep.Location = new System.Drawing.Point(412, 68);
            this.checkboxOptionalStep.Margin = new System.Windows.Forms.Padding(0);
            this.checkboxOptionalStep.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkboxOptionalStep.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkboxOptionalStep.Name = "checkboxOptionalStep";
            this.checkboxOptionalStep.Ripple = true;
            this.checkboxOptionalStep.Size = new System.Drawing.Size(82, 30);
            this.checkboxOptionalStep.TabIndex = 0;
            this.checkboxOptionalStep.Text = "Optional";
            this.checkboxOptionalStep.UseVisualStyleBackColor = true;
            // 
            // textboxConditionDataValue
            // 
            this.textboxConditionDataValue.Depth = 0;
            this.textboxConditionDataValue.Hint = "";
            this.textboxConditionDataValue.Location = new System.Drawing.Point(946, 250);
            this.textboxConditionDataValue.MaxLength = 32767;
            this.textboxConditionDataValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxConditionDataValue.Name = "textboxConditionDataValue";
            this.textboxConditionDataValue.PasswordChar = '\0';
            this.textboxConditionDataValue.SelectedText = "";
            this.textboxConditionDataValue.SelectionLength = 0;
            this.textboxConditionDataValue.SelectionStart = 0;
            this.textboxConditionDataValue.Size = new System.Drawing.Size(226, 23);
            this.textboxConditionDataValue.TabIndex = 18;
            this.textboxConditionDataValue.TabStop = false;
            this.textboxConditionDataValue.UseSystemPasswordChar = false;
            // 
            // textboxDataValue
            // 
            this.textboxDataValue.Depth = 0;
            this.textboxDataValue.Hint = "";
            this.textboxDataValue.Location = new System.Drawing.Point(946, 142);
            this.textboxDataValue.MaxLength = 32767;
            this.textboxDataValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxDataValue.Name = "textboxDataValue";
            this.textboxDataValue.PasswordChar = '\0';
            this.textboxDataValue.SelectedText = "";
            this.textboxDataValue.SelectionLength = 0;
            this.textboxDataValue.SelectionStart = 0;
            this.textboxDataValue.Size = new System.Drawing.Size(226, 23);
            this.textboxDataValue.TabIndex = 15;
            this.textboxDataValue.TabStop = false;
            this.textboxDataValue.UseSystemPasswordChar = false;
            // 
            // textboxElementName
            // 
            this.textboxElementName.Depth = 0;
            this.textboxElementName.Hint = "";
            this.textboxElementName.Location = new System.Drawing.Point(534, 111);
            this.textboxElementName.MaxLength = 32767;
            this.textboxElementName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxElementName.Name = "textboxElementName";
            this.textboxElementName.PasswordChar = '\0';
            this.textboxElementName.SelectedText = "";
            this.textboxElementName.SelectionLength = 0;
            this.textboxElementName.SelectionStart = 0;
            this.textboxElementName.Size = new System.Drawing.Size(248, 23);
            this.textboxElementName.TabIndex = 9;
            this.textboxElementName.TabStop = false;
            this.textboxElementName.UseSystemPasswordChar = false;
            // 
            // textboxIdentifierValue
            // 
            this.textboxIdentifierValue.Depth = 0;
            this.textboxIdentifierValue.Hint = "";
            this.textboxIdentifierValue.Location = new System.Drawing.Point(534, 180);
            this.textboxIdentifierValue.MaxLength = 32767;
            this.textboxIdentifierValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxIdentifierValue.Name = "textboxIdentifierValue";
            this.textboxIdentifierValue.PasswordChar = '\0';
            this.textboxIdentifierValue.SelectedText = "";
            this.textboxIdentifierValue.SelectionLength = 0;
            this.textboxIdentifierValue.SelectionStart = 0;
            this.textboxIdentifierValue.Size = new System.Drawing.Size(248, 23);
            this.textboxIdentifierValue.TabIndex = 11;
            this.textboxIdentifierValue.TabStop = false;
            this.textboxIdentifierValue.UseSystemPasswordChar = false;
            // 
            // textboxWaitTime
            // 
            this.textboxWaitTime.Depth = 0;
            this.textboxWaitTime.Hint = "";
            this.textboxWaitTime.Location = new System.Drawing.Point(579, 214);
            this.textboxWaitTime.MaxLength = 32767;
            this.textboxWaitTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxWaitTime.Name = "textboxWaitTime";
            this.textboxWaitTime.PasswordChar = '\0';
            this.textboxWaitTime.SelectedText = "";
            this.textboxWaitTime.SelectionLength = 0;
            this.textboxWaitTime.SelectionStart = 0;
            this.textboxWaitTime.Size = new System.Drawing.Size(199, 23);
            this.textboxWaitTime.TabIndex = 12;
            this.textboxWaitTime.TabStop = false;
            this.textboxWaitTime.UseSystemPasswordChar = false;
            // 
            // labelWaitTime
            // 
            this.labelWaitTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaitTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelWaitTime.Location = new System.Drawing.Point(414, 211);
            this.labelWaitTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelWaitTime.Name = "labelWaitTime";
            this.labelWaitTime.Size = new System.Drawing.Size(162, 26);
            this.labelWaitTime.TabIndex = 0;
            this.labelWaitTime.Text = "Wait Time (In Seconds):";
            this.labelWaitTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCopyStep
            // 
            this.buttonCopyStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonCopyStep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCopyStep.FlatAppearance.BorderSize = 2;
            this.buttonCopyStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCopyStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCopyStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyStep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopyStep.ForeColor = System.Drawing.Color.White;
            this.buttonCopyStep.Location = new System.Drawing.Point(1197, 164);
            this.buttonCopyStep.Name = "buttonCopyStep";
            this.buttonCopyStep.Size = new System.Drawing.Size(215, 29);
            this.buttonCopyStep.TabIndex = 23;
            this.buttonCopyStep.Text = "Copy Step";
            this.buttonCopyStep.UseVisualStyleBackColor = false;
            this.buttonCopyStep.Click += new System.EventHandler(this.action_CopyStep);
            // 
            // buttonReloadTableList
            // 
            this.buttonReloadTableList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonReloadTableList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReloadTableList.FlatAppearance.BorderSize = 2;
            this.buttonReloadTableList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReloadTableList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReloadTableList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReloadTableList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReloadTableList.ForeColor = System.Drawing.Color.White;
            this.buttonReloadTableList.Location = new System.Drawing.Point(1022, 24);
            this.buttonReloadTableList.Name = "buttonReloadTableList";
            this.buttonReloadTableList.Size = new System.Drawing.Size(150, 29);
            this.buttonReloadTableList.TabIndex = 6;
            this.buttonReloadTableList.Text = "Reload Table List";
            this.buttonReloadTableList.UseVisualStyleBackColor = false;
            this.buttonReloadTableList.Click += new System.EventHandler(this.action_ReloadTableList);
            // 
            // ControlComponentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonReloadTableList);
            this.Controls.Add(this.buttonCopyStep);
            this.Controls.Add(this.textboxWaitTime);
            this.Controls.Add(this.labelWaitTime);
            this.Controls.Add(this.textboxIdentifierValue);
            this.Controls.Add(this.textboxElementName);
            this.Controls.Add(this.textboxDataValue);
            this.Controls.Add(this.textboxConditionDataValue);
            this.Controls.Add(this.checkboxOptionalStep);
            this.Controls.Add(this.checkboxApplyCondition);
            this.Controls.Add(this.checkboxUseDatabase);
            this.Controls.Add(this.labelActionDescription);
            this.Controls.Add(this.labelIdentifierValue);
            this.Controls.Add(this.labelIdentifierType);
            this.Controls.Add(this.dropdownIdentifierType);
            this.Controls.Add(this.labelElementName);
            this.Controls.Add(this.buttonDeleteComponent);
            this.Controls.Add(this.labelConditionDataColumn);
            this.Controls.Add(this.dropdownConditionDataColumn);
            this.Controls.Add(this.labelConditionDataTable);
            this.Controls.Add(this.dropdownConditionDataTable);
            this.Controls.Add(this.labelConditionDataValue);
            this.Controls.Add(this.buttonDeleteStep);
            this.Controls.Add(this.buttonMoveStepDown);
            this.Controls.Add(this.buttonMoveStepUp);
            this.Controls.Add(this.buttonAddStep);
            this.Controls.Add(this.buttonAddStepBelowSelection);
            this.Controls.Add(this.labelTestDataColumn);
            this.Controls.Add(this.dropdownTestDataColumn);
            this.Controls.Add(this.labelTestDataTable);
            this.Controls.Add(this.dropdownTestDataTable);
            this.Controls.Add(this.labelDataValue);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.dropdownAction);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.dropdownOperation);
            this.Controls.Add(this.buttonSaveComponent);
            this.Controls.Add(this.buttonCreateComponent);
            this.Controls.Add(this.buttonLoadComponent);
            this.Controls.Add(this.panelScriptBackground);
            this.Controls.Add(this.labelComponentList);
            this.Controls.Add(this.dropdownComponentList);
            this.Name = "ControlComponentEditor";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 20, 20);
            this.Size = new System.Drawing.Size(1435, 785);
            this.Load += new System.EventHandler(this.action_FormLoad);
            this.panelScriptBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateComponent;
        private System.Windows.Forms.Button buttonLoadComponent;
        private System.Windows.Forms.Panel panelScriptBackground;
        private System.Windows.Forms.Label labelComponentName;
        private System.Windows.Forms.Label labelComponentList;
        private MetroFramework.Controls.MetroComboBox dropdownComponentList;
        private System.Windows.Forms.Button buttonSaveComponent;
        private System.Windows.Forms.Label labelOperation;
        private MetroFramework.Controls.MetroComboBox dropdownOperation;
        private System.Windows.Forms.Label labelAction;
        private MetroFramework.Controls.MetroComboBox dropdownAction;
        private System.Windows.Forms.Label labelTestDataTable;
        private MetroFramework.Controls.MetroComboBox dropdownTestDataTable;
        private System.Windows.Forms.Label labelDataValue;
        private System.Windows.Forms.Label labelTestDataColumn;
        private MetroFramework.Controls.MetroComboBox dropdownTestDataColumn;
        private System.Windows.Forms.Button buttonAddStepBelowSelection;
        private System.Windows.Forms.Button buttonAddStep;
        private System.Windows.Forms.Button buttonMoveStepUp;
        private System.Windows.Forms.Button buttonMoveStepDown;
        private System.Windows.Forms.Button buttonDeleteStep;
        private System.Windows.Forms.Label labelConditionDataColumn;
        private MetroFramework.Controls.MetroComboBox dropdownConditionDataColumn;
        private System.Windows.Forms.Label labelConditionDataTable;
        private MetroFramework.Controls.MetroComboBox dropdownConditionDataTable;
        private System.Windows.Forms.Label labelConditionDataValue;
        private System.Windows.Forms.Button buttonDeleteComponent;
        private System.Windows.Forms.Label labelIdentifierValue;
        private System.Windows.Forms.Label labelIdentifierType;
        private MetroFramework.Controls.MetroComboBox dropdownIdentifierType;
        private System.Windows.Forms.Label labelElementName;
        private System.Windows.Forms.Label labelActionDescription;
        private MaterialSkin.Controls.MaterialCheckBox checkboxUseDatabase;
        private MaterialSkin.Controls.MaterialCheckBox checkboxApplyCondition;
        private MaterialSkin.Controls.MaterialCheckBox checkboxOptionalStep;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxConditionDataValue;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxDataValue;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxElementName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxIdentifierValue;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxWaitTime;
        private System.Windows.Forms.Label labelWaitTime;
        private System.Windows.Forms.Button buttonCopyStep;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button buttonReloadTableList;
    }
}
