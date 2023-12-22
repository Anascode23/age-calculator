Console.WriteLine("Please enter when you were born to calculate you age: ");
var input = Console.ReadLine();
if (int.TryParse(input, out var year))
{
    var birthdate = new DateTime(year,1,1);
    var currentyear =  DateTime.Now.Year;
    var age =  Convert.ToInt32(currentyear - birthdate.Year);
    Console.WriteLine("You are " + age + " years old");
}
