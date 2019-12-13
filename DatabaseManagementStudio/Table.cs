using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementStudio
{
    public class Table
    {
        public string name;
        public List<Column> columns = new List<Column>();
        public List<Row> rows = new List<Row>();
        public Table() { }

        public Table(string n)
        {
            name = n;
        }

        public bool AddColumn(Column column)
        {
            if (columns.Any(c => c.name == column.name))
            {
                return false;
            }
            
            columns.Add(column);
            foreach (Row row in rows)
            {
                row.values.Add(null);
            }

            return true;
        }

        public void AddRow(Row row)
        {
            rows.Add(row);
        }

        public void DeleteRow(int id)
        {
            rows.RemoveAll(r => r.id == id);
        }
    }
}
