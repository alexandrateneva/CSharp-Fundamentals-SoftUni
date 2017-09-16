namespace Tests
{
    using System;
    using NUnit.Framework;
    using Unit_Testing___Lab.Models;

    [TestFixture]
    public class DummyTests
    {
        private const int DummyHp = 10;
        private const int DummyExp = 10;

        private Dummy dummy;

        [SetUp]
        public void Testinit()
        {
            this.dummy = new Dummy(DummyHp, DummyExp);
        }


        [Test]
        public void LosesHealth_IfAttacked()
        {
            //Act
            this.dummy.TakeAttack(5);

            //Assert
            Assert.AreEqual(5, this.dummy.Health);
        }

        [Test]
        public void ThrowsException_IfAttackedWhenDummyIsDead()
        {
            //Arange
            this.dummy = new Dummy(0, 10);

            //Act & Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.dummy.TakeAttack(5));
            Assert.AreEqual("Dummy is dead.", exception.Message);
        }

        [Test]
        public void CanGiveExperience()
        {
            //Arange
           this.dummy = new Dummy(0, 50);

            //Act
            var result = dummy.GiveExperience();

            //Assert
            Assert.AreEqual(50, result, "Dead dummy does not give exp!");
        }

        [Test]
        public void CanNotGiveExperience()
        {
            //Arange
            this.dummy = new Dummy(10, 50);

            //Act & Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.dummy.GiveExperience());
            Assert.AreEqual("Target is not dead.", exception.Message);
        }
    }
}
