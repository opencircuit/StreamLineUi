namespace StreamLineUi
{
    partial class ControlConfiguration
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
            this.buttonStartExecution = new System.Windows.Forms.Button();
            this.buttonStopExecution = new System.Windows.Forms.Button();
            this.panelTableBackground = new System.Windows.Forms.Panel();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.labelTableName = new System.Windows.Forms.Label();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.labelDataValue = new System.Windows.Forms.Label();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.labelColumnList = new System.Windows.Forms.Label();
            this.dropdownColumns = new MetroFramework.Controls.MetroComboBox();
            this.buttonRemoveSelections = new System.Windows.Forms.Button();
            this.labelDebugModeDescription = new System.Windows.Forms.Label();
            this.buttonLoadTable = new System.Windows.Forms.Button();
            this.textboxDataValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelBrowsers = new System.Windows.Forms.Label();
            this.dropdownBrowsers = new MetroFramework.Controls.MetroComboBox();
            this.checkboxDebugMode = new MaterialSkin.Controls.MaterialCheckBox();
            this.panelTableBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartExecution
            // 
            this.buttonStartExecution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartExecution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonStartExecution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStartExecution.FlatAppearance.BorderSize = 2;
            this.buttonStartExecution.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStartExecution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStartExecution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartExecution.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartExecution.ForeColor = System.Drawing.Color.White;
            this.buttonStartExecution.Location = new System.Drawing.Point(1094, 698);
            this.buttonStartExecution.Name = "buttonStartExecution";
            this.buttonStartExecution.Size = new System.Drawing.Size(318, 29);
            this.buttonStartExecution.TabIndex = 9;
            this.buttonStartExecution.Text = "Start Test Case Execution";
            this.buttonStartExecution.UseVisualStyleBackColor = false;
            this.buttonStartExecution.Click += new System.EventHandler(this.action_StartExecution);
            // 
            // buttonStopExecution
            // 
            this.buttonStopExecution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopExecution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonStopExecution.Enabled = false;
            this.buttonStopExecution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStopExecution.FlatAppearance.BorderSize = 2;
            this.buttonStopExecution.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStopExecution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStopExecution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopExecution.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopExecution.ForeColor = System.Drawing.Color.White;
            this.buttonStopExecution.Location = new System.Drawing.Point(1094, 733);
            this.buttonStopExecution.Name = "buttonStopExecution";
            this.buttonStopExecution.Size = new System.Drawing.Size(318, 29);
            this.buttonStopExecution.TabIndex = 10;
            this.buttonStopExecution.Text = "Terminate Test Case Execution";
            this.buttonStopExecution.UseVisualStyleBackColor = false;
            this.buttonStopExecution.Click += new System.EventHandler(this.action_StopExecution);
            // 
            // panelTableBackground
            // 
            this.panelTableBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTableBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelTableBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTableBackground.Controls.Add(this.gridview);
            this.panelTableBackground.Controls.Add(this.labelTableName);
            this.panelTableBackground.Location = new System.Drawing.Point(33, 23);
            this.panelTableBackground.Name = "panelTableBackground";
            this.panelTableBackground.Padding = new System.Windows.Forms.Padding(3);
            this.panelTableBackground.Size = new System.Drawing.Size(1379, 500);
            this.panelTableBackground.TabIndex = 0;
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToDeleteRows = false;
            this.gridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview.BackgroundColor = System.Drawing.Color.White;
            this.gridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gridview.ReadOnly = true;
            this.gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview.Size = new System.Drawing.Size(1371, 463);
            this.gridview.TabIndex = 0;
            // 
            // labelTableName
            // 
            this.labelTableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTableName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableName.ForeColor = System.Drawing.Color.White;
            this.labelTableName.Location = new System.Drawing.Point(3, 3);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(1371, 29);
            this.labelTableName.TabIndex = 0;
            this.labelTableName.Text = "Table: Main";
            this.labelTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonClearFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClearFilter.FlatAppearance.BorderSize = 2;
            this.buttonClearFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClearFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFilter.ForeColor = System.Drawing.Color.White;
            this.buttonClearFilter.Location = new System.Drawing.Point(403, 635);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(175, 29);
            this.buttonClearFilter.TabIndex = 6;
            this.buttonClearFilter.Text = "Clear Filter";
            this.buttonClearFilter.UseVisualStyleBackColor = false;
            this.buttonClearFilter.Click += new System.EventHandler(this.action_ClearFilter);
            // 
            // labelDataValue
            // 
            this.labelDataValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDataValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDataValue.Location = new System.Drawing.Point(30, 638);
            this.labelDataValue.Name = "labelDataValue";
            this.labelDataValue.Size = new System.Drawing.Size(92, 23);
            this.labelDataValue.TabIndex = 0;
            this.labelDataValue.Text = "Data Value:";
            this.labelDataValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonApplyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonApplyFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApplyFilter.FlatAppearance.BorderSize = 2;
            this.buttonApplyFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApplyFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplyFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyFilter.ForeColor = System.Drawing.Color.White;
            this.buttonApplyFilter.Location = new System.Drawing.Point(403, 600);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(175, 29);
            this.buttonApplyFilter.TabIndex = 5;
            this.buttonApplyFilter.Text = "Apply Data Filter";
            this.buttonApplyFilter.UseVisualStyleBackColor = false;
            this.buttonApplyFilter.Click += new System.EventHandler(this.action_ApplyFilter);
            // 
            // labelColumnList
            // 
            this.labelColumnList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelColumnList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumnList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelColumnList.Location = new System.Drawing.Point(30, 600);
            this.labelColumnList.Name = "labelColumnList";
            this.labelColumnList.Size = new System.Drawing.Size(92, 29);
            this.labelColumnList.TabIndex = 0;
            this.labelColumnList.Text = "Column List:";
            this.labelColumnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownColumns
            // 
            this.dropdownColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dropdownColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownColumns.FormattingEnabled = true;
            this.dropdownColumns.ItemHeight = 23;
            this.dropdownColumns.Location = new System.Drawing.Point(128, 600);
            this.dropdownColumns.Name = "dropdownColumns";
            this.dropdownColumns.Size = new System.Drawing.Size(269, 29);
            this.dropdownColumns.TabIndex = 3;
            this.dropdownColumns.UseSelectable = true;
            // 
            // buttonRemoveSelections
            // 
            this.buttonRemoveSelections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveSelections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonRemoveSelections.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRemoveSelections.FlatAppearance.BorderSize = 2;
            this.buttonRemoveSelections.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRemoveSelections.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRemoveSelections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveSelections.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveSelections.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveSelections.Location = new System.Drawing.Point(214, 532);
            this.buttonRemoveSelections.Name = "buttonRemoveSelections";
            this.buttonRemoveSelections.Size = new System.Drawing.Size(364, 29);
            this.buttonRemoveSelections.TabIndex = 2;
            this.buttonRemoveSelections.Text = "Remove Selections From Run List";
            this.buttonRemoveSelections.UseVisualStyleBackColor = false;
            this.buttonRemoveSelections.Click += new System.EventHandler(this.action_RemoveSelections);
            // 
            // labelDebugModeDescription
            // 
            this.labelDebugModeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDebugModeDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebugModeDescription.ForeColor = System.Drawing.Color.Red;
            this.labelDebugModeDescription.Location = new System.Drawing.Point(1094, 619);
            this.labelDebugModeDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelDebugModeDescription.Name = "labelDebugModeDescription";
            this.labelDebugModeDescription.Size = new System.Drawing.Size(314, 68);
            this.labelDebugModeDescription.TabIndex = 0;
            this.labelDebugModeDescription.Text = "In debug mode only the first test case in the execution list will be executed and" +
    " the browser will not be closed once execution is complete. Results will not be " +
    "recorded in the database.";
            this.labelDebugModeDescription.Visible = false;
            // 
            // buttonLoadTable
            // 
            this.buttonLoadTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoadTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonLoadTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTable.FlatAppearance.BorderSize = 2;
            this.buttonLoadTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadTable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadTable.ForeColor = System.Drawing.Color.White;
            this.buttonLoadTable.Location = new System.Drawing.Point(33, 532);
            this.buttonLoadTable.Name = "buttonLoadTable";
            this.buttonLoadTable.Size = new System.Drawing.Size(175, 29);
            this.buttonLoadTable.TabIndex = 1;
            this.buttonLoadTable.Text = "Load Table";
            this.buttonLoadTable.UseVisualStyleBackColor = false;
            this.buttonLoadTable.Click += new System.EventHandler(this.action_LoadTable);
            // 
            // textboxDataValue
            // 
            this.textboxDataValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxDataValue.Depth = 0;
            this.textboxDataValue.Hint = "";
            this.textboxDataValue.Location = new System.Drawing.Point(128, 641);
            this.textboxDataValue.MaxLength = 32767;
            this.textboxDataValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxDataValue.Name = "textboxDataValue";
            this.textboxDataValue.PasswordChar = '\0';
            this.textboxDataValue.SelectedText = "";
            this.textboxDataValue.SelectionLength = 0;
            this.textboxDataValue.SelectionStart = 0;
            this.textboxDataValue.Size = new System.Drawing.Size(269, 23);
            this.textboxDataValue.TabIndex = 4;
            this.textboxDataValue.TabStop = false;
            this.textboxDataValue.UseSystemPasswordChar = false;
            // 
            // labelBrowsers
            // 
            this.labelBrowsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBrowsers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrowsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelBrowsers.Location = new System.Drawing.Point(1026, 529);
            this.labelBrowsers.Name = "labelBrowsers";
            this.labelBrowsers.Size = new System.Drawing.Size(62, 29);
            this.labelBrowsers.TabIndex = 0;
            this.labelBrowsers.Text = "Browser:";
            this.labelBrowsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownBrowsers
            // 
            this.dropdownBrowsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dropdownBrowsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownBrowsers.FormattingEnabled = true;
            this.dropdownBrowsers.ItemHeight = 23;
            this.dropdownBrowsers.Location = new System.Drawing.Point(1094, 529);
            this.dropdownBrowsers.Name = "dropdownBrowsers";
            this.dropdownBrowsers.Size = new System.Drawing.Size(318, 29);
            this.dropdownBrowsers.TabIndex = 7;
            this.dropdownBrowsers.UseSelectable = true;
            // 
            // checkboxDebugMode
            // 
            this.checkboxDebugMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxDebugMode.AutoSize = true;
            this.checkboxDebugMode.Depth = 0;
            this.checkboxDebugMode.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkboxDebugMode.Location = new System.Drawing.Point(1192, 574);
            this.checkboxDebugMode.Margin = new System.Windows.Forms.Padding(0);
            this.checkboxDebugMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkboxDebugMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkboxDebugMode.Name = "checkboxDebugMode";
            this.checkboxDebugMode.Ripple = true;
            this.checkboxDebugMode.Size = new System.Drawing.Size(108, 30);
            this.checkboxDebugMode.TabIndex = 8;
            this.checkboxDebugMode.Text = "Debug Mode";
            this.checkboxDebugMode.UseVisualStyleBackColor = true;
            this.checkboxDebugMode.CheckedChanged += new System.EventHandler(this.action_DebugModeChanged);
            // 
            // ControlConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkboxDebugMode);
            this.Controls.Add(this.labelBrowsers);
            this.Controls.Add(this.dropdownBrowsers);
            this.Controls.Add(this.textboxDataValue);
            this.Controls.Add(this.buttonLoadTable);
            this.Controls.Add(this.labelDebugModeDescription);
            this.Controls.Add(this.buttonRemoveSelections);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.labelDataValue);
            this.Controls.Add(this.buttonApplyFilter);
            this.Controls.Add(this.labelColumnList);
            this.Controls.Add(this.dropdownColumns);
            this.Controls.Add(this.panelTableBackground);
            this.Controls.Add(this.buttonStopExecution);
            this.Controls.Add(this.buttonStartExecution);
            this.Name = "ControlConfiguration";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 20, 20);
            this.Size = new System.Drawing.Size(1435, 785);
            this.Load += new System.EventHandler(this.action_FormLoad);
            this.panelTableBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStartExecution;
        private System.Windows.Forms.Button buttonStopExecution;
        private System.Windows.Forms.Panel panelTableBackground;
        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.Button buttonClearFilter;
        private System.Windows.Forms.Label labelDataValue;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.Label labelColumnList;
        private MetroFramework.Controls.MetroComboBox dropdownColumns;
        private System.Windows.Forms.Button buttonRemoveSelections;
        private System.Windows.Forms.Label labelDebugModeDescription;
        private System.Windows.Forms.Button buttonLoadTable;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxDataValue;
        private System.Windows.Forms.Label labelBrowsers;
        private MetroFramework.Controls.MetroComboBox dropdownBrowsers;
        private MaterialSkin.Controls.MaterialCheckBox checkboxDebugMode;
        internal System.Windows.Forms.DataGridView gridview;
    }
}
