using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementStudio
{
    public partial class AddRowForm : Form
    {
        public Table table;
        public AddRowForm(Table t)
        {
            InitializeComponent();
            table = t;
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            List<Object> values = new List<Object>();

            foreach (Column column in table.columns)
            {
                if (column.type == "int")
                {
                    values.Add(((NumericUpDown)AddRowLayout.Controls[column.name + "Value"]).Value);
                }
                else
                {
                    string value = ((TextBox)AddRowLayout.Controls[column.name + "Value"]).Text;

                    if (column.isNotNull && string.IsNullOrEmpty(value))
                    {
                        MessageBox.Show("Не може бути порожньою колонка - " + column.name, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (!column.isNotNull && string.IsNullOrEmpty(value))
                    {
                        values.Add(null);
                    }
                    else if (column.type == "float")
                    {
                        double result;
                        if (!Double.TryParse(value, out result))
                        {
                            MessageBox.Show("Помилка типу даних колонки - " + column.name, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            values.Add(result);
                        }
                    }
                    else if (column.type == "email")
                    {
                        try
                        {
                            MailAddress m = new MailAddress(value);
                            values.Add(value);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Помилка типу даних колонки - " + column.name, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        values.Add(value);
                    }

                }
            }

            Row row = new Row(table.rows.Count + 1, values);
            table.AddRow(row);
            this.Close();
        }

        private void AddRowForm_Load(object sender, EventArgs e)
        {
            foreach (Column column in table.columns)
            {
                Label name = new Label() { Text = column.name }; 
                AddRowLayout.Controls.Add(name);
                
                if (column.type == "int")
                {
                    NumericUpDown intValue = new NumericUpDown();
                    intValue.Name = column.name + "Value";
                    AddRowLayout.Controls.Add(intValue);
                }
                else
                {
                    TextBox textValue = new TextBox();

                    if (column.type == "char")
                    {
                        textValue.MaxLength = 1;
                    }

                    textValue.Name = column.name + "Value";
                    AddRowLayout.Controls.Add(textValue);
                }
            }
        }
       
    }
}
