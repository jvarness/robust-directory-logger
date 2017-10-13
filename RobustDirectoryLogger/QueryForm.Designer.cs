namespace RobustDirectoryLogger
{
    partial class QueryForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryForm));
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryComboBox = new System.Windows.Forms.ComboBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.queryGrid = new System.Windows.Forms.DataGridView();
            this.gridLabel = new System.Windows.Forms.Label();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.queryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(13, 13);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(102, 13);
            this.queryLabel.TabIndex = 0;
            this.queryLabel.Text = "Query By Extension:";
            // 
            // queryComboBox
            // 
            this.queryComboBox.FormattingEnabled = true;
            this.queryComboBox.Location = new System.Drawing.Point(124, 10);
            this.queryComboBox.Name = "queryComboBox";
            this.queryComboBox.Size = new System.Drawing.Size(121, 21);
            this.queryComboBox.TabIndex = 1;
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(251, 8);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(75, 23);
            this.queryButton.TabIndex = 2;
            this.queryButton.Text = "Query";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.onQuery);
            // 
            // queryGrid
            // 
            this.queryGrid.AllowUserToAddRows = false;
            this.queryGrid.AllowUserToDeleteRows = false;
            this.queryGrid.AllowUserToResizeRows = false;
            this.queryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.Path,
            this.OldPath,
            this.Change,
            this.Date});
            this.queryGrid.Location = new System.Drawing.Point(12, 70);
            this.queryGrid.Name = "queryGrid";
            this.queryGrid.Size = new System.Drawing.Size(450, 213);
            this.queryGrid.TabIndex = 3;
            // 
            // gridLabel
            // 
            this.gridLabel.AutoSize = true;
            this.gridLabel.Location = new System.Drawing.Point(13, 51);
            this.gridLabel.Name = "gridLabel";
            this.gridLabel.Size = new System.Drawing.Size(293, 13);
            this.gridLabel.TabIndex = 4;
            this.gridLabel.Text = "Not specifiying an extension will retrieve the whole database.";
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            // 
            // OldPath
            // 
            this.OldPath.HeaderText = "Old Path";
            this.OldPath.Name = "OldPath";
            this.OldPath.ReadOnly = true;
            // 
            // Change
            // 
            this.Change.HeaderText = "Change";
            this.Change.Name = "Change";
            this.Change.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date / Time";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 295);
            this.Controls.Add(this.gridLabel);
            this.Controls.Add(this.queryGrid);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.queryComboBox);
            this.Controls.Add(this.queryLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            ((System.ComponentModel.ISupportInitialize)(this.queryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.ComboBox queryComboBox;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.DataGridView queryGrid;
        private System.Windows.Forms.Label gridLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}