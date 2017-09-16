using System;
using NUnit.Framework;
using Database_Problems;

namespace Db.Tests
{
    [TestFixture]
    public class TestClass
    {
        private const int element = 5;

        private Database database;

        [SetUp]
        public void Testinit()
        {
            this.database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
        }

        [Test]
        public void CreateDatabaseWithLessThan16Elements()
        {
            //Act & Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15));
            Assert.AreEqual("Storing array's capacity must be exactly 16 integers.", exception.Message);
        }

        [Test]
        public void CreateDatabaseWithMoreThan16Elements()
        {
            //Act & Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17));
            Assert.AreEqual("Storing array's capacity must be exactly 16 integers.", exception.Message);
        }


        [Test]
        public void AddElementToFullDatabase()
        {
            //Act & Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.database.Add(element));
            Assert.AreEqual("Database is full yet.", exception.Message);
        }

        [Test]
        public void RemoveElement()
        {
            //Act
            this.database.Remove();

            //Assert
            Assert.IsTrue(this.database.Count == 15, "The element was removed successfully.");
        }

        [Test]
        public void AddElement()
        {
            //Act
            this.database.Remove();
            this.database.Add(element);

            //Assert
            Assert.IsTrue(this.database.Count == 16, "The element was added successfully.");
        }

        [Test]
        public void RemoveElementFromEmptyDataBase()
        {
            //Act
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();
            this.database.Remove();

            //Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.database.Remove());
            Assert.AreEqual("Database is empty.", exception.Message);
        }
    }
}
