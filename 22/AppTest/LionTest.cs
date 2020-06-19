using System;
using Xunit;
using app;

namespace apptest
{
    public class LionTest
    {
        [Fact]
        public void Test1()
        {
            Lion simba = new Lion("Africa","Savannah");
            string location = simba.Location;
            string boundaries = simba.Boundaries;
            Assert.Equal("Africa", location);
            Assert.Equal("Savannah", boundaries);
        }
        [Fact]
        public void Test2()
        {
            Lion simba = new Lion("Africa","Savannah");
            string info = simba.Info();
            string roam = simba.Roam();
            string eat = simba.Eat();
            string noise = simba.MakeNoise();
            string sleep = simba.Sleep();
            Assert.Equal("the habitat of the lion - Africa, Savannah", info);
            Assert.Equal("the animal walks", roam);
            Assert.Equal("lion caught the Zebra and ate", eat);
            Assert.Equal("lion growled loudly", noise);
            Assert.Equal("the animal is asleep", sleep);            
        }
    }
}
