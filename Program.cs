using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Print your first and last name:"); // asking user input
            string userName = Console.ReadLine(); // parsing and saving the variable
            while (true) // while loop
            {
                Console.WriteLine("Please enter a number between 1 to 100"); // asking user input
                int userInput = int.Parse(Console.ReadLine()); // parsing and saving the variable

                if (userInput >100 || userInput <1) // rulling out the invalid number from the user
                {
                    Console.WriteLine(" the number is not within the range");
                }
                // using if/else statement to run the process and reading console writeline for the output in the following
               else if (userInput % 2 != 0)
                {
                    Console.WriteLine("{0} is odd", userInput);
                }
                else if (userInput % 2 == 0 && userInput >= 2 && userInput < 25)
                {

                    Console.WriteLine("{0} is even &  less than 25 ", userInput);
                }
                else if (userInput % 2 == 0 && userInput > 60)
                {
                    Console.WriteLine("{0} is even ", userInput);
                }

                else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60)
                {

                    Console.WriteLine("{0} is even ", userInput);
                }
                else if (userInput % 2 == 1 && userInput > 60)
                {
                    Console.WriteLine("{0} is odd ", userInput);

                }
                      

                Console.WriteLine("Do you want to continue? Y/N"); 
                string input1 = Console.ReadLine().ToUpper();
                               
                if (input1 == "N")
                {
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}

    

