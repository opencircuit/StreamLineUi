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
            this.gridview = new System.Windows.Forms.DataGridView();
            this.labelTableName = new System.Windows.Forms.Label();
            this.buttonLoadTable = new System.Windows.Forms.Button();
            this.dropdownTableList = new MetroFramework.Controls.MetroComboBox();
            this.labelTableList = new System.Windows.Forms.Label();
            this.buttonSaveTable = new System.Windows.Forms.Button();
            this.buttonDeleteTestCase = new System.Windows.Forms.Button();
            this.buttonReloadTableList = new System.Windows.Forms.Button();
            this.panelTableBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
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
            this.panelTableBackground.Location = new System.Drawing.Point(33, 58);
            this.panelTableBackground.Name = "panelTableBackground";
            this.panelTableBackground.Padding = new System.Windows.Forms.Padding(3);
            this.panelTableBackground.Size = new System.Drawing.Size(1379, 704);
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
            this.gridview.Name = "gridviewTable";
            this.gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridview.Size = new System.Drawing.Size(1371, 667);
            this.gridview.TabIndex = 0;
            this.gridview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.action_CopyPasteData);
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
            this.labelTableName.Text = "Table:";
            this.labelTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLoadTable
            // 
            this.buttonLoadTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonLoadTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTable.FlatAppearance.BorderSize = 2;
            this.buttonLoadTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoadTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadTable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadTable.ForeColor = System.Drawing.Color.White;
            this.buttonLoadTable.Location = new System.Drawing.Point(367, 23);
            this.buttonLoadTable.Name = "buttonLoadTable";
            this.buttonLoadTable.Size = new System.Drawing.Size(180, 29);
            this.buttonLoadTable.TabIndex = 2;
            this.buttonLoadTable.Text = "Load Table";
            this.buttonLoadTable.UseVisualStyleBackColor = false;
            this.buttonLoadTable.Click += new System.EventHandler(this.action_LoadTable);
            // 
            // dropdownTableList
            // 
            this.dropdownTableList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownTableList.FormattingEnabled = true;
            this.dropdownTableList.ItemHeight = 23;
            this.dropdownTableList.Location = new System.Drawing.Point(113, 23);
            this.dropdownTableList.Name = "dropdownTableList";
            this.dropdownTableList.Size = new System.Drawing.Size(248, 29);
            this.dropdownTableList.TabIndex = 1;
            this.dropdownTableList.UseSelectable = true;
            // 
            // labelTableList
            // 
            this.labelTableList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTableList.Location = new System.Drawing.Point(30, 23);
            this.labelTableList.Name = "labelTableList";
            this.labelTableList.Size = new System.Drawing.Size(77, 29);
            this.labelTableList.TabIndex = 0;
            this.labelTableList.Text = "Tables List:";
            this.labelTableList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSaveTable
            // 
            this.buttonSaveTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSaveTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveTable.FlatAppearance.BorderSize = 2;
            this.buttonSaveTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveTable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveTable.ForeColor = System.Drawing.Color.White;
            this.buttonSaveTable.Location = new System.Drawing.Point(553, 23);
            this.buttonSaveTable.Name = "buttonSaveTable";
            this.buttonSaveTable.Size = new System.Drawing.Size(180, 29);
            this.buttonSaveTable.TabIndex = 3;
            this.buttonSaveTable.Text = "Save Table";
            this.buttonSaveTable.UseVisualStyleBackColor = false;
            this.buttonSaveTable.Click += new System.EventHandler(this.action_SaveTable);
            // 
            // buttonDeleteTestCase
            // 
            this.buttonDeleteTestCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteTestCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDeleteTestCase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteTestCase.FlatAppearance.BorderSize = 2;
            this.buttonDeleteTestCase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTestCase.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTestCase.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteTestCase.Location = new System.Drawing.Point(1164, 23);
            this.buttonDeleteTestCase.Name = "buttonDeleteTestCase";
            this.buttonDeleteTestCase.Size = new System.Drawing.Size(248, 29);
            this.buttonDeleteTestCase.TabIndex = 5;
            this.buttonDeleteTestCase.Text = "Delete Selected Test Case(s)";
            this.buttonDeleteTestCase.UseVisualStyleBackColor = false;
            this.buttonDeleteTestCase.Click += new System.EventHandler(this.action_DeleteTestCases);
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
            this.buttonReloadTableList.Location = new System.Drawing.Point(739, 23);
            this.buttonReloadTableList.Name = "buttonReloadTableList";
            this.buttonReloadTableList.Size = new System.Drawing.Size(180, 29);
            this.buttonReloadTableList.TabIndex = 4;
            this.buttonReloadTableList.Text = "Reload Table List";
            this.buttonReloadTableList.UseVisualStyleBackColor = false;
            this.buttonReloadTableList.Click += new System.EventHandler(this.action_ReloadTableList);
            // 
            // ControlDataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonReloadTableList);
            this.Controls.Add(this.buttonDeleteTestCase);
            this.Controls.Add(this.buttonSaveTable);
            this.Controls.Add(this.buttonLoadTable);
            this.Controls.Add(this.panelTableBackground);
            this.Controls.Add(this.labelTableList);
            this.Controls.Add(this.dropdownTableList);
            this.Name = "ControlDataEditor";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 20, 20);
            this.Size = new System.Drawing.Size(1435, 785);
            this.Load += new System.EventHandler(this.action_FormLoad);
            this.panelTableBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTableBackground;
        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.Button buttonLoadTable;
        private MetroFramework.Controls.MetroComboBox dropdownTableList;
        private System.Windows.Forms.Label labelTableList;
        private System.Windows.Forms.Button buttonSaveTable;
        private System.Windows.Forms.Button buttonDeleteTestCase;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button buttonReloadTableList;
    }
}
