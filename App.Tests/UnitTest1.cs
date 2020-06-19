using System;
using Xunit;

namespace App.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Display()
        {
            Duck duck = new Duck("Утьоночек", 3, 5, true);
            string str = duck.Display();
            Assert.Equal("Уточки - милые создания", str);
        }

        [Fact]
        public void Area()
        {
            Duck duck = new Duck("Утьоночек", 3, 5, true);
            string str = duck.PlaceOfLiving();
            Assert.Equal("Я живу на озере, если что", str);
            Duck duck2 = new Duck("Дональд", 4, 10, false);
            string str2 = duck2.PlaceOfLiving();
            Assert.Equal("Живу на реке, держу в курсе", str2);
        }

        [Fact]
        public void FlightDirection()
        {
            Duck duck = new Duck("Утьоночек", 3, 5, true);
            string str = duck.FlightDirection();
            Assert.Equal("Я улетаю на юг!!!", str);
        }
    }
}
