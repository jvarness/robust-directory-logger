/*
 * Jake Varness
 * 2-7-2013
 * CSCD 306, Midterm Project
 * 
 * This is the midterm project for CSCD 306.
 * 
 * This is a re-hash of the FileSystemWatcher from assignment 1. It includes
 * a lot more features than the previous FS watcher, and overall looks
 * a lot prettier.
 * 
 * I also made my own Icon for the app. The little disk with the sunglasses is an
 * image I made using Gimp. The other icons I just downloaded from the internet.
 * 
 * Of the extra-credit worthy things, obviously I think the icon is a nice touch ;)
 * 
 * Along with that, I also implemented a SaveDialogForm that would allow the user to
 * save the rows in the DataGridView to a txt file.
 */ 

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace RobustDirectoryLogger
{

    public partial class RobustWatcher : Form
    {
        #region Private Fields
        // private fields used during runtime
        // used for WatchButton
        private readonly string START = "Start Watching";
        private readonly string STOP = "Stop Watching";
        // used for SQL Lite
        private SQLiteCommand cmd = null;
        private SQLiteConnection con = null;
        private static readonly string DB_PATH = ".\\log.db";
        // extensions data
        private static string[] ext = { "", ".txt", ".doc", ".odt" };
        private ArrayList EXTENSIONS = new ArrayList(ext);
        // the query form
        private QueryForm queryForm = null;
        #endregion

        #region Constructor/Destructor
        // On start-up
        public RobustWatcher()
        {
            InitializeComponent();
            this.watchButton.Enabled = false;
            this.watchButton.Text = this.START;
            this.startToolstripButton.Enabled = false;
            this.stopToolstripButton.Enabled = false;
            this.fsCombobox.DataSource = EXTENSIONS;
            this.queryForm = new QueryForm();
            this.queryForm.Visible = false;

            // check to see if the database exists. if not,
            // then make a new one.
            FileInfo db = new FileInfo(DB_PATH);
            if (db.Exists)
                this.con = new SQLiteConnection("Data Source=" + DB_PATH + ";Version=3;New=false;Compress=true");
            else
                this.con = new SQLiteConnection("Data Source=" + DB_PATH + ";Version=3;New=true;Compress=true");
            this.con.Open();
            // create the table if it doesn't exist
            this.cmd = this.con.CreateCommand();
            this.cmd.CommandText = "CREATE TABLE IF NOT EXISTS log (name varchar(300), path varchar(300), old_path varchar(300), change varchar(15), date varchar(30))";
            this.cmd.ExecuteNonQuery();
        }

        // Deconstructor used to ensure that at the end of the
        // program that our connection to the SQL database
        // and the FSwatcher are closed and no longer running.
        ~RobustWatcher()
        {
            if (this.con != null && this.con.State == ConnectionState.Open)
                this.con.Close();
        }
        #endregion

        #region Event Handlers
        // This event handler is called when a file is either deleted, changed,
        // or created.
        private void OnFSChanged(object sender, System.IO.FileSystemEventArgs e)
        {
            // watch all paths except where the exe is located, which by default is where the database
            // is located
            if (!e.FullPath.ToUpper().StartsWith(Environment.CurrentDirectory.ToUpper()))
            {
                string[] row = { e.ChangeType.ToString(), e.Name.ToString(), e.FullPath.ToString(), "", System.DateTime.Now.ToString() };
                this.dataGrid.Rows.Add(row);
            }
        }

        // This event handler is called when a file is renamed. It's unique
        // from other handlers because it logs the old full path
        private void OnFSRenamed(object sender, System.IO.RenamedEventArgs e)
        {
            string[] row = { e.ChangeType.ToString(), e.Name.ToString(), e.FullPath.ToString(), e.OldFullPath.ToString(), System.DateTime.Now.ToString() };
            this.dataGrid.Rows.Add(row);
        }

        // This event handler reads the text from the UI's text box
        // and checks if the path is valid.
        private void ValidateDir(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(dirBox.Text);
                if (dir.Exists)
                {
                    this.watchButton.Enabled = true;
                    this.dirBox.ForeColor = Color.Green;
                    this.startToolstripButton.Enabled = true;
                }
                else
                    throw new ArgumentException();
            }
            catch
            {
                this.watchButton.Enabled = false;
                this.dirBox.ForeColor = Color.Black;
                this.startToolstripButton.Enabled = false;
            }
        }

        // event handler that will start watching a given
        // directory
        private void StartWatching(object sender, EventArgs e)
        {
            this.watcher.Filter = "*" + (this.fsCombobox.SelectedItem == "" ? ".*" : this.fsCombobox.SelectedItem);
            this.watcher.Path = this.dirBox.Text;
            this.watcher.EnableRaisingEvents = true;
            this.watchButton.Text = this.STOP;
            this.dirBox.Enabled = false;
            this.startToolstripButton.Enabled = false;
            this.stopToolstripButton.Enabled = true;
            this.clearToolStripButton.Enabled = false;
            this.saveToolstripButton.Enabled = false;
        }

        // event handler that will stop the watcher from watching
        private void StopWatching(object sender, EventArgs e)
        {
            this.watcher.EnableRaisingEvents = false;
            this.watchButton.Text = this.START;
            this.dirBox.Enabled = true;
            this.stopToolstripButton.Enabled = false;
            this.startToolstripButton.Enabled = true;
            this.clearToolStripButton.Enabled = true;
            this.saveToolstripButton.Enabled = true;
        }

        // this event handler is meant for the watch button. it
        // will call the startWatching and stopWatching event
        // handlers accordingly
        private void onWatchButtonClick(object sender, EventArgs e)
        {
            if (this.watchButton.Text == this.START)
            {
                this.StartWatching(sender, e);
            }
            else
            {
                this.StopWatching(sender, e);
            }
        }

        // user is able to save the results to a file
        // of their choosing
        private void onSave(object sender, EventArgs e)
        {
            if (this.saveDialogForm.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(this.saveDialogForm.OpenFile());
                DataGridViewRowCollection coll = this.dataGrid.Rows;
                foreach (DataGridViewRow row in coll)
                {
                    foreach (DataGridViewTextBoxCell cell in row.Cells)
                        writer.Write(cell.Value + " ");
                    writer.WriteLine();
                }
                writer.Close();
            }
        }

        // this event handler will clear out the results from
        // the FileSystemWatcher
        private void onClear(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Do you really want to clear the table?", "Drive Watcher", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                DataGridViewRowCollection coll = this.dataGrid.Rows;
                coll.Clear();
            }
        }
        
        // event handler for bringing up the information about the
        // app
        private void onAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Jake Varness\r\nDrive Watcher v1.0\r\n.NET Version 4.5 x86", "Drive Watcher", MessageBoxButtons.OK);
        }

        // event handler that will prompt the user if they want to
        // write the content of the table to the 
        private void onSaveToDatabase(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Write the current table to the database?", "Drive Watcher", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                DataGridViewRowCollection coll = this.dataGrid.Rows;
                string cmdString = "INSERT INTO log(name, path, old_path, change, date) VALUES ";
                string slave = "";
                string [] values = new string[5];
                int index = 0;
                foreach (DataGridViewRow row in coll)
                {
                    foreach (DataGridViewTextBoxCell cell in row.Cells)
                    {
                        values[index] = cell.Value.ToString();
                        index++;
                    }
                    slave = cmdString + "('" + values[1] + "','" + values[2] + "','" + values[3] + "','" + values[0] + "','" + values[4] + "')";
                    index = 0;
                    this.cmd = this.con.CreateCommand();
                    this.cmd.CommandText = slave;
                    this.cmd.ExecuteNonQuery();
                    slave = "";
                    values = new string[5];
                }
            }
        }

        // event handler that will ask the user if they want to
        // clear the contents of the database
        private void onDatabaseClear(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to clear out the database?", "Drive Watcher", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                this.cmd = this.con.CreateCommand();
                this.cmd.CommandText = "DELETE FROM log";
                this.cmd.ExecuteNonQuery();
            }
        }

        // event handler that will execute when the
        // user attempts to exit
        private void onExit(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Write data in the table to the database?", "Drive Watcher", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                DataGridViewRowCollection coll = this.dataGrid.Rows;
                string cmdString = "INSERT INTO log(name, path, old_path, change, date) VALUES ";
                string slave = "";
                string [] values = new string[5];
                int index = 0;
                foreach (DataGridViewRow row in coll)
                {
                    foreach (DataGridViewTextBoxCell cell in row.Cells)
                    {
                        values[index] = cell.Value.ToString();
                        index++;
                    }
                    slave = cmdString + "('" + values[1] + "','" + values[2] + "','" + values[3] + "','" + values[0] + "','" + values[4] + "')";
                    index = 0;
                    this.cmd = this.con.CreateCommand();
                    this.cmd.CommandText = slave;
                    this.cmd.ExecuteNonQuery();
                    slave = "";
                    values = new string[5];
                }
            }
            this.queryForm.Close();
            this.Close();
        }

        // event handler that will bring up a form
        // that allows the user to query the database
        private void onQuery(object sender, EventArgs e)
        {
            if (!this.queryForm.Visible)
            {
                if (this.queryForm.IsDisposed)
                    this.queryForm = new QueryForm();
                this.queryForm.Visible = true;
            }
        }

        // event handler that will bring up a MessageBox
        // explaining program usage
        private void onHelp(object sender, EventArgs e)
        {
            MessageBox.Show("1.) Type directory into text box\r\n2.) (Optional) Specify extension filter\r\n3.) Hit Start!\r\nOnce the table has data in it, you can\r\nwrite that data to a txt file or to\r\nthe database", "Drive Watcher");
        }
        #endregion
    }
}
