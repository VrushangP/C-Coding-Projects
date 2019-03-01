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
            int highestNumber = 0;
            int smallestNumber = 1000;
            string smallestCords = "";
            string HighestCords = "";
            int aveNumber = 0;

            // 2D arrays formatting
            int[,] value = new int[4, 4];
            //int[type of array] grid variable = new int[size of array];
            Random rnd = new Random();
            int rando2 = rnd.Next(0, 1000);
            for (int i = 0; i < 4; i++)
            {
                for (int ii = 0; ii < 4; ii++)
                {
                    rando2 = rnd.Next(0, 1000);
                    value[ii, i] = rando2;
                    Console.WriteLine(value[ii, i]);
                    if (value[ii,i] > highestNumber)
                    {
                        highestNumber = value[ii, i];
                        HighestCords = (ii + ", " + i);
                    }
                    if (value[ii, i] < smallestNumber)
                    {
                        smallestNumber = value[ii, i];
                        smallestCords = (ii + ", " + i);
                    }
                    aveNumber += value[ii, i];
                }
            }
            aveNumber = aveNumber/ (value.Length);
            //first value creates containers, second value initiates variables in each container
            Console.WriteLine("");
            Console.WriteLine(highestNumber);
            Console.WriteLine(HighestCords);           
            Console.WriteLine(smallestNumber);
            Console.WriteLine(smallestCords);
            Console.WriteLine(aveNumber);

            Console.ReadLine();
        }
    }
}
