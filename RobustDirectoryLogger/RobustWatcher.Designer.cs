namespace RobustDirectoryLogger
{
    partial class RobustWatcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RobustWatcher));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.saveToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.stopToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.startToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.clearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.writeToDatabaseToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.fscomboLabel = new System.Windows.Forms.Label();
            this.fsCombobox = new System.Windows.Forms.ComboBox();
            this.dirBox = new System.Windows.Forms.TextBox();
            this.dirLabel = new System.Windows.Forms.Label();
            this.watchButton = new System.Windows.Forms.Button();
            this.watcher = new System.IO.FileSystemWatcher();
            this.saveDialogForm = new System.Windows.Forms.SaveFileDialog();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.changeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldPathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fileSystemWatcherToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(471, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileToolStripMenuItem,
            this.saveToDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.saveToFileToolStripMenuItem.Text = "&Save to File...";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.onSave);
            // 
            // saveToDatabaseToolStripMenuItem
            // 
            this.saveToDatabaseToolStripMenuItem.Name = "saveToDatabaseToolStripMenuItem";
            this.saveToDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.saveToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.saveToDatabaseToolStripMenuItem.Text = "Save to &Database...";
            this.saveToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.onSaveToDatabase);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.onExit);
            // 
            // fileSystemWatcherToolStripMenuItem
            // 
            this.fileSystemWatcherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.fileSystemWatcherToolStripMenuItem.Name = "fileSystemWatcherToolStripMenuItem";
            this.fileSystemWatcherToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.fileSystemWatcherToolStripMenuItem.Text = "File System Watcher";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.onClear);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryDatabaseToolStripMenuItem,
            this.clearDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // queryDatabaseToolStripMenuItem
            // 
            this.queryDatabaseToolStripMenuItem.Name = "queryDatabaseToolStripMenuItem";
            this.queryDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.queryDatabaseToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.queryDatabaseToolStripMenuItem.Text = "&Query Database";
            this.queryDatabaseToolStripMenuItem.Click += new System.EventHandler(this.onQuery);
            // 
            // clearDatabaseToolStripMenuItem
            // 
            this.clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            this.clearDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.clearDatabaseToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.clearDatabaseToolStripMenuItem.Text = "Clear Database";
            this.clearDatabaseToolStripMenuItem.Click += new System.EventHandler(this.onDatabaseClear);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.onAbout);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.onHelp);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolstripButton,
            this.stopToolstripButton,
            this.startToolstripButton,
            this.clearToolStripButton,
            this.writeToDatabaseToolstripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(471, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // saveToolstripButton
            // 
            this.saveToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolstripButton.Image = global::RobustDirectoryLogger.Properties.Resources.Save_Icon;
            this.saveToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolstripButton.Name = "saveToolstripButton";
            this.saveToolstripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolstripButton.Text = "Save";
            this.saveToolstripButton.Click += new System.EventHandler(this.onSave);
            // 
            // stopToolstripButton
            // 
            this.stopToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopToolstripButton.Image = global::RobustDirectoryLogger.Properties.Resources.Stop_sign;
            this.stopToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopToolstripButton.Name = "stopToolstripButton";
            this.stopToolstripButton.Size = new System.Drawing.Size(23, 22);
            this.stopToolstripButton.Text = "Stop Watching";
            this.stopToolstripButton.Click += new System.EventHandler(this.StopWatching);
            // 
            // startToolstripButton
            // 
            this.startToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startToolstripButton.Image = global::RobustDirectoryLogger.Properties.Resources.Play_icon;
            this.startToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startToolstripButton.Name = "startToolstripButton";
            this.startToolstripButton.Size = new System.Drawing.Size(23, 22);
            this.startToolstripButton.Text = "Start Watching";
            this.startToolstripButton.Click += new System.EventHandler(this.StartWatching);
            // 
            // clearToolStripButton
            // 
            this.clearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearToolStripButton.Image = global::RobustDirectoryLogger.Properties.Resources.edit_clear;
            this.clearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearToolStripButton.Name = "clearToolStripButton";
            this.clearToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.clearToolStripButton.Text = "Clear";
            this.clearToolStripButton.ToolTipText = "Clear Results";
            this.clearToolStripButton.Click += new System.EventHandler(this.onClear);
            // 
            // writeToDatabaseToolstripButton
            // 
            this.writeToDatabaseToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.writeToDatabaseToolstripButton.Image = global::RobustDirectoryLogger.Properties.Resources.database;
            this.writeToDatabaseToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.writeToDatabaseToolstripButton.Name = "writeToDatabaseToolstripButton";
            this.writeToDatabaseToolstripButton.Size = new System.Drawing.Size(23, 22);
            this.writeToDatabaseToolstripButton.Text = "Write To Database";
            this.writeToDatabaseToolstripButton.Click += new System.EventHandler(this.onSaveToDatabase);
            // 
            // fscomboLabel
            // 
            this.fscomboLabel.AutoSize = true;
            this.fscomboLabel.Location = new System.Drawing.Point(12, 79);
            this.fscomboLabel.Name = "fscomboLabel";
            this.fscomboLabel.Size = new System.Drawing.Size(101, 13);
            this.fscomboLabel.TabIndex = 2;
            this.fscomboLabel.Text = "Watch By Extention";
            // 
            // fsCombobox
            // 
            this.fsCombobox.FormattingEnabled = true;
            this.fsCombobox.Location = new System.Drawing.Point(119, 76);
            this.fsCombobox.Name = "fsCombobox";
            this.fsCombobox.Size = new System.Drawing.Size(121, 21);
            this.fsCombobox.TabIndex = 3;
            // 
            // dirBox
            // 
            this.dirBox.Location = new System.Drawing.Point(118, 50);
            this.dirBox.Name = "dirBox";
            this.dirBox.Size = new System.Drawing.Size(341, 20);
            this.dirBox.TabIndex = 4;
            this.dirBox.TextChanged += new System.EventHandler(this.ValidateDir);
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Location = new System.Drawing.Point(12, 53);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(100, 13);
            this.dirLabel.TabIndex = 5;
            this.dirLabel.Text = "Directory To Watch";
            // 
            // watchButton
            // 
            this.watchButton.Location = new System.Drawing.Point(246, 74);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(213, 23);
            this.watchButton.TabIndex = 6;
            this.watchButton.Text = "Start Watching";
            this.watchButton.UseVisualStyleBackColor = true;
            this.watchButton.Click += new System.EventHandler(this.onWatchButtonClick);
            // 
            // watcher
            // 
            this.watcher.EnableRaisingEvents = true;
            this.watcher.IncludeSubdirectories = true;
            this.watcher.SynchronizingObject = this;
            this.watcher.Changed += new System.IO.FileSystemEventHandler(this.OnFSChanged);
            this.watcher.Created += new System.IO.FileSystemEventHandler(this.OnFSChanged);
            this.watcher.Deleted += new System.IO.FileSystemEventHandler(this.OnFSChanged);
            this.watcher.Renamed += new System.IO.RenamedEventHandler(this.OnFSRenamed);
            // 
            // saveDialogForm
            // 
            this.saveDialogForm.AddExtension = false;
            this.saveDialogForm.DefaultExt = "txt";
            this.saveDialogForm.Filter = "Text File|*.txt|All Files|*.*";
            this.saveDialogForm.Title = "Drive Watcher";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.changeColumn,
            this.NameColumn,
            this.PathColumn,
            this.OldPathColumn,
            this.DateTimeColumn});
            this.dataGrid.Location = new System.Drawing.Point(13, 103);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(446, 246);
            this.dataGrid.TabIndex = 7;
            // 
            // changeColumn
            // 
            this.changeColumn.HeaderText = "Change Type";
            this.changeColumn.Name = "changeColumn";
            this.changeColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // PathColumn
            // 
            this.PathColumn.HeaderText = "Path";
            this.PathColumn.Name = "PathColumn";
            this.PathColumn.ReadOnly = true;
            // 
            // OldPathColumn
            // 
            this.OldPathColumn.HeaderText = "Old Path";
            this.OldPathColumn.Name = "OldPathColumn";
            this.OldPathColumn.ReadOnly = true;
            // 
            // DateTimeColumn
            // 
            this.DateTimeColumn.HeaderText = "Date / Time";
            this.DateTimeColumn.Name = "DateTimeColumn";
            this.DateTimeColumn.ReadOnly = true;
            this.DateTimeColumn.Width = 150;
            // 
            // RobustWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 361);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.watchButton);
            this.Controls.Add(this.dirLabel);
            this.Controls.Add(this.dirBox);
            this.Controls.Add(this.fsCombobox);
            this.Controls.Add(this.fscomboLabel);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RobustWatcher";
            this.Text = "Drive Watcher";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSystemWatcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Label fscomboLabel;
        private System.Windows.Forms.ComboBox fsCombobox;
        private System.Windows.Forms.TextBox dirBox;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.Button watchButton;
        private System.IO.FileSystemWatcher watcher;
        private System.Windows.Forms.SaveFileDialog saveDialogForm;
        private System.Windows.Forms.ToolStripButton saveToolstripButton;
        private System.Windows.Forms.ToolStripButton stopToolstripButton;
        private System.Windows.Forms.ToolStripButton startToolstripButton;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem queryDatabaseToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ToolStripButton clearToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldPathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeColumn;
        private System.Windows.Forms.ToolStripButton writeToDatabaseToolstripButton;
    }
}

