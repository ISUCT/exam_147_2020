using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlenaSheshotovaExam
{
    public class Program
    {
        public static Random random;


        static void Main(string[] args)
        {
            random = new Random();


            // исходные данные
            IWeapon weapon = new Bow("Супер Магический жезл", 5);
            Wizard actual = new Wizard("Алена", 70, 0, weapon, 5);
            double expected = 85;


            // получение значения 
            actual.Healing(10);


            // сравнение ожидаемого результата с полученным
          //  Assert.AreEqual(expected, actual.Armor);

            Console.ReadLine();
        }
    }
}
