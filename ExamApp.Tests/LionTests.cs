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
            Lion simba = new Lion("Africa","Savanna");
            string location = simba.Location;
            string boundaries = simba.Boundaries;
            Assert.Equal("Africa", location);
            Assert.Equal("Savanna", boundaries);
        }
        [Fact]
        public void TestMethods()
        {
            Lion simba = new Lion("Africa","Savana");
            Assert.Equal("Lion is asleep.",simba.Sleep());
            Assert.Equal("A lion has caught a Zebra and is eating it.",simba.Eat());
            Assert.Equal("The lion roars.",simba.MakeNoise());
            string location = simba.Location;
            string boundaries = simba.Boundaries;
            Assert.Equal($"Lion roams - {location},{boundaries}.",simba.Roam());
        }
        [Fact]
        public void TestNull()
        {
            Lion simba = new Lion("Africa","Savana");
            simba.Boundaries = null;
            simba.Location = null;
            Assert.Equal("Africa",simba.Location);
            Assert.Equal("Savana",simba.Boundaries);
        }
    }
}
