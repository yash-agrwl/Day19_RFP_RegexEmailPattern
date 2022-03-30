using System;

namespace RegexEmailPattern
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Regex Email Pattern Problem.\n");

            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            Console.WriteLine($"\nThe entered input i.e. {email} is " + Pattern.ValidateEmail(email));
        }
    }
}




