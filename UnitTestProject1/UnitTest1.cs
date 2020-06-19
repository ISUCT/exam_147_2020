using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlenaSheshotovaExam;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAttack()
        {
            // исходные данные
            IWeapon weapon = new Sword("Супер Меч", 5);
            Hero actual = new Hero("Алена", 70, 2, weapon);
            double expected = 67;


            // получение значения 
            actual.Attack(actual);


            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual.Health);
        }

        [TestMethod]
        public void TestAbilitySword()
        {
            // исходные данные
            IWeapon weapon = new Sword("Супер Меч", 5);
            Hero actual = new Hero("Алена", 70, 2, weapon);
            double expected = 80;


            // получение значения 
            actual.Weapon.UseAbility(actual);


            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual.Health);
        }

        [TestMethod]
        public void TestAbilityBow()
        {
            // исходные данные
            IWeapon weapon = new Bow("Супер Лук", 5);
            Hero actual = new Hero("Алена", 70, 0, weapon);
            double expected = 60;


            // получение значения 
            actual.Weapon.UseAbility(actual);


            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual.Health);
        }

        [TestMethod]
        public void TestAbilityMagicWand()
        {
            // исходные данные
            IWeapon weapon = new MagicWand("Супер Магический жезл", 5);
            Hero actual = new Hero("Алена", 70, 10, weapon);
            double expected = 0;


            // получение значения 
            actual.Weapon.UseAbility(actual);


            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual.Armor);
        }

        [TestMethod]
        public void TestWizardHealing()
        {
            // исходные данные
            IWeapon weapon = new Bow("Супер лук", 5);
            Wizard actual = new Wizard("Алена", 70, 0, weapon, 5);
            double expected = 85;


            // получение значения 
            actual.Healing(10);


            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual.Health);
        }

        [TestMethod]
        public void TestOnceUseAbility()
        {
            // исходные данные
            IWeapon weapon = new Bow("Супер Лук", 5);
            Hero actual = new Hero("Алена", 70, 0, weapon);
            double expected = 60;


            // получение значения 
            actual.Weapon.UseAbility(actual);
            actual.Weapon.UseAbility(actual);
            actual.Weapon.UseAbility(actual);
            actual.Weapon.UseAbility(actual);


            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual.Health);
        }

        [TestMethod]
        public void TestMakeDamage()
        {
            // исходные данные
            IWeapon weapon = new Sword("Супер Меч", 5);
            Hero hero = new Hero("Алена", 70, 3, weapon);
            double expected = 2;


            // получение значения 
            double actual = hero.Weapon.MakeDamage(hero.Armor);


            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
    }
    
}
