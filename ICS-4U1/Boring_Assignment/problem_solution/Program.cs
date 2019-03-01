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

            bool[,] array = new bool[200, 401];
                bool mine = true;

                    for(int vertical = 0; vertical < 7; vertical++){
	                    for(int horizontal = 199; horizontal < 214; horizontal++){

	                                if (horizontal == 199)
	                                {
		                                if (vertical == 4|| vertical == 5|| vertical ==6)
		                                {
   			                                array[vertical, horizontal] = false;
		                                }
	                                }
	                                if (horizontal == 201 || horizontal == 202|| horizontal == 206)
	                                {
		                                if (vertical == 2||vertical ==6)
		                                {
   			                                array[vertical, horizontal] = false;
		                                }
	                                }
	                                if (horizontal == 203 || horizontal == 205)
	                                {
		                                if (vertical == 2||vertical == 3||vertical == 4|| vertical==6)
		                                {
   			                                array[vertical, horizontal] = false;
		                                }
	                                }
                                        if (horizontal == 207)
	                                {
		                                if (vertical == 2||vertical == 3||vertical == 4||vertical == 5||vertical == 6)
		                                {
   			                                array[vertical, horizontal] = false;
		                                }
	                                }
                                            if (horizontal == 200)
	                                {
		                                if (vertical == 0||vertical == 1||vertical == 2||vertical == 6)
		                                {
   			                                array[vertical, horizontal] = false;
		                                }
	                                }
                                     if (horizontal == 204)
	                                {
		                                if (vertical == 4||vertical == 6)
		                                {
   			                                array[vertical, horizontal] = false;
		                                }
	                                }
		                            else
		                            {
		                            array[vertical, horizontal] = true;
		                            }
	                            }
                            }

             	// Input string.
        string input = Console.ReadLine();
        char[] newarray2 = input.ToCharArray();
        int count = 0;
        // Loop through array.
        int Ldirection = 0;
        int Ddirection = 0;
        int Rdirection = 0;
        int Qdirection = 0;

        foreach (char newval in newarray2)
        {
            if (count == 0)
            {
                if (newval == 'l')
                {
                    Ldirection = newarray2[2];
                }
                if (newval == 'd')
                {
                    Ddirection = newarray2[2];
                }
                if (newval == 'r')
                {
                    Rdirection = newarray2[2];
                }
                if (newval == 'q')
                {
                    Qdirection = newarray2[2];
                }
            }
            count++;
        }
        int v = 5;
        int h = 199;
        int newvert = 0;
        int newhort = 0;
        // Use ToCharArray to convert string to array.
        for (int i = 0; i < Ldirection; i++)
        {
            newvert = Ldirection + v;
            if (array[v, h] == array[v, h])
            {
                
            }
             
        }


        }
    }
}
