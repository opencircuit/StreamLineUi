namespace StreamLineUi
{
    partial class ControlDashboard
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
            this.labelExecutedTestSetList = new System.Windows.Forms.Label();
            this.dropdownExecutionIds = new MetroFramework.Controls.MetroComboBox();
            this.buttonLoadExecution = new System.Windows.Forms.Button();
            this.gaugePassedTests = new LiveCharts.WinForms.SolidGauge();
            this.chartExecutionTime = new LiveCharts.WinForms.CartesianChart();
            this.gaugeFailedTests = new LiveCharts.WinForms.SolidGauge();
            this.labelPassedTests = new System.Windows.Forms.Label();
            this.labelFailedTests = new System.Windows.Forms.Label();
            this.panelTableBackground = new System.Windows.Forms.Panel();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.labelExecutedTestsList = new System.Windows.Forms.Label();
            this.labelExecutionTimeOverview = new System.Windows.Forms.Label();
            this.labelSkippedTests = new System.Windows.Forms.Label();
            this.gaugeSkippedTests = new LiveCharts.WinForms.SolidGauge();
            this.labelEndDateDescription = new System.Windows.Forms.Label();
            this.panelEndDate = new System.Windows.Forms.Panel();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.panelEndTime = new System.Windows.Forms.Panel();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.labelEndTimeDescription = new System.Windows.Forms.Label();
            this.panelStartTime = new System.Windows.Forms.Panel();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelStartTimeDescription = new System.Windows.Forms.Label();
            this.panelStartDate = new System.Windows.Forms.Panel();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelStartDateDescription = new System.Windows.Forms.Label();
            this.panelMachineName = new System.Windows.Forms.Panel();
            this.labelMachineName = new System.Windows.Forms.Label();
            this.labelMachineNameDescription = new System.Windows.Forms.Label();
            this.panelExecutionId = new System.Windows.Forms.Panel();
            this.labelExecutionId = new System.Windows.Forms.Label();
            this.labelExecutionIdDescription = new System.Windows.Forms.Label();
            this.panelTotalTestsAvailable = new System.Windows.Forms.Panel();
            this.labelTotalTestsAvailableCount = new System.Windows.Forms.Label();
            this.labelTotalTestsAvailableDescription = new System.Windows.Forms.Label();
            this.panelTotalTestsRan = new System.Windows.Forms.Panel();
            this.labelTotalTestsRanCount = new System.Windows.Forms.Label();
            this.labelTotalTestsRanDescription = new System.Windows.Forms.Label();
            this.buttonDeleteExecution = new System.Windows.Forms.Button();
            this.buttonReloadExecutionIdList = new System.Windows.Forms.Button();
            this.panelBrowserName = new System.Windows.Forms.Panel();
            this.labelBrowserName = new System.Windows.Forms.Label();
            this.labelBrowserNameDescription = new System.Windows.Forms.Label();
            this.panelTableBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.panelEndDate.SuspendLayout();
            this.panelEndTime.SuspendLayout();
            this.panelStartTime.SuspendLayout();
            this.panelStartDate.SuspendLayout();
            this.panelMachineName.SuspendLayout();
            this.panelExecutionId.SuspendLayout();
            this.panelTotalTestsAvailable.SuspendLayout();
            this.panelTotalTestsRan.SuspendLayout();
            this.panelBrowserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelExecutedTestSetList
            // 
            this.labelExecutedTestSetList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExecutedTestSetList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelExecutedTestSetList.Location = new System.Drawing.Point(33, 33);
            this.labelExecutedTestSetList.Name = "labelExecutedTestSetList";
            this.labelExecutedTestSetList.Size = new System.Drawing.Size(118, 29);
            this.labelExecutedTestSetList.TabIndex = 0;
            this.labelExecutedTestSetList.Text = "Execution ID List:";
            this.labelExecutedTestSetList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownExecutionIds
            // 
            this.dropdownExecutionIds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownExecutionIds.FormattingEnabled = true;
            this.dropdownExecutionIds.ItemHeight = 23;
            this.dropdownExecutionIds.Location = new System.Drawing.Point(157, 33);
            this.dropdownExecutionIds.Name = "dropdownExecutionIds";
            this.dropdownExecutionIds.Size = new System.Drawing.Size(266, 29);
            this.dropdownExecutionIds.TabIndex = 1;
            this.dropdownExecutionIds.UseSelectable = true;
            // 
            // buttonLoadExecution
            // 
            this.buttonLoadExecution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonLoadExecution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadExecution.FlatAppearance.BorderSize = 2;
            this.buttonLoadExecution.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadExecution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadExecution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadExecution.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadExecution.ForeColor = System.Drawing.Color.White;
            this.buttonLoadExecution.Location = new System.Drawing.Point(429, 33);
            this.buttonLoadExecution.Name = "buttonLoadExecution";
            this.buttonLoadExecution.Size = new System.Drawing.Size(117, 29);
            this.buttonLoadExecution.TabIndex = 2;
            this.buttonLoadExecution.Text = "Load Execution";
            this.buttonLoadExecution.UseVisualStyleBackColor = false;
            this.buttonLoadExecution.Click += new System.EventHandler(this.action_LoadExecution);
            // 
            // gaugePassedTests
            // 
            this.gaugePassedTests.BackColor = System.Drawing.Color.Black;
            this.gaugePassedTests.ForeColor = System.Drawing.Color.White;
            this.gaugePassedTests.Location = new System.Drawing.Point(36, 126);
            this.gaugePassedTests.Name = "gaugePassedTests";
            this.gaugePassedTests.Size = new System.Drawing.Size(150, 150);
            this.gaugePassedTests.TabIndex = 0;
            // 
            // chartExecutionTime
            // 
            this.chartExecutionTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartExecutionTime.BackColor = System.Drawing.Color.Black;
            this.chartExecutionTime.ForeColor = System.Drawing.Color.White;
            this.chartExecutionTime.Location = new System.Drawing.Point(806, 56);
            this.chartExecutionTime.Name = "chartExecutionTime";
            this.chartExecutionTime.Size = new System.Drawing.Size(606, 220);
            this.chartExecutionTime.TabIndex = 0;
            this.chartExecutionTime.Text = "cartesianChart1";
            // 
            // gaugeFailedTests
            // 
            this.gaugeFailedTests.BackColor = System.Drawing.Color.Black;
            this.gaugeFailedTests.ForeColor = System.Drawing.Color.White;
            this.gaugeFailedTests.Location = new System.Drawing.Point(292, 126);
            this.gaugeFailedTests.Name = "gaugeFailedTests";
            this.gaugeFailedTests.Size = new System.Drawing.Size(150, 150);
            this.gaugeFailedTests.TabIndex = 0;
            // 
            // labelPassedTests
            // 
            this.labelPassedTests.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassedTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPassedTests.Location = new System.Drawing.Point(36, 94);
            this.labelPassedTests.Name = "labelPassedTests";
            this.labelPassedTests.Size = new System.Drawing.Size(150, 29);
            this.labelPassedTests.TabIndex = 0;
            this.labelPassedTests.Text = "Tests Passed";
            this.labelPassedTests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFailedTests
            // 
            this.labelFailedTests.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFailedTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFailedTests.Location = new System.Drawing.Point(292, 94);
            this.labelFailedTests.Name = "labelFailedTests";
            this.labelFailedTests.Size = new System.Drawing.Size(150, 29);
            this.labelFailedTests.TabIndex = 0;
            this.labelFailedTests.Text = "Tests Failed";
            this.labelFailedTests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTableBackground
            // 
            this.panelTableBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTableBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelTableBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTableBackground.Controls.Add(this.gridview);
            this.panelTableBackground.Controls.Add(this.labelExecutedTestsList);
            this.panelTableBackground.Location = new System.Drawing.Point(451, 329);
            this.panelTableBackground.Name = "panelTableBackground";
            this.panelTableBackground.Padding = new System.Windows.Forms.Padding(3);
            this.panelTableBackground.Size = new System.Drawing.Size(961, 398);
            this.panelTableBackground.TabIndex = 0;
            // 
            // gridviewTable
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
            this.gridview.MultiSelect = false;
            this.gridview.Name = "gridviewTable";
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
            this.gridview.Size = new System.Drawing.Size(953, 361);
            this.gridview.TabIndex = 0;
            this.gridview.DoubleClick += new System.EventHandler(this.action_LaunchHtmlReport);
            // 
            // labelExecutedTestsList
            // 
            this.labelExecutedTestsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelExecutedTestsList.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExecutedTestsList.ForeColor = System.Drawing.Color.White;
            this.labelExecutedTestsList.Location = new System.Drawing.Point(3, 3);
            this.labelExecutedTestsList.Name = "labelExecutedTestsList";
            this.labelExecutedTestsList.Size = new System.Drawing.Size(953, 29);
            this.labelExecutedTestsList.TabIndex = 0;
            this.labelExecutedTestsList.Text = "Executed Test Case List";
            this.labelExecutedTestsList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelExecutionTimeOverview
            // 
            this.labelExecutionTimeOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExecutionTimeOverview.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExecutionTimeOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelExecutionTimeOverview.Location = new System.Drawing.Point(806, 24);
            this.labelExecutionTimeOverview.Name = "labelExecutionTimeOverview";
            this.labelExecutionTimeOverview.Size = new System.Drawing.Size(606, 29);
            this.labelExecutionTimeOverview.TabIndex = 22;
            this.labelExecutionTimeOverview.Text = "Test Case Execution Time Overview";
            this.labelExecutionTimeOverview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSkippedTests
            // 
            this.labelSkippedTests.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkippedTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSkippedTests.Location = new System.Drawing.Point(548, 94);
            this.labelSkippedTests.Name = "labelSkippedTests";
            this.labelSkippedTests.Size = new System.Drawing.Size(150, 29);
            this.labelSkippedTests.TabIndex = 0;
            this.labelSkippedTests.Text = "Tests Skipped";
            this.labelSkippedTests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gaugeSkippedTests
            // 
            this.gaugeSkippedTests.BackColor = System.Drawing.Color.Black;
            this.gaugeSkippedTests.ForeColor = System.Drawing.Color.White;
            this.gaugeSkippedTests.Location = new System.Drawing.Point(548, 126);
            this.gaugeSkippedTests.Name = "gaugeSkippedTests";
            this.gaugeSkippedTests.Size = new System.Drawing.Size(150, 150);
            this.gaugeSkippedTests.TabIndex = 0;
            // 
            // labelEndDateDescription
            // 
            this.labelEndDateDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelEndDateDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEndDateDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDateDescription.ForeColor = System.Drawing.Color.White;
            this.labelEndDateDescription.Location = new System.Drawing.Point(5, 0);
            this.labelEndDateDescription.Name = "labelEndDateDescription";
            this.labelEndDateDescription.Size = new System.Drawing.Size(88, 30);
            this.labelEndDateDescription.TabIndex = 0;
            this.labelEndDateDescription.Text = "End Date:";
            this.labelEndDateDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelEndDate
            // 
            this.panelEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEndDate.Controls.Add(this.labelEndDate);
            this.panelEndDate.Controls.Add(this.labelEndDateDescription);
            this.panelEndDate.Location = new System.Drawing.Point(36, 622);
            this.panelEndDate.Name = "panelEndDate";
            this.panelEndDate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelEndDate.Size = new System.Drawing.Size(298, 32);
            this.panelEndDate.TabIndex = 0;
            // 
            // labelEndDate
            // 
            this.labelEndDate.BackColor = System.Drawing.Color.White;
            this.labelEndDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEndDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEndDate.Location = new System.Drawing.Point(99, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(197, 30);
            this.labelEndDate.TabIndex = 0;
            this.labelEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEndTime
            // 
            this.panelEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEndTime.Controls.Add(this.labelEndTime);
            this.panelEndTime.Controls.Add(this.labelEndTimeDescription);
            this.panelEndTime.Location = new System.Drawing.Point(36, 730);
            this.panelEndTime.Name = "panelEndTime";
            this.panelEndTime.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelEndTime.Size = new System.Drawing.Size(297, 32);
            this.panelEndTime.TabIndex = 0;
            // 
            // labelEndTime
            // 
            this.labelEndTime.BackColor = System.Drawing.Color.White;
            this.labelEndTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelEndTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEndTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEndTime.Location = new System.Drawing.Point(99, 0);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(196, 30);
            this.labelEndTime.TabIndex = 0;
            this.labelEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEndTimeDescription
            // 
            this.labelEndTimeDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelEndTimeDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEndTimeDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndTimeDescription.ForeColor = System.Drawing.Color.White;
            this.labelEndTimeDescription.Location = new System.Drawing.Point(5, 0);
            this.labelEndTimeDescription.Name = "labelEndTimeDescription";
            this.labelEndTimeDescription.Size = new System.Drawing.Size(88, 30);
            this.labelEndTimeDescription.TabIndex = 0;
            this.labelEndTimeDescription.Text = "End Time:";
            this.labelEndTimeDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStartTime
            // 
            this.panelStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStartTime.Controls.Add(this.labelStartTime);
            this.panelStartTime.Controls.Add(this.labelStartTimeDescription);
            this.panelStartTime.Location = new System.Drawing.Point(36, 692);
            this.panelStartTime.Name = "panelStartTime";
            this.panelStartTime.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelStartTime.Size = new System.Drawing.Size(297, 32);
            this.panelStartTime.TabIndex = 0;
            // 
            // labelStartTime
            // 
            this.labelStartTime.BackColor = System.Drawing.Color.White;
            this.labelStartTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStartTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStartTime.Location = new System.Drawing.Point(99, 0);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(196, 30);
            this.labelStartTime.TabIndex = 0;
            this.labelStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStartTimeDescription
            // 
            this.labelStartTimeDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelStartTimeDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStartTimeDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTimeDescription.ForeColor = System.Drawing.Color.White;
            this.labelStartTimeDescription.Location = new System.Drawing.Point(5, 0);
            this.labelStartTimeDescription.Name = "labelStartTimeDescription";
            this.labelStartTimeDescription.Size = new System.Drawing.Size(88, 30);
            this.labelStartTimeDescription.TabIndex = 0;
            this.labelStartTimeDescription.Text = "Start Time:";
            this.labelStartTimeDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStartDate
            // 
            this.panelStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStartDate.Controls.Add(this.labelStartDate);
            this.panelStartDate.Controls.Add(this.labelStartDateDescription);
            this.panelStartDate.Location = new System.Drawing.Point(36, 584);
            this.panelStartDate.Name = "panelStartDate";
            this.panelStartDate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelStartDate.Size = new System.Drawing.Size(298, 32);
            this.panelStartDate.TabIndex = 0;
            // 
            // labelStartDate
            // 
            this.labelStartDate.BackColor = System.Drawing.Color.White;
            this.labelStartDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStartDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStartDate.Location = new System.Drawing.Point(99, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(197, 30);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStartDateDescription
            // 
            this.labelStartDateDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelStartDateDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStartDateDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDateDescription.ForeColor = System.Drawing.Color.White;
            this.labelStartDateDescription.Location = new System.Drawing.Point(5, 0);
            this.labelStartDateDescription.Name = "labelStartDateDescription";
            this.labelStartDateDescription.Size = new System.Drawing.Size(88, 30);
            this.labelStartDateDescription.TabIndex = 0;
            this.labelStartDateDescription.Text = "Start Date:";
            this.labelStartDateDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMachineName
            // 
            this.panelMachineName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMachineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMachineName.Controls.Add(this.labelMachineName);
            this.panelMachineName.Controls.Add(this.labelMachineNameDescription);
            this.panelMachineName.Location = new System.Drawing.Point(36, 367);
            this.panelMachineName.Name = "panelMachineName";
            this.panelMachineName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelMachineName.Size = new System.Drawing.Size(390, 32);
            this.panelMachineName.TabIndex = 0;
            // 
            // labelMachineName
            // 
            this.labelMachineName.BackColor = System.Drawing.Color.White;
            this.labelMachineName.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelMachineName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMachineName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMachineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMachineName.Location = new System.Drawing.Point(133, 0);
            this.labelMachineName.Name = "labelMachineName";
            this.labelMachineName.Size = new System.Drawing.Size(255, 30);
            this.labelMachineName.TabIndex = 0;
            this.labelMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMachineNameDescription
            // 
            this.labelMachineNameDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMachineNameDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMachineNameDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMachineNameDescription.ForeColor = System.Drawing.Color.White;
            this.labelMachineNameDescription.Location = new System.Drawing.Point(5, 0);
            this.labelMachineNameDescription.Name = "labelMachineNameDescription";
            this.labelMachineNameDescription.Size = new System.Drawing.Size(122, 30);
            this.labelMachineNameDescription.TabIndex = 0;
            this.labelMachineNameDescription.Text = "Machine Name:";
            this.labelMachineNameDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelExecutionId
            // 
            this.panelExecutionId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelExecutionId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExecutionId.Controls.Add(this.labelExecutionId);
            this.panelExecutionId.Controls.Add(this.labelExecutionIdDescription);
            this.panelExecutionId.Location = new System.Drawing.Point(36, 329);
            this.panelExecutionId.Name = "panelExecutionId";
            this.panelExecutionId.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelExecutionId.Size = new System.Drawing.Size(390, 32);
            this.panelExecutionId.TabIndex = 0;
            // 
            // labelExecutionId
            // 
            this.labelExecutionId.BackColor = System.Drawing.Color.White;
            this.labelExecutionId.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelExecutionId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExecutionId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExecutionId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelExecutionId.Location = new System.Drawing.Point(133, 0);
            this.labelExecutionId.Name = "labelExecutionId";
            this.labelExecutionId.Size = new System.Drawing.Size(255, 30);
            this.labelExecutionId.TabIndex = 0;
            this.labelExecutionId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelExecutionIdDescription
            // 
            this.labelExecutionIdDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelExecutionIdDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExecutionIdDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExecutionIdDescription.ForeColor = System.Drawing.Color.White;
            this.labelExecutionIdDescription.Location = new System.Drawing.Point(5, 0);
            this.labelExecutionIdDescription.Name = "labelExecutionIdDescription";
            this.labelExecutionIdDescription.Size = new System.Drawing.Size(122, 30);
            this.labelExecutionIdDescription.TabIndex = 0;
            this.labelExecutionIdDescription.Text = "Execution ID:";
            this.labelExecutionIdDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTotalTestsAvailable
            // 
            this.panelTotalTestsAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTotalTestsAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalTestsAvailable.Controls.Add(this.labelTotalTestsAvailableCount);
            this.panelTotalTestsAvailable.Controls.Add(this.labelTotalTestsAvailableDescription);
            this.panelTotalTestsAvailable.Location = new System.Drawing.Point(36, 513);
            this.panelTotalTestsAvailable.Name = "panelTotalTestsAvailable";
            this.panelTotalTestsAvailable.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelTotalTestsAvailable.Size = new System.Drawing.Size(299, 32);
            this.panelTotalTestsAvailable.TabIndex = 0;
            // 
            // labelTotalTestsAvailableCount
            // 
            this.labelTotalTestsAvailableCount.BackColor = System.Drawing.Color.White;
            this.labelTotalTestsAvailableCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTotalTestsAvailableCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalTestsAvailableCount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTestsAvailableCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTotalTestsAvailableCount.Location = new System.Drawing.Point(181, 0);
            this.labelTotalTestsAvailableCount.Name = "labelTotalTestsAvailableCount";
            this.labelTotalTestsAvailableCount.Size = new System.Drawing.Size(116, 30);
            this.labelTotalTestsAvailableCount.TabIndex = 0;
            this.labelTotalTestsAvailableCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalTestsAvailableDescription
            // 
            this.labelTotalTestsAvailableDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotalTestsAvailableDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalTestsAvailableDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTestsAvailableDescription.ForeColor = System.Drawing.Color.White;
            this.labelTotalTestsAvailableDescription.Location = new System.Drawing.Point(5, 0);
            this.labelTotalTestsAvailableDescription.Name = "labelTotalTestsAvailableDescription";
            this.labelTotalTestsAvailableDescription.Size = new System.Drawing.Size(170, 30);
            this.labelTotalTestsAvailableDescription.TabIndex = 0;
            this.labelTotalTestsAvailableDescription.Text = "Total Tests Available:";
            this.labelTotalTestsAvailableDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTotalTestsRan
            // 
            this.panelTotalTestsRan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTotalTestsRan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalTestsRan.Controls.Add(this.labelTotalTestsRanCount);
            this.panelTotalTestsRan.Controls.Add(this.labelTotalTestsRanDescription);
            this.panelTotalTestsRan.Location = new System.Drawing.Point(36, 475);
            this.panelTotalTestsRan.Name = "panelTotalTestsRan";
            this.panelTotalTestsRan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelTotalTestsRan.Size = new System.Drawing.Size(299, 32);
            this.panelTotalTestsRan.TabIndex = 0;
            // 
            // labelTotalTestsRanCount
            // 
            this.labelTotalTestsRanCount.BackColor = System.Drawing.Color.White;
            this.labelTotalTestsRanCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTotalTestsRanCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalTestsRanCount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTestsRanCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTotalTestsRanCount.Location = new System.Drawing.Point(181, 0);
            this.labelTotalTestsRanCount.Name = "labelTotalTestsRanCount";
            this.labelTotalTestsRanCount.Size = new System.Drawing.Size(116, 30);
            this.labelTotalTestsRanCount.TabIndex = 0;
            this.labelTotalTestsRanCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalTestsRanDescription
            // 
            this.labelTotalTestsRanDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotalTestsRanDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalTestsRanDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTestsRanDescription.ForeColor = System.Drawing.Color.White;
            this.labelTotalTestsRanDescription.Location = new System.Drawing.Point(5, 0);
            this.labelTotalTestsRanDescription.Name = "labelTotalTestsRanDescription";
            this.labelTotalTestsRanDescription.Size = new System.Drawing.Size(170, 30);
            this.labelTotalTestsRanDescription.TabIndex = 0;
            this.labelTotalTestsRanDescription.Text = "Total Tests Ran:";
            this.labelTotalTestsRanDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDeleteExecution
            // 
            this.buttonDeleteExecution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteExecution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDeleteExecution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteExecution.FlatAppearance.BorderSize = 2;
            this.buttonDeleteExecution.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteExecution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteExecution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteExecution.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteExecution.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteExecution.Location = new System.Drawing.Point(451, 733);
            this.buttonDeleteExecution.Name = "buttonDeleteExecution";
            this.buttonDeleteExecution.Size = new System.Drawing.Size(961, 29);
            this.buttonDeleteExecution.TabIndex = 4;
            this.buttonDeleteExecution.Text = "Delete Loaded Execution";
            this.buttonDeleteExecution.UseVisualStyleBackColor = false;
            this.buttonDeleteExecution.Click += new System.EventHandler(this.action_DeleteLoadedExecution);
            // 
            // buttonReloadExecutionIdList
            // 
            this.buttonReloadExecutionIdList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonReloadExecutionIdList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReloadExecutionIdList.FlatAppearance.BorderSize = 2;
            this.buttonReloadExecutionIdList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReloadExecutionIdList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReloadExecutionIdList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReloadExecutionIdList.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReloadExecutionIdList.ForeColor = System.Drawing.Color.White;
            this.buttonReloadExecutionIdList.Location = new System.Drawing.Point(552, 33);
            this.buttonReloadExecutionIdList.Name = "buttonReloadExecutionIdList";
            this.buttonReloadExecutionIdList.Size = new System.Drawing.Size(170, 29);
            this.buttonReloadExecutionIdList.TabIndex = 3;
            this.buttonReloadExecutionIdList.Text = "Reload Execution ID\'s";
            this.buttonReloadExecutionIdList.UseVisualStyleBackColor = false;
            this.buttonReloadExecutionIdList.Click += new System.EventHandler(this.action_ReloadExecutionIdList);
            // 
            // panelBrowserName
            // 
            this.panelBrowserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBrowserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBrowserName.Controls.Add(this.labelBrowserName);
            this.panelBrowserName.Controls.Add(this.labelBrowserNameDescription);
            this.panelBrowserName.Location = new System.Drawing.Point(36, 405);
            this.panelBrowserName.Name = "panelBrowserName";
            this.panelBrowserName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelBrowserName.Size = new System.Drawing.Size(390, 32);
            this.panelBrowserName.TabIndex = 1;
            // 
            // labelBrowserName
            // 
            this.labelBrowserName.BackColor = System.Drawing.Color.White;
            this.labelBrowserName.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelBrowserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBrowserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrowserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelBrowserName.Location = new System.Drawing.Point(133, 0);
            this.labelBrowserName.Name = "labelBrowserName";
            this.labelBrowserName.Size = new System.Drawing.Size(255, 30);
            this.labelBrowserName.TabIndex = 0;
            this.labelBrowserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBrowserNameDescription
            // 
            this.labelBrowserNameDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelBrowserNameDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBrowserNameDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrowserNameDescription.ForeColor = System.Drawing.Color.White;
            this.labelBrowserNameDescription.Location = new System.Drawing.Point(5, 0);
            this.labelBrowserNameDescription.Name = "labelBrowserNameDescription";
            this.labelBrowserNameDescription.Size = new System.Drawing.Size(122, 30);
            this.labelBrowserNameDescription.TabIndex = 0;
            this.labelBrowserNameDescription.Text = "Browser Name:";
            this.labelBrowserNameDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBrowserName);
            this.Controls.Add(this.buttonReloadExecutionIdList);
            this.Controls.Add(this.buttonDeleteExecution);
            this.Controls.Add(this.panelTotalTestsAvailable);
            this.Controls.Add(this.panelStartDate);
            this.Controls.Add(this.panelEndDate);
            this.Controls.Add(this.panelMachineName);
            this.Controls.Add(this.panelEndTime);
            this.Controls.Add(this.panelTotalTestsRan);
            this.Controls.Add(this.panelStartTime);
            this.Controls.Add(this.panelExecutionId);
            this.Controls.Add(this.labelSkippedTests);
            this.Controls.Add(this.gaugeSkippedTests);
            this.Controls.Add(this.labelExecutionTimeOverview);
            this.Controls.Add(this.panelTableBackground);
            this.Controls.Add(this.labelFailedTests);
            this.Controls.Add(this.labelPassedTests);
            this.Controls.Add(this.gaugeFailedTests);
            this.Controls.Add(this.chartExecutionTime);
            this.Controls.Add(this.gaugePassedTests);
            this.Controls.Add(this.buttonLoadExecution);
            this.Controls.Add(this.dropdownExecutionIds);
            this.Controls.Add(this.labelExecutedTestSetList);
            this.Name = "ControlDashboard";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 20, 20);
            this.Size = new System.Drawing.Size(1435, 785);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.panelTableBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.panelEndDate.ResumeLayout(false);
            this.panelEndTime.ResumeLayout(false);
            this.panelStartTime.ResumeLayout(false);
            this.panelStartDate.ResumeLayout(false);
            this.panelMachineName.ResumeLayout(false);
            this.panelExecutionId.ResumeLayout(false);
            this.panelTotalTestsAvailable.ResumeLayout(false);
            this.panelTotalTestsRan.ResumeLayout(false);
            this.panelBrowserName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelExecutedTestSetList;
        private MetroFramework.Controls.MetroComboBox dropdownExecutionIds;
        private System.Windows.Forms.Button buttonLoadExecution;
        private LiveCharts.WinForms.SolidGauge gaugePassedTests;
        private LiveCharts.WinForms.CartesianChart chartExecutionTime;
        private LiveCharts.WinForms.SolidGauge gaugeFailedTests;
        private System.Windows.Forms.Label labelPassedTests;
        private System.Windows.Forms.Label labelFailedTests;
        private System.Windows.Forms.Panel panelTableBackground;
        private System.Windows.Forms.Label labelExecutedTestsList;
        private System.Windows.Forms.Label labelExecutionTimeOverview;
        private System.Windows.Forms.Label labelSkippedTests;
        private LiveCharts.WinForms.SolidGauge gaugeSkippedTests;
        private System.Windows.Forms.Label labelEndDateDescription;
        private System.Windows.Forms.Panel panelEndDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Panel panelEndTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.Label labelEndTimeDescription;
        private System.Windows.Forms.Panel panelStartTime;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelStartTimeDescription;
        private System.Windows.Forms.Panel panelStartDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelStartDateDescription;
        private System.Windows.Forms.Panel panelMachineName;
        private System.Windows.Forms.Label labelMachineName;
        private System.Windows.Forms.Label labelMachineNameDescription;
        private System.Windows.Forms.Panel panelExecutionId;
        private System.Windows.Forms.Label labelExecutionId;
        private System.Windows.Forms.Label labelExecutionIdDescription;
        private System.Windows.Forms.Panel panelTotalTestsAvailable;
        private System.Windows.Forms.Label labelTotalTestsAvailableCount;
        private System.Windows.Forms.Label labelTotalTestsAvailableDescription;
        private System.Windows.Forms.Panel panelTotalTestsRan;
        private System.Windows.Forms.Label labelTotalTestsRanCount;
        private System.Windows.Forms.Label labelTotalTestsRanDescription;
        private System.Windows.Forms.Button buttonDeleteExecution;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button buttonReloadExecutionIdList;
        private System.Windows.Forms.Panel panelBrowserName;
        private System.Windows.Forms.Label labelBrowserName;
        private System.Windows.Forms.Label labelBrowserNameDescription;
    }
}
