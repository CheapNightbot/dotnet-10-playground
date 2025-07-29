Console.WriteLine("Enter snack name or 'clear' to clear the snack log and 'exit' to exit out of Snack Logger!");
Console.Write(">>> ");
var snack = Console.ReadLine();

if (snack == "clear")
{
    File.WriteAllText("snacks.txt", "");
}
else if (snack == "exit")
{
    Environment.Exit(0);
}
else
{
    File.AppendAllText("snacks.txt", snack + Environment.NewLine);
}

string snackLog = File.ReadAllText("snacks.txt");

if (snackLog == "" && snack == "clear")
{
    Console.Write("Snack log cleared!");
}
else if (snackLog == "")
{
    Console.WriteLine("Snack log is empty! Try adding a snack next time...");
}
else
{
    Console.WriteLine("\nSnack Log:");
    Console.WriteLine("+++++++++\n");
    Console.WriteLine(snackLog);
}
