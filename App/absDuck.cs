using System;

namespace App
{
    public abstract class absDuck : IFly, IQuack
    {
        public string FlightDirection()
        {
            return "Я улетаю на юг!!!";
        }
        public virtual int Count { get; set; }
        public virtual string PlaceOfLiving()
        {
            return "Я уточка, живу где хочу";
        }
        public static string Swim()
        {
            return "Утки хорошо держатся на поверхности воды благодаря форме тела — оно у неё сплюснутое";
        }

        public abstract string Display();
    }
}
