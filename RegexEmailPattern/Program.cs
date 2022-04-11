using System;

namespace RegexEmailPattern
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\tWelcome to the Regex Email Pattern Problem");
            Console.WriteLine("============================================================\n");

            Console.WriteLine("   Custom Email Validation:");
            Console.WriteLine("==============================\n");
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            if(Pattern.ValidateEmail(email))
                Console.WriteLine($"\nThe entered input i.e. {email} is Valid.");
            else
                Console.WriteLine($"\nThe entered input i.e. {email} is InValid.");
        }
    }
}




