using System.Collections.Generic;
using Xunit;

namespace ConsoleApp1
{
    public class UnitTest1
    {
        [Fact]
        public void TestSwim()
        {
            Duck1 donald = new Duck1();
            Assert.Equal("swim", donald.Swim());
        }

        [Fact]
        public void TestDisplay()
        {
            Duck1 donald = new Duck1();
            Assert.Equal("Display Duck 1", donald.Display());
        }

        [Fact]
        public void TestFly()
        {
            Duck1 donald = new Duck1();
            Assert.Equal("Fly Duck 1", donald.Fly());
        }

        [Fact]
        public void TestQuack()
        {
            Duck1 donald = new Duck1();
            Assert.Equal("Quack Duck 1", donald.Quack());
        }
    }
}
