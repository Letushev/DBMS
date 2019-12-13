using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace DatabaseManagementStudio
{   
    [Serializable]
    public class DatabaseManager
    {
        public List<Database> databases;
        private string fileName = "databases.xml";
             
        public DatabaseManager()
        {
            databases = new List<Database>();
        }

        public void AddDatabase(string name)
        {
            Database db = new Database(name);
            databases.Add(db);
        }

        public bool CheckNewName(string name)
        {
            return databases.Any(d => d.name == name);
        }

        public void SaveDatabases()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Database>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                fs.SetLength(0);
                formatter.Serialize(fs, databases);
            }
        }

        public List<Database> RetrieveDatabases()
        {
            if (!File.Exists(fileName))
            {
                return new List<Database>();
            }

            XmlSerializer formatter = new XmlSerializer(typeof(List<Database>));

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                List<Database> data = (List<Database>)formatter.Deserialize(fs);
                return data;
            }
        }

        public void DeleteDatabase(string name)
        {
            Database database = databases.SingleOrDefault(d => d.name == name);
            if (database != null)
            {
                databases.Remove(database);
            }
        }

        public Database GetDatabase(string name)
        {
            return databases.Find(d => d.name == name);
        }
    }
}
