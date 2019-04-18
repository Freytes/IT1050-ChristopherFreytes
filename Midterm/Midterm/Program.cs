using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Identify and briefly describe 3 types of control structures that we can use to order the statements in our programs?  
             * 
             * Different control structures we use are loops, if statements and switch statements. Loops such as while, do while and for 
             * will repeat a fragment of code until the terminating sequence is met. If statements, if else and else statements use logic 
             * to solve code, and switch statements can be used in replacement of if else statements.
             * 
             */

            /* Create an infinite while loop.  Use a Boolean variable called keepLooping that set to true in the loop’s termination condition.  
             * 
             * 
             * 
             
            int i = 12;
            Boolean keepLooping = true;
            while (keepLooping) {
                if (i <= 11)
                    keepLooping = false;
                i++; Console.WriteLine(i);
            }
            */

            /* Write a while loop to prints 2 through 128 in brackets
             * 
             */

            int numbers = 2;
            while (numbers <= 128)
            {
                Console.WriteLine("[{0}]", numbers);
                numbers++;
            }

            /* Write a for loop that prints 49 through 1 separated by a comma.
             *  
             */
            for (int x = 49; x > 0; x--)
            {
                Console.Write("{0}{1}", x, x == 1 ? "" : ",");
            }
            Console.WriteLine();


            /* Write a while loop that prints all odd numbers 1 through 21 separated by spaces 
             * 
             */
            int o = 1;
            do
            {
                if (o % 2 != 0)
                {
                    Console.Write(" {0} ", o);
                }
                o++;
            } while (o <= 21);


            /* What is the output for the following code?
                    int n = 8;
                    int i = 10; // initialize
                    do {
                    Console.Write("*");
                    i++; // update!
                    } while (i < n); // test condition

             * What would the output be with the exact same code but using a while statement as opposed to a do-while?
             * 
             * A: The do while loop only outputs a single “*” on the other hand the while loop doesn’t outputany…The 
             * while loop will check the condition before executing the program and the do while will execute the program 
             * then check the condition after.
             * 
             */

            /* Explain how do we combine multiple Boolean values?  Write an if statement that outputs “Let’s go outside!” 
             * when both Boolean values are false.
             * boolean icyRain;
             * boolean tornadoWarning;
             * 
             * A: You can also combine true/false values by using the Boolean operators, which take true/false values as 
             * operands and compute new true/false values
             *  
             */
            bool icyRain = false, tornadowarning = false;
            // bool tornadowarning = false;
            if (icyRain == false && tornadowarning == false)
            {
                Console.WriteLine("\n Lets go outside");
            }
            else
            {
                Console.WriteLine("\n Lets stay inside");
            }

            /* Extra Credit: Use nested loops to print the following to the console:
             * 123454321
             *  1234321
             *   12321
             *    121
             *     1
             */

            for (int row = 0; row < 5; row++)
            {

                for (int space = 0; space < row; space++)
                {
                    Console.Write(" ");
                }

                for (int num = 0; num < 5 - row;)
                {
                    Console.Write(++num);
                }

                for (int num = 5 - row; num > 1;)
                {
                    Console.Write(--num);
                }

                for (int space = 0; space < row; space++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(" ");
            }

            /*Command which allows you close Window*/
            Console.WriteLine("\n \n Press the Enter Key to Close..");// Command used to display closed message.
            Console.ReadLine(); // Command used to keep window open
        }
    }
}
