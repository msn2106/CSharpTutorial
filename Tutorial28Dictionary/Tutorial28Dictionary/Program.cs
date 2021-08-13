using System;
using System.Collections.Generic;

/*
 * A dictionary is a collection of unique key/value pairs where a key is used to access the corresponding value. 
 * The C# generic collection Dictionary<K, V> class requires all key/value pairs be of the same type K, V. 
 * Duplicate keys are not permitted to ensure that every key/value pair is unique. 
 */
// Dictionaries are used in database indexing, cache implementations, and so on.

namespace Tutorial28Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("Uno", 1); // Adds the key, value pair to the dictionary.     
            d.Add("One", 1);
            d.Add("Dos", 2);
            d.Add("Deux", 2);

            /*
             * Item[K key] - Gets the value associated with the specified key in the dictionary. 
             * Item is the indexer and is not required when accessing an element. 
             * You only need to use the brackets [] and key value. 
             */
            Console.WriteLine("Dictionary: ");
            foreach (string s in d.Keys)
                Console.WriteLine(s + ": " + d[s]);  // Uno: 1 One: 1 Dos: 2 Deux: 2

            d.Remove("One");  // Remove key-value pair One, 1 // Removes the key/value pair related to the specified key from the dictionary. 
            d.Remove("Dos");  // Remove key-value pair Dos, 2

            Console.WriteLine("Dictionary after Remove(\"One\") & Remove(\"Dos\"):");
            foreach (string s in d.Keys) // Keys - Gets an indexed collection containing only the keys contained in the dictionary. 
                Console.WriteLine(s + ": " + d[s]);  // Uno: 1  Deux: 2
            Console.WriteLine("\nCount: {0}", d.Count); // 2  // Gets the number of key/value pairs contained in the dictionary. 

            Console.WriteLine("d.ContainsKey(\"Dos\"):" + d.ContainsKey("Dos"));
            // ContainsKey(K key) - Returns true if the specified key is present in the dictionary. 

            // ContainsValue(V value) - Returns true if the specified value is present in the dictionary. 
            Console.WriteLine("d.ContainsValue(2):" + d.ContainsValue(2));

            d.Clear(); // Removes all the key/value pairs from the dictionary. 
            Console.WriteLine("d.Count of d.Clear():"+d.Count);


        }
    }
}
