using System;

namespace exam_147_2020
{
    class Program
    {
        public static void Main()
        {
            Lion neb = new Lion("Africa","Savanna");
            Wolf bonk = new Wolf("USA","Brooklyn");
            
            Console.WriteLine( neb.Info() );
            Console.WriteLine( neb.Roam() );
            Console.WriteLine( neb.Eat() );
            Console.WriteLine( neb.MakeNoise() );
            Console.WriteLine( neb.Sleep() );
            Console.WriteLine("\n");
            Console.WriteLine( bonk.Info() );
            Console.WriteLine( bonk.Roam() );
            Console.WriteLine( bonk.Eat() );
            Console.WriteLine( bonk.MakeNoise() );
            Console.WriteLine( bonk.Sleep() );            
        }
    }
}
