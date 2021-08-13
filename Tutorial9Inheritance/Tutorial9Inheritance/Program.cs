using System;

/*
 * Inheritance allows the derived class to reuse the code in the base class without having to 
 * rewrite it. And the derived class can be customized by adding more members. 
 * In this manner, the derived class extends the functionality of the base class.
 */

/*
 * C# does not support multiple inheritance, so you cannot inherit from multiple classes.
 * However, you can use interfaces to implement multiple inheritance.
 */

namespace Tutorial9Inheritance
{
    class Program
    {
        class Animal    // Base Class
        {
            public int Legs { get; set; }
            public int Age { get; set; }
        }

        class Dog : Animal  // Derived Class // A colon and the name of the base class follow the name of the derived class. 
        {
            public Dog()
            {
                Legs = 4;
            }
            public void Bark()
            {
                Console.Write("Woof");
            }
        }

        class Pug : Dog     // Multi-level Inheritance
        {
            public Pug()
            {
                Age = 2;
            }
        }

        static void Main(string[] args)
        {
            /* All public members of Animal become public members of Dog. 
             * That is why we can access the Legs member in the Dog constructor.
             * Now we can instantiate an object of type Dog and access the inherited members 
             * as well as call its own Bark method.
             */
            Dog d = new Dog();
            Console.WriteLine(d.Legs);

            d.Bark();
            Console.WriteLine();

            Pug p = new Pug();
            p.Bark();   // A derived class inherits all the members of the base class, including its methods.
            // A base class can have multiple derived classes.
            // For example, a Cat class can inherit from Animal. 



        }
    }
}
