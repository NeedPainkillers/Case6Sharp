using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Kaspersky
{
    class Program
    {
       /// <summary>
       /// Переписал бы это используя рефлексию, но времени не хватит
       /// </summary>
        static void case6s()
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No data");
                return;
            }

            int n = 0;
            int f = 0;
            int s = 0;
            int t = 0;
            int fo = 0;
            string err = "";
            foreach (var item in input.Split(','))
            {
                if (item.Equals("None") || item.Equals("0"))
                    n++;
                else
                if (item.Equals("First") || item.Equals("1"))
                    f++;
                else
                if (item.Equals("Second") || item.Equals("2"))
                    s++;
                else
                if (item.Equals("Third") || item.Equals("3"))
                    t++;
                else
                if (item.Equals("Fourth") || item.Equals("4"))
                    f++;
                else
                {
                    if (string.IsNullOrEmpty(err))
                        err = item;
                    else
                        err += "," + item;
                }
            }
            Console.WriteLine($"Input data types:");
            Console.WriteLine($"None(0)-{n}");
            Console.WriteLine($"First(1)-{f}");
            Console.WriteLine($"Second(2)-{s}");
            Console.WriteLine($"Third(3)-{t}");
            Console.WriteLine($"Fourth(4)-{fo}");
            Console.WriteLine($"Errors:");
            Console.WriteLine($"Not valid input strings: {err}");
        }

        static void Main(string[] args)
        {
            case6s();
        }
    }
}
//