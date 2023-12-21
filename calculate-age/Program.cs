Console.WriteLine("Please enter when you were born to calculate you age: ");
var input = Console.ReadLine();

if (DateTime.TryParse(input, out var dateTime))
{
    int year = dateTime.Year;
    Console.WriteLine("datetime object now" + year);
}
//Console.WriteLine(age);