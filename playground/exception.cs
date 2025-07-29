Console.Write("What is your age?: ");

string age = Console.ReadLine() ?? "";
// try
// {
//     int userAge = int.Parse(age);
//     if (userAge <= 0)
//     {
//         throw new InvalidAgeException($"Baka, how is your age '{age}' ?? (。_。)");
//     }
// }
// catch (FormatException)
// {
//     Console.WriteLine($"'{age}' - huh ? (ｏ ‵-′)ノ”(ノ﹏<。) don't you know numbers ?!!!");
// }
// catch (InvalidAgeException ex)
// {
//     Console.WriteLine(ex.Message);
// }
// finally
// {
//     Console.WriteLine("~ (￣m￣）");
// }

try
{
    if (!int.TryParse(age, out int userAge))
    {
        Console.WriteLine($"'{age}' - huh ? (ｏ ‵-′)ノ”(ノ﹏<。) don't you know numbers ?!!!");
    }

    else if (userAge <= 0)
    {
        throw new InvalidAgeException($"Baka, how is your age '{age}' ?? (。_。)");
    }
}
catch (InvalidAgeException ex)
{
    Console.WriteLine(ex.Message);
}

public class InvalidAgeException : Exception
{
    public InvalidAgeException() { }
    public InvalidAgeException(string message) : base(message) { }
    public InvalidAgeException(string message, Exception inner) : base(message, inner) { }
}
