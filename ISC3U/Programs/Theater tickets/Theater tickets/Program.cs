using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theater_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int U = 0; // Declare and initialize variable used for when USER inputs the amount of people visiting
            double Ticket = 0; // Declare and initialize variable use for Ticket cost calculation
            double A = 0; // Declare and initialize variable used for age
            int Count = 0; // Declare in initialize variable used to count how many seniors USER inputed
        
                Console.WriteLine("Welcome to Your name here! ");
                Console.WriteLine("What day will you be attending? ");
                Console.WriteLine(" ");
                Console.WriteLine(" Enter 1 for Sunday-Regular prices ");
                Console.WriteLine("             Monday-Closed ");
                Console.WriteLine(" Enter 2 for Tuesday-30% discount for Seniors ");
                Console.WriteLine(" Enter 3 for Wedensday-Regular prices ");
                Console.WriteLine(" Enter 4 for Thursday-25% for all visitors ");
                Console.WriteLine(" Enter 5 for Friday-Regular prices ");
                Console.WriteLine(" Enter 6 for Saturday-Regular prices ");
                int D = Convert.ToInt32(Console.ReadLine()); //Allow user to inut what they they will be  coming
                if ((D > 6) | (D < 0)) // Loops if user does not enter a valid day 
                {
                    Console.WriteLine("Pleas enter a valid day ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" Enter 1 for Sunday-Regular prices ");
                    Console.WriteLine("             Monday-Closed ");
                    Console.WriteLine(" Enter 2 for Tuesday-30% discount for Seniors ");
                    Console.WriteLine(" Enter 3 for Wedensday-Regular prices ");
                    Console.WriteLine(" Enter 4 for Thursday-25% for all visitors ");
                    Console.WriteLine(" Enter 5 for Friday-Regular prices ");
                    Console.WriteLine(" Enter 6 for Saturday-Regular prices ");
                    int D2 = Convert.ToInt32(Console.ReadLine());
                    D = D2;
                }
           
            
            Console.WriteLine("How many people will be attending? ");
            U = Convert.ToInt32(Console.ReadLine()); // User inputing how many people will be coming 

            for (int i = 1; i < U + 1; i++) // It loops for how many people will come, but starts at 1 
            {
                Console.WriteLine("What is the age of person No." + i);
                A = Convert.ToDouble(Console.ReadLine()); // User inputing age, which will be looped for how many people they chose previously
                if ((A <= 4) & (A >= 0))
                {
                    Ticket = Ticket + 0;

                }
                else if ((A <= 12) & (A > 4))
                {
                    Ticket = Ticket + 8;
                    if (i > U) // To continue the program
                    {
                        break;
                    }
                }
                else if ((A <= 19) & (A >= 13))
                {
                    Ticket = Ticket + 12;
                    if (i > U) // To continue the program
                    {
                        break;
                    }
                }
                else if ((A <= 60) & (A >= 20))
                {
                    Ticket = Ticket + 16;
                    if (i > U) // To continue the program
                    {
                        break;
                    }
                }
                else if ((A > 60) & (D!=2)) // The regular price of seniors is here 
                {
                    Ticket = Ticket + 10;
                    if (i > U) // To continue the program
                    {
                        break;
                    }
                }
                else if ((A > 60) & (D == 2)) // The 30% discount is added here
                {
                    Ticket = Ticket + 7;
                    Count = Count + 1;
                    if (i > U) // To continue the program
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid age");
                    if (i > U) // To continue the program
                    {
                        break;
                    }
                }
            }
                if ((D == 1) & (D == 3) & (D == 5) & (D == 6))
                {
                    Console.WriteLine("The cost of your Ticket is: $" + Ticket * 1.13);
                    Console.ReadLine();
                }
                if (D == 4) // 
                {
                    Ticket = Ticket-(Ticket*0.25);
                }
                else if ((D == 2) & (Count > 1)) // Setting writeline for when it is tues day and there is more than 1 senior
                {
                    Console.WriteLine("You recived a 30% discount on " + Count);
                    Console.WriteLine("seniors and the cost of your Ticket is: $" + Ticket * 1.13);
                    Console.ReadLine();
                }
                else if ((D == 2) & (Count == 1)) // Setting writeline when there is 1 senior and it is tuesday
                {
                    Console.WriteLine("You recived a 30% discount on " + Count);
                    Console.WriteLine("senior and the cost of your Ticket is: $" + Ticket * 1.13);
                    Console.ReadLine();
                }
                else if ((D == 2) & (Count == 0)) //Setting writeline for when there are no seniors and it is tuesday
                {
                    Console.WriteLine("You had no seniors, so no discount was applied, and the cost of your ticket is: $" + Ticket * 1.13);
                    Console.ReadLine();
                }
                else if (D == 4)
                {
                    Console.WriteLine("You recived a 25% discount for everyone, and the cost of your Ticket is: $" + Ticket * 1.13);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("your Ticket value is: $" + Ticket * 1.13);
                }
                Console.ReadLine();
        }
    }
}
