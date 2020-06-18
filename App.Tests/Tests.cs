using System;
using Xunit;

namespace App.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Quack()
        {
            Duck donald = new Duck();
            string str = donald.Quack();
            Assert.Equal("Я переопределился, но против поправок, ведь я умный утенок.", str);
        }

        [Fact]
        public void Display()
        {
            Duck donald = new Duck();
            string str = donald.Display();
            Assert.Equal("У уток очень хорошее зрение. Они видят лучше людей и собак.\nТакже они воспринимают окружающий мир в полномасштабной цветовой гамме.", str);
        }

        [Fact]
        public void SpeedFly()
        {
            Duck donald = new Duck();
            Assert.Equal(50, donald.SpeedFly);
        }

        [Fact]
        public void NicknameAndAge()
        {
            Duck donald = new Duck();
            Assert.Equal("Дональд", donald.nickname);
            Assert.Equal(10, donald.age);
            donald.nickname = "Duck";
            donald.age = 15;
            Assert.Equal("Duck", donald.nickname);
            Assert.Equal(15, donald.age);
        }
    }
}
