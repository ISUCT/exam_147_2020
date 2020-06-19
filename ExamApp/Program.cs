using System;

namespace ExamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Bishop();
            Console.WriteLine(a.Y);
            a.MakeAMove();
            Console.WriteLine(a.Y);
            Console.WriteLine("Hello World!");
        }
    }
}
