using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Registration_Regex
{

    public class Lambdafunction
    {
        //Regex Pattern For Validation

        public string FirstName = "^[A-Z]{1}[a-zA-Z]{3,15}$";
        public string LastName = "^[A-Z]{1}[a-zA-Z]{3,15}$";
        public string Mail = "^[0-9a-zA-Z]+.[a-zA-Z]{0,5}+@[a-zA-Z]{2,3}]+.[a-zA-Z]{2,3}+.[a-zA-Z]{2,4}&";
        public string Phone = "^[91]+[]+[6-9]{1}+[0-9]{9}$";
        public string Password = "^[A-Z]{1}+[a-zA-Z0-9]{8,}+[0-9]{1}+[!@#$%&*]{1}$";

        // Here Ternary operator is a Conditional operator and It takes arguments and evaluates a Boolean expression.

        // string? first = Console.ReadLine();
        public string resF(string first) => Regex.IsMatch(first, FirstName) ? "Correct" : "Wrong";

        // string? last = Console.ReadLine();
        public string resL(string last) => Regex.IsMatch(last, LastName) ? "Correct" : "Wrong";
        // string? Email = Console.ReadLine();
        public string resE(string Email) => Regex.IsMatch(Email, Mail) ? "Correct" : "Wrong";
        // string? PN = Console.ReadLine();
        public string resP(string PN) => Regex.IsMatch(PN, Phone) ? "Correct" : "Wrong";
        //  string? PW = Console.ReadLine();
        public string resPas(string PW) => Regex.IsMatch(PW, Password) ? "Correct" : "Wrong";


        //List<string> res1 = list.Where(x => Regex.IsMatch(first, FirstName) == true).ToList();
        //return IsMatch;
        //List<string> res1 = list2.Where(x => Regex.IsMatch(first, FirstName) == false).ToList();
        //return IsMatch2;

    }
}



