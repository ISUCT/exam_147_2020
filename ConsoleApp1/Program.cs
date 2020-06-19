using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Duck1 duck1 = new Duck1();
            Console.WriteLine(duck1.Display());
            Console.WriteLine(duck1.Fly());
            Console.WriteLine(duck1.Quack());
            Console.WriteLine(duck1.Swim());
        }
    }
};