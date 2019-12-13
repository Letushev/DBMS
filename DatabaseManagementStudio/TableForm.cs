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
    public partial class TableForm : Form
    {
        public Table table;
        
        private bool noControls = false;

        public event EventHandler onDelete;
        public TableForm(Table t, bool noC = false)
        {
            InitializeComponent();
            table = t;
            this.Text = t.name;
            // table.columns.Clear();
            noControls = noC;
            UpdateTable();

            if (noControls)
            {
                AddColumnButton.Enabled = false;
                AddRowButton.Enabled = false;
                DeleteTableButton.Enabled = false;
            }
        }

        private void DeleteTableButton_Click(object sender, EventArgs e)
        {

            this.Close();
            onDelete(sender, e);
        }

        private void AddColumnButton_Click(object sender, EventArgs args)
        {

            AddColumnForm addColumnForm = new AddColumnForm(table);
            addColumnForm.onColumnAdd += (s, e) => UpdateTable();
            addColumnForm.Show();
        }

        private void UpdateTable()
        {
            TableLayout.Controls.Clear();
            TableLayout.ColumnCount = table.columns.Count;
            TableLayout.RowCount = table.rows.Count;

            if (!noControls)
            {
                TableLayout.ColumnCount += 2;
                TableLayout.RowCount += 1;
            }

            TableLayoutRowStyleCollection styles = TableLayout.RowStyles;

            foreach (RowStyle style in styles)
            {
                style.SizeType = SizeType.AutoSize;
            }

            if (!noControls) { TableLayout.Controls.Add(new Label() { Text = "id" }); }

            foreach (Column column in table.columns)
            {
                TableLayout.Controls.Add(new Label() { Text = column.name });
            }

            if (!noControls) { TableLayout.Controls.Add(new Label() { Text = "" }); }

            foreach (Row row in table.rows)
            {
                if (!noControls) { TableLayout.Controls.Add(new Label() { Text = row.id.ToString() }); }
                foreach (Object value in row.values)
                {
                    string v = "";

                    if (value != null)
                    {
                        v = value.ToString();
                    }

                    TableLayout.Controls.Add(new Label() { Text = v });
                }

                if (!noControls)
                {
                    Button deleteButton = new Button();
                    deleteButton.Text = "Видалити";
                    deleteButton.Click += (s, e) =>
                    {
                        table.DeleteRow(row.id);
                        UpdateTable();
                    };

                    TableLayout.Controls.Add(deleteButton);
                }
            }
        }

        private void AddRowButton_Click(object sender, EventArgs args)
        {
            if (table.columns.Count == 0)
            {
                MessageBox.Show("Спочатку додайте стовпчики", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AddRowForm addRowForm = new AddRowForm(table);
                addRowForm.Closed += (s, e) => UpdateTable();
                addRowForm.Show();
            }
        }
    }
}
