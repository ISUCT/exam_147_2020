using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck krya = new Duck("Утьоночек", 3, 5, true);
            Console.WriteLine(krya.name);
            Console.WriteLine(krya.Age + " лет");
            Console.WriteLine($"Нас {krya.Count}");
            Console.WriteLine(krya.PlaceOfLiving());
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine(krya.Display());
        }
    }
}
