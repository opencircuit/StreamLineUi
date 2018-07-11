namespace StreamLineUi
{
    partial class ControlDatabaseEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlDatabaseEditor));
            this.panelTableBackground = new System.Windows.Forms.Panel();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.labelSchema = new System.Windows.Forms.Label();
            this.buttonReloadSchema = new System.Windows.Forms.Button();
            this.labelTableList = new System.Windows.Forms.Label();
            this.dropdownTableList = new MetroFramework.Controls.MetroComboBox();
            this.buttonCreateTable = new System.Windows.Forms.Button();
            this.buttonDropTable = new System.Windows.Forms.Button();
            this.buttonAddColumn = new System.Windows.Forms.Button();
            this.buttonDeleteColumn = new System.Windows.Forms.Button();
            this.textboxDefaultValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelDefaultValue = new System.Windows.Forms.Label();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.textboxColumnName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelColumnName = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.panelTableBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTableBackground
            // 
            this.panelTableBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTableBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelTableBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTableBackground.Controls.Add(this.gridview);
            this.panelTableBackground.Controls.Add(this.labelSchema);
            this.panelTableBackground.Location = new System.Drawing.Point(33, 23);
            this.panelTableBackground.Name = "panelTableBackground";
            this.panelTableBackground.Padding = new System.Windows.Forms.Padding(3);
            this.panelTableBackground.Size = new System.Drawing.Size(600, 704);
            this.panelTableBackground.TabIndex = 0;
            // 
            // gridviewSchema
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToDeleteRows = false;
            this.gridview.AllowUserToResizeColumns = false;
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
            this.gridview.MultiSelect = false;
            this.gridview.Name = "gridviewSchema";
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
            this.gridview.Size = new System.Drawing.Size(592, 667);
            this.gridview.TabIndex = 0;
            // 
            // labelSchema
            // 
            this.labelSchema.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSchema.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchema.ForeColor = System.Drawing.Color.White;
            this.labelSchema.Location = new System.Drawing.Point(3, 3);
            this.labelSchema.Name = "labelSchema";
            this.labelSchema.Size = new System.Drawing.Size(592, 29);
            this.labelSchema.TabIndex = 0;
            this.labelSchema.Text = "Database Schema";
            this.labelSchema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReloadSchema
            // 
            this.buttonReloadSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReloadSchema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonReloadSchema.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReloadSchema.FlatAppearance.BorderSize = 2;
            this.buttonReloadSchema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReloadSchema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReloadSchema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReloadSchema.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReloadSchema.ForeColor = System.Drawing.Color.White;
            this.buttonReloadSchema.Location = new System.Drawing.Point(33, 733);
            this.buttonReloadSchema.Name = "buttonReloadSchema";
            this.buttonReloadSchema.Size = new System.Drawing.Size(600, 29);
            this.buttonReloadSchema.TabIndex = 10;
            this.buttonReloadSchema.Text = "Reload Database Schema";
            this.buttonReloadSchema.UseVisualStyleBackColor = false;
            this.buttonReloadSchema.Click += new System.EventHandler(this.action_ReloadDatabaseSchema);
            // 
            // labelTableList
            // 
            this.labelTableList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTableList.Location = new System.Drawing.Point(675, 56);
            this.labelTableList.Margin = new System.Windows.Forms.Padding(0);
            this.labelTableList.Name = "labelTableList";
            this.labelTableList.Size = new System.Drawing.Size(117, 29);
            this.labelTableList.TabIndex = 0;
            this.labelTableList.Text = "Table List:";
            this.labelTableList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownTableList
            // 
            this.dropdownTableList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownTableList.FormattingEnabled = true;
            this.dropdownTableList.ItemHeight = 23;
            this.dropdownTableList.Location = new System.Drawing.Point(795, 56);
            this.dropdownTableList.Name = "dropdownTableList";
            this.dropdownTableList.Size = new System.Drawing.Size(248, 29);
            this.dropdownTableList.TabIndex = 1;
            this.dropdownTableList.UseSelectable = true;
            // 
            // buttonCreateTable
            // 
            this.buttonCreateTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonCreateTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateTable.FlatAppearance.BorderSize = 2;
            this.buttonCreateTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreateTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTable.ForeColor = System.Drawing.Color.White;
            this.buttonCreateTable.Location = new System.Drawing.Point(1066, 56);
            this.buttonCreateTable.Name = "buttonCreateTable";
            this.buttonCreateTable.Size = new System.Drawing.Size(170, 29);
            this.buttonCreateTable.TabIndex = 2;
            this.buttonCreateTable.Text = "Create Table";
            this.buttonCreateTable.UseVisualStyleBackColor = false;
            this.buttonCreateTable.Click += new System.EventHandler(this.action_CreateOrDropTable);
            // 
            // buttonDropTable
            // 
            this.buttonDropTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDropTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDropTable.FlatAppearance.BorderSize = 2;
            this.buttonDropTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDropTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDropTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDropTable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDropTable.ForeColor = System.Drawing.Color.White;
            this.buttonDropTable.Location = new System.Drawing.Point(1242, 56);
            this.buttonDropTable.Name = "buttonDropTable";
            this.buttonDropTable.Size = new System.Drawing.Size(170, 29);
            this.buttonDropTable.TabIndex = 3;
            this.buttonDropTable.Text = "Drop Table";
            this.buttonDropTable.UseVisualStyleBackColor = false;
            this.buttonDropTable.Click += new System.EventHandler(this.action_CreateOrDropTable);
            // 
            // buttonAddColumn
            // 
            this.buttonAddColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonAddColumn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddColumn.FlatAppearance.BorderSize = 2;
            this.buttonAddColumn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddColumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddColumn.ForeColor = System.Drawing.Color.White;
            this.buttonAddColumn.Location = new System.Drawing.Point(1066, 101);
            this.buttonAddColumn.Name = "buttonAddColumn";
            this.buttonAddColumn.Size = new System.Drawing.Size(170, 29);
            this.buttonAddColumn.TabIndex = 5;
            this.buttonAddColumn.Text = "Add Column";
            this.buttonAddColumn.UseVisualStyleBackColor = false;
            this.buttonAddColumn.Click += new System.EventHandler(this.action_AddOrDeleteColumn);
            // 
            // buttonDeleteColumn
            // 
            this.buttonDeleteColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDeleteColumn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteColumn.FlatAppearance.BorderSize = 2;
            this.buttonDeleteColumn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteColumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteColumn.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteColumn.Location = new System.Drawing.Point(1242, 101);
            this.buttonDeleteColumn.Name = "buttonDeleteColumn";
            this.buttonDeleteColumn.Size = new System.Drawing.Size(170, 29);
            this.buttonDeleteColumn.TabIndex = 6;
            this.buttonDeleteColumn.Text = "Delete Column";
            this.buttonDeleteColumn.UseVisualStyleBackColor = false;
            this.buttonDeleteColumn.Click += new System.EventHandler(this.action_AddOrDeleteColumn);
            // 
            // textboxDefaultValue
            // 
            this.textboxDefaultValue.Depth = 0;
            this.textboxDefaultValue.Hint = "";
            this.textboxDefaultValue.Location = new System.Drawing.Point(795, 107);
            this.textboxDefaultValue.MaxLength = 32767;
            this.textboxDefaultValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxDefaultValue.Name = "textboxDefaultValue";
            this.textboxDefaultValue.PasswordChar = '\0';
            this.textboxDefaultValue.SelectedText = "";
            this.textboxDefaultValue.SelectionLength = 0;
            this.textboxDefaultValue.SelectionStart = 0;
            this.textboxDefaultValue.Size = new System.Drawing.Size(248, 23);
            this.textboxDefaultValue.TabIndex = 4;
            this.textboxDefaultValue.TabStop = false;
            this.textboxDefaultValue.UseSystemPasswordChar = false;
            // 
            // labelDefaultValue
            // 
            this.labelDefaultValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefaultValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDefaultValue.Location = new System.Drawing.Point(675, 105);
            this.labelDefaultValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelDefaultValue.Name = "labelDefaultValue";
            this.labelDefaultValue.Size = new System.Drawing.Size(117, 26);
            this.labelDefaultValue.TabIndex = 0;
            this.labelDefaultValue.Text = "Default Value:";
            this.labelDefaultValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonApplyFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApplyFilter.FlatAppearance.BorderSize = 2;
            this.buttonApplyFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApplyFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplyFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyFilter.ForeColor = System.Drawing.Color.White;
            this.buttonApplyFilter.Location = new System.Drawing.Point(1066, 543);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(170, 29);
            this.buttonApplyFilter.TabIndex = 8;
            this.buttonApplyFilter.Text = "Apply Filter";
            this.buttonApplyFilter.UseVisualStyleBackColor = false;
            this.buttonApplyFilter.Click += new System.EventHandler(this.action_ApplyFilter);
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonClearFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClearFilter.FlatAppearance.BorderSize = 2;
            this.buttonClearFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClearFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFilter.ForeColor = System.Drawing.Color.White;
            this.buttonClearFilter.Location = new System.Drawing.Point(1242, 543);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(170, 29);
            this.buttonClearFilter.TabIndex = 9;
            this.buttonClearFilter.Text = "Clear Filter";
            this.buttonClearFilter.UseVisualStyleBackColor = false;
            this.buttonClearFilter.Click += new System.EventHandler(this.action_ReloadDatabaseSchema);
            // 
            // textboxColumnName
            // 
            this.textboxColumnName.Depth = 0;
            this.textboxColumnName.Hint = "";
            this.textboxColumnName.Location = new System.Drawing.Point(795, 549);
            this.textboxColumnName.MaxLength = 32767;
            this.textboxColumnName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxColumnName.Name = "textboxColumnName";
            this.textboxColumnName.PasswordChar = '\0';
            this.textboxColumnName.SelectedText = "";
            this.textboxColumnName.SelectionLength = 0;
            this.textboxColumnName.SelectionStart = 0;
            this.textboxColumnName.Size = new System.Drawing.Size(248, 23);
            this.textboxColumnName.TabIndex = 7;
            this.textboxColumnName.TabStop = false;
            this.textboxColumnName.UseSystemPasswordChar = false;
            // 
            // labelColumnName
            // 
            this.labelColumnName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumnName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelColumnName.Location = new System.Drawing.Point(675, 547);
            this.labelColumnName.Margin = new System.Windows.Forms.Padding(0);
            this.labelColumnName.Name = "labelColumnName";
            this.labelColumnName.Size = new System.Drawing.Size(117, 26);
            this.labelColumnName.TabIndex = 0;
            this.labelColumnName.Text = "Column Name:";
            this.labelColumnName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNote
            // 
            this.labelNote.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.ForeColor = System.Drawing.Color.Gray;
            this.labelNote.Location = new System.Drawing.Point(675, 233);
            this.labelNote.Margin = new System.Windows.Forms.Padding(0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(737, 169);
            this.labelNote.TabIndex = 0;
            this.labelNote.Text = resources.GetString("labelNote.Text");
            // 
            // labelWarning
            // 
            this.labelWarning.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.ForeColor = System.Drawing.Color.Tomato;
            this.labelWarning.Location = new System.Drawing.Point(675, 402);
            this.labelWarning.Margin = new System.Windows.Forms.Padding(0);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(737, 38);
            this.labelWarning.TabIndex = 0;
            this.labelWarning.Text = resources.GetString("labelWarning.Text");
            // 
            // ControlDatabaseEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.textboxColumnName);
            this.Controls.Add(this.labelColumnName);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.buttonApplyFilter);
            this.Controls.Add(this.textboxDefaultValue);
            this.Controls.Add(this.labelDefaultValue);
            this.Controls.Add(this.buttonDeleteColumn);
            this.Controls.Add(this.buttonAddColumn);
            this.Controls.Add(this.buttonDropTable);
            this.Controls.Add(this.buttonCreateTable);
            this.Controls.Add(this.labelTableList);
            this.Controls.Add(this.dropdownTableList);
            this.Controls.Add(this.buttonReloadSchema);
            this.Controls.Add(this.panelTableBackground);
            this.Name = "ControlDatabaseEditor";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 20, 20);
            this.Size = new System.Drawing.Size(1435, 785);
            this.Load += new System.EventHandler(this.action_FormLoad);
            this.panelTableBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTableBackground;
        private System.Windows.Forms.Label labelSchema;
        private System.Windows.Forms.Button buttonReloadSchema;
        private System.Windows.Forms.Label labelTableList;
        private MetroFramework.Controls.MetroComboBox dropdownTableList;
        private System.Windows.Forms.Button buttonCreateTable;
        private System.Windows.Forms.Button buttonDropTable;
        private System.Windows.Forms.Button buttonAddColumn;
        private System.Windows.Forms.Button buttonDeleteColumn;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxDefaultValue;
        private System.Windows.Forms.Label labelDefaultValue;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.Button buttonClearFilter;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxColumnName;
        private System.Windows.Forms.Label labelColumnName;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.DataGridView gridview;
    }
}
