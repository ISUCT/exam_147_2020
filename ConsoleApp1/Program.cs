using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        public static Dictionary<string, string> Func(Dictionary<string, Dictionary<string, Dictionary<string, string>>> dict)
        {
            Dictionary<string, string> dictresult = new Dictionary<string, string>();
            string path = "";
            foreach (var a in dict)
            {
                    path = a.Key + "/";
                    foreach (var b in a.Value)
                    {
                            path += b.Key + "/";
                            foreach (var c in b.Value)
                            {
                                 dictresult.Add(path + c.Key, c.Value);
                            }
                    }
            }
            return dictresult;
        }
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> dict = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            dict.Add("a", new Dictionary<string, Dictionary<string, string>>());
            dict["a"].Add("b", new Dictionary<string, string>());
            dict["a"]["b"].Add("c", "12");
            dict["a"]["b"].Add("d", "Hello World");
            foreach (var a in Func(dict))
            {
                Console.Write(a + " ");
            }
        }
    }
};