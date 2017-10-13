/*
 * Jake Varness
 * 2-16-2012
 * CSCD 306, .NET Programming
 * 
 * This form is a simple form that allows the user to query the database used
 * in the RobustWatcher
 * 
 */
 
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace RobustDirectoryLogger
{
    public partial class QueryForm : Form
    {
        private SQLiteConnection db;
        private SQLiteCommand cmd;
        private SQLiteDataReader reader;
        private static string[] ext = { "", ".txt", ".doc", ".odt" };
        private ArrayList EXTENSIONS = new ArrayList(ext);
        private static readonly string DB_PATH = ".\\log.db";

        public QueryForm()
        {
            InitializeComponent();
            this.queryComboBox.DataSource = this.EXTENSIONS;
            FileInfo inf = new FileInfo(DB_PATH);
            if (inf.Exists)
                this.db = new SQLiteConnection("Data Source=" + DB_PATH + ";Version=3;New=false;Compress=true");
            else
                this.db = new SQLiteConnection("Data Source=" + DB_PATH + ";Version=3;New=true;Compress=true");
            this.db.Open();
        }

        ~QueryForm()
        {
            if(!this.IsDisposed && this.db.State == ConnectionState.Open)
                this.db.Close();
        }
        
        // event handler used to query the database
        private void onQuery(object sender, System.EventArgs e)
        {
            this.cmd = this.db.CreateCommand();
            this.cmd.CommandText = "SELECT * FROM log" + (this.queryComboBox.SelectedItem == "" ? "" : " WHERE path LIKE '%" + this.queryComboBox.SelectedItem + "'");
            this.reader = this.cmd.ExecuteReader();
            if (!this.reader.HasRows)
                MessageBox.Show("No query results", "Drive Watcher");
            else
            {
                this.queryGrid.Rows.Clear();
                while (reader.Read())
                {
                    this.queryGrid.Rows.Add(new string [] {(string) reader["name"], (string) reader["path"], (string) reader["old_path"], (string) reader["change"], (string) reader["date"]});
                }
            }
        }
    }
}
