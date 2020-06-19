using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Duck1 : AbstractDuck, IFly, IQuack
    {
        public override string Display()
        {
            return ("Display Duck 1");
        }
        public string Fly()
        {
            return ("Fly Duck 1");
        }
        public string Quack()
        {
            return ("Quack Duck 1");
        }
    }
}
