using System;
using Xunit;
using Exam1;

namespace Exam1.Test
{
    public class WolfTest
    {
        [Fact]
        public void Test1()
        {
            Wolf Chacha = new Wolf("Канада","Лес");
            string location = Chacha.Location;
            string boundaries = Chacha.Boundaries;
            Assert.Equal("Канада", location);
            Assert.Equal("Лес", boundaries);
        }
        [Fact]
        public void Test2()
        {
            Wolf Chacha = new Wolf("Канада","Лес");
            string info = Chacha.Info();
            string roam = Chacha.Roam();
            string eat = Chacha.Eat();
            string noise = Chacha.MakeNoise();
            string sleep = Chacha.Sleep();
            Assert.Equal("место обитания волка - Канада, Лес", info);
            Assert.Equal("животное бродит туда-сюда", roam);
            Assert.Equal("волк поймал зайца и съел", eat);
            Assert.Equal("волк воет на луну", noise);
            Assert.Equal("животное спит", sleep);
        }
    }
}