//Создайте абстрактный класс животные, содержащие поля location и boundaries. Методы sleep и roam, а также абстрактные методы makeNoize и Eat, классы наследующие класс животное — Lion и Woolf. Оба класса наследника переопределяют методы базового класса. Приведите пример использования классов наследников.

using System;

namespace app
{
    class Program
    {
        public static void Main()
        {
            Lion simba = new Lion("Africa","Savannah");
            Wolf jimmie = new Wolf("Russia","Forest");
            Console.WriteLine(simba.Info());
            Console.WriteLine(simba.Roam());
            Console.WriteLine(simba.Eat());
            Console.WriteLine(simba.MakeNoise());
            Console.WriteLine(simba.Sleep());
            Console.WriteLine(jimmie.Info());
            Console.WriteLine(jimmie.Roam());
            Console.WriteLine(jimmie.Eat());
            Console.WriteLine(jimmie.MakeNoise());
            Console.WriteLine(jimmie.Sleep());            
        }
    }
}
