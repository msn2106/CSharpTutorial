//using System; //here using says that program is using System namespace

/*
 * The .NET Framework uses namespaces to organize its many classes. System is one example of a .NET Framework namespace.
 * Declaring your own namespaces can help you group your class and method names in larger programming projects.
 */
/*
 * Namespaces declare a scope that contains a set of related objects. 
 * You can use a namespace to organize code elements. 
 * You can define your own namespaces and use them in your program.
 * The using keyword states that the program is using a given namespace.
 */

namespace Tutorial15Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!"); // here we have to specify where Console class resides
        }
    }
}
