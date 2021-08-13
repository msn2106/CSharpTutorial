using System;
using System.Collections.Generic;


/* Stack:
 * A stack is a Last In, First Out (LIFO) collection of elements where the last element that goes into the stack will be the first element that comes out.
 * Inserting an element onto a stack is called pushing. Deleting an element from a stack is called popping. 
 * Pushing and popping can be performed only at the top of the stack.
 * Stacks can be used to create undo-redo functionalities, parsing expressions (infix to postfix/prefix conversion), 
 * and much more.
 * The C# generic collection Stack<T> class requires all elements to be of the same type T.
 */

namespace Tutorial26Stack
{
    class Program
    {
        static void Main(string[] args)
        {
			Stack<int> s = new Stack<int>();

			s.Push(59); // Inserts an element t at the top of the stack. 
			s.Push(72);
			s.Push(65);

			for (int i = 80; i > 20; i = i - 11) s.Push(i);

			Console.Write("Stack: ");
			foreach (int i in s)
				Console.Write(i + " ");  // 65  72  59
			Console.Write("\nCount: " + s.Count);  // 3 // Returns the number of elements in the stack.

			Console.Write("\nTop: " + s.Peek());  // 65 // Returns the element at the top of the stack without removing it. 
			Console.Write("\nPop: " + s.Pop());  // 65 // Returns the element at the top of the stack and removes it from the stack. 

			Console.Write("\nStack: ");
			foreach (int i in s)
				Console.Write(i + " ");  // 72  59
			Console.Write("\nCount: " + s.Count);  // 2
            Console.WriteLine();

            Console.WriteLine("Contains(11):"+ s.Contains(11));

            Console.Write("As array using ToArray():");
			int[] arr = s.ToArray(); // Copies the stack into a new array. 
			foreach (int i in arr) Console.Write(i+",");
            Console.WriteLine();

			s.Clear(); // Removes all the elements from the stack. 
			Console.WriteLine("Count after Clear():"+s.Count);
		}
    }
}
