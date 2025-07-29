Console.Write("What is your age?: ");

string age = Console.ReadLine() ?? "";
try
{
    int userAge = int.Parse(age);
    if (userAge <= 0)
    {
        throw new Exception($"Baka, how is your age '{age}' ?? (。_。)");
    }
}
catch (FormatException)
{
    Console.WriteLine($"'{age}' - huh ? (ｏ ‵-′)ノ”(ノ﹏<。) don't you know numbers ?!!!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("~ (￣m￣）");
}
