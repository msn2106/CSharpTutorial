using System;
using System.Linq;

namespace Tutorial2
{

    class Program
    {

        static void Main(string[] args)
        {
            // Arrays

            // Creation ---------------------------------------------------------------

            // All below are same thing and each way can be used.
            // string[] names = new string[3] { "John", "Mary", "Jessica" };
            // string[] names = new string[] { "John", "Mary", "Jessica" };
            // string[] names = { "John", "Mary", "Jessica" };
            string[] names = new string[3];
            names[0] = "John";
            names[1] = "Mary";
            names[2] = "Jessica";

            foreach(string s in names)Console.Write(s+" ");
            Console.WriteLine();

            //same like above all below are valid and can be used
            // double[] prices = new double[4] { 3.6, 9.8, 6.4, 5.9 };
            // double[] prices = new double[] { 3.6, 9.8, 6.4, 5.9 };
            double[] prices = { 3.6, 9.8, 6.4, 5.9 };

            foreach(double price in prices)Console.Write(price +" ");
            Console.WriteLine();

            // Accessing value at any valid index --------------------------------------------
            int[] numbers = { 4, 12, 3, 7, 34, 22 };
            Console.WriteLine(numbers[2]);


            // Accessing array in loops
            int[] a = new int[10];
            for (int k = 0; k < 10; k++)
            {
                a[k] = k * 2;
            }
            for (int k = 0; k < 10; k++)
            {
                Console.Write(a[k]+",");
            }
            Console.WriteLine();
            Console.Write("Using for each:");
            foreach (int k in a)
            {
                Console.Write(k+",");
            }
            Console.WriteLine();

            // using foreach for calculating sum
            int[] arr = { 11, 35, 62, 555, 989 };
            int sum = 0;

            foreach (int x in arr)sum += x;
            Console.WriteLine("Sum :"+sum);

            // Multidimensional Array ------------------------------------------
            // type[, , … ,] arrayName = new type[size1, size2, …, sizeN];

            Console.WriteLine("\nMultidimensional Array");
            int[,] someNums = { { 2, 3 }, { 5, 6 }, { 4, 6 } };
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(someNums[k, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Rank: " + someNums.Rank);

            // Jagged Array -----------------------------------------------------
            // This is a combination of array of array. The component arrays can be of different length
            // Unlike multi-dimensional array where each array should have same no. of columns.

            int[][] jagged = new int[3][];

            int[][] jaggedArr = new int[][]
            {
                new int[ ] {1,8,2,7,9},
                new int[ ] {2,4,6},
                new int[ ] {33,42}
            };

            int sampleVal = jaggedArr[2][1];
            Console.WriteLine("Element at jaggedArr[2][1]:"+sampleVal);
            Console.WriteLine("Rank: " + jaggedArr.Rank);

            /*
             * A jagged array is an array-of-arrays, so an int[ ][ ] is an array of int[ ],
             * each of which can be of different lengths and occupy their own block in memory.
             * A multidimensional array (int[,]) is a single block of memory (essentially a matrix).
             * It always has the same amount of columns for every row.
             */

            // Functions used with arrays
            // the Length and Rank properties return the number of elements and the number of
            // dimensions of the array, respectively. 
            int[] arr1 = { 2, 4, 7 };

            Console.WriteLine("\narr1.Length: "+ arr1.Length);
            for (int k = 0; k < arr1.Length; k++)
            {
                Console.Write(arr1[k]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Rank: "+arr1.Rank);
            Console.WriteLine("Max:"+arr1.Max());
            Console.WriteLine("Min:"+arr1.Min());
            Console.WriteLine("Sum:"+arr1.Sum());

        }
    }
}
