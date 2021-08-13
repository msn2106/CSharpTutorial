using System;

/*
 * Polymorphism is a way to call the same method for different objects and generate different 
 * results based on the object type. This behavior is achieved through virtual methods in the 
 * base class. 
 */

namespace Tutorial12Polymorphism
{
    class Program
    {
        class Shape
        {
            // public void Draw() {
            //     Console.Write("Base Draw");
            // }
            public virtual void Draw()          // "virtual" keyword is used to make method eligible for overriden in derived class
            {
                Console.Write("Base Draw");
            }
        }
        class Circle : Shape
        {
            public override void Draw()         // "override" keyword is used to override the definition given by base class in derived class
            {
                // draw a circle...
                Console.WriteLine("Circle Draw");
            }
        }

        class Rectangle : Shape
        {
            // public override void Draw() {
            //     // draw a rectangle...
            //     Console.WriteLine("Rect Draw");
            // }
            public new void Draw()          // "new" keyword says that this is a new method but it still has working of base class, coz it has not overriden it.
            {
                // draw a rectangle...
                Console.WriteLine("Rect Draw");
            }
            //public void Draw()              // warning: this hides inherited member 'Program.Shape.Draw()'
            //{
            //    // draw a rectangle...
            //    Console.WriteLine("Rect Draw");
            //}
        }

        class Cube
        {
            public void Draw()
            {
                Console.WriteLine("Draw of Cube");
            }

            public void Draw(int r)         // this is compile time polymorphism 
            {
                Console.WriteLine("Side of Cube:" + r);
            }
        }

        static void Main(string[] args)
        {
            // Dynamic/Late/Run-time polymorphism
            // In this the function to be called is decided at runtime
            // The selection is based on which class's object is calling and 'virtual' and 'override' keyword 
            // Notice below the objects of the base type, but instantiated as the derived type. 
            // Shape is the base class. Circle is the derived class. 
            Shape c = new Circle();
            c.Draw();

            Shape r = new Rectangle();
            r.Draw();
            Console.WriteLine();

            // Compile time/Early/ Static Polymorphism
            // The function to be used is decided by compiler at the compile time only, by checking the signature of the method
            Cube cb = new Cube();

            cb.Draw();
            cb.Draw(5);

            // We can create the object of rectangle class to access it method specifically too.
            Rectangle rc = new Rectangle();
            rc.Draw();

        }
    }
}
/* Advantage of Polymorhism:
 * 1. The polymorphic approach allows us to treat each object the same way. 
 * As all objects are of type Shape, it is easier to maintain and work with them. 
 * You could, for example, have a list (or array) of objects of that type and work with them 
 * dynamically, without knowing the actual derived type of each object. 
 * 
 * 2. For example:-  We could create a game where we would have different Player types with each 
 * Player having a separate behavior for the Attack method.
 * In this case, Attack would be a virtual method of the base class Player and each derived 
 * class would override it.
 */