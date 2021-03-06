﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /* 3. Before adding a constructor method, describe what is called when we create an instance of type Book?
       
       A: A constructor is a special method of the class which gets automatically invoked whenever an instance of the class is created.
       Like methods, a constructor also contains the collection of instructions that are executed at the time of Object creation. Before adding
       the constructor method the class is called 'Book' which contains the parameters of the variables. Then the constructor 'Booktest' is created to
       pass on the needed variables. 
 
     */

    /* 4. What concept would we be practicing if we created two new constructor methods? 
       
       A: New constructor method create a new function in C#    
     */

    /* 5. Why is it important to use exception handling?
       
       A: Exception handling is important for handling exceptions in the program. We can easily handle them by using try 
       catch blocks.     
     */

    /* 6. What’s the purpose of private vs. public when we’re adding new properties and/or methods to our class?  How does this apply to information hiding?
        A:	PRIVATE 
        Visible to the class only (private).
        Methods, Variables and Constructors that are declared private can only be accessed within the declared class itself.
        Private access modifier is the most restrictive access level. Class and interfaces cannot be private.
        Variables that are declared private can be accessed outside the class if public getter methods are present in the class.
        Using the private modifier is the main way that an object encapsulates itself and hide data from the outside world.
        
        PUBLIC
        Visible to the world (public).
        A class, method, constructor, interface etc declared public can be accessed from any other class. Therefore fields, methods, blocks declared inside a public 
        class can be accessed from any class belonging to the Java Universe. However if the public class we are trying to access is in a different package, then the public 
        class still need to be imported. Because of class inheritance, all public methods and variables of a class are inherited by its subclasses.

     */

    /* 7. What is composition?  How could we use Composition in our Book class?
       A: Composition over inheritance (or composite reuse principle) in object-oriented programming (OOP) is the principle that classes should achieve polymorphic behavior 
       and code reuse by their composition (by containing instances of other classes that implement the desired functionality) rather than inheritance from a base or parent class.
       Composition is used in our book class, when we use our constructor 'BookTest' to reference values from with the Book class.
     */

    /* 8. What is data abstraction?
       A: Data abstraction is one of the principle of object oriented programming. It is used to display only necessary and essential features of an object to outside the world. Means displaying what 
       is necessary and encapsulate the unnecessary things to outside the world. Hiding can be achieved by using "private" access modifiers.

     */

    class Book
    {
        //FIELDS
        string title;
        string author;
        string year;

        //PROPERTIES

        public virtual string Title
        {
            get { return title; }
            set { title = value; }
        }

        public virtual string Author
        {
            get { return author; }
            set { author = value; }
        }
        public virtual string Year
        {
            get { return year; }
            set { year = value; }
        }

        //METHODS
        public virtual void Display()
        {
            Console.WriteLine($"{title}");
            Console.WriteLine($"{author}");
            Console.WriteLine($"{year}");
        }

        //CONSTRUCTOR
        class BookTest : Book
        {

        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Example Book Information:\n");

                BookTest myBook = new BookTest();

                myBook.Title = "The Martian";
                myBook.Author = "Andy Weir";
                myBook.Year = "2011";

                myBook.Display();

                /*Command which allows you close Window*/
                Console.WriteLine("\n \n Press the Enter Key to Close..");// Command used to display closed message.
                Console.ReadLine(); // Command used to keep window open

            }

        }
    }

}
