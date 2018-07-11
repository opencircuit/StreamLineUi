namespace StreamLineUi
{
    partial class ControlScriptEditor
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
            this.labelComponentList = new System.Windows.Forms.Label();
            this.dropdownComponentList = new MetroFramework.Controls.MetroComboBox();
            this.buttonAddComponent = new System.Windows.Forms.Button();
            this.buttonAddComponentBelow = new System.Windows.Forms.Button();
            this.buttonMoveComponentUp = new System.Windows.Forms.Button();
            this.buttonMoveComponentDown = new System.Windows.Forms.Button();
            this.buttonRemoveComponents = new System.Windows.Forms.Button();
            this.buttonRefreshComponentsList = new System.Windows.Forms.Button();
            this.buttonSaveScript = new System.Windows.Forms.Button();
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
            this.panelTableBackground.Location = new System.Drawing.Point(33, 23);
            this.panelTableBackground.Name = "panelTableBackground";
            this.panelTableBackground.Padding = new System.Windows.Forms.Padding(3);
            this.panelTableBackground.Size = new System.Drawing.Size(600, 704);
            this.panelTableBackground.TabIndex = 0;
            // 
            // gridviewScript
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            this.gridview.Location = new System.Drawing.Point(3, 3);
            this.gridview.Name = "gridviewScript";
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
            this.gridview.Size = new System.Drawing.Size(592, 696);
            this.gridview.TabIndex = 0;
            // 
            // labelComponentList
            // 
            this.labelComponentList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComponentList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelComponentList.Location = new System.Drawing.Point(675, 56);
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
            this.dropdownComponentList.Location = new System.Drawing.Point(795, 56);
            this.dropdownComponentList.Name = "dropdownComponentList";
            this.dropdownComponentList.Size = new System.Drawing.Size(248, 29);
            this.dropdownComponentList.TabIndex = 2;
            this.dropdownComponentList.UseSelectable = true;
            // 
            // buttonAddComponent
            // 
            this.buttonAddComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonAddComponent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddComponent.FlatAppearance.BorderSize = 2;
            this.buttonAddComponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddComponent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddComponent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddComponent.ForeColor = System.Drawing.Color.White;
            this.buttonAddComponent.Location = new System.Drawing.Point(795, 121);
            this.buttonAddComponent.Name = "buttonAddComponent";
            this.buttonAddComponent.Size = new System.Drawing.Size(248, 29);
            this.buttonAddComponent.TabIndex = 4;
            this.buttonAddComponent.Text = "Add Component";
            this.buttonAddComponent.UseVisualStyleBackColor = false;
            this.buttonAddComponent.Click += new System.EventHandler(this.action_AddComponent);
            // 
            // buttonAddComponentBelow
            // 
            this.buttonAddComponentBelow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonAddComponentBelow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddComponentBelow.FlatAppearance.BorderSize = 2;
            this.buttonAddComponentBelow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddComponentBelow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddComponentBelow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddComponentBelow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddComponentBelow.ForeColor = System.Drawing.Color.White;
            this.buttonAddComponentBelow.Location = new System.Drawing.Point(795, 156);
            this.buttonAddComponentBelow.Name = "buttonAddComponentBelow";
            this.buttonAddComponentBelow.Size = new System.Drawing.Size(248, 29);
            this.buttonAddComponentBelow.TabIndex = 5;
            this.buttonAddComponentBelow.Text = "Add Component Below Selection";
            this.buttonAddComponentBelow.UseVisualStyleBackColor = false;
            this.buttonAddComponentBelow.Click += new System.EventHandler(this.action_AddComponentBelow);
            // 
            // buttonMoveComponentUp
            // 
            this.buttonMoveComponentUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonMoveComponentUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveComponentUp.FlatAppearance.BorderSize = 2;
            this.buttonMoveComponentUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveComponentUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveComponentUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveComponentUp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveComponentUp.ForeColor = System.Drawing.Color.White;
            this.buttonMoveComponentUp.Location = new System.Drawing.Point(795, 191);
            this.buttonMoveComponentUp.Name = "buttonMoveComponentUp";
            this.buttonMoveComponentUp.Size = new System.Drawing.Size(248, 29);
            this.buttonMoveComponentUp.TabIndex = 6;
            this.buttonMoveComponentUp.Text = "Move Component Up";
            this.buttonMoveComponentUp.UseVisualStyleBackColor = false;
            this.buttonMoveComponentUp.Click += new System.EventHandler(this.action_MoveComponentUp);
            // 
            // buttonMoveComponentDown
            // 
            this.buttonMoveComponentDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonMoveComponentDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveComponentDown.FlatAppearance.BorderSize = 2;
            this.buttonMoveComponentDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveComponentDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveComponentDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveComponentDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveComponentDown.ForeColor = System.Drawing.Color.White;
            this.buttonMoveComponentDown.Location = new System.Drawing.Point(795, 226);
            this.buttonMoveComponentDown.Name = "buttonMoveComponentDown";
            this.buttonMoveComponentDown.Size = new System.Drawing.Size(248, 29);
            this.buttonMoveComponentDown.TabIndex = 7;
            this.buttonMoveComponentDown.Text = "Move Component Down";
            this.buttonMoveComponentDown.UseVisualStyleBackColor = false;
            this.buttonMoveComponentDown.Click += new System.EventHandler(this.action_MoveComponentDown);
            // 
            // buttonRemoveComponents
            // 
            this.buttonRemoveComponents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonRemoveComponents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRemoveComponents.FlatAppearance.BorderSize = 2;
            this.buttonRemoveComponents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRemoveComponents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRemoveComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveComponents.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveComponents.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveComponents.Location = new System.Drawing.Point(795, 261);
            this.buttonRemoveComponents.Name = "buttonRemoveComponents";
            this.buttonRemoveComponents.Size = new System.Drawing.Size(248, 29);
            this.buttonRemoveComponents.TabIndex = 8;
            this.buttonRemoveComponents.Text = "Remove Component(s)";
            this.buttonRemoveComponents.UseVisualStyleBackColor = false;
            this.buttonRemoveComponents.Click += new System.EventHandler(this.action_RemoveComponents);
            // 
            // buttonRefreshComponentsList
            // 
            this.buttonRefreshComponentsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonRefreshComponentsList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRefreshComponentsList.FlatAppearance.BorderSize = 2;
            this.buttonRefreshComponentsList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRefreshComponentsList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRefreshComponentsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshComponentsList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshComponentsList.ForeColor = System.Drawing.Color.White;
            this.buttonRefreshComponentsList.Location = new System.Drawing.Point(1049, 56);
            this.buttonRefreshComponentsList.Name = "buttonRefreshComponentsList";
            this.buttonRefreshComponentsList.Size = new System.Drawing.Size(248, 29);
            this.buttonRefreshComponentsList.TabIndex = 3;
            this.buttonRefreshComponentsList.Text = "Refresh Components List";
            this.buttonRefreshComponentsList.UseVisualStyleBackColor = false;
            this.buttonRefreshComponentsList.Click += new System.EventHandler(this.action_RefreshComponentsList);
            // 
            // buttonSaveScript
            // 
            this.buttonSaveScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSaveScript.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveScript.FlatAppearance.BorderSize = 2;
            this.buttonSaveScript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveScript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveScript.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveScript.ForeColor = System.Drawing.Color.White;
            this.buttonSaveScript.Location = new System.Drawing.Point(33, 733);
            this.buttonSaveScript.Name = "buttonSaveScript";
            this.buttonSaveScript.Size = new System.Drawing.Size(600, 29);
            this.buttonSaveScript.TabIndex = 1;
            this.buttonSaveScript.Text = "Save Script";
            this.buttonSaveScript.UseVisualStyleBackColor = false;
            this.buttonSaveScript.Click += new System.EventHandler(this.action_SaveScript);
            // 
            // ControlScriptEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonSaveScript);
            this.Controls.Add(this.buttonRefreshComponentsList);
            this.Controls.Add(this.buttonRemoveComponents);
            this.Controls.Add(this.buttonMoveComponentDown);
            this.Controls.Add(this.buttonMoveComponentUp);
            this.Controls.Add(this.buttonAddComponentBelow);
            this.Controls.Add(this.buttonAddComponent);
            this.Controls.Add(this.labelComponentList);
            this.Controls.Add(this.dropdownComponentList);
            this.Controls.Add(this.panelTableBackground);
            this.Name = "ControlScriptEditor";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 20, 20);
            this.Size = new System.Drawing.Size(1435, 785);
            this.Load += new System.EventHandler(this.action_FormLoad);
            this.panelTableBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTableBackground;
        private System.Windows.Forms.Label labelComponentList;
        private MetroFramework.Controls.MetroComboBox dropdownComponentList;
        private System.Windows.Forms.Button buttonAddComponent;
        private System.Windows.Forms.Button buttonAddComponentBelow;
        private System.Windows.Forms.Button buttonMoveComponentUp;
        private System.Windows.Forms.Button buttonMoveComponentDown;
        private System.Windows.Forms.Button buttonRemoveComponents;
        private System.Windows.Forms.Button buttonRefreshComponentsList;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button buttonSaveScript;
    }
}
