using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator_If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0;
            double H = 0;
            double r = 0;
            double Cube = 0;
            double Cone = 0;
            double Sphere = 0;
            double Cylinder = 0;


            Console.WriteLine("Welcome to the volume calculator 2.5 ");
            Console.WriteLine("Enter 1 to calculate volume of a Cube");
            Console.WriteLine("Enter 2 to calculate volume of a Cone");
            Console.WriteLine("Enter 3 to calculate volume of a Sphere");
            Console.WriteLine("Enter 4 to calculate volume of a Cylinder");
            int Userinput = Convert.ToInt32(Console.ReadLine());
            if (Userinput == 1)
            {
                Console.WriteLine("Input the Value of A for a cube ");
                A = Convert.ToDouble(Console.ReadLine());
                Cube = A * A * A;

                Console.WriteLine("The Vomule of the Cube is : ");
                Console.Write(Cube);
                Console.ReadLine();

            }
            if (Userinput == 2)
            {
                Console.WriteLine("Input the Value of radius for the base of a Cone ");
                r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the Value of Height of the Cone ");
                H = Convert.ToDouble(Console.ReadLine());
                Cone = 1 * 3.146 * (r * r) * H / 3;

                Console.WriteLine("The Vomule of the Cone is : ");
                Console.Write(Cone);
                Console.ReadLine();
            }
            if (Userinput == 3)
            {
                Console.WriteLine("Input the Value of radius for a Sphere ");
                r = Convert.ToDouble(Console.ReadLine());
                Sphere = 4 * 3.246 * (r * r * r) / 3;

                Console.WriteLine("The Vomule of the Sphere is : ");
                Console.Write(Sphere);
                Console.ReadLine();
            }
           
            if (Userinput == 4)
            {
                Console.WriteLine("Input the Value of radius for a Cylinder ");
                r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the Value of the Height of a Cylinder ");
                H = Convert.ToDouble(Console.ReadLine());
                Cylinder = 3.246 * (r * r) * H;

                Console.WriteLine("The Vomule of the Cylinder is : ");
                Console.Write(Cylinder);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid value");
                ;
            }

           

           





        }
    }
}
