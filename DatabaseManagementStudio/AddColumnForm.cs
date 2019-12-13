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
    public partial class AddColumnForm : Form
    {
        public Table table;
        public event EventHandler onColumnAdd;
        public AddColumnForm(Table t)
        {
            InitializeComponent();
            table = t;
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            string name = ColumnNameTextBox.Text;
            if (!string.IsNullOrEmpty(name) && ColumnTypeDropDown.SelectedIndex != -1)
            {
                Column column = new Column(name, ColumnTypeDropDown.SelectedItem.ToString(), IsNotNullRadioButton.Checked);
                bool success = table.AddColumn(column);
                if (success)
                {
                    onColumnAdd(sender, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такий стовпчик уже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Заповніть обов'язкові поля!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
