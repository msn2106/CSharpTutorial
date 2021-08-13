using System;

namespace Tutorial5
{
    class Program
    {
        class SomeClass
        {
            public static int X { get; set; }
            public static int Y { get; set; }
            public int Z { get;}
            private int a;
            public int A
            {
                set { a = value;} //if on the place of value I give any value, it can be overwritten only in constructor
                get { return a; }
            }
            static SomeClass()
            {
                X = 10;
                Y = 20;
                // Z = 30; // only static members can be accessed inside a static method.
            }
            public SomeClass()
            {
                X = 5;
                Y = 4;
                Z = 11;
                a = 15;
            }
        }
        static void Main(string[] args)
        {
            /*
             * Constructors can be declared static to initialize static members of the class.
             * The static constructor is automatically called once when we access a static
             * member of the class. 
             */
            Console.WriteLine("X:"+SomeClass.X);
            // Console.WriteLine(SomeClass.Z); //Z is not static

            SomeClass sc = new SomeClass();
            Console.WriteLine("X:"+SomeClass.X); //here the value are overwritten by the new constructor
            Console.WriteLine("Y:"+SomeClass.Y);
            Console.WriteLine("Z:" + sc.Z);
            
            // a is filled value now by constructor
            Console.WriteLine("a:"+sc.A);

            sc.A = 11;  // now here the value given by constructor is overwritten using the set method
            Console.WriteLine("a:" + sc.A);
        }
    }
}
