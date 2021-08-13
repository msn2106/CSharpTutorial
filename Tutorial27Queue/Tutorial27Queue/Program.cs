using System;
using System.Collections.Generic;

/* Queue:
 * A queue is a First In, First Out (FIFO) collection of elements where the first element that goes into a queue is also the first element that comes out.
 * Inserting an element into a queue is referred to as Enqueue. Deleting an element from a queue is referred to as Dequeue.
 * Queues are used whenever we need to manage objects in order starting with the first one in.
 */

 /* Scenarios include printing documents on a printer, call center systems answering people on hold people, 
 * and so on.
 * The C# generic collection Queue<T> class requires that all elements be of the same type T.
 */


namespace Tutorial27Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(5); // Adds the object t to the end of the queue. 
            q.Enqueue(10);
            q.Enqueue(15);
            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");  // 5  10  15
            Console.Write("\nCount: " + q.Count);  // 3

            Console.Write("\nDequeue: " + q.Dequeue()); // 5 // Returns the object at the beginning of the queue and also removes it. 

            Console.Write("\nQueue: ");
            foreach (int i in q)
                Console.Write(i + " ");  // 10  15
            Console.Write("\nCount: " + q.Count);  // 2 // Gets the number of elements in the queue.

            Console.WriteLine("q.Contains(11):"+q.Contains(11)); // Returns true when the element t is present in the queue.

            Console.WriteLine("q.Peek():"+q.Peek()); // Returns the object at the beginning of the queue without removing it. 

            Console.Write("q.ToArray():"); //Copies the queue into a new array. 
            int[] arr = q.ToArray();
            foreach (int i in arr) Console.Write(i+",");
            Console.WriteLine();

            q.Clear(); // Removes all objects from the queue. 
            Console.WriteLine("Count of elements in q after q.Clear()"+ q.Count);
        }
    }
}
