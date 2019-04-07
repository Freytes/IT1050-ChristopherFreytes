using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* If statement, while loop compare and contrast.
             * The if-statement checks if an expression is true or false only once. Whereas the While loop
             * would continue to run that expression until the condition is met or changed.
             * Both statements are similar because they are both used to evaluate expression. Both can be used
             * to route logic based on pre-defined conditions and both can be used in conjunction with operator statements.
             * An if-statement would be used if you know your evaluating condition, a while loop is best when you are unsure how
             * many times to process a specific command. Commonly, while loops are nested within if-statements, when you know your expression
             * but it needs to be evaluated multiple times. */

            /*Declaring 'speedLimit' and 'speedVariable' variables*/
            int speedLimit = 35;
            int speedVariable = 42;

            /*If statement which displays the words 'Slow Now' if speed is greater than speed limit*/
            if ( speedVariable > speedLimit )
            {
                Console.WriteLine("{0} {1} {2} {3}\n ", "Slow Now! Your current speed is", speedVariable , "which is greater than the speed limit of", speedLimit);
                   
            }

            /*Declaring 'isTrue' boolean*/
            bool isTrue = true;

            /*If-else statement is true or is false*/
            if (isTrue == true)
            {
                Console.WriteLine("It is True! \n");
            }
            else
            {
                Console.WriteLine("It is False! \n");
            }

            /* User interactive statement which converts Fahrenheit temperature to Celsius*/

            Console.Write("Temperature in Fahrenheit:"); // Command which requires user input.
            double fahrenheit = Convert.ToDouble(Console.ReadLine()); // Command which reads Fahrenheit value
            double fahrenheitValue = fahrenheit; // Command which captures Fahrenheit value
            double celsius = (fahrenheit - 32d) * 5d / 9d;

            Console.WriteLine("Celsius Value is: {0} \n ", celsius);

            /* If statement which displays 'it is cold' if Fahrenheit is less than 40, and 'it is hot' if Fahrenheit is over 90*/
            if(fahrenheitValue <= 40)
            {
                Console.WriteLine("It is Cold!\n");
            }
            if (fahrenheitValue >= 90)
            {
                Console.WriteLine("It is Hot!\n");
            }

            /* While loop that outputs values 1 to 10 incrementing by 1*/

            int intLoop = 1;

            while (intLoop <= 10)
            {
                Console.WriteLine("Value of Interger increasing by 1: {0}\n", intLoop);

                intLoop++;
            }

            /* While loop that outputs values 60 to 20 decrementing by 5*/

            int intdecLoop = 60;

            while (intdecLoop >= 20)
            {
                Console.WriteLine("Value of Interger decreasing by 5: {0}\n", intdecLoop);

                intdecLoop -= 5;
            }

            /* While loop that outputs values 10 to 20 incrementing by 2*/

            int intincLoop = 10;

            while (intincLoop <= 20)
            {
                Console.WriteLine("Value of Interger increasing by 2: {0}\n", intincLoop);

                intincLoop +=2;
            }

            /*Command which allows you close Window*/
            Console.WriteLine("Press the Enter Key to Close..");// Command used to display closed message.
            Console.ReadLine(); // Command used to keep window open


        }
    }
}
