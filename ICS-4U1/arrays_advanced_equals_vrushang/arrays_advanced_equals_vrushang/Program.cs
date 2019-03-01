using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p = {0,0,0 };
            int[] q = {0, 0, 0 };
            int num = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("input value for array p: "+i);
                p[i] = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("input value for array q: " + i);
                q[i] = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }

            for (int i = 0; i < 3; i++)
            {
                if (p[i] == q[i])
                {
                    num += 1;
                }
            }
            if (num == 3)
            {
                Console.WriteLine("congradulations array p and q are equal");
            }
            else
            {
                Console.WriteLine("too bad those arrays do not match");
            }
        }
    }
}
