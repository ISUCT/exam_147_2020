using System;

namespace CourseApp
{
public interface IFly
    {
        string Fly();
    }

public interface IQuack
    {
        string Quack();
    }

public abstract class Duck : IFly, IQuack
    {
        public static string Swim()
        {
            return "Water is acceptable.";
        }

        public abstract string Display();

        public string Fly()
        {
            return "5 minutes, flight is fine.";
        }

        public string Quack()
        {
            return "Quack-Quack!";
        }
    }
}