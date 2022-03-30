using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexEmailPattern
{
    internal class Pattern
    {

        public static string EmailPattern = "^[a-z0-9]+$";

        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, EmailPattern);
        }
    }
}