using LevelEvaluation.Data;
using System;

namespace Q2_Register
{
    class Program
    {
        /// <summary>
        /// This method prints info provided by a user about themselves.
        /// The text after * should be displayed in the console.
        /// The text surrounded by -- is an example of a user input.
        /// You must complete the todos in the Person class first.
        /// You must use the Person class with its ToString method.
        /// </summary>
        static void Main(string[] args)
        {
            Person person;

            // * Hello, please enter your name:
            // -- Max --
            Console.WriteLine("Hello, please enter your name:");
            string name = Console.ReadLine();


            // * How old are you?
            // -- 25 --
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            // * Where are you from?
            // -- United States --
            Console.WriteLine("Where are you from?");
            string country = Console.ReadLine();

            // * What languages do you speak?
            // -- English French Japanese --
            Console.WriteLine("What languages do you speak?");
            string[] languages = Console.ReadLine().Split(' ');

            Console.WriteLine();

            // * Hey there! My name is Max.
            // * I am from the United States and I am 25 years old.
            // * I speak the following languages: English, French, Japanese.
            person = new Person(name, age, country, languages);
            Console.WriteLine(person.ToString());

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
