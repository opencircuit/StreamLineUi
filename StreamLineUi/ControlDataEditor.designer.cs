namespace StreamLineUi
{
    partial class ControlDataEditor
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
            this.panelTableBackground = new System.Windows.Forms.Panel();
            this.gridviewTable = new MetroFramework.Controls.MetroGrid();
            this.labelTableName = new System.Windows.Forms.Label();
            this.buttonLoadTable = new System.Windows.Forms.Button();
            this.dropdownTableList = new MetroFramework.Controls.MetroComboBox();
            this.labelTableList = new System.Windows.Forms.Label();
            this.buttonCreateTable = new System.Windows.Forms.Button();
            this.buttonAddColumn = new System.Windows.Forms.Button();
            this.textboxColumnName = new System.Windows.Forms.TextBox();
            this.labelColumnName = new System.Windows.Forms.Label();
            this.buttonDeleteColumn = new System.Windows.Forms.Button();
            this.buttonSaveTable = new System.Windows.Forms.Button();
            this.buttonDeleteTable = new System.Windows.Forms.Button();
            this.buttonEditTable = new System.Windows.Forms.Button();
            this.labelTableDescription = new System.Windows.Forms.Label();
            this.labelColumnDescription = new System.Windows.Forms.Label();
            this.buttonDeleteTestCase = new System.Windows.Forms.Button();
            this.panelTableBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTableBackground
            // 
            this.panelTableBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelTableBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTableBackground.Controls.Add(this.gridviewTable);
            this.panelTableBackground.Controls.Add(this.labelTableName);
            this.panelTableBackground.Location = new System.Drawing.Point(33, 135);
            this.panelTableBackground.Name = "panelTableBackground";
            this.panelTableBackground.Padding = new System.Windows.Forms.Padding(5);
            this.panelTableBackground.Size = new System.Drawing.Size(1391, 632);
            this.panelTableBackground.TabIndex = 1;
            // 
            // gridviewTable
            // 
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
            this.gridviewTable.Size = new System.Drawing.Size(1379, 588);
            this.gridviewTable.TabIndex = 20;
            // 
            // labelTableName
            // 
            this.labelTableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTableName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableName.ForeColor = System.Drawing.Color.White;
            this.labelTableName.Location = new System.Drawing.Point(5, 5);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(1379, 29);
            this.labelTableName.TabIndex = 19;
            this.labelTableName.Text = "Table:";
            this.labelTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonLoadTable.Location = new System.Drawing.Point(367, 30);
            this.buttonLoadTable.Name = "buttonLoadTable";
            this.buttonLoadTable.Size = new System.Drawing.Size(200, 29);
            this.buttonLoadTable.TabIndex = 15;
            this.buttonLoadTable.Text = "Load Table";
            this.buttonLoadTable.UseVisualStyleBackColor = false;
            this.buttonLoadTable.Click += new System.EventHandler(this.action_LoadTable);
            // 
            // dropdownTableList
            // 
            this.dropdownTableList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownTableList.FormattingEnabled = true;
            this.dropdownTableList.ItemHeight = 23;
            this.dropdownTableList.Location = new System.Drawing.Point(141, 30);
            this.dropdownTableList.Name = "dropdownTableList";
            this.dropdownTableList.Size = new System.Drawing.Size(220, 29);
            this.dropdownTableList.TabIndex = 14;
            this.dropdownTableList.UseSelectable = true;
            // 
            // labelTableList
            // 
            this.labelTableList.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTableList.Location = new System.Drawing.Point(30, 30);
            this.labelTableList.Name = "labelTableList";
            this.labelTableList.Size = new System.Drawing.Size(105, 29);
            this.labelTableList.TabIndex = 13;
            this.labelTableList.Text = "Tables List:";
            this.labelTableList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCreateTable
            // 
            this.buttonCreateTable.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCreateTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTable.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTable.ForeColor = System.Drawing.Color.White;
            this.buttonCreateTable.Location = new System.Drawing.Point(367, 65);
            this.buttonCreateTable.Name = "buttonCreateTable";
            this.buttonCreateTable.Size = new System.Drawing.Size(200, 29);
            this.buttonCreateTable.TabIndex = 18;
            this.buttonCreateTable.Text = "Create Table";
            this.buttonCreateTable.UseVisualStyleBackColor = false;
            this.buttonCreateTable.Click += new System.EventHandler(this.action_CreateTable);
            // 
            // buttonAddColumn
            // 
            this.buttonAddColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddColumn.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAddColumn.Enabled = false;
            this.buttonAddColumn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddColumn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddColumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddColumn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddColumn.ForeColor = System.Drawing.Color.White;
            this.buttonAddColumn.Location = new System.Drawing.Point(1224, 30);
            this.buttonAddColumn.Name = "buttonAddColumn";
            this.buttonAddColumn.Size = new System.Drawing.Size(200, 29);
            this.buttonAddColumn.TabIndex = 21;
            this.buttonAddColumn.Text = "Add Column";
            this.buttonAddColumn.UseVisualStyleBackColor = false;
            this.buttonAddColumn.Click += new System.EventHandler(this.action_AddColumn);
            // 
            // textboxColumnName
            // 
            this.textboxColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxColumnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxColumnName.Enabled = false;
            this.textboxColumnName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxColumnName.Location = new System.Drawing.Point(998, 31);
            this.textboxColumnName.Name = "textboxColumnName";
            this.textboxColumnName.Size = new System.Drawing.Size(220, 26);
            this.textboxColumnName.TabIndex = 20;
            // 
            // labelColumnName
            // 
            this.labelColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelColumnName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumnName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelColumnName.Location = new System.Drawing.Point(887, 32);
            this.labelColumnName.Name = "labelColumnName";
            this.labelColumnName.Size = new System.Drawing.Size(105, 23);
            this.labelColumnName.TabIndex = 19;
            this.labelColumnName.Text = "Column Name:";
            this.labelColumnName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDeleteColumn
            // 
            this.buttonDeleteColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteColumn.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDeleteColumn.Enabled = false;
            this.buttonDeleteColumn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteColumn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteColumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteColumn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteColumn.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteColumn.Location = new System.Drawing.Point(1224, 65);
            this.buttonDeleteColumn.Name = "buttonDeleteColumn";
            this.buttonDeleteColumn.Size = new System.Drawing.Size(200, 29);
            this.buttonDeleteColumn.TabIndex = 26;
            this.buttonDeleteColumn.Text = "Delete Column";
            this.buttonDeleteColumn.UseVisualStyleBackColor = false;
            this.buttonDeleteColumn.Click += new System.EventHandler(this.action_DeleteColumn);
            // 
            // buttonSaveTable
            // 
            this.buttonSaveTable.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSaveTable.Enabled = false;
            this.buttonSaveTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveTable.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveTable.ForeColor = System.Drawing.Color.White;
            this.buttonSaveTable.Location = new System.Drawing.Point(573, 64);
            this.buttonSaveTable.Name = "buttonSaveTable";
            this.buttonSaveTable.Size = new System.Drawing.Size(200, 29);
            this.buttonSaveTable.TabIndex = 33;
            this.buttonSaveTable.Text = "Save Table";
            this.buttonSaveTable.UseVisualStyleBackColor = false;
            this.buttonSaveTable.Click += new System.EventHandler(this.action_SaveTable);
            // 
            // buttonDeleteTable
            // 
            this.buttonDeleteTable.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDeleteTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTable.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTable.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteTable.Location = new System.Drawing.Point(367, 100);
            this.buttonDeleteTable.Name = "buttonDeleteTable";
            this.buttonDeleteTable.Size = new System.Drawing.Size(200, 29);
            this.buttonDeleteTable.TabIndex = 25;
            this.buttonDeleteTable.Text = "Delete Table";
            this.buttonDeleteTable.UseVisualStyleBackColor = false;
            this.buttonDeleteTable.Click += new System.EventHandler(this.action_DeleteTable);
            // 
            // buttonEditTable
            // 
            this.buttonEditTable.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEditTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEditTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEditTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEditTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditTable.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTable.ForeColor = System.Drawing.Color.White;
            this.buttonEditTable.Location = new System.Drawing.Point(573, 29);
            this.buttonEditTable.Name = "buttonEditTable";
            this.buttonEditTable.Size = new System.Drawing.Size(200, 29);
            this.buttonEditTable.TabIndex = 34;
            this.buttonEditTable.Text = "Edit Table";
            this.buttonEditTable.UseVisualStyleBackColor = false;
            this.buttonEditTable.Click += new System.EventHandler(this.action_EditTable);
            // 
            // labelTableDescription
            // 
            this.labelTableDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableDescription.ForeColor = System.Drawing.Color.Red;
            this.labelTableDescription.Location = new System.Drawing.Point(30, 72);
            this.labelTableDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelTableDescription.Name = "labelTableDescription";
            this.labelTableDescription.Size = new System.Drawing.Size(331, 57);
            this.labelTableDescription.TabIndex = 35;
            this.labelTableDescription.Text = "When adding tables remember to not make the table name too long. It also must not" +
    " contain numbers, special characters or spaces.";
            // 
            // labelColumnDescription
            // 
            this.labelColumnDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumnDescription.ForeColor = System.Drawing.Color.Red;
            this.labelColumnDescription.Location = new System.Drawing.Point(887, 70);
            this.labelColumnDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelColumnDescription.Name = "labelColumnDescription";
            this.labelColumnDescription.Size = new System.Drawing.Size(331, 58);
            this.labelColumnDescription.TabIndex = 36;
            this.labelColumnDescription.Text = "When adding columns remember that they must not contain numbers, special characte" +
    "rs or spaces. All Column types are VarChar (255).";
            // 
            // buttonDeleteTestCase
            // 
            this.buttonDeleteTestCase.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDeleteTestCase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteTestCase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTestCase.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTestCase.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteTestCase.Location = new System.Drawing.Point(573, 99);
            this.buttonDeleteTestCase.Name = "buttonDeleteTestCase";
            this.buttonDeleteTestCase.Size = new System.Drawing.Size(200, 29);
            this.buttonDeleteTestCase.TabIndex = 37;
            this.buttonDeleteTestCase.Text = "Delete Selected Test Case(s)";
            this.buttonDeleteTestCase.UseVisualStyleBackColor = false;
            this.buttonDeleteTestCase.Click += new System.EventHandler(this.action_DeleteTestCase);
            // 
            // ControlDataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonDeleteTestCase);
            this.Controls.Add(this.labelColumnDescription);
            this.Controls.Add(this.labelTableDescription);
            this.Controls.Add(this.buttonEditTable);
            this.Controls.Add(this.buttonSaveTable);
            this.Controls.Add(this.buttonDeleteTable);
            this.Controls.Add(this.buttonDeleteColumn);
            this.Controls.Add(this.buttonAddColumn);
            this.Controls.Add(this.textboxColumnName);
            this.Controls.Add(this.labelColumnName);
            this.Controls.Add(this.buttonCreateTable);
            this.Controls.Add(this.buttonLoadTable);
            this.Controls.Add(this.panelTableBackground);
            this.Controls.Add(this.labelTableList);
            this.Controls.Add(this.dropdownTableList);
            this.Name = "ControlDataEditor";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(1460, 805);
            this.Load += new System.EventHandler(this.action_FormLoad);
            this.panelTableBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTableBackground;
        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.Button buttonLoadTable;
        private MetroFramework.Controls.MetroComboBox dropdownTableList;
        private System.Windows.Forms.Label labelTableList;
        private System.Windows.Forms.Button buttonCreateTable;
        private System.Windows.Forms.Button buttonAddColumn;
        private System.Windows.Forms.TextBox textboxColumnName;
        private System.Windows.Forms.Label labelColumnName;
        private System.Windows.Forms.Button buttonDeleteColumn;
        private System.Windows.Forms.Button buttonSaveTable;
        private System.Windows.Forms.Button buttonDeleteTable;
        private System.Windows.Forms.Button buttonEditTable;
        private System.Windows.Forms.Label labelTableDescription;
        private System.Windows.Forms.Label labelColumnDescription;
        private MetroFramework.Controls.MetroGrid gridviewTable;
        private System.Windows.Forms.Button buttonDeleteTestCase;
    }
}
