using System;
using System.Collections;   //notice it is not in Generic

/* BitArray 
 * A bit array is a collection of bits. The value of a bit can be either 0 (off/false) or 1 (on/true).
 * Bit arrays compactly store bits. Most commonly, they are used to represent a simple group of boolean flags or an ordered sequence of boolean values.
 */
/*BitArrays can be used in image processing to store the individual bits of a gray-scale image. 
 */

namespace Tutorial25BitArray
{
    class Program
    {
        // Printing BitArray
        public static void PrintBarr(string name, BitArray ba)
        {
            Console.Write(name + " : ");
            for (int x = 0; x < ba.Length; x++)
                Console.Write(ba.Get(x) + " "); //Gets the value of the bit at a specified position i in the bit array. 
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);

            ba1.SetAll(true); // Sets all the bits to a specified value in the bit array. 
            ba2.SetAll(false);

            ba1.Set(2, false); // Sets the bit at a specified position i to a specified value in the bit array.
            ba2.Set(3, true); 

            PrintBarr("ba1", ba1);
            PrintBarr("ba2", ba2);
            Console.WriteLine();

            PrintBarr("ba1 AND ba2", ba1.And(ba2)); // Performs the bitwise AND operation on the elements of the bit array object with a specified bit array ba. 
            PrintBarr("    NOT ba2", ba2.Not()); // Inverts the bit values of the bit array. 
            PrintBarr("ba1 OR ba2", ba1.Or(ba2)); // Performs the bitwise OR operation on the elements of the bit array and the specified bit array ba. 
            PrintBarr("ba1 XOR ba2", ba1.Xor(ba2)); // Performs the bitwise XOR operation on the elements of the current bit array object and the elements in the specified bit array ba. 

            Console.WriteLine("Count:"+ba1.Count); // Gets the number of bits in the bit array. 
            Console.WriteLine("IsReadOnly:"+ ba1.IsReadOnly); // Gets a value indicating if the bit array is read only or not. 

            Console.WriteLine("Length:"+ba1.Length);

            Console.Write(ba1.And(ba2).Get(3));

        }
    }
}
