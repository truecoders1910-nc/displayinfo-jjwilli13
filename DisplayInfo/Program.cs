using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get first and last name from user input
            // Get their favorite number
            // Get their favorite animal

            // Once you have gotten all their info and stored it,
            // display it back to them.

            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.

            Console.WriteLine("Hello, What is your first name?");
            string firstName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("What is your favorite animal?");
            string favAnmial = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Hello, {firstName} {lastName}!");


            if (favNum >= 10)

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your favorite number is {favNum}!");

            }

            if (favNum <= 5)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your favorite number is {favNum}!");

            }

            Console.ResetColor();

            Console.WriteLine($"Your favorite animal is a {favAnmial}!");




        }
    }      
}
