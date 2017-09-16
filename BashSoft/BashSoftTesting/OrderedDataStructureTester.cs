namespace BashSoftTesting
{
    using System;
    using System.Collections.Generic;
    using BashSoft.Contracts;
    using BashSoft.DataStructures;
    using NUnit.Framework;

    [TestFixture]
    public class OrderedDataStructureTests
    {
        private ISimpleOrderedBag<string> data;

        [SetUp]
        public void Setup()
        {
            this.data = new SimpleSortedList<string>();
        }

        [Test]
        public void TestEmptyCtor()
        {
            Assert.AreEqual(16, this.data.Capacity);
            Assert.AreEqual(0, this.data.Size);
        }

        [Test]
        public void TestCtorWithInitialCapacity()
        {
            this.data = new SimpleSortedList<string>(20);

            Assert.AreEqual(20, this.data.Capacity);
            Assert.AreEqual(0, this.data.Size);
        }

        [Test]
        public void TestCtorWithAllParameters()
        {
            this.data = new SimpleSortedList<string>(30, StringComparer.OrdinalIgnoreCase);

            Assert.AreEqual(30, this.data.Capacity);
            Assert.AreEqual(0, this.data.Size);
        }

        [Test]
        public void TestCtorWithInitialComparer()
        {
            this.data = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);

            Assert.AreEqual(16, this.data.Capacity);
            Assert.AreEqual(0, this.data.Size);
        }

        [Test]
        public void TestAddIncreasesSize()
        {
            this.data.Add("Gosho");
            Assert.AreEqual(1, this.data.Size);
        }

        [Test]
        public void TestAddNullThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                this.data.Add(null);
            });
        }

        [Test]
        public void TestAddingMoreThanInitialCapacity()
        {
            var elements = new List<string>();

            for (int i = 0; i < 17; i++)
            {
                elements.Add("Pesho");
            }

            this.data.AddAll(elements);

            Assert.AreEqual(17, this.data.Size);
            Assert.AreNotEqual(16, this.data.Capacity);
        }

        [Test]
        public void TestAddUnsortedDataIsHeldSorted()
        {
            this.data.Add("Rosen");
            this.data.Add("Georgi");
            this.data.Add("Balkan");

            var expected = new List<string>()
            {
                "Balkan",
                "Georgi",
                "Rosen"
            };

            CollectionAssert.AreEqual(expected, this.data);
        }

        [Test]
        public void TestAddingAllFromCollectionIncreasesSize()
        {
            this.data.AddAll(new List<string>
            {
                "Ivan",
                "Pesho"
            });

            Assert.AreEqual(2, this.data.Size);
        }

        [Test]
        public void TestAddAllThrowsExceptionWhenNullIsProviededAsValue()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                this.data.AddAll(null);
            });
        }

        [Test]
        public void TestAddAllKeepsSorted()
        {
            this.data = new SimpleSortedList<string>();
            this.data.AddAll(new List<string>()
            {
                "Rosen",
                "Georgi",
                "Balkan"
            });

            var expected = new List<string>()
            {
                "Balkan",
                "Georgi",
                "Rosen"
            };

            CollectionAssert.AreEqual(expected, this.data);
        }

        [Test]
        public void TestRemoveValidElementDecreasesSize()
        {
            this.data.Add("Ivan");
            this.data.Add("Nasko");

            this.data.Remove("Nasko");

            Assert.AreEqual(1, this.data.Size);
        }

        [Test]
        public void TestRemoveValidElementRemovesSelectedOne()
        {
            this.data.Add("Ivan");
            this.data.Add("Nasko");

            this.data.Remove("Ivan");

            var expected = new List<string>()
            {
                "Nasko"
            };

            CollectionAssert.AreEqual(expected, this.data);
        }

        [Test]
        public void TestRemovingNullThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                this.data.Remove(null);
            });
        }

        [Test]
        public void TestJoinWithNullThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                this.data.JoinWith(null);
            });
        }

        [Test]
        public void TestJoinWithWorksFine()
        {
            this.data.Add("Nasko");
            this.data.Add("Ivan");
            this.data.Add("Pesho");

            string expected = "Ivan, Nasko, Pesho";

            Assert.AreEqual(expected, this.data.JoinWith(", "));
        }
    }
}