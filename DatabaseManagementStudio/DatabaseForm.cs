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
    public partial class DatabaseForm : Form
    {
        public Database database;

        public event EventHandler onDelete;
        public DatabaseForm(Database db)
        {
            InitializeComponent();
            this.Text = db.name;
            database = db;
            TablesList.Items.AddRange(db.tables.Select(t => t.name).ToArray());
            TablesList.SelectedIndexChanged += onTableClick;
        }

        public void DeleteDatabaseButton_Click(object sender, EventArgs e)
        {
            this.onDelete(sender, e);
            this.Close();
        }

        private void AddTableButton_Click(object sender, EventArgs e)
        {
            string name = AddTableTextBox.Text;

            if (!string.IsNullOrEmpty(name))
            {
                Table table = new Table(name);
                bool success = database.AddTable(table);

                if (success)
                {
                    TablesList.Items.Insert(TablesList.Items.Count, name);
                }
                else
                {
                    MessageBox.Show("Таке ім'я вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                AddTableTextBox.Text = "";
            }
        }

        private void onTableClick(object sender, EventArgs args)
        {
            if (TablesList.SelectedIndex == -1)
            {
                return;
            }

            string name = TablesList.SelectedItem.ToString();
            TableForm tableForm = new TableForm(database.tables.Find(t => t.name == name));
            this.Hide();
            tableForm.Closed += (s, e) => this.Show();
            tableForm.onDelete += (s, e) => onTableDelete(s, e, name);
            tableForm.Show();
        }

        public void onTableDelete (object sender, EventArgs args, string name)
        {
            database.DeleteTable(name);
            TablesList.Items.Clear();
            TablesList.Items.AddRange(database.tables.Select(t => t.name).ToArray());
        }

        private void TablesDiffButton_Click(object sender, EventArgs e)
        {
            if (database.tables.Count < 2)
            {
                MessageBox.Show("Для пошуку різниці необіхдно мінімум 2 таблиці", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TablesDiffForm diffForm = new TablesDiffForm(database);
            diffForm.Show();
        }
    }
}
