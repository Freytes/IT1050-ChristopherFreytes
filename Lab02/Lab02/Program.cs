using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        /* Question: At what point in the program does our C# Console Application execution?
           Ans: Applications begin at the 'Main' method */
        static void Main(string[] args) 
        {

            /* Question: What is the difference between an integer type variable and a double / floating-point variable?
               Answer: Integer type variables, are numbers without decimal points. A double or a floating point are variables with
               decimal points.*/

            /* Question: We can create blocks of code that we can call by name using a method. Give an example of a method from Chapter 4.
               Answer: An example of a method from Chapter 4 was the GetName() and SetName() methods, from the Account class.*/

            /* Question: Like we have types double and int, we can create our own custom types using Classes.  
             * Each class has variables called instance variables or class members.  To read the value of 
             * an instance variable, we create method called a _getter__ accessor.  
             * To assign a value ton instance variable, we use a method called a __setter__ accessor. 
             */


            /* Question: What is the difference between a class and an object? 
             * How many instances of a class can we create (please explain your answer)?
             * Answer:  An object is an instance of a class at any given time. The difference 
             * between a class and an object is that the object contains values for the properties. Many instances of a class can be created
             * class can be created because you can use different operators on each class. */

            int productValue1; // declare first value to multiply.
            int productValue2; // declare second value to multiply.
            int productSum; // declare sum of multiplied values.

            /* Console Write Line Hello World (One Line) */
            Console.WriteLine( "\n {0}\n {1}","Hello World!", "From Christopher Freytes");

            /* Console Write Line Hello World (Tab)*/
            Console.WriteLine( "\n {0}\t{1}", "Hello World!", "From Christopher Freytes");

            Console.Write( "\n Enter First Value: "); // Command which requires user input.
            productValue1 = Convert.ToInt32(Console.ReadLine()); // Read Value input by user.

            Console.Write("\n Enter Second Value: "); // Second Command which requires user input.
            productValue2 = Convert.ToInt32(Console.ReadLine()); // Read Second Value input by user.

            productSum = productValue1 * productValue2; // Multiply both values.

            Console.WriteLine("\n Sum is: {0} ", productSum); //Display product of two values.

            Console.WriteLine("\n Press Any Key to Close..");// Command used to display closed message.
            Console.ReadLine(); // Command used to keep window open
         
        }
    }
}
