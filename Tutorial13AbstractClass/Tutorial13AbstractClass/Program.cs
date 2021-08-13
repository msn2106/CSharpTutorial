using System;

/* Abstract Class &  Method:- 
 * In some situations there is no meaningful need for the virtual method to have a separate 
 * definition in the base class.
 * These methods are defined using the abstract keyword and specify that the derived classes must 
 * define that method on their own.
 * You cannot create objects of a class containing an abstract method, which is why the class itself
 * should be abstract. 
 */
/*
 * As you can see, the Draw method is abstract and thus has no body. 
 * You do not even need the curly brackets; just end the statement with a semicolon.
 * The Shape class itself must be declared abstract because it contains an abstract method. 
 * Abstract method declarations are only permitted in abstract classes. 
 */

/*An abstract class is intended to be a base class of other classes. 
 * It acts like a template for its derived classes. 
 */

namespace Tutorial13AbstractClass
{
    class Program
    {
        abstract class Shape        // class must be declared abstract, as it has abstract method
        {
            public int val = 5;
            public abstract void Draw();    // no implementation, just declaration

            public void Sample()    // an abstract class can have concrete method
            {
                Console.WriteLine("A sample not abstract method");
            }
        }
        class Circle : Shape
        {
            public override void Draw() // all the abstract methods must be defined, otherwise this class too becomes abstract
            {
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape // 'override' keyword is used to give own definition to inherted methods
        {
            public override void Draw()
            {
                Console.WriteLine("Rect Draw");
            }
        }

        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();

            Rectangle r = new Rectangle();
            r.Draw();

            Console.WriteLine(r.val); // an abstract class can have member varibles and concrete methods
            r.Sample(); // inherited concrete method 'Sample()' from abstract class Shape.
        }
    }   
}
/*
 * Abstract classes have the following features:
 * - An abstract class cannot be instantiated.
 * - An abstract class may contain abstract methods and accessors.
 * - A non-abstract class derived from an abstract class must include actual implementations of 
 * all inherited abstract methods and accessors. 
 */

/* It is not possible to modify an abstract class with the sealed modifier because the two modifiers
 * have opposite meanings. The sealed modifier prevents a class from being inherited and the abstract
 * modifier requires a class to be inherited.
 */