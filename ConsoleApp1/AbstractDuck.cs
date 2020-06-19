using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class AbstractDuck
    {
        public string Swim()
        {
            return "swim";
        }
        public abstract string Display();
    }
}
