Stack<string> pancakes = new Stack<string>();
int pancakesCount = 2;
Console.WriteLine("# Using Stack for Pancakes! #");
Console.WriteLine("+++++++++++++++++++++++++++++");
Console.WriteLine($"How many pancakes do you want? (defualt to {pancakesCount}) ");
Console.Write(">>> ");
pancakesCount = int.Parse(Console.ReadLine() ?? "2");

for (int i = 0; i < pancakesCount; i++)
{
    pancakes.Push($"pancake {i + 1}");
}

while (pancakes.Count > 0)
{
    Console.Write("Press enter to start eating!");
    Console.ReadLine();
    Console.WriteLine($"You just ate {pancakes.Pop()}");
    Console.WriteLine($"Pancakes left: {pancakes.Count()}");
}
