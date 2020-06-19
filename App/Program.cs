using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck donald = new Duck();
            donald.Distance = 40.0F;
            float flightTime = donald.Distance / donald.SpeedFly;
            Console.WriteLine("============================================================");
            Console.WriteLine(donald.nickname);
            Console.WriteLine(donald.age + " лет");
            Console.WriteLine($"Время полета (в часах) = {flightTime}");
            Console.WriteLine(donald.Quack());
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine(donald.Display());
            Console.WriteLine("============================================================");
        }
    }
}
