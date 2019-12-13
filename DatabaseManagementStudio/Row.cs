using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementStudio
{
    public class Row
    {
        public List<Object> values;
        public int id;
        public Row() { }

        public Row(int i, List<Object> v)
        {
            id = i;
            values = v;
        }
    }
}
