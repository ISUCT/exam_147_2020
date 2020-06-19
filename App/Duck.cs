using System;

namespace App
{
    public class Duck : absDuck
    {
        public string name;
        public int count;
        public bool isLake;
        public int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if ( age >= 0 && age < 20)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Установите возраст от 0 до 20");
                }
            }
        }
        public Duck(string name, int age, int count, bool isLake) { this.name = name; Age = age;  Count = count; this.isLake = isLake; }

        public override int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value; 
            }
        }

        public override string PlaceOfLiving()
        {
            if (isLake == true)
            {
                return "Я живу на озере, если что";
            }
            else
            {
                return "Живу на реке, держу в курсе";
            }
        }

        public override string Display()
        {
            return "Уточки - милые создания";
        }


    }
}