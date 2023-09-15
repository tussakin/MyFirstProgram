using System;
namespace numberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Theres Sundberg Selin, klass .NET23


            int number = 13;

            // If-else-statement that compares the value of the variable declared above to see what statement to print
            if (number >= 10)
            {
                Console.WriteLine("Talet är stort!");
            }

            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            // Asks user for input and then colleects it
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();

            // Uses the inut and writes out a greeting with the input
            Console.WriteLine($"Hej {name}!");

            int countingToNumber = 0;

            // While-loop that compares variables so that it can print the numbers leading up to the number declared at the top
            while (countingToNumber <= number)
            {
                Console.WriteLine($"{countingToNumber}");
                countingToNumber++;
            }

        }
    }
}

