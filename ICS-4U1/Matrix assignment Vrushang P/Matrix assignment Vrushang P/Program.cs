
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static void generateMatrix()
        {
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] array3 = new int[3, 3];

            Random rnd = new Random();
            int rando2 = rnd.Next(0, 9);
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
            for (int i = 0; i < 3; i++)
            {
                for (int ii = 0; ii < 3; ii++)
                {
                    rando2 = rnd.Next(0, 9);
                    array1[ii, i] = rando2;
                    if (ii == 0 && i == 0)
                    {
                        Console.Write("First Array : " + array1[ii, i] + "  ");
                    }
                    else if (ii == 0 && i != 0)
                    {
                        Console.Write("              " + array1[ii, i] + "  ");
                    }
                    else
                    {
                        Console.Write(array1[ii, i] + "  ");
                    }

                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.ReadLine();
        }

        public static void generateTranspose()
        {
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] array3 = new int[3, 3];

            Random rnd = new Random();
            int rando2 = rnd.Next(0, 9);
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
            for (int i = 0; i < 3; i++)
            {
                for (int ii = 0; ii < 3; ii++)
                {
                    rando2 = rnd.Next(0, 9);
                    array1[ii, i] = rando2;
                    if (ii == 0 && i == 0)
                    {
                        Console.Write("First Array :  | " + array1[ii, i] + "   | ");
                    }
                    else if (ii == 0 && i != 0)
                    {
                        Console.Write("               | " + array1[ii, i] + "   | ");
                    }
                    else
                    {
                        Console.Write(array1[ii, i] + "   | ");
                    }

                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");

            for (int i = 0; i < 3; i++)
            {
                for (int ii = 0; ii < 3; ii++)
                {
                    if (ii == 0 && i == 0)
                    {
                        Console.Write("Second Array : | " + array1[i, ii] + "   | ");
                    }
                    else if (ii == 0 && i != 0)
                    {
                        Console.Write("               | " + array1[i, ii] + "   | ");
                    }
                    else
                    {
                        Console.Write(array1[i, ii] + "   | ");
                    }

                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
        public static void multiplyMatrixByConstant()
        {
            int[,] array1 = new int[3, 2];
            int[,] array2 = new int[2, 3];
            int[,] array3 = new int[2, 2];

            Console.WriteLine("the constent that the matrix is multiplied by is :");
            int num = Convert.ToInt16(Console.ReadLine());

            Random rnd = new Random();
            int rando2 = rnd.Next(0, 9);
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");

            for (int vert1 = 0; vert1 < 2; vert1++)
            {
                for (int hor1 = 0; hor1 < 3; hor1++)
                {
                    if (vert1 == 0 && hor1 == 0)
                    {
                        rando2 = rnd.Next(0, 9);
                        array1[hor1, vert1] = rando2;
                        Console.Write("First Array:     | " + array1[hor1, vert1] + "      | ");
                    }
                    else if (hor1 == 0 && vert1 != 0)
                    {
                        rando2 = rnd.Next(0, 9);
                        array1[hor1, vert1] = rando2;
                        Console.Write("                 | " + array1[hor1, vert1] + "      | ");
                    }
                    else
                    {
                        rando2 = rnd.Next(0, 9);
                        array1[hor1, vert1] = rando2;
                        Console.Write(array1[hor1, vert1] + "      | ");
                    }

                }
                Console.WriteLine("");

            }
            Console.WriteLine("");
            Console.WriteLine("");
            for (int vert1 = 0; vert1 < 2; vert1++)
            {
                for (int hor1 = 0; hor1 < 3; hor1++)
                {
                    if (hor1 == 0)
                    {
                        Console.Write("                 | " + array1[hor1, vert1] + " *  " + num + " | ");
                    }
                    else
                    {
                        Console.Write(array1[hor1, vert1] + " *  " + num + " | ");
                    }

                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            for (int vert1 = 0; vert1 < 2; vert1++)
            {
                for (int hor1 = 0; hor1 < 3; hor1++)
                {
                    if (hor1 == 0)
                    {
                        array1[hor1, vert1] = array1[hor1, vert1] * num;
                        if (array1[hor1, vert1] > 9)
                        {
                            Console.Write("                 | " + array1[hor1, vert1] + "  ");
                        }
                        else
                        {
                            Console.Write("                 | " + array1[hor1, vert1] + "   ");
                        }
                    }
                    else
                    {
                        array1[hor1, vert1] = array1[hor1, vert1] * num;

                        if (array1[hor1, vert1] > 9)
                        {
                            Console.Write("   | " + array1[hor1, vert1] + "  ");
                        }
                        else
                        {
                            Console.Write("    | " + array1[hor1, vert1] + "  ");
                        }
                    }

                }
                Console.WriteLine("");
            }
            Console.ReadLine();


        }
        public static void multiplyMatrix()
        {
            int[,] array1 = new int[3, 2];
            int[,] array2 = new int[2, 3];
            int[,] array3 = new int[2, 2];

            Random rnd = new Random();
            int rando2 = rnd.Next(0, 9);
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
            for (int vert1 = 0; vert1 < 2; vert1++)
            {
                for (int hor1 = 0; hor1 < 3; hor1++)
                {
                    if (vert1 == 0 && hor1 == 0)
                    {
                        rando2 = rnd.Next(0, 9);
                        array1[hor1, vert1] = rando2;
                        Console.Write("First Array:       " + array1[hor1, vert1] + "    ");
                    }
                    else if (hor1 == 0 && vert1 != 0)
                    {
                        rando2 = rnd.Next(0, 9);
                        array1[hor1, vert1] = rando2;
                        Console.Write("                   " + array1[hor1, vert1] + "    ");
                    }
                    else
                    {
                        rando2 = rnd.Next(0, 9);
                        array1[hor1, vert1] = rando2;
                        Console.Write(array1[hor1, vert1] + "    ");
                    }

                }
                Console.WriteLine("");

            }
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
            for (int vert2 = 0; vert2 < 3; vert2++)
            {
                for (int hor2 = 0; hor2 < 2; hor2++)
                {
                    if (vert2 == 0 && hor2 == 0)
                    {
                        rando2 = rnd.Next(0, 9);
                        array2[hor2, vert2] = rando2;
                        Console.Write("Second Array:      " + array1[hor2, vert2] + "    ");
                    }
                    else if (hor2 == 0 && vert2 != 0)
                    {
                        rando2 = rnd.Next(0, 9);
                        array2[hor2, vert2] = rando2;
                        Console.Write("                   " + array2[hor2, vert2] + "    ");
                    }
                    else
                    {
                        rando2 = rnd.Next(0, 9);
                        array2[hor2, vert2] = rando2;
                        Console.Write(array2[hor2, vert2] + "    ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");

            int val = 0;
            for (int vert3 = 0; vert3 < 2; vert3++)
            {
                for (int hor3 = 0; hor3 < 2; hor3++)
                {
                    if (vert3 == 0)
                    {
                        for (int third = 0; third < 3; third++)
                        {
                            val += array1[third, hor3] * array2[hor3, third];
                        }
                    }
                    if (vert3 == 1)
                    {
                        for (int third = 0; third < 3; third++)
                        {
                            val += array1[third, vert3] * array2[vert3, third];
                        }
                    }
                    array3[vert3, hor3] = val;
                    if (vert3 == 0 && hor3 == 0)
                    {
                        Console.Write("Multiplied Matrix: ");
                        if (val > 9 && val < 100)
                        {
                            Console.Write(array3[vert3, hor3] + "   ");
                        }
                        else if (val > 99)
                        {
                            Console.Write(array3[vert3, hor3] + "  ");
                        }
                        else if (val < 10)
                        {
                            Console.Write(array3[vert3, hor3] + "    ");
                        }

                    }
                    else if (hor3 == 0 && vert3 != 0)
                    {
                        Console.Write("                   ");
                        if (val > 9 && val < 100)
                        {
                            Console.Write(array3[vert3, hor3] + "   ");
                        }
                        else if (val > 99)
                        {
                            Console.Write(array3[vert3, hor3] + "  ");
                        }
                        else if (val < 10)
                        {
                            Console.Write(array3[vert3, hor3] + "    ");
                        }
                    }
                    else
                    {
                        if (val > 9 && val < 100)
                        {
                            Console.Write(array3[vert3, hor3] + "   ");
                        }
                        else if (val > 99)
                        {
                            Console.Write(array3[vert3, hor3] + "  ");
                        }
                        else if (val < 10)
                        {
                            Console.Write(array3[vert3, hor3] + "    ");
                        }
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
        public static void newmethod()
        {
            int input = Convert.ToInt16(Console.ReadLine());
            if (input == 1)
            {
                generateMatrix();
            }
            else if (input == 2)
            {
                generateTranspose();
            }
            else if (input == 3)
            {
                multiplyMatrixByConstant();
            }
            else if (input == 4)
            {
                multiplyMatrix();
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("        ----------Welcome to the Matrix Program!---------------");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1: The Random Matrix");
            Console.WriteLine("2: The Transpose Matrix");
            Console.WriteLine("3: Multiplying a Matrix by a Constant");
            Console.WriteLine("4: Multiplying Two Matrices");
            Console.Write("Your choice is:");
            newmethod();

            Console.WriteLine("        ----------Welcome to the Matrix Program!---------------");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1: The Random Matrix");
            Console.WriteLine("2: The Transpose Matrix");
            Console.WriteLine("3: Multiplying a Matrix by a Constant");
            Console.WriteLine("4: Multiplying Two Matrices");
            Console.Write("Your choice is:");
            newmethod();

        }
    }
}


