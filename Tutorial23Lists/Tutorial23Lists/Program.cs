using System;
using System.Collections;
using System.Collections.Generic; // Remember, you need to include the statement: using Systems.Collections.Generic; to use List<T>.

/* List :- 
 * A list is similar to an array, but the elements in a list can be inserted and removed dynamically.
 * The C# generic collection List<T> class requires all elements be of the same type T. 
 */

namespace Tutorial23Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic List and some of its methods
            List<int> list = new List<int>();
            for(int i = 99; i > 10; i = i - 7)
            {
                list.Add(i);
            }
            Console.Write("List:");
            foreach (int i in list) Console.Write(i+",");
            Console.WriteLine();
            Console.WriteLine("Count:"+list.Count); // A property that gets the number of elements contained in the list. 
            Console.WriteLine("Item[4]:"+list[4]); // Gets or sets the element in the list at the index i. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and the index value inside the brackets. 
            list.RemoveAt(4); // RemoveAt(int index) Removes the element at the specified position (index) from the list. 
            Console.Write("RemoveAt(4):");
            foreach (int i in list) Console.Write(i + ",");
            Console.WriteLine();
            list.Sort(); // Sort() Sorts elements in the list. 
            Console.Write("Sorted List:");
            foreach (int i in list) Console.Write(i + ",");
            Console.WriteLine();
            Console.WriteLine("Capacity:"+list.Capacity); // A property that gets the number of elements the list can hold before needing to be resized. 
            list.TrimExcess(); // Sets the capacity to the actual number of elements in the list. This is useful when trying to reduce memory overhead. 
            Console.WriteLine("Capacity after TrimExcess():" + list.Capacity);
            list.Insert(4, 12); // Inserts an element t at a specific index i in the list. 
            Console.Write("Insert(4,12):");
            foreach (int i in list) Console.Write(i + ",");
            Console.WriteLine();
            list.Remove(50); // Removes the first occurrence of the object t from the list. 
            Console.Write("Remove first occurrence of 50 Remove(50):");
            foreach (int i in list) Console.Write(i + ",");
            Console.WriteLine();
            Console.WriteLine("Contains(T t):"+list.Contains(43)); // Returns true if the specified element t is present in the list. 
            Console.WriteLine("IndexOf(43):"+list.IndexOf(43)); // Returns the index of the first occurrence of the element t in the list. 
            list.Reverse(); // Reverses the order of the elements in the list. 
            Console.Write("Reversed List:");
            foreach (int i in list) Console.Write(i + ",");
            Console.WriteLine();

            int[] arr = list.ToArray(); // Copies the elements of the list into a new array. 
            Console.Write("Array arr:");
            for(int i = 0; i< arr.Length; i++)
            {
                Console.Write(arr[i]+",");
            }
            Console.WriteLine();

        }
    }
}
