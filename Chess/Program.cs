using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Pawn("Белый");
            Figure figure1 = new Knight("Черный");
            Figure figure2 = new Rook("Белый");
            Console.WriteLine(figure.Eat(figure1));
            Console.WriteLine(figure1.Eat(figure2));
            Console.WriteLine(figure.Walk());
            Console.WriteLine(figure1.Walk());
            Console.WriteLine(figure2.Walk());
        }
    }
}
