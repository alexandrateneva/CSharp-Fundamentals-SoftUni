namespace Extended_Db.Tests
{
    using System;
    using Extended_Database_Problems;
    using NUnit.Framework;

    [TestFixture]
    public class TestClass
    {
        private Database people;

        [SetUp]
        public void Testinit()
        {
            this.people = new Database(
                new Person(1234567, "Pesho"),
                new Person(987456786875765, "Gosho"),
                new Person(78345697897, "Ivan"),
                new Person(123890854, "Stamat"),
                new Person(986754567, "Minko")
                );
        }

        [Test]
        public void CreateDatabaseWithLessThan5Elements()
        {
            //Act & Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.people = new Database(
                new Person(1234567, "Pesho"),
                new Person(987456786875765, "Gosho"),
                new Person(78345697897, "Ivan"),
                new Person(123890854, "Stamat")
            ));
            Assert.AreEqual("Storing array's capacity must be exactly 5 integers.", exception.Message);
        }

        [Test]
        public void CreateDatabaseWithMoreThan5Elements()
        {
            //Act & Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.people = new Database(
                new Person(1234567, "Pesho"),
                new Person(987456786875765, "Gosho"),
                new Person(78345697897, "Ivan"),
                new Person(123890854, "Stamat"),
                new Person(986754567, "Minko"),
                new Person(98675457976, "Toshko")
            ));
            Assert.AreEqual("Storing array's capacity must be exactly 5 integers.", exception.Message);
        }

        [Test]
        public void RemovePerson()
        {
            //Act
            this.people.Remove();

            //Assert
            Assert.IsTrue(this.people.Count == 4, "The element was removed successfully.");
        }

        [Test]
        public void AddPersonWithSameName()
        {
            //Arrange
            this.people.Remove();

            //Act & Assert
            var exception =
                Assert.Throws<InvalidOperationException>(() =>
                this.people.Add(new Person(12345679, "Pesho")));

            Assert.AreEqual("There is person with the same name yet.", exception.Message);
        }

        [Test]
        public void AddPersonWithSameId()
        {
            //Arrange
            this.people.Remove();

            //Act & Assert
            var exception =
                Assert.Throws<InvalidOperationException>(() =>
                    this.people.Add(new Person(1234567, "Peskoo")));

            Assert.AreEqual("There is person with the same id yet.", exception.Message);
        }

        [Test]
        public void FindPersonByUsername_WhenDoesNotExist()
        {
            //Act & Assert
            var exception =
                Assert.Throws<InvalidOperationException>(() =>
                    this.people.FindByUsername("Sasho"));

            Assert.AreEqual("There isn't person with the same username.", exception.Message);
        }

        [Test]
        public void FindPersonById_WhenDoesNotExist()
        {
            //Act & Assert
            var exception =
                Assert.Throws<InvalidOperationException>(() =>
                    this.people.FindById(12345));

            Assert.AreEqual("There isn't person with the same id.", exception.Message);
        }

        [Test]
        public void FindPersonByUsername_WhenParameterIsNull()
        {
            //Act & Assert
            var exception =
                Assert.Throws<NullReferenceException>(() =>
                    this.people.FindByUsername(null));

            Assert.AreEqual("Username can not be null or empty.", exception.Message);
        }

        [Test]
        public void FindPersonById_WhenIdIsNegativeNumber()
        {
            //Act & Assert
            var exception =
                Assert.Throws<InvalidOperationException>(() =>
                    this.people.FindById(-12345));

            Assert.AreEqual("Id can not be negative number.", exception.Message);
        }
    }
}