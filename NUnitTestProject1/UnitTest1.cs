using NUnit.Framework;
using DatabaseManagementStudio;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            string name = "name";
            Database db = new Database("database");
            Table table1 = new Table(name);
            Table table2 = new Table(name);
            db.AddTable(table1);

            // Act
            bool success = db.AddTable(table2);

            // Assert
            Assert.IsFalse(success, "Same tables added...");
        }
    }
}