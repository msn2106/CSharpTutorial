using System;

namespace Tutorial3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * It’s common to think of strings as arrays of characters.
             * In reality, strings in C# are objects.
                When you declare a string variable, you basically instantiate an object of type String.
                
                String objects support a number of useful properties and methods:

                1.) Length returns the length of the string.

                2.) IndexOf(value) returns the index of the first occurrence of the value within the string.
                
                3.) Insert(index, value) inserts the value into the string starting from the specified index.
                
                4.) Remove(index) removes all characters in the string from the specified index.

                5.) Replace(oldValue, newValue) replaces the specified value in the string.

                6.) Substring(index, length) returns a substring of the specified length, starting from the specified index. 
                If length is not specified, the operation continues to the end of the string.

                7.) Contains(value) returns true if the string contains the specified value.
             */

            string a = "some text";
            Console.WriteLine("Original string:"+a);
            Console.WriteLine("Length of string:"+a.Length);
            //Outputs 9

            Console.WriteLine("Index of first occurrence of \'t\': "+a.IndexOf('t'));
            //Outputs 5

            a = a.Insert(0, "This is ");
            Console.WriteLine("Insert the string given, starting from given index:"+a);
            //Outputs "This is some text"

            a = a.Replace("This is", "I am");
            Console.WriteLine("Replace the specified segment of string with the new one:"+a);
            //Outputs "I am some text"

            if (a.Contains("some"))
                Console.WriteLine("Check for \"some\" in the string:"+ "found");
            //Outputs "found"

            a = a.Remove(4);
            Console.WriteLine("Removes all the character after the given index:"+a);
            //Outputs "I am"

            a = a.Substring(2);
            Console.WriteLine("Substring from 2 to end:"+a);
            //Outputs "am"

            a = a + "some random text";
            Console.WriteLine("String now:"+a);

            a = a.Substring(2,7);
            Console.WriteLine("Substring from 2 to 7:" + a);

            Console.WriteLine("Character at index 2:"+a[2]);

            // Application of string methods
            /*
             * The code above replaces all occurrences of "dog" with "cat".
             * After that it takes a substring of the original string starting from the
             * first index until the first occurrence of a period character.
             * We add one to the index of the period to include the period in the substring. 
             */

            string text = "This is some text about a dog. The word dog appears in this text a number of times. This is the end.";
            text = text.Replace("dog", "cat");
            text = text.Substring(0, text.IndexOf(".") + 1);

            Console.WriteLine(text);

        }
    }
}
