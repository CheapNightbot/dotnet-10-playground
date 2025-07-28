string name = "Potato";
int age = 5;
bool isBoiled = false;

Console.WriteLine("Hello, World! Me " + name + " ~");
Console.WriteLine("Age: " + age);
Console.WriteLine("Is boiled? " + isBoiled);

int maxAge = 13;
while (age < maxAge)
{

    if (isBoiled)
    {
        Console.WriteLine(name + " is ready to eat! 🤤");
        break;
    }
    else if (age > 8)
    {
        isBoiled = true;
    }
    else if (age < 8 && !isBoiled)
    {
        Console.WriteLine("NO! yu can't eat " + name + "!");
    }
    else
    {
        Console.WriteLine(name + " is not ready ~ 😣");
    }
    age++;
}
