using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DuckTest
    {
        [Fact]
        public void Test1()
        {
            Drake a = new Drake();
            string s = Drake.Swim();
            Assert.Equal("Water is acceptable.", s);
        }

        [Fact]
        public void Test2()
        {
            Drake a = new Drake();
            string d = a.Display();
            Assert.Equal("Kono Ahiru Da!", d);
        }

        [Fact]
        public void Test3()
        {
            IFly a = new Drake();
            string f = a.Fly();
            Assert.Equal("5 minutes, flight is fine.", f);
        }

        [Fact]
        public void Test4()
        {
            IQuack a = new Drake();
            string q = a.Quack();
            Assert.Equal("Quack-Quack!", q);
        }
    }
}
