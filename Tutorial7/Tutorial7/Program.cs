using System;

namespace Tutorial7
{
    class Program
    {
        class Person
        {
            private readonly string name = "John";
            private readonly int age;               // may or may not be initialized
            //const double PI;  // must be initialized

            readonly double a = Math.Sin(60); // OK
            //const double b = Math.Sin(60); // Error!

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    //name = value; // this will give error.
                }
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        class Clients
        {
            private string[] names = new string[10];
            public string this[int index]
            {
                get
                {
                    return names[index];
                }
                set
                {
                    names[index] = value;
                }
            }
        }

        class Box
        {
            public int Height { get; set; }
            public int Width { get; set; }
            public Box(int h, int w)
            {
                Height = h;
                Width = w;
            }

            /* Overloaded operators are methods with special names, 
             * where the keyword operator is followed by the symbol for the operator being defined.
             * Similar to any other method, an overloaded operator has a return type and a 
             * parameter list. 
             * Additionally, the overloaded operator must be static. 
             */
            public static Box operator+(Box a, Box b)
            {
                int h = a.Height + b.Height;
                int w = a.Width + b.Width;
                Box res = new Box(h, w);
                return res;
            }
        }


        static void Main(string[] args)
        {
            /*The readonly modifier prevents a member of a class from being modified after construction.
             * It means that the field declared as readonly can be modified only when you declare it
             * or from within a constructor. 
             */

            Person p = new Person("Mike",25);
            Console.WriteLine(p.Name);

            // Difference between const and readonly fields. { Check in class }
            // 1. a constant field must be initialized when it is declared,
            // whereas a readonly field can be declared without initialization

            // 2. Second, a readonly field value can be changed in a constructor,
            // but a constant value cannot. 

            // 3. the readonly field can be assigned a value that is a result of a calculation,
            // but constants cannot

            //-----------------------------------------------------------------------------------

            // An indexer allows objects to be indexed like an array. 
            string str = "Hello World";
            char x = str[4];
            Console.WriteLine(x);

            /* Declaration of an indexer is to some extent similar to a property. 
             * The difference is that indexer accessors require an index.
             * Like a property, you use get and set accessors for defining an indexer. 
             * However, where properties return or set a specific data member, indexers return 
             * or set a particular value from the object instance.
             * Indexers are defined with the this keyword. 
             */

            Clients c = new Clients();
            c[0] = "Dave";
            c[1] = "Bob";

            Console.WriteLine("c[1]:"+c[1]);

            // You typically use an indexer if the class represents a list, collection, or array of objects.

            // --------------------------------------------------------------------------------------------

            // Operator Overloading
            /* Most operators in C# can be overloaded, meaning they can be redefined for custom actions.
             * For example, you can redefine the action of the plus(+) operator in a custom class. 
             */

            Box b1 = new Box(14, 3);
            Box b2 = new Box(5, 7);

            Box b3 = b1 + b2;

            Console.WriteLine(b3.Height);
            Console.WriteLine(b3.Width);

            /*All arithmetic and comparison operators can be overloaded. 
             * For instance, you could define greater than and less than operators for the boxes 
             * that would compare the Boxes and return a boolean result. Just keep in mind that 
             * when overloading the greater than operator, the less than operator should also be 
             * defined.
             */

        }
    }
}
