using System;


namespace Git
{
    interface IFly
    {
        string Fly();
    }

    interface IQuack
    {
        string Quack();
    }

    public abstract class Duck : IFly, IQuack
    {
        public static string swim()
        {
            return "Swiu";
        }

        public abstract string Display();

        public string Fly()
        {
            return "Утка косплеит Falcon X";
        }

        public string Quack()
        {
            return "Qurack";
        }
    }

}