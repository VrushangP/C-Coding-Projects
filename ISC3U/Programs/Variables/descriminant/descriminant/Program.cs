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
            double a = 4;
            double descriminant = 4;
            Console.Write(" Enter a :");
            a = Convert.ToDouble(Console.ReadLine());

            descriminant = a * a + a / 3;
            
            Console.Write(" descriminant ");
            Console.Write(descriminant);
            Console.ReadLine();






        }
    }
}
