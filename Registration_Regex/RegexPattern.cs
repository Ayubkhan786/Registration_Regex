using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Registration_Regex
{
    public class RegexPattern
    {
        /// <summary>
        /// Name starts with Capital
        /// Length Min 3 Char
        /// </summary>
         string FirstName = "^[A-Z]{1}[a-zA-Z]{3,10}$";
         string First = Console.ReadLine();
        public bool Validate()
        { 
            return Regex.IsMatch(First, FirstName);
        }
       
    }
}



