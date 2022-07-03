using Registration_Regex;
Console.WriteLine("Registraion problem Using Regex");





//To Validate First Name
 
RegexPattern Rp = new RegexPattern();
var result = Rp.Validate();
Console.WriteLine(result);
