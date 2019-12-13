using Microsoft.VisualStudio.TestTools.UnitTesting;
using DatabaseManagementStudio;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
