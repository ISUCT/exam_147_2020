using System;
using Xunit;
using app;

namespace apptest
{
    public class WolfTest
    {
        [Fact]
        public void Test1()
        {
            Wolf jimmie = new Wolf("Russia","Forest");
            string location = jimmie.Location;
            string boundaries = jimmie.Boundaries;
            Assert.Equal("Russia", location);
            Assert.Equal("Forest", boundaries);
        }
        [Fact]
        public void Test2()
        {
            Wolf jimmie = new Wolf("Russia","Forest");
            string info = jimmie.Info();
            string roam = jimmie.Roam();
            string eat = jimmie.Eat();
            string noise = jimmie.MakeNoise();
            string sleep = jimmie.Sleep();
            Assert.Equal("habitat of a wolf - Russia, Forest", info);
            Assert.Equal("the animal walks", roam);
            Assert.Equal("wolf caught the hare and ate", eat);
            Assert.Equal("wolf howls at the moon", noise);
            Assert.Equal("the animal is asleep", sleep);            
        }
    }
}
