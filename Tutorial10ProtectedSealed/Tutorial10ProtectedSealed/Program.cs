using System;

/*
 * Public members may be accessed from anywhere outside of the class, while access to private members 
 * is limited to their class.
 * The protected access modifier is very similar to private with one difference; 
 * it can be accessed in the derived classes. So, a protected member is accessible only from 
 * derived classes. 
 */
/*
 * A class can prevent other classes from inheriting it, or any of its members, 
 * by using the sealed modifier. 
 */
namespace Tutorial10ProtectedSealed
{
    class Program
    {
        class Person
        {
            protected int Age { get; set; }     // this makes it accessible only in this class and derived classes
            protected string Name { get; set; }
        }
        class Student : Person
        {
            public Student(string nm)
            {
                Name = nm;
            }
            public void Speak()
            {
                Console.Write("Name: " + Name);
            }
        }

        sealed class Animal
        {
            //some code
        }
        //class Dog : Animal { } //Error as the class is sealed

        static void Main(string[] args)
        {
            Student s = new Student("David");
            s.Speak();
            //s.Age = 5;        // This will give error as the variable is protected in nature
        }
    }
}
