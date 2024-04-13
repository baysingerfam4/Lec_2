using System;

namespace Lec_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?");
            string username = Console.ReadLine();
            Console.Write("What is the date?");
            string userdate = Console.ReadLine();
            Console.Write("What is the assignment called?");
            string userassignment = Console.ReadLine();
            // Carla Baysinger
            // 04/12/2024
            // Lecture 2
            Console.WriteLine("//" + username);
            Console.WriteLine("//" + userdate);
            Console.WriteLine("//" + userassignment);

            Console.WriteLine("Hello, World");
            Console.WriteLine("Benny Goodman");
            Console.WriteLine("------");
            Console.WriteLine("sing, sing, sing");
            // 1.What does it mean to declare and initialize ? means to write down what a string is listed as. Assign a value.

           // 2.What does it mean to concatenate? Adding two strings together to form one complete string.

           // 3.What is a "string" type consist of(ex.numbers, letters, etc... )any character including numbers, letters, and symbols.

           // 4.Console.ReadLine() returns what TYPE ? where questions have to be answered (input)

           // 5.What happens if you try to assignment a value to a variable before it has been declared? It doesnt display. Its not in memory.

        }
    }
}
