using System;

/* Structure - Struct :-
 * A struct type is a value type that is typically used to encapsulate small groups of related variables, 
 * such as the coordinates of a rectangle or the characteristics of an item in an inventory. 
 * 
 * Structs share most of the same syntax as classes, but are more limited than classes.
 * Unlike classes, structs can be instantiated without using a new operator. 
 * 
 * Structs do not support inheritance and cannot contain virtual methods.
 * 
 * Structs can contain methods, properties, indexers, and so on.  <-- IMPORTANT
 * Structs cannot contain default constructors (a constructor without parameters), 
 * but they can have constructors that take parameters. 
 * In that case the new keyword is used to instantiate a struct object, similar to class objects. 
 */

namespace Tutorial17Struct
{
    class Program
    {
        struct Book
        {
            public string title;
            public double price;
            public string author;
        }
        struct Point // struct can have methods, properties, indexers and constructors
        {
            public int x;
            public int y;
            public Point(int x, int y)  // constructor in struct
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            Book b;
            b.title = "Test";
            b.price = 5.99;
            b.author = "David";

            Console.WriteLine("Title:"+b.title);
            Console.WriteLine("Price:"+b.price);


            Point p = new Point(10, 15);    // as this is initialized using constructor so "new" keyword is used.
            Console.WriteLine(p.x);
            p.x = 7;    // this way still can be used
            Console.WriteLine(p.x);
        }
    }
}

/* Structs vs. Classes
 * In general, classes are used to model more complex behavior, or data, 
 * that is intended to be modified after a class object is created. 
 * Structs are best suited for small data structures that contain primarily data that is 
 * not intended to be modified after the struct is created. 
 * Consider defining a struct instead of a class if you are trying to represent a simple set of data. 
 */

/* All standard C# types (int, double, bool, char, etc.) are actually structs. */