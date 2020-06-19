using System;

namespace ExamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Bishop();
            Console.WriteLine(a.X);

            var b = new Pawn();
            Console.WriteLine(b.Y);

            var c = new Rook();
            Console.WriteLine(c.Y);

            Console.ReadLine();
        }
    }
}
