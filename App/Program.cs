using System;

namespace App
{
    public class Program
    {
        public static void Main()
        {
            Duck2 donald = new Duck2();
            Console.WriteLine(donald.Display());
            Console.WriteLine(Duck2.swim());
            Console.WriteLine(donald.Fly());
            Console.WriteLine(donald.Quack());

        }
    }
}
