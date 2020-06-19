using System;

namespace App
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
            return "Утка плавает";
        }

        public abstract string Display();

        public string Fly()
        {
            return "Утка летает";
        }

        public string Quack()
        {
            return "Утка крякает";
        }
    }
}
