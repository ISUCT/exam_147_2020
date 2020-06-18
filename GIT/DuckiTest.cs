using System;
using Xunit;
using Git;


namespace DuckiTest

{
    public class DuckiTest
    {
        public void Test1()
        {
            Duckinator utkonos = new Duckinator();
            string a = Duckinator.swim();
            Assert.Equal("Duckinator всплыл", a);
        }


        public void Test2()
        {
            Duckinator utkonos = new Duckinator();
            string b = utkonos.Display();
            Assert.Equal("I Duckinator", b);
        }

        public void Test3()
        {
            Duckinator utkonos = new Duckinator();
            string c = utkonos.Fly();
            Assert.Equal("Duckinator пробил луну", c);
        }

        public void Test4()

        {
            Duckinator utkonos = new Duckinator();
            string d = utkonos.Quack();
            Assert.Equal("Dukinaaaaaaaaaaaaaaaaaaaaaaaaator", d);
        }
    }
}
