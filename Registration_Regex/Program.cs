using Registration_Regex;
Console.WriteLine("Registraion problem Using Regex");





//To Validate First Name
 
RegexPattern Rp = new RegexPattern();
var result = Rp.Validate();
Console.WriteLine(result);
Console.WriteLine("------------------------------------------");




//To Validate Last Name

RegexPattern Rp1 = new RegexPattern();
var result1 = Rp1.ValidateLast();
Console.WriteLine(result1);
Console.WriteLine("------------------------------------------");

