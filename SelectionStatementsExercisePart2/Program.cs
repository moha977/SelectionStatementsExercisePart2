using System;

namespace SelectionStatementsExercisePart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite school subject");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "Math":
                    Console.WriteLine("Math is awesome");
                    break;
                case "History":
                    Console.WriteLine("Very intresting");
                    break;
                case "English":
                    Console.WriteLine("Welcome to America");
                    break;
                case "science":
                    Console.WriteLine("Very tough");
                    break;
                case "coding":
                    Console.WriteLine("C# is the best");
                        break;
                    default:
                    Console.WriteLine("Try finding something you good at and like at the same time ");
                    break;
            }
        }
    }
}
