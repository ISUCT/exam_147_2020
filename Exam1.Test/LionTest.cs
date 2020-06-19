using System;
using Xunit;
using Exam1;

namespace Exam1.Test
{
    public class LionTest
    {
        [Fact]
        public void Test1()
        {
            Lion Myla  = new Lion("Африка","Саванны");
            string location = Myla .Location;
            string boundaries = Myla .Boundaries;
            Assert.Equal("Африка", location);
            Assert.Equal("Саванны", boundaries);
        }
        [Fact]
        public void Test2()
        {
            Lion Myla  = new Lion("Африка","Саванны");
            string info = Myla .Info();
            string roam = Myla .Roam();
            string eat = Myla .Eat();
            string noise = Myla .MakeNoise();
            string sleep = Myla .Sleep();
            Assert.Equal("место обитания льва - Африка, Саванны", info);
            Assert.Equal("животное бродит туда-сюда", roam);
            Assert.Equal("Лев поймал антилопу и съел", eat);
            Assert.Equal("Лев рычит", noise);
            Assert.Equal("животное спит", sleep);
        }
    }
}