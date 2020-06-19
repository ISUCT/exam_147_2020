using System;

namespace Exam1
{
    class Program
    {
        public static void Main()
        {
            Lion Myla = new Lion("Африка","Саванны");
            Wolf Chacha = new Wolf("Россия","Лес");
            Console.WriteLine(Myla.Info());
            Console.WriteLine(Myla.Roam());
            Console.WriteLine(Myla.Eat());
            Console.WriteLine(Myla.MakeNoise());
            Console.WriteLine(Myla.Sleep());
            Console.WriteLine(Chacha.Info());
            Console.WriteLine(Chacha.Roam());
            Console.WriteLine(Chacha.Eat());
            Console.WriteLine(Chacha.MakeNoise());
            Console.WriteLine(Chacha.Sleep());
        }
    }
}
