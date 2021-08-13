using System;

/* Enums
 * The enum keyword is used to declare an enumeration: a type that consists of a set of named constants called the enumerator list.
 * By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1.
 * For example, in the following enumeration, Sun is 0, Mon is 1, Tue is 2, and so on:
 * enum Days {Sun, Mon, Tue, Wed, Thu, Fri, Sat}; 
 * Note that the values are comma separated. 
 */
/*Basically, Enums define variables that represent members of a fixed set.
 * Some sample Enum uses include month names, days of the week, cards in a deck, etc.
 */
namespace Tutorial18Enums
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        //You can also assign your own enumerator values: 
        enum DaysNew { Sun, Mon, Tue = 4, Wed, Thu, Fri, Sat };

        enum TrafficLights { Green, Red, Yellow };
        static void Main(string[] args)
        {
            // You can refer to the values in the Enum with the dot syntax. 
            // In order to assign Enum values to int variables, you have to specify the type in parentheses: 
            int y = (int)Days.Tue;
            Console.WriteLine(y);
            y = (int)DaysNew.Wed;
            Console.WriteLine(y);

            TrafficLights x = TrafficLights.Red;
            switch (x)
            {
                case TrafficLights.Green:
                    Console.WriteLine("Go!");
                    break;
                case TrafficLights.Red:
                    Console.WriteLine("Stop!");
                    break;
                case TrafficLights.Yellow:
                    Console.WriteLine("Caution!");
                    break;
            }
        }
    }
}
