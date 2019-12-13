using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementStudio
{
    public class Column
    {
        public string name;
        public string type;
        public bool isNotNull;

        public Column() { }

        public Column(string n, string t, bool inn = false)
        {
            name = n;
            type = t;
            isNotNull = inn;
        }
    }
}
