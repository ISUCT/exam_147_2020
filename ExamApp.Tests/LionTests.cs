using System;
using Xunit;

namespace ExamApp.Tests
{
    public class LionTests
    {
        [Fact]
        public void ZeroParameters()
        {
            Lion simba = new Lion();
            string location = simba.Location;
            string boundaries = simba.Boundaries;
            Assert.Equal("World",location);
            Assert.Equal("Unknown",boundaries);
        }
        [Fact]
        public void Create()
        {
            Lion simba = new Lion("Африка","Саванны");
            string location = simba.Location;
            string boundaries = simba.Boundaries;
            Assert.Equal("Африка", location);
            Assert.Equal("Саванны", boundaries);
        }
        [Fact]
        public void TestMethods()
        {
            Lion simba = new Lion("Африка","Саванны");
            Assert.Equal("Lion is asleep.",simba.Sleep());
            Assert.Equal("A lion has caught a Zebra and is eating it.",simba.Eat());
            Assert.Equal("The lion roars.",simba.MakeNoise());
        }
    }
}
