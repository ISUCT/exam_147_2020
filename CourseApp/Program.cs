using System;

namespace CourseApp
{
   public class Program
{
public static void Main()
        {
            Drake a = new Drake();
            Console.WriteLine(a.Display());
            Console.WriteLine(Drake.Swim());
            Console.WriteLine(a.Fly());
            Console.WriteLine(a.Quack());
        }
}
}