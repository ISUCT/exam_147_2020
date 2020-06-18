using System;

namespace Git
{
    public class Program
    {
        public static void Main()
        {
            Duckinator utkonos = new Duckinator();
            Console.WriteLine(utkonos.Display());
            Console.WriteLine(Duckinator.swim());
            Console.WriteLine(utkonos.Fly());
            Console.WriteLine(utkonos.Quack());
        }
    }
}