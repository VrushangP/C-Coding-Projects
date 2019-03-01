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

            int[] numbers = new int[1000];
            int highestnum = 0;

            Random rnd = new Random();
            int rando2 = rnd.Next(0, 1000);

            for (int i = 0; i < 50; i++)
            {
               rando2 = rnd.Next(0, 1000);
               numbers[i] = rando2; 
            }
            foreach (var element in numbers)
            {
                Console.WriteLine(element);

                if (element > highestnum)
                {
                    highestnum = element;
                }
            }
            Console.WriteLine();
            Console.WriteLine(highestnum);
            Console.ReadLine();
	

        }
    }
}
