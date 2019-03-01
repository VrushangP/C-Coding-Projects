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

            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] array3 = new int[3, 3];
            int sum = 0;
            
            //int[type of array] grid variable = new int[size of array];
            Random rnd = new Random();
            int rando2 = rnd.Next(0, 1000);

            for (int i = 0; i < 3; i++)
            {
                for (int ii = 0; ii < 3; ii++)
                {
                    rando2 = rnd.Next(0, 1000);
                    array1[ii, i] = rando2;
                    Console.Write(array1[ii,i]+"  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            for (int i = 0; i < 3; i++)
            {
                 for (int ii = 0; ii < 3; ii++)
                {
                    rando2 = rnd.Next(0, 1000);
                    array2[ii, i] = rando2;
                    Console.Write(array2[ii, i] + "  ");
                }
                 Console.WriteLine("");
            }
            Console.WriteLine("");
            for (int i = 0; i < 3; i++)
            {
                 for (int ii = 0; ii < 3; ii++)
                {
                    sum = 0;
                    sum = array1[ii, i] + array2[ii, i];
                    array3[ii, i] = sum;
                    Console.Write(array3[ii,i]+"  ");
                }
                 Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
