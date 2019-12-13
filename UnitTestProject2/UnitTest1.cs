using Microsoft.VisualStudio.TestTools.UnitTesting;
using DatabaseManagementStudio;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        private Database db = new Database("database");

        [TestMethod]
        public void ÀddTables_EqualNames()
        {
            // Arrange
            string name = "name";
            Table table1 = new Table(name);
            Table table2 = new Table(name);
            db.AddTable(table1);

            // Act
            bool success = db.AddTable(table2);

            // Assert
            Assert.IsFalse(success, "Same tables added...");
        }

        [TestMethod]
        public void TablesDiff_ColumnsCount()
        {
            // Arrange
            Table table1 = new Table("table1");
            Table table2 = new Table("table2");

            table1.AddColumn(new Column());
            table1.AddColumn(new Column());

            table2.AddColumn(new Column());

            // Act
            Table result = db.FindDiff(table1, table2);

            // Asert
            Assert.AreEqual(result.columns.Count, 1);
        }

        [TestMethod]
        public void TablesDiff_ColumnsType()
        {
            // Arrange
            Table table1 = new Table("table1");
            Table table2 = new Table("table2");

            table1.AddColumn(new Column("a", "int"));

            table2.AddColumn(new Column("a", "float"));

            // Asert
            try
            {
                Table result = db.FindDiff(table1, table2);
                Assert.Fail("ExceptionX should be thrown");
}
            catch (System.Exception e)
            {
                // test passed
            }
        }
    }
}
