using System;

namespace ExamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion simba = new Lion("Africa","Savannah");
            Console.WriteLine("Lion:");
            Console.WriteLine(simba.Sleep());
            Console.WriteLine(simba.Roam());
            Console.WriteLine(simba.Eat());
            Console.WriteLine(simba.MakeNoise());

            Wolf akela = new Wolf("India","Jungle");
            Console.WriteLine("Wolf:");
            Console.WriteLine(akela.Sleep());
            Console.WriteLine(akela.Roam());
            Console.WriteLine(akela.Eat());
            Console.WriteLine(akela.MakeNoise());
        }
    }
}
