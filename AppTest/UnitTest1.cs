using System;
using Xunit;
using App;

namespace AppTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Duck2 donald = new Duck2();
            string s = Duck2.swim();
            Assert.Equal("Утка плавает по озеру", s);
        }

        [Fact]
        public void Test2()
        {
            Duck2 donald = new Duck2();
            string d = donald.Display();
            Assert.Equal("Я утка", d);
        }

        [Fact]
        public void Test3()
        {
            Duck2 donald = new Duck2();
            string f = donald.Fly();
            Assert.Equal("Утка летает", f);
        }

        [Fact]
        public void Test4()
        {
            Duck2 donald = new Duck2();
            string q = donald.Quack();
            Assert.Equal("Утка крякает", q);
        }
    }
}