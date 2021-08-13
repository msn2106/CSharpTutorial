using System;
using System.Collections.Generic;

/* Sorted List:
 * A sorted list is a collection of key/value pairs that are sorted by key. A key can be used to access its corresponding value in the sorted list.
 * The C# generic collection SortedList<K, V> class requires all element key/value pairs to be of the same type K, V. 
 * Duplicate keys are not permitted, which ensures that every key/value pair is unique. 
 */

namespace Tutorial24SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> sl = new SortedList<string, int>();

            sl.Add("Solo", 59);
            sl.Add("A", 95);
            sl.Add("Learn", 72);
            sl.Remove("A");

            Console.WriteLine("Sorted List: ");
            foreach (string s in sl.Keys)
                Console.WriteLine(s + ": " + sl[s]);  // Learn: 72  Solo: 59
            Console.WriteLine("\nCount: " + sl.Count);  // 2

            Console.WriteLine();

            SortedList<int, char> sl2 = new SortedList<int, char>();

            for (int i = 1; i < 8; i++)
            {
                for(char j = 'a'; j < 'z'; j++)
                {
                    sl2[i] = j; //Gets or sets the value associated the specified key contained in the sorted list. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and the key, value. 
                    break;
                }
            }
            sl2.Add(13, 'm'); // Adds an element with a specific key, value pair into the sorted list. 

            sl2.Add(15, 'm');   // multiple keys can have same value
            sl2.Add(14, 'n');   //key are always in sorted order irrespective of entry order

            // sl2.Add(13, 'n');       // error - key already alloted at runtime
            foreach (int i in sl2.Keys) // Keys - Gets a sorted and indexed collection containing only the keys in the sorted list. 
                Console.Write(i+":"+sl2[i]+", ");
            Console.WriteLine();

            Console.Write("Values:");
            foreach(char c in sl2.Values) // Values - Gets a sorted and indexed collection of the values in the sorted list. 
                Console.Write(c+",");
            Console.WriteLine();

            Console.WriteLine("KeyValuePair way:");
            foreach(KeyValuePair<int,char> kvp in sl2)
                Console.WriteLine("key: {0} , value: {1}",kvp.Key,kvp.Value);

            Console.WriteLine("Count:" + sl2.Count); // Gets the number of key/value pairs contained in the sorted list. 
            Console.WriteLine("Capacity:"+sl2.Capacity);

            sl2.Remove(5); // Removes the element with the specific key, value pair associated with the specified key from the sorted list. 
            Console.WriteLine("After removing Key 5:");
            foreach (int i in sl2.Keys)
                Console.Write(i + ":" + sl2[i] + ", ");
            Console.WriteLine("ContainsKey(13):"+sl2.ContainsKey(13)); // Returns true when the specified key is present in the sorted list. 
            Console.WriteLine("ContainsValue('m'):" + sl2.ContainsValue('m')); // Returns true when a specified value is present in the sorted list. 

            Console.WriteLine("IndexOfKey(13):"+sl2.IndexOfKey(13)); // Returns the index of the specified key within the sorted list. 
            Console.WriteLine("IndexOfValue('d'):"+sl2.IndexOfValue('d')); // Returns the index of the specified value within the sorted list. 

            string res = sl2.ToString();
            Console.WriteLine("sl2 as ToString():"+res);
            sl2.Clear(); // Removes all the elements from the sorted list. 
            Console.WriteLine("Size after sl2.Clear():"+sl2.Count);

        }
    }
}
