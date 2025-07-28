string name = "Potato";
int age = 5;
bool isBoiled = false;

Console.WriteLine("Hello, World! Me " + name + " ~");
Console.WriteLine("Age: " + age);
Console.WriteLine("Is boiled? " + isBoiled);

int maxAge = 13;
double temperature = 34.6; // in degree celsius
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

    if ((temperature % age) < 1)
    {
        age += 1;
    }
    else
    {
        age += 2;
    }
}

void Greet(string name, int age)
{
    string status = age < 18 ? "a cool kid" : "an awesome adult";
    System.Console.WriteLine($"Hello {name}! You are {age} years old and {status}.");
}

Greet(name, age);
System.Console.WriteLine(nameof(Greet));

int Square(int x) => x * x;
System.Console.WriteLine(Square(69));


(string name, int age) GetInfo()
{
    return ("Potato", 12);
}

var info = GetInfo();
System.Console.WriteLine($"Once Again: {info.name} // {info.age}");
