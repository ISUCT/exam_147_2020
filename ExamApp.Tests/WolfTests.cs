using System;
using Xunit;

namespace ExamApp.Tests
{
    public class WolfTests
    {
        [Fact]
        public void ZeroParameters()
        {
            Wolf wolf = new Wolf();
            string location = wolf.Location;
            string boundaries = wolf.Boundaries;
            Assert.Equal("World",location);
            Assert.Equal("Unknown",boundaries);
        }
        [Fact]
        public void Create()
        {
            Wolf wolf = new Wolf("Russia","Forest");
            string location = wolf.Location;
            string boundaries = wolf.Boundaries;
            Assert.Equal("Russia", location);
            Assert.Equal("Forest", boundaries);
        }
        [Fact]
        public void TestMethods()
        {
            Wolf wolf = new Wolf("Russia","Forest");
            Assert.Equal("Wolf is asleep.",wolf.Sleep());
            Assert.Equal("The wolf eats the rabbit.",wolf.Eat());
            Assert.Equal("The wolf howls at the moon.",wolf.MakeNoise());
            string location = wolf.Location;
            string boundaries = wolf.Boundaries;
            Assert.Equal($"Wolf roams - {location},{boundaries}.",wolf.Roam());
        }
        [Fact]
        public void TestNull()
        {
            Wolf wolf = new Wolf("Russia","Forest");
            wolf.Boundaries = null;
            wolf.Location = null;
            Assert.Equal("Russia",wolf.Location);
            Assert.Equal("Forest",wolf.Boundaries);
        }
    }
}
