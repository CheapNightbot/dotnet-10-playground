string name = "Potato";
int age = 5;
bool isBoiled = true;

Console.WriteLine(name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Is boiled? " + isBoiled);

if (isBoiled)
{
    Console.WriteLine(name + " is ready to eat! 🤤");
}
else if (age < 8 && !isBoiled)
{
    Console.WriteLine("NO! yu can't eat " + name + "!");
}
else
{
    Console.WriteLine(name + " is not ready ~ 😣");
}
