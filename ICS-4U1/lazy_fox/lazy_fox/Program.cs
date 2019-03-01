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

            
            int N = Convert.ToInt16(Console.ReadLine());
            int[,] local = new int[N, 25];
            
            int[] possibledis = new int[N];
            int[] currentpos = { 0, 0 };
            int x = 0;
            int y = 1;
            int maxdis = 0;
            int checkloop = 0;
            int numoftreat = 0;
            int localmaxdis = 100000000;
            int neighbornumber = 0;




            for (int i = 0; i <= N; i++)
            {

                
                string[] z = Console.ReadLine().Split(' ');
                int[] number = new int[z.Length];
                for (int w = 0; w < z.Length; w++)
                {
                    local[N, w] = Convert.ToInt32(z[w]);
                }
            }

            location:
            for (int i = 0; i <= N; i++)
            {
                possibledis[N] = (currentpos[x] - local[N, x]) * (currentpos[x] - local[N, x]) + (currentpos[y] - local[N, y]) * (currentpos[y] - local[N, y]);

                if (possibledis[N] > maxdis && possibledis[N] < localmaxdis)
                {
                    maxdis = possibledis[N];
                    neighbornumber = N;
                    checkloop += 1;
                }
                if (i == N && checkloop == 0)
                {
                    goto newlocation;
                }
            }
            currentpos[x] = local[neighbornumber, x];
            currentpos[y] = local[neighbornumber, y];
            numoftreat += 1;
            checkloop = 0;
            localmaxdis = maxdis;
            goto location;

        newlocation:

            Console.WriteLine(numoftreat);


            //    //Read line, and split it by whitespace into an array of strings
            //string[] tokens = Console.ReadLine().Split();

            ////Parse element 0
            //int a = int.Parse(tokens[0]);

            ////Parse element 1
            //int b = int.Parse(tokens[1]);

        }
    }
}
