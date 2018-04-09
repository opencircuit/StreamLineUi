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
            this.groupboxBrowsers = new System.Windows.Forms.GroupBox();
            this.radioIE64 = new System.Windows.Forms.RadioButton();
            this.radioIE32 = new System.Windows.Forms.RadioButton();
            this.radioChrome = new System.Windows.Forms.RadioButton();
            this.radioFirefox32 = new System.Windows.Forms.RadioButton();
            this.buttonStartExecution = new System.Windows.Forms.Button();
            this.buttonStopExecution = new System.Windows.Forms.Button();
            this.panelTableBackground = new System.Windows.Forms.Panel();
            this.gridviewTable = new MetroFramework.Controls.MetroGrid();
            this.labelTableName = new System.Windows.Forms.Label();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.textboxDataValue = new System.Windows.Forms.TextBox();
            this.labelDataValue = new System.Windows.Forms.Label();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.labelColumnList = new System.Windows.Forms.Label();
            this.dropdownColumns = new MetroFramework.Controls.MetroComboBox();
            this.buttonRemoveSelections = new System.Windows.Forms.Button();
            this.checkboxDebugMode = new System.Windows.Forms.CheckBox();
            this.labelDebugModeDescription = new System.Windows.Forms.Label();
            this.buttonLoadTable = new System.Windows.Forms.Button();
            this.labelExecutingTestCaseId = new System.Windows.Forms.Label();
            this.radioFirefox64 = new System.Windows.Forms.RadioButton();
            this.groupboxBrowsers.SuspendLayout();
            this.panelTableBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxBrowsers
            // 
            this.groupboxBrowsers.Controls.Add(this.radioFirefox64);
            this.groupboxBrowsers.Controls.Add(this.radioIE64);
            this.groupboxBrowsers.Controls.Add(this.radioIE32);
            this.groupboxBrowsers.Controls.Add(this.radioChrome);
            this.groupboxBrowsers.Controls.Add(this.radioFirefox32);
            this.groupboxBrowsers.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxBrowsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupboxBrowsers.Location = new System.Drawing.Point(33, 616);
            this.groupboxBrowsers.Name = "groupboxBrowsers";
            this.groupboxBrowsers.Size = new System.Drawing.Size(364, 156);
            this.groupboxBrowsers.TabIndex = 55;
            this.groupboxBrowsers.TabStop = false;
            this.groupboxBrowsers.Text = " Browsers ";
            // 
            // radioIE64
            // 
            this.radioIE64.AutoSize = true;
            this.radioIE64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioIE64.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIE64.Location = new System.Drawing.Point(30, 110);
            this.radioIE64.Name = "radioIE64";
            this.radioIE64.Size = new System.Drawing.Size(181, 20);
            this.radioIE64.TabIndex = 2;
            this.radioIE64.Text = "Internet Explorer 64-Bit";
            this.radioIE64.UseVisualStyleBackColor = true;
            // 
            // radioIE32
            // 
            this.radioIE32.AutoSize = true;
            this.radioIE32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioIE32.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIE32.Location = new System.Drawing.Point(30, 75);
            this.radioIE32.Name = "radioIE32";
            this.radioIE32.Size = new System.Drawing.Size(181, 20);
            this.radioIE32.TabIndex = 0;
            this.radioIE32.Text = "Internet Explorer 32-Bit";
            this.radioIE32.UseVisualStyleBackColor = true;
            // 
            // radioChrome
            // 
            this.radioChrome.AutoSize = true;
            this.radioChrome.Checked = true;
            this.radioChrome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioChrome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioChrome.Location = new System.Drawing.Point(30, 40);
            this.radioChrome.Name = "radioChrome";
            this.radioChrome.Size = new System.Drawing.Size(74, 20);
            this.radioChrome.TabIndex = 0;
            this.radioChrome.TabStop = true;
            this.radioChrome.Text = "Chrome";
            this.radioChrome.UseVisualStyleBackColor = true;
            // 
            // radioFirefox32
            // 
            this.radioFirefox32.AutoSize = true;
            this.radioFirefox32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioFirefox32.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFirefox32.Location = new System.Drawing.Point(110, 40);
            this.radioFirefox32.Name = "radioFirefox32";
            this.radioFirefox32.Size = new System.Drawing.Size(114, 20);
            this.radioFirefox32.TabIndex = 0;
            this.radioFirefox32.Text = "Firefox 32-Bit";
            this.radioFirefox32.UseVisualStyleBackColor = true;
            // 
            // buttonStartExecution
            // 
            this.buttonStartExecution.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStartExecution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStartExecution.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStartExecution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStartExecution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartExecution.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartExecution.ForeColor = System.Drawing.Color.White;
            this.buttonStartExecution.Location = new System.Drawing.Point(951, 722);
            this.buttonStartExecution.Name = "buttonStartExecution";
            this.buttonStartExecution.Size = new System.Drawing.Size(235, 50);
            this.buttonStartExecution.TabIndex = 57;
            this.buttonStartExecution.Text = "Start Test Case Execution";
            this.buttonStartExecution.UseVisualStyleBackColor = false;
            this.buttonStartExecution.Click += new System.EventHandler(this.action_StartExecution);
            // 
            // buttonStopExecution
            // 
            this.buttonStopExecution.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStopExecution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStopExecution.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStopExecution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStopExecution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopExecution.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopExecution.ForeColor = System.Drawing.Color.White;
            this.buttonStopExecution.Location = new System.Drawing.Point(1192, 722);
            this.buttonStopExecution.Name = "buttonStopExecution";
            this.buttonStopExecution.Size = new System.Drawing.Size(235, 50);
            this.buttonStopExecution.TabIndex = 58;
            this.buttonStopExecution.Text = "Terminate Test Case Execution";
            this.buttonStopExecution.UseVisualStyleBackColor = false;
            this.buttonStopExecution.Click += new System.EventHandler(this.action_StopExecution);
            // 
            // panelTableBackground
            // 
            this.panelTableBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelTableBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTableBackground.Controls.Add(this.gridviewTable);
            this.panelTableBackground.Controls.Add(this.labelTableName);
            this.panelTableBackground.Location = new System.Drawing.Point(33, 33);
            this.panelTableBackground.Name = "panelTableBackground";
            this.panelTableBackground.Padding = new System.Windows.Forms.Padding(5);
            this.panelTableBackground.Size = new System.Drawing.Size(1394, 493);
            this.panelTableBackground.TabIndex = 59;
            // 
            // gridviewTable
            // 
            this.gridviewTable.AllowUserToAddRows = false;
            this.gridviewTable.AllowUserToDeleteRows = false;
            this.gridviewTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.gridviewTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridviewTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridviewTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridviewTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridviewTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridviewTable.EnableHeadersVisualStyles = false;
            this.gridviewTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridviewTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridviewTable.Location = new System.Drawing.Point(5, 37);
            this.gridviewTable.Name = "gridviewTable";
            this.gridviewTable.ReadOnly = true;
            this.gridviewTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridviewTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridviewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewTable.Size = new System.Drawing.Size(1382, 449);
            this.gridviewTable.TabIndex = 21;
            // 
            // labelTableName
            // 
            this.labelTableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTableName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableName.ForeColor = System.Drawing.Color.White;
            this.labelTableName.Location = new System.Drawing.Point(5, 5);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(1382, 29);
            this.labelTableName.TabIndex = 19;
            this.labelTableName.Text = "Table: MAIN";
            this.labelTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonClearFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClearFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClearFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFilter.ForeColor = System.Drawing.Color.White;
            this.buttonClearFilter.Location = new System.Drawing.Point(413, 569);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(230, 29);
            this.buttonClearFilter.TabIndex = 65;
            this.buttonClearFilter.Text = "Clear Filter";
            this.buttonClearFilter.UseVisualStyleBackColor = false;
            this.buttonClearFilter.Click += new System.EventHandler(this.action_ClearFilter);
            // 
            // textboxDataValue
            // 
            this.textboxDataValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxDataValue.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDataValue.Location = new System.Drawing.Point(128, 571);
            this.textboxDataValue.Name = "textboxDataValue";
            this.textboxDataValue.Size = new System.Drawing.Size(269, 26);
            this.textboxDataValue.TabIndex = 64;
            // 
            // labelDataValue
            // 
            this.labelDataValue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDataValue.Location = new System.Drawing.Point(30, 571);
            this.labelDataValue.Name = "labelDataValue";
            this.labelDataValue.Size = new System.Drawing.Size(92, 26);
            this.labelDataValue.TabIndex = 63;
            this.labelDataValue.Text = "Data Value:";
            this.labelDataValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonApplyFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApplyFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApplyFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplyFilter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyFilter.ForeColor = System.Drawing.Color.White;
            this.buttonApplyFilter.Location = new System.Drawing.Point(413, 534);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(230, 29);
            this.buttonApplyFilter.TabIndex = 62;
            this.buttonApplyFilter.Text = "Apply Data Filter";
            this.buttonApplyFilter.UseVisualStyleBackColor = false;
            this.buttonApplyFilter.Click += new System.EventHandler(this.action_ApplyFilter);
            // 
            // labelColumnList
            // 
            this.labelColumnList.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumnList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelColumnList.Location = new System.Drawing.Point(30, 534);
            this.labelColumnList.Name = "labelColumnList";
            this.labelColumnList.Size = new System.Drawing.Size(92, 29);
            this.labelColumnList.TabIndex = 60;
            this.labelColumnList.Text = "Column List:";
            this.labelColumnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownColumns
            // 
            this.dropdownColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownColumns.FormattingEnabled = true;
            this.dropdownColumns.ItemHeight = 23;
            this.dropdownColumns.Location = new System.Drawing.Point(128, 534);
            this.dropdownColumns.Name = "dropdownColumns";
            this.dropdownColumns.Size = new System.Drawing.Size(269, 29);
            this.dropdownColumns.TabIndex = 61;
            this.dropdownColumns.UseSelectable = true;
            // 
            // buttonRemoveSelections
            // 
            this.buttonRemoveSelections.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRemoveSelections.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRemoveSelections.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRemoveSelections.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRemoveSelections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveSelections.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveSelections.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveSelections.Location = new System.Drawing.Point(1192, 534);
            this.buttonRemoveSelections.Name = "buttonRemoveSelections";
            this.buttonRemoveSelections.Size = new System.Drawing.Size(235, 50);
            this.buttonRemoveSelections.TabIndex = 67;
            this.buttonRemoveSelections.Text = "Remove Selected Test Case(s) From Execution List";
            this.buttonRemoveSelections.UseVisualStyleBackColor = false;
            this.buttonRemoveSelections.Click += new System.EventHandler(this.action_RemoveSelections);
            // 
            // checkboxDebugMode
            // 
            this.checkboxDebugMode.AutoSize = true;
            this.checkboxDebugMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxDebugMode.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxDebugMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxDebugMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxDebugMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxDebugMode.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxDebugMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxDebugMode.Location = new System.Drawing.Point(413, 620);
            this.checkboxDebugMode.Name = "checkboxDebugMode";
            this.checkboxDebugMode.Size = new System.Drawing.Size(152, 20);
            this.checkboxDebugMode.TabIndex = 68;
            this.checkboxDebugMode.Text = "Run In Debug Mode";
            this.checkboxDebugMode.UseVisualStyleBackColor = true;
            this.checkboxDebugMode.CheckedChanged += new System.EventHandler(this.action_DebugModeChanged);
            // 
            // labelDebugModeDescription
            // 
            this.labelDebugModeDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebugModeDescription.ForeColor = System.Drawing.Color.Red;
            this.labelDebugModeDescription.Location = new System.Drawing.Point(410, 676);
            this.labelDebugModeDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelDebugModeDescription.Name = "labelDebugModeDescription";
            this.labelDebugModeDescription.Size = new System.Drawing.Size(233, 96);
            this.labelDebugModeDescription.TabIndex = 69;
            this.labelDebugModeDescription.Text = "In debug mode only the first test case in the execution list will be executed and" +
    " the browser will not be closed once execution is complete. Results will also no" +
    "t be recorded in the database.";
            this.labelDebugModeDescription.Visible = false;
            // 
            // buttonLoadTable
            // 
            this.buttonLoadTable.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLoadTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadTable.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadTable.ForeColor = System.Drawing.Color.White;
            this.buttonLoadTable.Location = new System.Drawing.Point(951, 534);
            this.buttonLoadTable.Name = "buttonLoadTable";
            this.buttonLoadTable.Size = new System.Drawing.Size(235, 50);
            this.buttonLoadTable.TabIndex = 70;
            this.buttonLoadTable.Text = "Load Table";
            this.buttonLoadTable.UseVisualStyleBackColor = false;
            this.buttonLoadTable.Click += new System.EventHandler(this.action_LoadTable);
            // 
            // labelExecutingTestCaseId
            // 
            this.labelExecutingTestCaseId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExecutingTestCaseId.ForeColor = System.Drawing.Color.Red;
            this.labelExecutingTestCaseId.Location = new System.Drawing.Point(951, 639);
            this.labelExecutingTestCaseId.Margin = new System.Windows.Forms.Padding(0);
            this.labelExecutingTestCaseId.Name = "labelExecutingTestCaseId";
            this.labelExecutingTestCaseId.Size = new System.Drawing.Size(470, 21);
            this.labelExecutingTestCaseId.TabIndex = 71;
            // 
            // radioFirefox64
            // 
            this.radioFirefox64.AutoSize = true;
            this.radioFirefox64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioFirefox64.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFirefox64.Location = new System.Drawing.Point(230, 40);
            this.radioFirefox64.Name = "radioFirefox64";
            this.radioFirefox64.Size = new System.Drawing.Size(114, 20);
            this.radioFirefox64.TabIndex = 3;
            this.radioFirefox64.Text = "Firefox 64-Bit";
            this.radioFirefox64.UseVisualStyleBackColor = true;
            // 
            // ControlConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelExecutingTestCaseId);
            this.Controls.Add(this.buttonLoadTable);
            this.Controls.Add(this.labelDebugModeDescription);
            this.Controls.Add(this.checkboxDebugMode);
            this.Controls.Add(this.buttonRemoveSelections);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.textboxDataValue);
            this.Controls.Add(this.labelDataValue);
            this.Controls.Add(this.buttonApplyFilter);
            this.Controls.Add(this.labelColumnList);
            this.Controls.Add(this.dropdownColumns);
            this.Controls.Add(this.panelTableBackground);
            this.Controls.Add(this.buttonStopExecution);
            this.Controls.Add(this.buttonStartExecution);
            this.Controls.Add(this.groupboxBrowsers);
            this.Name = "ControlConfiguration";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(1460, 805);
            this.Load += new System.EventHandler(this.action_FormLoad);
            this.groupboxBrowsers.ResumeLayout(false);
            this.groupboxBrowsers.PerformLayout();
            this.panelTableBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupboxBrowsers;
        private System.Windows.Forms.RadioButton radioIE32;
        private System.Windows.Forms.RadioButton radioChrome;
        private System.Windows.Forms.RadioButton radioFirefox32;
        private System.Windows.Forms.Button buttonStartExecution;
        private System.Windows.Forms.Button buttonStopExecution;
        private System.Windows.Forms.Panel panelTableBackground;
        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.Button buttonClearFilter;
        private System.Windows.Forms.TextBox textboxDataValue;
        private System.Windows.Forms.Label labelDataValue;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.Label labelColumnList;
        private MetroFramework.Controls.MetroComboBox dropdownColumns;
        private System.Windows.Forms.Button buttonRemoveSelections;
        private System.Windows.Forms.CheckBox checkboxDebugMode;
        private System.Windows.Forms.Label labelDebugModeDescription;
        private System.Windows.Forms.RadioButton radioIE64;
        private System.Windows.Forms.Button buttonLoadTable;
        private MetroFramework.Controls.MetroGrid gridviewTable;
        private System.Windows.Forms.Label labelExecutingTestCaseId;
        private System.Windows.Forms.RadioButton radioFirefox64;
    }
}
