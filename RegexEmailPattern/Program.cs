using System;

namespace RegexEmailPattern
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Regex Email Pattern Problem.\n");

            string email = "abc";
            Console.WriteLine($"The mandatory 1st part of email i.e. {email} is " + Pattern.ValidateEmail(email));
        }
    }
}




