using System;
using System.Collections.Generic;

namespace exApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static List<int[]> GetZeroSumms(List<int> list)
        {
            List<int> vvod = list;
            vvod.Sort();
            List<int[]> result = new List<int[]>();
            int f = 0;
            int j = vvod.Count - 1;
            while (j > f)
            {
                if (vvod[f] == 0 - vvod[j])
                {
                    result.Add(new int[2] { vvod[f], vvod[j] });
                    f++;
                }
                else
                {
                    if (Math.Abs(vvod[j]) > Math.Abs(vvod[f]))
                    {
                        j--;
                    }
                    else
                    {
                        f++;
                    }
                }
                
            }

            return result;
        }
    }

}
