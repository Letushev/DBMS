using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementStudio
{
    public class Database
    {
        public string name;
        public List<Table> tables = new List<Table>();

        public Database() { }

        public Database(string n)
        {
            name = n;
        }

        public bool AddTable(Table table)
        {
            if (tables.Any(t => t.name == table.name))
            {
                return true;
            }

            tables.Add(table);
            return true;
        }

        public void DeleteTable(string name)
        {
            tables.RemoveAll(t => t.name == name);
        }

        public Table FindDiff(Table t1, Table t2)
        {
            Table diff = new Table("Різниця " + t1.name + " та " + t2.name);

            List<Row> both = t1.rows.Concat(t2.rows).ToList();
            List<Row> result = new List<Row>();

            int pos = 0;

            while (pos < both.Count)
            {
                bool unique = true;

                for (int i = 0; i < both.Count; i++)
                {
                    if (pos != i)
                    {
                        bool equal = true;

                        for (int j = 0; j < both[pos].values.Count; j++)
                        {
                            if (both[pos].values[j] == null || both[i].values[j] == null)
                            {
                                if ((both[pos].values[j] == null && both[i].values[j] != null) || (both[pos].values[j] != null && both[i].values[j] == null))
                                {
                                    equal = false;
                                    break;
                                }
                            }

                            if (!both[pos].values[j].Equals(both[i].values[j]))
                            {
                                equal = false;
                                break;
                            }
                        }

                        if (equal)
                        {
                            unique = false;
                            break;
                        }
                    }
                }

                if (unique)
                {
                    result.Add(both[pos]);
                }

                pos++;
            }

            foreach (Column c in t1.columns)
            {
                diff.columns.Add(new Column("", c.type));
            }

            diff.rows = result;
            return diff;
        }
    }
}
