using System;

namespace Tutorial4
{
    class Program
    {
        class Cat
        {
            public static int count = 0;
            public Cat()
            {
                count++;
            }
        }

        class Dog
        {
            private int no = 4;
            public static void Bark()
            {
                Console.WriteLine("Woof");
            }
        }

        class MathClass
        {
            public const int ONE = 1;
        }

        static void Main(string[] args)
        {
            // static keyword
            /*
             * Class members (variables, properties, methods) can also be declared as static.
             * This makes those members belong to the class itself,
             * instead of belonging to individual objects.
             * No matter how many objects of the class are created,
             * there is only one copy of the static member. 
             */

            Cat c1 = new Cat();
            Cat c2 = new Cat();

            // Because of their global nature, static members can be accessed directly
            // using the class name without an object.
            Console.WriteLine(Cat.count);
            // If you try to access them via an object of that class, you will generate an error.
            // Console.WriteLine(c1.count);

            // static method Bark without object of Dog class.
            // static method can only access static members
            Dog.Bark();

            // Constant members are static by definition. 
            Console.Write(MathClass.ONE);

        }
    }
}
/*
 * The Main method is static, as it is the starting point of any program.
 * Therefore any method called directly from Main had to be static.
 * */