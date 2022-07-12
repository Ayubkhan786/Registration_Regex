using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Regex
{
        public enum CustomExp
        {

            Invalid_First_Name, Invalid_Last_Name, Invalid_Email, Invalid_Phone_Number, Invalid_Password

        }
        public class Exception_Handling : Exception
        {
            public CustomExp ex;
            public Exception_Handling(string msg, CustomExp ex) : base(msg)
            {
                this.ex = ex;
            }
        }
    }
}
