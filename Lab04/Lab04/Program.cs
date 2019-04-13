using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Describe the four basic basic elements of the counter-controlled repetition:
             * The four basic elements of the counter-controlled reptition are: control variable, initial value , increment (decrement) 
             * and the loop-continuation condition. 
             * 
             */

            /*
             * Compare and contrast the while and for repetition statement:
             * The while statement, also called the while loop, executes a block of statements as long as a specified condition is true. A while loop have a condition to check 
             * then executes untill the condition is true, increament or decrement is true. In 'for' loop iteration statement is written at top, hence, executes only after all 
             * statements in loop are executed. In 'while' loop, the iteration statement can be written anywhere in the loop
             * 
             */

            /*
             * Discuss when it would be more appropriate to use a do-while statement than a while statement:
             * Use do-while instead of while when a set of instructions/block of statements that need to executed at least once. 
             * A while statement can be executed at any point within the cycle and can be executed more than once. An example of a 
             * good use case of aa do-while is if validation on a user interaction is needed. The do-while would execute once, the user
             * has input the value in which triggers the do-while statement.
             */


            /* For loop that outputs values 1 to 100 incrementing by 1, also outputs if the increment is odd or even*/


            for (int i = 1; i <= 100; i++)
            {

                if ((i % 2) == 0) // Determines if value is odd, on false would be even

                {
                    Console.WriteLine("Value of Interger increasing by 1: {0} it's even \n", i);

                }

                else if ((i % 2) != 0)

                {
                    Console.WriteLine("Value of Interger increasing by 1: {0} it's odd \n", i);

                }

            }

            /* User interactive statement*/

            Console.Write("Please enter Temperature:"); // Command which requires user input.
            double fahrenheit = Convert.ToInt32(Console.ReadLine()); // Command which reads Fahrenheit value
            if (fahrenheit >= 90)
            {
                Console.WriteLine("Teperature: {0} ({1})", fahrenheit, "Fish");
            }

            else if (fahrenheit >= 80)
            {
                Console.WriteLine("Teperature: {0} ({1})", fahrenheit, "Lion");
            }
            else if (fahrenheit >= 70)
            {
                Console.WriteLine("Teperature: {0} ({1})", fahrenheit, "Turtle");
            }
            else if (fahrenheit >= 60)
            {
                Console.WriteLine("Teperature: {0} ({1})", fahrenheit, "Deer");
            }
            else if (fahrenheit >= 50)
            {
                Console.WriteLine("Teperature: {0} ({1})", fahrenheit, "Reindeer");
            }
            else if (fahrenheit >= 40)
            {
                Console.WriteLine("Teperature: {0} ({1})", fahrenheit, "Moose");

            }
            else if (fahrenheit >= 20)
            {
                Console.WriteLine("Teperature: {0} ({1})", fahrenheit, "Penguin");
            }
            else if (fahrenheit >= 10)
            {
                Console.WriteLine("Teperature: {0} ({1})", fahrenheit, "Polar Bear");
            }
            else
            {
                Console.WriteLine("Teperature: {0} ({1})", fahrenheit, "Bug");
            }

            /*
             * 7. The following code is meant to loop and output 10-20, each number on a separate line.  
             * What’s wrong?  Copy it into your solution and fix the problem.
             * 
             * Identified the followign issues:
             * 1. The problem with this piece of code is that local parameter named 'i' is already used somewhere else in the 
             * program. 
             * 2. The parameter 'variable'++ is missing so that the 'variable' continues to increment and not loop indefinetly.
             */

            int numbers = 10;
            while (numbers < 21)
            {
                Console.WriteLine(numbers);
                numbers++;
            }

            /* 8. The following statement is supposed to output every number from 0-100 separated by a line with asterisks on it.  
             * What is wrong with the code? 
             * 
             * Identified the followign issues:
             * 1. The **** values are not being placed underneath the variable, because the WriteLine command is not properly formmatted.
             * once formatted as follows Console.WriteLine("{0} \n {1}",i, "********"); the output mirrored the example.
             * 
             */

            for (int i = 0; i < 101; i++)
                Console.WriteLine("{0}\n{1}", i, "********");

            /*Command which allows you close Window*/
            Console.WriteLine("Press the Enter Key to Close..");// Command used to display closed message.
            Console.ReadLine(); // Command used to keep window open
        }
    }

}