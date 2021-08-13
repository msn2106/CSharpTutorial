using System;

/* Interface:- 
 * An interface is a completely abstract class, which contains only abstract members. 
 * All members of the interface are by default abstract, so no need to use the abstract keyword. 
 * Interfaces can have public (by default), private and protected members. 
 * Interfaces can contain properties, methods, etc. but cannot contain fields (variables).
 * 
 * When a class implements an interface, it must also implement, or define, all of its methods. <-- IMPORTANT
 */

/* IMPORTANT
 * But why use interfaces rather than abstract classes?
 * A class can inherit from just one base class, but it can implement multiple interfaces!
 * Therefore, by using interfaces you can include behavior from multiple sources in a class.
 * To implement multiple interfaces, use a comma separated list of interfaces when 
 * creating the class: class A: IShape, IAnimal, etc.
 */

/* IMPORTANT
 * Default implementation in interfaces allows to write an implementation of any method. 
 * This is useful when there is a need to provide a single implementation for common functionality. 
 * SaveWork Method in Shape interface is an example
 */

namespace Tutorial14Interface
{
    class Program
    {
        public interface IShape
        {
            //int val = 5;  //error : interface cannot have instance field(variable)

            void Draw();    // no need to specifically say abstract

            //private void Name()   //it is possible.. but what for ?
            //{
            //    Console.WriteLine(" Name inside interface");
            //}
            void Name();

            protected void Rename() // it is possible..but what for?
            {
                Console.WriteLine("Rename inside interface");
            }
        }

        interface Shape
        {
            void Name();

            void SaveWork()     // default method
            {
                Console.WriteLine("This is a default method.");
            }
        }
        class Circle : IShape, Shape        // Multiple Inheritance
        {
            public void Draw()  // Note, that the override keyword is not needed when you implement an interface. 
            {
                Console.WriteLine("Circle Draw");
            }

            public void Name()
            {
                Console.WriteLine("This is implementation of Name inside Circle");
            }
        }

        class Rect : Shape
        {
            public void Name()
            {
                Console.WriteLine("Rectangle");
            }

        }
        static void Main(string[] args)
        {
            IShape c = new Circle();
            c.Draw();
            c.Name();


            Shape r = new Rect();   // notice the object is of reference 'Shape' but initalized by Rect class.
            r.Name();
            r.SaveWork();       // default method from Shape interface
            // if the default method is overriden in the derived class then it will be implemented instead of default method

            /* Note :- Methods with default implementation can be freely overridden inside the class which 
             * implements that interface.
             */
        }
    }
}
/*
 * It is common to use the capital letter I as the starting letter for an interface name. 
 */

/* The term implementing an interface is used (opposed to the term "inheriting from") to describe the process 
 * of creating a class based on an interface. The interface simply describes what a class should do. 
 * The class implementing the interface must define how to accomplish the behaviors. 
 */