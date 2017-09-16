namespace Tests
{
    using System;
    using NUnit.Framework;
    using Unit_Testing___Lab.Models;

    [TestFixture]
    public class AxeTests
    {
        private const int AxeAttack = 10;
        private const int AxeDurability = 10;
        private const int DummyHp = 10;
        private const int DummyExp = 10;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void Testinit()
        {
            this.axe = new Axe(AxeAttack, AxeDurability);
            this.dummy = new Dummy(DummyHp, DummyExp);
        }

        [Test]
        public void AxeLosesDurabilyAfterAttack()
        {
            this.axe.Attack(this.dummy);

            Assert.AreEqual(9, this.axe.DurabilityPoints, "Axe Durability doesn't change after attack");
        }


        [Test]
        public void BrokenAxeCantAttack()
        {
            this.axe = new Axe(1, 1);

            this.axe.Attack(this.dummy);

            var ex = Assert.Throws<InvalidOperationException>
                (() => this.axe.Attack(this.dummy));
            Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
        }

    }
}