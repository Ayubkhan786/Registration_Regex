using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Registration_Regex
{
    public class Regex_Pattern_Exp
    {
        string ValidName = "^[A-Z]{1}[a-zA-Z]{3,15}$";
        string ValidMail = "^[0-9a-zA-Z]+.[a-zA-Z]{0,5}+@[a-zA-Z]{2,3}]+.[a-zA-Z]{2,3}+.[a-zA-Z]{2,4}&";
        string ValidNumber = "^[91]+[]+[6-9]{1}+[0-9]{9}$";
        string ValidPassword = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=-])[a-zA-Z0-9!@#$%^&*()_+=-]{8,15}$";

        public string FirstName(string firstname)
        {
            try
            {
                bool First = Regex.IsMatch(firstname, ValidName);
                if (First.Equals(true))
                {
                    Console.WriteLine("Correct");
                    return "Correct";
                }

                else
                {
                    throw new Exception_Handling("Wrong Format", CustomExp.Invalid_First_Name);
                }
            }
            catch (Exception_Handling ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public string LastName(string lastname)
        {
            try
            {
                bool last = Regex.IsMatch(lastname, ValidName);
                if (last.Equals(true))
                {
                    Console.WriteLine("Correct");
                    return "Correct";
                }

                else
                {
                    throw new Exception_Handling("Wrong Format", CustomExp.Invalid_Last_Name);
                }
            }
            catch (Exception_Handling ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public string Email(string email)
        {
            try
            {
                bool mail = Regex.IsMatch(email, ValidMail);
                if (mail.Equals(true))
                {
                    Console.WriteLine("Correct");
                    return "Correct";
                }

                else
                {
                    throw new Exception_Handling("Wrong Format", CustomExp.Invalid_Email);
                }
            }
            catch (Exception_Handling ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public string PhoneNumber(string phonenumber)
        {
            try
            {
                bool phone = Regex.IsMatch(phonenumber, ValidNumber);
                if (phone.Equals(true))
                {
                    Console.WriteLine("Correct");
                    return "Correct";
                }
                else
                {
                    throw new Exception_Handling("Wrong Format", CustomExp.Invalid_Phone_Number);
                }
            }
            catch (Exception_Handling ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public string Password(string password)
        {
            try
            {
                bool pass = Regex.IsMatch(password, ValidPassword);
                if (pass.Equals(true))
                {
                    Console.WriteLine("Correct");
                    return "Correct";
                }
                else
                {
                    throw new Exception_Handling("Wrong Format", CustomExp.Invalid_Password);
                }
            }
            catch (Exception_Handling ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
