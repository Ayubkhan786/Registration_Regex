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
         string FirstName = "^[A-Z]{1}[a-zA-Z]{3,15}$";
        string First = Console.ReadLine();
       
        /// <summary>
        /// Name starts with Capital
        /// Length Min 3 Char
        /// </summary>
        string LastName = "^[A-Z]{1}[a-zA-Z]{3,15}$";
        string Last = Console.ReadLine();

        /// <summary>
        ///  E.g. abc.xyz@bl.co.in 
        ///  Email has 3 mandatory parts (abc, bl & co)
        ///  2 optional(xyz & in) 
        ///  with precise @ and.positions
        /// </summary>
        /// 

        string Email = "^[0-9a-zA-Z]+.[a-zA-Z]{0,5}+@[a-zA-Z]{2,3}]+.[a-zA-Z]{2,3}+.[a-zA-Z]{2,4}&";
        string Mail = Console.ReadLine();
        public bool Validate()
        { 
            return Regex.IsMatch(First, FirstName);
        }
       public bool ValidateLast()
        { 
            return Regex.IsMatch(Last, LastName);
        }

        public bool ValidateMail()
        {
            return Regex.IsMatch(Mail, Email);
        }
    }
}



