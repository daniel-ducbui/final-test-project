using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Functions.Validation
{
    class RegexPatterns
    {
        public static string Username { get; } = @"^[a-z][a-zA-Z0-9-_.]*$";
        public static string Password { get; } = @"^[a-z0-9]{3,9}$";
        public static string Name { get; } = @"\b[A-Z][a-z]*( [A-Z][a-z]*)*\b";
        public static string Dob { get; } = @"^(\d{1,2})/(\d{1,2})/(\d{4})$";
    }
}
