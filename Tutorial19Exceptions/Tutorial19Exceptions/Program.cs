using System;
/*
 * An exception is a problem that occurs during program execution. Exceptions cause abnormal termination of the program.
 * An exception can occur for many different reasons. Some examples:
 * - A user has entered invalid data.
 * - A file that needs to be opened cannot be found.
 * - A network connection has been lost in the middle of communications.
 * - Insufficient memory and other issues related to physical resources. 
 */
/*
 * exceptions are caused by user error, programmer error, or physical resource issues. 
 * However, a well-written program should handle all possible exceptions.
 */
namespace Tutorial19Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] arr = new int[] { 4, 5, 8 };
            //Console.Write(arr[8]);  //Index out of range error.

            // code prone to exception is written in try block
            try
            {
                int[] arr1 = new int[] { 4, 5, 8 ,0};
                //Console.Write(arr1[8]);
                int res = arr1[1] / arr1[3];
                Console.WriteLine(res);
            }
            //exceptions are handled in catch block
            //there can be multiple catch block - they should exist in specific towards generic type
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot Divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("After try-catch block representing that it does not stop the flow of program.");

            /* Finally
             * An optional finally block can be used after the catch blocks. 
             * The finally block is used to execute a given set of statements, whether an exception is thrown or not.
             */
            int result = 0;
            int num1 = 8;
            int num2 = 4;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine(result);
            }
        }
    }
}
