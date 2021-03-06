using Registration_Regex;

namespace Regex_Testing
{
    [TestClass]
    public class UnitTest1
    {
       
            [TestMethod]

            public void FirstTest()
            {
                RegexPattern check = new RegexPattern();
                bool res = check.Validate("Ayub");
                bool exp = true;
                Assert.AreEqual(exp, res);
            }
            [TestMethod]
            public void LastTest()
            {
                RegexPattern check1 = new RegexPattern();
                bool exp = true;
                bool res = check1.ValidateLast("Khan");
                Assert.AreEqual(exp, res);
            }
            [TestMethod]
            public void MailTest()
            {
                RegexPattern check2 = new RegexPattern();
                bool exp = true;
                bool res = check2.ValidateMail("AyubKhan@gmail.com");
                Assert.AreEqual(exp, res);
            }
            [TestMethod]
            public void Mobiletest()
            {
                RegexPattern check3 = new RegexPattern();
                bool exp = true;
                bool res = check3.ValidateNumber("91 9876543210");
                Assert.AreEqual(exp, res);
            }
            [TestMethod]
            public void PasswordTest()
            {
                RegexPattern check4 = new RegexPattern();
                bool exp = true;
                bool res = check4.ValidatePassword("Khan235@45");
                Assert.AreEqual(exp, res);
            }
        [TestMethod]
        public void FirstName()
        {
            Regex_Pattern_Exp regex = new Regex_Pattern_Exp();
            string res = regex.FirstName("Ayub");
            Assert.AreEqual("Correct", res);
        }
        [TestMethod]
        public void LastName()
        {
            Regex_Pattern_Exp regex = new Regex_Pattern_Exp();
            string res = regex.LastName("Khan");
            Assert.AreEqual("Correct", res);
        }
        [TestMethod]
        public void Email()
        {
            Regex_Pattern_Exp regex = new Regex_Pattern_Exp();
            string result = regex.Email("Ayub@bl.co.in");
            Assert.AreEqual("Correct", result);
        }
        [TestMethod]
        public void MobileNumber()
        {
            Regex_Pattern_Exp regex = new Regex_Pattern_Exp();
            string res = regex.PhoneNumber("91 9874563120");
            Assert.AreEqual("Correct", res);
        }
        [TestMethod]
        public void Password()
        {
            Regex_Pattern_Exp regex = new Regex_Pattern_Exp();
            string res = regex.Password("Ayub@7");
            Assert.AreEqual("Correct", res);
        }
    }
    
}