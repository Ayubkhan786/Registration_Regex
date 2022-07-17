using Registration_Regex;
//Console.WriteLine("Registraion problem Using Regex");






////To Validate First Name

//RegexPattern Rp = new RegexPattern();
//var result = Rp.Validate("Ayub");
//Console.WriteLine(result);
//Console.WriteLine("------------------------------------------");




////To Validate Last Name

//RegexPattern Rp1 = new RegexPattern();
//var result1 = Rp1.ValidateLast("Khan");
//Console.WriteLine(result1);
//Console.WriteLine("------------------------------------------");




////To Validate Mail

//RegexPattern Rp2 = new RegexPattern();
//var result2 = Rp2.ValidateMail("Ayub@bl.co.in");
//Console.WriteLine(result2);
//Console.WriteLine("------------------------------------------");


////To Validate Number

//RegexPattern Rp3 = new RegexPattern();
//var result3 = Rp3.ValidateNumber("91 9876543210");
//Console.WriteLine(result3);
//Console.WriteLine("------------------------------------------");



////To Validate Password

//RegexPattern Rp4 = new RegexPattern();
//var result4 = Rp4.ValidatePassword("Ayub56454@3");
//Console.WriteLine(result4);
//Console.WriteLine("------------------------------------------");

Lambdafunction lambdafunction = new Lambdafunction();

//To Validate First Name

Console.WriteLine("Check for FirstName");
string first = Console.ReadLine();
string resultF = lambdafunction.resF(first);
Console.WriteLine(resultF);

//To Validate Last Name

Console.WriteLine("Check for LastName");
string last = Console.ReadLine();
string resultL = lambdafunction.resL(last);
Console.WriteLine(resultL);

//To Validate Mail

Console.WriteLine("Check for Email");
string Email = Console.ReadLine();
string resultE = lambdafunction.resE(Email);
Console.WriteLine(resultE);

//To Validate Number

Console.WriteLine("Check for PhoneNumber");
string PN = Console.ReadLine();
string resultPN = lambdafunction.resP(PN);
Console.WriteLine(resultPN);

//To Validate Password

Console.WriteLine("Check for PassWord");
string PW = Console.ReadLine();
string resultPW = lambdafunction.resPas(PW);
Console.WriteLine(resultPW);