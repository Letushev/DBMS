using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementStudio
{
    public partial class MainForm : Form
    {
        public DatabaseManager dbm;
        private List<Button> buttons = new List<Button>();

        public MainForm()
        {
            InitializeComponent();
            dbm = new DatabaseManager();
        }

        private void MainForm_Load(object sender, EventArgs args)
        {
            List<Database> databases = dbm.RetrieveDatabases();
            dbm.databases = databases;

            foreach (Database d in databases)
            {
                this.AddButton(d.name);
            }
        }

        private void AddDatabaseButton_Click(object sender, EventArgs args)
        {
            string name = NewDatabaseNameTextbox.Text;

            if (!string.IsNullOrEmpty(name))
            {
                if (dbm.CheckNewName(name))
                {
                    // Warning: name is already used
                    return;
                }

                this.AddButton(name);

                NewDatabaseNameTextbox.Text = "";

                dbm.AddDatabase(name);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbm.SaveDatabases();
        }

        void DbButtonClick(object sender, EventArgs args, string name)
        {
            this.Hide();
            DatabaseForm form = new DatabaseForm(dbm.GetDatabase(name));
            form.Closed += (s, e) => this.Show();
            form.onDelete += (s, e) => onDatabaseDelete(s, e, name);
            form.Show();
        }

        void onDatabaseDelete(object sender, EventArgs args, string name)
        {
            Button button = buttons.Find(b => b.Text == name);
            DatabasesTableLayout.Controls.Remove(button);
            dbm.DeleteDatabase(name);
        }

        private void AddButton(string name)
        {
            Button dbButton = new Button();
            dbButton.Size = new Size(252, 140);
            dbButton.Text = name;
            dbButton.Font = new Font("Arial", 24);
            dbButton.Click += (s, e) => DbButtonClick(s, e, name);
            DatabasesTableLayout.Controls.Add(dbButton);
            buttons.Add(dbButton);
        }
    }
}
