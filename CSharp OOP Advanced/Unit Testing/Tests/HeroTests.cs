﻿namespace Tests
{
    using System;
    using Moq;
    using NUnit.Framework;
    using Unit_Testing___Lab.Models;
    using Unit_Testing___Lab.Interfaces;

    [TestFixture()]
    public class HeroTests
    {
        [Test]
        public void HeroGetsExpWhenTargetDies()
        {
            IWeapon fakeAxe = new Axe(10, 10);
            ITarget fakeDummy = new Dummy(10, 10);

            Hero sut = new Hero("Pesho", fakeAxe);
            int expAtStart = sut.Experience;

            sut.Attack(fakeDummy);

            Assert.AreEqual(expAtStart + 10, sut.Experience);
        }

        [Test]
        public void HeroGetsNoExpIfTargetIsNotDead()
        {
            Mock<IWeapon> weapon = new Mock<IWeapon>();
            Mock<ITarget> target = new Mock<ITarget>();
            target.Setup(t => t.IsDead()).Returns(true);
            target.Setup(t => t.GiveExperience()).Throws(new InvalidOperationException("Target is not dead."));

            Hero hero = new Hero("Pesho", weapon.Object);

            Exception ex = Assert.Throws<InvalidOperationException>(() => hero.Attack(target.Object));
            Assert.AreEqual("Target is not dead.", ex.Message);
        }
    }
}
