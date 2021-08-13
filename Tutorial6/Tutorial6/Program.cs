using System;

namespace Tutorial6
{
    class Program
    {
        /*
         * A static class can contain only static members. <------ IMPORTANT
         * You cannot instantiate an object of a static class,
         * as only one instance of the static class can exist in a program.
         * Static classes are useful for combining logical properties and methods.
         * A good example of this is the Math class.
         * It contains various useful properties and methods for mathematical operations.
         * For example, the Pow method raises a number to a power:
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // You access all members of the Math class using the class name,
            // without declaring an object. 
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(23,11));

            // Array class is a static class and there are different static methods in it.
            int[] arr = { 4, 11, 2, 3, 7, 9};
            Array.Reverse(arr);
            Console.Write("\nReverse Array:");
            foreach(int i in arr)Console.Write(i+",");
            Console.WriteLine();
            //O/P :- arr = {4, 3, 2, 1}
            Array.Sort(arr);
            Console.Write("Sorted Array:");
            foreach (int i in arr) Console.Write(i + ",");
            Console.WriteLine("\n");
            //O/P:- arr = {1, 2, 3, 4}

            // Some String static class methods
            string s1 = "some text";
            string s2 = "another text";
            Console.WriteLine(String.Concat(s1, s2)); // combines the two strings
            Console.WriteLine(String.Equals(s1, s2)); // returns false
            Console.WriteLine();

            //Some DateTime class methods
            Console.WriteLine("DateTime.Now :" + DateTime.Now);
            Console.WriteLine("DateTime.Today :" + DateTime.Today);
            Console.WriteLine("DateTime.DaysInMonth(2021, 7) :" + DateTime.DaysInMonth(2021, 7));

        }
    }
}
/*
 * The Console class is also an example of a static class.
 * We use its static WriteLine() method to output to the screen,
 * or the static ReadLine() method to get user input.
 * The Convert class used to convert value types is also a static class.
 * */