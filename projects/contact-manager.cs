List<Person> contacts = new List<Person>();
bool running = true;

while (running)
{
    System.Console.WriteLine("=========================================");
    System.Console.WriteLine("             CONTACT MANAGER             ");
    System.Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");

    System.Console.WriteLine("Please choose an action:");
    System.Console.WriteLine("0. Exit");
    System.Console.WriteLine("1. Show All Contacts");
    System.Console.WriteLine("2. Search Contact");
    System.Console.WriteLine("3. Add New Contact");
    System.Console.WriteLine("4. Delete A Contact");

    System.Console.Write(">>> ");
    var action = Console.ReadLine();

    switch (action)
    {
        case "0":
            running = false;
            break;
        case "1":
            if (contacts.Count <= 0)
            {
                System.Console.WriteLine("No contacts found, try adding one!");
                Console.ReadLine();
                break;
            }
            foreach (var person in contacts)
            {
                System.Console.WriteLine("**********************");
                System.Console.WriteLine($"Name: {person.Name}");
                System.Console.WriteLine($"Number: {person.Number}");
                System.Console.WriteLine($"Email: {person.Email}");
                System.Console.WriteLine("**********************");
            }
            Console.ReadLine();
            break;
        case "2":
            System.Console.Write("Enter the name to search: ");
            var nameToSearch = Console.ReadLine();
            var found = contacts.FirstOrDefault(x => x.Name == nameToSearch);
            if (found != null)
            {
                System.Console.WriteLine("Contact found with that name:");
                System.Console.WriteLine("**********************");
                System.Console.WriteLine($"Name: {found.Name}");
                System.Console.WriteLine($"Number: {found.Number}");
                System.Console.WriteLine($"Email: {found.Email}");
                System.Console.WriteLine("**********************");
            }
            else
            {
                System.Console.WriteLine("Contact Not Found!");
            }
            Console.ReadLine();
            break;
        case "3":
            System.Console.WriteLine("Please fill out following details!");
            System.Console.Write("Name: ");
            var newName = Console.ReadLine() ?? "";
            System.Console.Write("Number: ");
            var newNum = Console.ReadLine() ?? "";
            System.Console.Write("Email (optional): ");
            var newEmail = Console.ReadLine() ?? "";

            var newContact = new Person(newName, newNum, newEmail);
            contacts.Add(newContact);
            System.Console.WriteLine("New contact added!");
            Console.ReadLine();
            break;
        case "4":
            if (contacts.Count <= 0)
            {
                System.Console.WriteLine("No contacts found, try adding one!");
                Console.ReadLine();
                break;
            }
            for (int i = 0; i < contacts.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}. {contacts[i].Name} ({contacts[i].Number})");
            }
            System.Console.Write("Contact name to delete: ");
            var delContact = Console.ReadLine();
            var contactFound = contacts.FirstOrDefault(x => x.Name == delContact);
            if (contactFound != null)
            {
                contacts.Remove(contactFound);
                System.Console.WriteLine("Contact deleted!");
            }
            else
            {
                System.Console.WriteLine("Conact not found!");
            }
            Console.ReadLine();
            break;
        default:
            System.Console.WriteLine("Please choose a valid action!\n");
            Console.ReadLine();
            break;
    }
}

class Person
{
    public string Name = "";
    private string number = "";
    private string email = "";

    public string Number
    {
        get { return number; }
        set { number = value; }
    }
    public string Email
    {
        get { return email; }
        set { if (value.Contains('@')) { email = value; } else { email = "No email added!"; } }
    }

    public Person(string name, string number, string email)
    {
        Name = name;
        Number = number;
        Email = email;
    }
}
