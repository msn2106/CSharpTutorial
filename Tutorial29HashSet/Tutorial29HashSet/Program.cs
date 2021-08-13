using System;
using System.Collections.Generic;

/* HashSet:
 * A hash set is a set of unique values where duplicates are not allowed.
 * C# includes the HashSet<T> class in the generic collections namespace. 
 * All HashSet<T> elements are required to be of the same type T.
 */

/* Hash sets are different from other collections because they are simply a set of values. 
 * They do not have index positions and elements cannot be ordered.
 */

/* The HashSet<T> class provides high-performance set operations. 
 * HashSets allow fast lookup, addition, and removal of items, and can be used to implement either
 * dynamic sets of items or lookup tables that allow finding an item by its key 
 * (e.g., finding the phone number of a person by the last name).
 */

namespace Tutorial29HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hs = new HashSet<int>();

            hs.Add(5); // Add(T t) Adds a value (t) to the hash set. 
            hs.Add(10);
            hs.Add(15);
            hs.Add(25);
            hs.Add(15); // This will be just ignored as 15 is already present in hashset.
            hs.Add(20);

            Console.Write("\nHashSet: ");
            foreach (int i in hs)
                Console.Write(i + " ");  // 5  10  15  20  *elements may be in any order
            Console.Write("\nCount: " + hs.Count);  // 4 // Returns the number of values in the hash set. 

            HashSet<int> hs2 = new HashSet<int>();
            hs2.Add(15);
            hs2.Add(20);
            //hs2.Add(30);
            Console.Write("\n{15, 20} is a subset of {5, 10, 15, 25, 20}: " + hs2.IsSubsetOf(hs)); // True 
            // IsSubsetOf(ICollection c) Returns true if the hash set is a subset of the specified collection (c).

            Console.WriteLine();
            hs.Remove(15); // Remove(T t) Removes the value (t) from the hash set. 
            Console.Write("HashSet hs after hs.Remove(15):");
            foreach (int i in hs) Console.Write(i+" ");

            Console.WriteLine("hs.Contains(10):" + hs.Contains(10)); // Contains(T t) Returns true when a value (t) is present in the hash set. 

            string str = hs.ToString();
            Console.WriteLine(str);
        }
    }
}
/* Some other useful methods of HashSet are:-
 * Clear() Removes all the elements form the hash set.
 * Contains(T t) Returns true when a value (t) is present in the hash set.
 * ToString() Creates a string from the hash set.
 * IsSupersetOf(ICollection c) Returns true if the hash set is a superset of the specified collection.
 * UnionWith(ICollection c) Applies set union operation on the hash set and the specified collection (c).
 * IntersectWith(ICollection c) Applies set intersection operation on the hash set and the specified collection (c).
 * ExceptWith(ICollection c) Applies set difference operation on the hash set and the specified collection (c). 
 */