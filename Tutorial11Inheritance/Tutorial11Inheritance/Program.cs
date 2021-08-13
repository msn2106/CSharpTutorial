using System;

namespace Tutorial11Inheritance
{
    class Program
    {
        class Animal
        {
            protected int x = 5;
            public Animal()
            {
                x++;
                Console.WriteLine("Animal Created");
            }
            ~Animal()
            {
                Console.WriteLine("Animal Deleted");
            }
        }

        class Dog : Animal
        {
            public int X { 
                get { return x; }
                set { x = value; }
            }
            public int y = 2;
            public int Y
            {
                get { return y; }
                set { y = value; }
            }
            public Dog()
            {
                x++;
                y++;
                Console.WriteLine("Dog Created");
            }
            ~Dog()
            {
                Console.WriteLine("Dog Deleted");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dog dog = new Dog();
            /* Note that the base class constructor is called first and the derived class constructor
             * is called next. When the object is destroyed, the derived class destructor is invoked 
             * and then the base class destructor is invoked. 
             */

            /* You can think of it as the following: The derived class needs its base class in order 
             * to work, which is why the base class constructor is called first.
             */
            Console.WriteLine(dog.X); // Here X is incremented by 2, once by base and once by derived class
            Console.WriteLine(dog.Y); // Here Y is incremented once by its class constructor only.
        }
    }
}
