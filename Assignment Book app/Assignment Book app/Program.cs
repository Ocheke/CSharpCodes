// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, User!");
Console.WriteLine(" ");

Dictionary<string, string> DictBook = new Dictionary<string, string>();

while (true)
{

    Console.WriteLine("What would you like to do? SAVE, VIEW, UPDATE, DELETE.");
    string book = Console.ReadLine(); 

    if (book == "save")
    {
        Console.WriteLine("Enter contact name to save.");
        string name = Console.ReadLine();
        Console.WriteLine("Enter phone number to save.");
        string number = Console.ReadLine();
        DictBook.Add(name, number);
        Console.WriteLine($"You have successfully saved {name}'s contact.");
    }
    else if (book == "view")
    {
        Console.WriteLine("Enter contact name to view.");
        string name = Console.ReadLine();
        if (DictBook.ContainsKey(name))
        {
            Console.WriteLine($"{name}'s contact is {DictBook[name]} ");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        } 
    }
    else if (book == "update")
    {
        Console.WriteLine("Enter contact name to update.");
        string name = Console.ReadLine();
        Console.WriteLine("Enter new number to update.");
        string number = Console.ReadLine();
        DictBook[name] = number;
        Console.WriteLine($"You updated {name}'s contact as {DictBook[name]}");
        //Console.WriteLine("Number successfully updated.");
    }
    else if (book == "delete")
    {
        Console.WriteLine("Enter contact name to delete.");
        string name = Console.ReadLine();
        DictBook.Remove(name);
        Console.WriteLine($"You have successfully deleted {name}'s contact.");
    }

    else
    {
        Console.WriteLine("Invalid command.");
    }




}





