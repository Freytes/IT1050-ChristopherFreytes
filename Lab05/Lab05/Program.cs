using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Identify and describe the following elements of the method header given the following method called getArea().  
             * You must identify where they are in the method header example, other possible values and what the significance 
             * of each is (what does it mean?)
             * 
             * a.Scopedouble height, double width. Anything within the () in a method header.
             * b.Static vs. Non-StaticStatic or not static, if static you can access information all across the code. If not static then must fetch information another way. 
             * c.Return TypeDouble in this example. Signifies how the program returns information. Can be void, or int aswell.
             * d.Method Name (Identifier)getArea in this example. Tells the code where to go to for information. 
             * e.ParametersPublic in this example. Tells the code the access restrictions if any. Public don’t have restrictions private do.
             * f.Method BodyReturn height * width; in this example. Marks the area of code that must be executed
             */


            /*
             * Explain the difference between a user-defined method and a method that is provided with a framework.  
             * What should we consider when creating a user-defined method?
             * 
             * User defined method is written by the user and are hidden from other methods. Methods provided by the 
             * framework are able to be reused from several locations in an app
             * 
             */

            /*
             * Discuss the difference between a static and non-static method
             * 
             * The difference between a static and non-static method is that a non-static 
             * method is allowed to access all the non-static fields in an object. While the static 
             * method does not have access to any of the objects non-static fields.
             */

            /*
             * Use the attached code.  Note: you will have to extract the code and open it in Visual Studio before starting.  Add a 
             * method to the Dog class called bark(). It should have the following characteristics:
             * 
             * a.Zero parameters
             * b.No return value
             * c.Should execute Console.WriteLine("{0} is Barking...", name);
             * 
             */
            Dog myDog = new Dog();
            myDog.Name = "Fido";
            myDog.bark();
            myDog.doTrick("Fetch");

            /*Command which allows you close Window*/
            Console.WriteLine("\n \n Press the Enter Key to Close..");// Command used to display closed message.
            Console.ReadLine(); // Command used to keep window open
        }
    }
}