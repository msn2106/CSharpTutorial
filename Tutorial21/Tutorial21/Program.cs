using System;

/* Generic Methods & Classes:- 
 * Generics allow the reuse of code across different types, thus it prevent useless code.
 * Generic types can also be used with classes. 
 * The most common use for generic classes is with collections of items like stack, list etc.
 */
/*
 * In a generic class we do not need to define the generic type for its methods, 
 * because the generic type is already defined on the class level.
 */

namespace Tutorial21
{
    class Person
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
    class Stack<T>
    {

        int index = 0;

        T[] innerArray = new T[100];
        public void Push(T item)
        {
            innerArray[index++] = item;
        }

        public T Pop()
        {
            return innerArray[--index];
        }

        public T Get(int k) { return innerArray[k]; }

    }
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // below is a generic method, where T denotes generic datatype
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            Console.WriteLine("a,b:"+a+","+b);
            Swap(ref a, ref b);
            Console.WriteLine("a,b:"+a +","+b);

            double c = 5.4;
            double d = 6.85;
            Console.WriteLine("c,d:"+c+","+d);
            Swap(ref c, ref d);                 // generic one - this way also can be written
            Console.WriteLine("c,d:"+c+","+d);

            string str1 = "abcd";
            string str2 = "efgh";
            Console.WriteLine("str1,str2:" + str1 + "," + str2);
            Swap<string>(ref str1, ref str2);   // this way it can also be written
            Console.WriteLine("str1,str2:" + str1 + "," + str2);

            // If you omit specifying the type when calling a generic method,
            // the compiler will use the type based on the arguments passed to the method. 

            // Using Generic Class 
            Stack<int> intStack = new Stack<int>();
            Stack<string> strStack = new Stack<string>();
            //generic class with custom types, such as the custom defined Person type. 
            Stack<Person> PersonStack = new Stack<Person>();

            // Generic class methods are called the same as for any other object: 
            intStack.Push(3);
            intStack.Push(6);
            intStack.Push(7);

            Console.WriteLine(intStack.Get(1));
        }
    }
}
