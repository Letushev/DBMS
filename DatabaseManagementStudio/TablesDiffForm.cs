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
    public partial class TablesDiffForm : Form
    {
        public Database database;
        public TablesDiffForm(Database db)
        {
            InitializeComponent();
            database = db;
        }

        private void TablesDiffForm_Load(object sender, EventArgs e)
        {
            string [] tables = database.tables.Select(t => t.name).ToArray();
            Table1DropDown.Items.AddRange(tables);
            Table2DropDown.Items.AddRange(tables);
        }

        private void FindDiffButton_Click(object sender, EventArgs e)
        {
            if (Table1DropDown.SelectedIndex == -1 || Table2DropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть таблиці для порівняння", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string t1 = Table1DropDown.SelectedItem.ToString();
            string t2 = Table2DropDown.SelectedItem.ToString();

            if (t1 == t2)
            {
                MessageBox.Show("Виберіть різні таблиці", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Table table1 = database.tables.Find(t => t.name == t1);
            Table table2 = database.tables.Find(t => t.name == t2);

            if (table1.columns.Count != table2.columns.Count)
            {
                MessageBox.Show("Кількість та типи стопвчиків повинні збігатися", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool typesMatch = true;
                for (int i = 0; i < table1.columns.Count; i++)
                {
                    if (table1.columns[i].type != table2.columns[i].type)
                    {
                        typesMatch = false;
                    }
                }

                if (!typesMatch)
                {
                    MessageBox.Show("Кількість та типи стопвчиків повинні збігатися", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Table diff = database.FindDiff(table1, table2);
            TableForm form = new TableForm(diff, true);
            form.Show();
        }
    }
}
