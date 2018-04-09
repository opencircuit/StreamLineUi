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
            this.dropdownExecutedID = new MetroFramework.Controls.MetroComboBox();
            this.buttonLoadTestSet = new System.Windows.Forms.Button();
            this.gaugePassedTests = new LiveCharts.WinForms.SolidGauge();
            this.chartExecutionTime = new LiveCharts.WinForms.CartesianChart();
            this.gaugeFailedTests = new LiveCharts.WinForms.SolidGauge();
            this.gaugeTotalTests = new LiveCharts.WinForms.SolidGauge();
            this.labelPassedTests = new System.Windows.Forms.Label();
            this.labelFailedTests = new System.Windows.Forms.Label();
            this.labelTotalTestsRan = new System.Windows.Forms.Label();
            this.panelTableBackground = new System.Windows.Forms.Panel();
            this.gridviewTable = new MetroFramework.Controls.MetroGrid();
            this.labelExecutedTestsList = new System.Windows.Forms.Label();
            this.labelExecutionTimeOverview = new System.Windows.Forms.Label();
            this.labelSkippedTests = new System.Windows.Forms.Label();
            this.gaugeSkippedTests = new LiveCharts.WinForms.SolidGauge();
            this.labelEndDateDescription = new System.Windows.Forms.Label();
            this.panelEndDateBackground = new System.Windows.Forms.Panel();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.panelEndTimeBackground = new System.Windows.Forms.Panel();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.labelEndTimeDescription = new System.Windows.Forms.Label();
            this.panelStartTimeBackground = new System.Windows.Forms.Panel();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelStartTimeDescription = new System.Windows.Forms.Label();
            this.panelStartDateBackground = new System.Windows.Forms.Panel();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelStartDateDescription = new System.Windows.Forms.Label();
            this.buttonLoadTestCaseDetails = new System.Windows.Forms.Button();
            this.panelMachineNameBackground = new System.Windows.Forms.Panel();
            this.labelMachineName = new System.Windows.Forms.Label();
            this.labelMachineNameDescription = new System.Windows.Forms.Label();
            this.panelExecutionIDBackground = new System.Windows.Forms.Panel();
            this.labelExecutionID = new System.Windows.Forms.Label();
            this.labelExecutionIDDescription = new System.Windows.Forms.Label();
            this.panelTotalTestsAvailableBackground = new System.Windows.Forms.Panel();
            this.labelTotalTestsAvailableCount = new System.Windows.Forms.Label();
            this.labelTotalTestsAvailableDescription = new System.Windows.Forms.Label();
            this.panelTotalTestsRanBackground = new System.Windows.Forms.Panel();
            this.labelTotalTestsRanCount = new System.Windows.Forms.Label();
            this.labelTotalTestsRanDescription = new System.Windows.Forms.Label();
            this.panelTableBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTable)).BeginInit();
            this.panelEndDateBackground.SuspendLayout();
            this.panelEndTimeBackground.SuspendLayout();
            this.panelStartTimeBackground.SuspendLayout();
            this.panelStartDateBackground.SuspendLayout();
            this.panelMachineNameBackground.SuspendLayout();
            this.panelExecutionIDBackground.SuspendLayout();
            this.panelTotalTestsAvailableBackground.SuspendLayout();
            this.panelTotalTestsRanBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelExecutedTestSetList
            // 
            this.labelExecutedTestSetList.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExecutedTestSetList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelExecutedTestSetList.Location = new System.Drawing.Point(33, 33);
            this.labelExecutedTestSetList.Name = "labelExecutedTestSetList";
            this.labelExecutedTestSetList.Size = new System.Drawing.Size(150, 29);
            this.labelExecutedTestSetList.TabIndex = 1;
            this.labelExecutedTestSetList.Text = "Execution ID List:";
            this.labelExecutedTestSetList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownExecutedID
            // 
            this.dropdownExecutedID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownExecutedID.FormattingEnabled = true;
            this.dropdownExecutedID.ItemHeight = 23;
            this.dropdownExecutedID.Location = new System.Drawing.Point(189, 33);
            this.dropdownExecutedID.Name = "dropdownExecutedID";
            this.dropdownExecutedID.Size = new System.Drawing.Size(438, 29);
            this.dropdownExecutedID.TabIndex = 3;
            this.dropdownExecutedID.UseSelectable = true;
            // 
            // buttonLoadTestSet
            // 
            this.buttonLoadTestSet.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLoadTestSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTestSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTestSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTestSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadTestSet.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadTestSet.ForeColor = System.Drawing.Color.White;
            this.buttonLoadTestSet.Location = new System.Drawing.Point(633, 33);
            this.buttonLoadTestSet.Name = "buttonLoadTestSet";
            this.buttonLoadTestSet.Size = new System.Drawing.Size(117, 29);
            this.buttonLoadTestSet.TabIndex = 12;
            this.buttonLoadTestSet.Text = "Load Test Set";
            this.buttonLoadTestSet.UseVisualStyleBackColor = false;
            this.buttonLoadTestSet.Click += new System.EventHandler(this.action_LoadSelectedExecutionDetails);
            // 
            // gaugePassedTests
            // 
            this.gaugePassedTests.Location = new System.Drawing.Point(33, 233);
            this.gaugePassedTests.Name = "gaugePassedTests";
            this.gaugePassedTests.Size = new System.Drawing.Size(150, 150);
            this.gaugePassedTests.TabIndex = 13;
            this.gaugePassedTests.Text = "solidGauge1";
            // 
            // chartExecutionTime
            // 
            this.chartExecutionTime.Location = new System.Drawing.Point(806, 163);
            this.chartExecutionTime.Name = "chartExecutionTime";
            this.chartExecutionTime.Size = new System.Drawing.Size(621, 220);
            this.chartExecutionTime.TabIndex = 14;
            this.chartExecutionTime.Text = "cartesianChart1";
            // 
            // gaugeFailedTests
            // 
            this.gaugeFailedTests.Location = new System.Drawing.Point(224, 233);
            this.gaugeFailedTests.Name = "gaugeFailedTests";
            this.gaugeFailedTests.Size = new System.Drawing.Size(150, 150);
            this.gaugeFailedTests.TabIndex = 15;
            this.gaugeFailedTests.Text = "solidGauge2";
            // 
            // gaugeTotalTests
            // 
            this.gaugeTotalTests.Location = new System.Drawing.Point(600, 233);
            this.gaugeTotalTests.Name = "gaugeTotalTests";
            this.gaugeTotalTests.Size = new System.Drawing.Size(150, 150);
            this.gaugeTotalTests.TabIndex = 16;
            this.gaugeTotalTests.Text = "solidGauge3";
            // 
            // labelPassedTests
            // 
            this.labelPassedTests.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassedTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPassedTests.Location = new System.Drawing.Point(33, 201);
            this.labelPassedTests.Name = "labelPassedTests";
            this.labelPassedTests.Size = new System.Drawing.Size(150, 29);
            this.labelPassedTests.TabIndex = 18;
            this.labelPassedTests.Text = "Tests Passed";
            this.labelPassedTests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFailedTests
            // 
            this.labelFailedTests.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFailedTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFailedTests.Location = new System.Drawing.Point(224, 201);
            this.labelFailedTests.Name = "labelFailedTests";
            this.labelFailedTests.Size = new System.Drawing.Size(150, 29);
            this.labelFailedTests.TabIndex = 19;
            this.labelFailedTests.Text = "Tests Failed";
            this.labelFailedTests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalTestsRan
            // 
            this.labelTotalTestsRan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTestsRan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTotalTestsRan.Location = new System.Drawing.Point(585, 201);
            this.labelTotalTestsRan.Name = "labelTotalTestsRan";
            this.labelTotalTestsRan.Size = new System.Drawing.Size(180, 29);
            this.labelTotalTestsRan.TabIndex = 20;
            this.labelTotalTestsRan.Text = "Tests Ran Vs Available";
            this.labelTotalTestsRan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTableBackground
            // 
            this.panelTableBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTableBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelTableBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTableBackground.Controls.Add(this.gridviewTable);
            this.panelTableBackground.Controls.Add(this.labelExecutedTestsList);
            this.panelTableBackground.Location = new System.Drawing.Point(33, 446);
            this.panelTableBackground.Name = "panelTableBackground";
            this.panelTableBackground.Padding = new System.Windows.Forms.Padding(5);
            this.panelTableBackground.Size = new System.Drawing.Size(1394, 326);
            this.panelTableBackground.TabIndex = 21;
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
            this.gridviewTable.MultiSelect = false;
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
            this.gridviewTable.Size = new System.Drawing.Size(1382, 282);
            this.gridviewTable.TabIndex = 22;
            // 
            // labelExecutedTestsList
            // 
            this.labelExecutedTestsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelExecutedTestsList.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExecutedTestsList.ForeColor = System.Drawing.Color.White;
            this.labelExecutedTestsList.Location = new System.Drawing.Point(5, 5);
            this.labelExecutedTestsList.Name = "labelExecutedTestsList";
            this.labelExecutedTestsList.Size = new System.Drawing.Size(1382, 29);
            this.labelExecutedTestsList.TabIndex = 18;
            this.labelExecutedTestsList.Text = "Test Set Execution Results";
            this.labelExecutedTestsList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelExecutionTimeOverview
            // 
            this.labelExecutionTimeOverview.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExecutionTimeOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelExecutionTimeOverview.Location = new System.Drawing.Point(806, 131);
            this.labelExecutionTimeOverview.Name = "labelExecutionTimeOverview";
            this.labelExecutionTimeOverview.Size = new System.Drawing.Size(621, 29);
            this.labelExecutionTimeOverview.TabIndex = 22;
            this.labelExecutionTimeOverview.Text = "Test Case Execution Time Overview";
            this.labelExecutionTimeOverview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSkippedTests
            // 
            this.labelSkippedTests.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkippedTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSkippedTests.Location = new System.Drawing.Point(415, 201);
            this.labelSkippedTests.Name = "labelSkippedTests";
            this.labelSkippedTests.Size = new System.Drawing.Size(150, 29);
            this.labelSkippedTests.TabIndex = 25;
            this.labelSkippedTests.Text = "Tests Skipped";
            this.labelSkippedTests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gaugeSkippedTests
            // 
            this.gaugeSkippedTests.Location = new System.Drawing.Point(415, 233);
            this.gaugeSkippedTests.Name = "gaugeSkippedTests";
            this.gaugeSkippedTests.Size = new System.Drawing.Size(150, 150);
            this.gaugeSkippedTests.TabIndex = 24;
            this.gaugeSkippedTests.Text = "solidGauge4";
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
            this.labelEndDateDescription.TabIndex = 27;
            this.labelEndDateDescription.Text = "End Date:";
            this.labelEndDateDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelEndDateBackground
            // 
            this.panelEndDateBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEndDateBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEndDateBackground.Controls.Add(this.labelEndDate);
            this.panelEndDateBackground.Controls.Add(this.labelEndDateDescription);
            this.panelEndDateBackground.Location = new System.Drawing.Point(1177, 33);
            this.panelEndDateBackground.Name = "panelEndDateBackground";
            this.panelEndDateBackground.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelEndDateBackground.Size = new System.Drawing.Size(250, 32);
            this.panelEndDateBackground.TabIndex = 28;
            // 
            // labelEndDate
            // 
            this.labelEndDate.BackColor = System.Drawing.Color.White;
            this.labelEndDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEndDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEndDate.Location = new System.Drawing.Point(99, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(149, 30);
            this.labelEndDate.TabIndex = 28;
            this.labelEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEndTimeBackground
            // 
            this.panelEndTimeBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEndTimeBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEndTimeBackground.Controls.Add(this.labelEndTime);
            this.panelEndTimeBackground.Controls.Add(this.labelEndTimeDescription);
            this.panelEndTimeBackground.Location = new System.Drawing.Point(1177, 71);
            this.panelEndTimeBackground.Name = "panelEndTimeBackground";
            this.panelEndTimeBackground.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelEndTimeBackground.Size = new System.Drawing.Size(250, 32);
            this.panelEndTimeBackground.TabIndex = 29;
            // 
            // labelEndTime
            // 
            this.labelEndTime.BackColor = System.Drawing.Color.White;
            this.labelEndTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelEndTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEndTime.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEndTime.Location = new System.Drawing.Point(102, 0);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(146, 30);
            this.labelEndTime.TabIndex = 28;
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
            this.labelEndTimeDescription.TabIndex = 27;
            this.labelEndTimeDescription.Text = "End Time:";
            this.labelEndTimeDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStartTimeBackground
            // 
            this.panelStartTimeBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelStartTimeBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStartTimeBackground.Controls.Add(this.labelStartTime);
            this.panelStartTimeBackground.Controls.Add(this.labelStartTimeDescription);
            this.panelStartTimeBackground.Location = new System.Drawing.Point(806, 71);
            this.panelStartTimeBackground.Name = "panelStartTimeBackground";
            this.panelStartTimeBackground.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelStartTimeBackground.Size = new System.Drawing.Size(250, 32);
            this.panelStartTimeBackground.TabIndex = 31;
            // 
            // labelStartTime
            // 
            this.labelStartTime.BackColor = System.Drawing.Color.White;
            this.labelStartTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStartTime.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStartTime.Location = new System.Drawing.Point(99, 0);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(149, 30);
            this.labelStartTime.TabIndex = 28;
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
            this.labelStartTimeDescription.TabIndex = 27;
            this.labelStartTimeDescription.Text = "Start Time:";
            this.labelStartTimeDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStartDateBackground
            // 
            this.panelStartDateBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelStartDateBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStartDateBackground.Controls.Add(this.labelStartDate);
            this.panelStartDateBackground.Controls.Add(this.labelStartDateDescription);
            this.panelStartDateBackground.Location = new System.Drawing.Point(806, 33);
            this.panelStartDateBackground.Name = "panelStartDateBackground";
            this.panelStartDateBackground.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelStartDateBackground.Size = new System.Drawing.Size(250, 32);
            this.panelStartDateBackground.TabIndex = 30;
            // 
            // labelStartDate
            // 
            this.labelStartDate.BackColor = System.Drawing.Color.White;
            this.labelStartDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStartDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStartDate.Location = new System.Drawing.Point(99, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(149, 30);
            this.labelStartDate.TabIndex = 28;
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
            this.labelStartDateDescription.TabIndex = 27;
            this.labelStartDateDescription.Text = "Start Date:";
            this.labelStartDateDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonLoadTestCaseDetails
            // 
            this.buttonLoadTestCaseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadTestCaseDetails.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLoadTestCaseDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTestCaseDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTestCaseDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTestCaseDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadTestCaseDetails.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadTestCaseDetails.ForeColor = System.Drawing.Color.White;
            this.buttonLoadTestCaseDetails.Location = new System.Drawing.Point(1192, 411);
            this.buttonLoadTestCaseDetails.Name = "buttonLoadTestCaseDetails";
            this.buttonLoadTestCaseDetails.Size = new System.Drawing.Size(235, 29);
            this.buttonLoadTestCaseDetails.TabIndex = 32;
            this.buttonLoadTestCaseDetails.Text = "Load Selected Test Case Details";
            this.buttonLoadTestCaseDetails.UseVisualStyleBackColor = false;
            this.buttonLoadTestCaseDetails.Click += new System.EventHandler(this.action_LoadDetailedReport);
            // 
            // panelMachineNameBackground
            // 
            this.panelMachineNameBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMachineNameBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMachineNameBackground.Controls.Add(this.labelMachineName);
            this.panelMachineNameBackground.Controls.Add(this.labelMachineNameDescription);
            this.panelMachineNameBackground.Location = new System.Drawing.Point(33, 132);
            this.panelMachineNameBackground.Name = "panelMachineNameBackground";
            this.panelMachineNameBackground.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelMachineNameBackground.Size = new System.Drawing.Size(390, 32);
            this.panelMachineNameBackground.TabIndex = 33;
            // 
            // labelMachineName
            // 
            this.labelMachineName.BackColor = System.Drawing.Color.White;
            this.labelMachineName.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelMachineName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMachineName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMachineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMachineName.Location = new System.Drawing.Point(133, 0);
            this.labelMachineName.Name = "labelMachineName";
            this.labelMachineName.Size = new System.Drawing.Size(255, 30);
            this.labelMachineName.TabIndex = 28;
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
            this.labelMachineNameDescription.TabIndex = 27;
            this.labelMachineNameDescription.Text = "Machine Name:";
            this.labelMachineNameDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelExecutionIDBackground
            // 
            this.panelExecutionIDBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelExecutionIDBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExecutionIDBackground.Controls.Add(this.labelExecutionID);
            this.panelExecutionIDBackground.Controls.Add(this.labelExecutionIDDescription);
            this.panelExecutionIDBackground.Location = new System.Drawing.Point(33, 94);
            this.panelExecutionIDBackground.Name = "panelExecutionIDBackground";
            this.panelExecutionIDBackground.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelExecutionIDBackground.Size = new System.Drawing.Size(389, 32);
            this.panelExecutionIDBackground.TabIndex = 32;
            // 
            // labelExecutionID
            // 
            this.labelExecutionID.BackColor = System.Drawing.Color.White;
            this.labelExecutionID.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelExecutionID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExecutionID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExecutionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelExecutionID.Location = new System.Drawing.Point(133, 0);
            this.labelExecutionID.Name = "labelExecutionID";
            this.labelExecutionID.Size = new System.Drawing.Size(254, 30);
            this.labelExecutionID.TabIndex = 28;
            this.labelExecutionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelExecutionIDDescription
            // 
            this.labelExecutionIDDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelExecutionIDDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExecutionIDDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExecutionIDDescription.ForeColor = System.Drawing.Color.White;
            this.labelExecutionIDDescription.Location = new System.Drawing.Point(5, 0);
            this.labelExecutionIDDescription.Name = "labelExecutionIDDescription";
            this.labelExecutionIDDescription.Size = new System.Drawing.Size(122, 30);
            this.labelExecutionIDDescription.TabIndex = 27;
            this.labelExecutionIDDescription.Text = "Execution ID:";
            this.labelExecutionIDDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTotalTestsAvailableBackground
            // 
            this.panelTotalTestsAvailableBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTotalTestsAvailableBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalTestsAvailableBackground.Controls.Add(this.labelTotalTestsAvailableCount);
            this.panelTotalTestsAvailableBackground.Controls.Add(this.labelTotalTestsAvailableDescription);
            this.panelTotalTestsAvailableBackground.Location = new System.Drawing.Point(451, 132);
            this.panelTotalTestsAvailableBackground.Name = "panelTotalTestsAvailableBackground";
            this.panelTotalTestsAvailableBackground.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelTotalTestsAvailableBackground.Size = new System.Drawing.Size(299, 32);
            this.panelTotalTestsAvailableBackground.TabIndex = 33;
            // 
            // labelTotalTestsAvailableCount
            // 
            this.labelTotalTestsAvailableCount.BackColor = System.Drawing.Color.White;
            this.labelTotalTestsAvailableCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTotalTestsAvailableCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalTestsAvailableCount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTestsAvailableCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTotalTestsAvailableCount.Location = new System.Drawing.Point(181, 0);
            this.labelTotalTestsAvailableCount.Name = "labelTotalTestsAvailableCount";
            this.labelTotalTestsAvailableCount.Size = new System.Drawing.Size(116, 30);
            this.labelTotalTestsAvailableCount.TabIndex = 28;
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
            this.labelTotalTestsAvailableDescription.TabIndex = 27;
            this.labelTotalTestsAvailableDescription.Text = "Total Tests Available:";
            this.labelTotalTestsAvailableDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTotalTestsRanBackground
            // 
            this.panelTotalTestsRanBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTotalTestsRanBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalTestsRanBackground.Controls.Add(this.labelTotalTestsRanCount);
            this.panelTotalTestsRanBackground.Controls.Add(this.labelTotalTestsRanDescription);
            this.panelTotalTestsRanBackground.Location = new System.Drawing.Point(451, 94);
            this.panelTotalTestsRanBackground.Name = "panelTotalTestsRanBackground";
            this.panelTotalTestsRanBackground.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelTotalTestsRanBackground.Size = new System.Drawing.Size(299, 32);
            this.panelTotalTestsRanBackground.TabIndex = 32;
            // 
            // labelTotalTestsRanCount
            // 
            this.labelTotalTestsRanCount.BackColor = System.Drawing.Color.White;
            this.labelTotalTestsRanCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTotalTestsRanCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalTestsRanCount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTestsRanCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTotalTestsRanCount.Location = new System.Drawing.Point(181, 0);
            this.labelTotalTestsRanCount.Name = "labelTotalTestsRanCount";
            this.labelTotalTestsRanCount.Size = new System.Drawing.Size(116, 30);
            this.labelTotalTestsRanCount.TabIndex = 28;
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
            this.labelTotalTestsRanDescription.TabIndex = 27;
            this.labelTotalTestsRanDescription.Text = "Total Tests Ran:";
            this.labelTotalTestsRanDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelTotalTestsAvailableBackground);
            this.Controls.Add(this.panelMachineNameBackground);
            this.Controls.Add(this.panelTotalTestsRanBackground);
            this.Controls.Add(this.buttonLoadTestCaseDetails);
            this.Controls.Add(this.panelExecutionIDBackground);
            this.Controls.Add(this.panelStartTimeBackground);
            this.Controls.Add(this.panelEndTimeBackground);
            this.Controls.Add(this.panelStartDateBackground);
            this.Controls.Add(this.panelEndDateBackground);
            this.Controls.Add(this.labelSkippedTests);
            this.Controls.Add(this.gaugeSkippedTests);
            this.Controls.Add(this.labelExecutionTimeOverview);
            this.Controls.Add(this.panelTableBackground);
            this.Controls.Add(this.labelTotalTestsRan);
            this.Controls.Add(this.labelFailedTests);
            this.Controls.Add(this.labelPassedTests);
            this.Controls.Add(this.gaugeTotalTests);
            this.Controls.Add(this.gaugeFailedTests);
            this.Controls.Add(this.chartExecutionTime);
            this.Controls.Add(this.gaugePassedTests);
            this.Controls.Add(this.buttonLoadTestSet);
            this.Controls.Add(this.dropdownExecutedID);
            this.Controls.Add(this.labelExecutedTestSetList);
            this.Name = "ControlDashboard";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(1460, 805);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.panelTableBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTable)).EndInit();
            this.panelEndDateBackground.ResumeLayout(false);
            this.panelEndTimeBackground.ResumeLayout(false);
            this.panelStartTimeBackground.ResumeLayout(false);
            this.panelStartDateBackground.ResumeLayout(false);
            this.panelMachineNameBackground.ResumeLayout(false);
            this.panelExecutionIDBackground.ResumeLayout(false);
            this.panelTotalTestsAvailableBackground.ResumeLayout(false);
            this.panelTotalTestsRanBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelExecutedTestSetList;
        private MetroFramework.Controls.MetroComboBox dropdownExecutedID;
        private System.Windows.Forms.Button buttonLoadTestSet;
        private LiveCharts.WinForms.SolidGauge gaugePassedTests;
        private LiveCharts.WinForms.CartesianChart chartExecutionTime;
        private LiveCharts.WinForms.SolidGauge gaugeFailedTests;
        private LiveCharts.WinForms.SolidGauge gaugeTotalTests;
        private System.Windows.Forms.Label labelPassedTests;
        private System.Windows.Forms.Label labelFailedTests;
        private System.Windows.Forms.Label labelTotalTestsRan;
        private System.Windows.Forms.Panel panelTableBackground;
        private System.Windows.Forms.Label labelExecutedTestsList;
        private System.Windows.Forms.Label labelExecutionTimeOverview;
        private System.Windows.Forms.Label labelSkippedTests;
        private LiveCharts.WinForms.SolidGauge gaugeSkippedTests;
        private System.Windows.Forms.Label labelEndDateDescription;
        private System.Windows.Forms.Panel panelEndDateBackground;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Panel panelEndTimeBackground;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.Label labelEndTimeDescription;
        private System.Windows.Forms.Panel panelStartTimeBackground;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelStartTimeDescription;
        private System.Windows.Forms.Panel panelStartDateBackground;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelStartDateDescription;
        private System.Windows.Forms.Button buttonLoadTestCaseDetails;
        private System.Windows.Forms.Panel panelMachineNameBackground;
        private System.Windows.Forms.Label labelMachineName;
        private System.Windows.Forms.Label labelMachineNameDescription;
        private System.Windows.Forms.Panel panelExecutionIDBackground;
        private System.Windows.Forms.Label labelExecutionID;
        private System.Windows.Forms.Label labelExecutionIDDescription;
        private MetroFramework.Controls.MetroGrid gridviewTable;
        private System.Windows.Forms.Panel panelTotalTestsAvailableBackground;
        private System.Windows.Forms.Label labelTotalTestsAvailableCount;
        private System.Windows.Forms.Label labelTotalTestsAvailableDescription;
        private System.Windows.Forms.Panel panelTotalTestsRanBackground;
        private System.Windows.Forms.Label labelTotalTestsRanCount;
        private System.Windows.Forms.Label labelTotalTestsRanDescription;
    }
}
