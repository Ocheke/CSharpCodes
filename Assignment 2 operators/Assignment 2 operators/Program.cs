// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, abigail");

//Console.WriteLine("Enter first number");
//string num1 = Console.ReadLine();
//Console.WriteLine("Enter second number");
//string num2 = Console.ReadLine();
//Console.WriteLine("Enter third number");
//string num3 = Console.ReadLine();
//Console.WriteLine("Enter fourth number");
//string num4 = Console.ReadLine();
//Console.WriteLine("Enter firth number");
//string num5 = Console.ReadLine();

//Console.WriteLine($"Total = {(int.Parse(num1) + int.Parse(num2)) * (int.Parse(num3)) - (int.Parse(num4)) / int.Parse(num5)} ");


while (true)
{
    Console.WriteLine("Enter first number");
    string num1 = Console.ReadLine();
    Console.WriteLine("Enter second number");
    string num2 = Console.ReadLine();
    Console.WriteLine($"Total = {int.Parse(num1) + int.Parse(num2)}");

    Console.WriteLine("Enter third number");
    string num3 = Console.ReadLine();
    Console.WriteLine($"Total = {(int.Parse(num1) + int.Parse(num2)) * int.Parse(num3)}");

    Console.WriteLine("Enter fourth number");
    string num4 = Console.ReadLine();
    Console.WriteLine($"Total = {(int.Parse(num1) + int.Parse(num2)) * (int.Parse(num3)) - (int.Parse(num4))}");

    Console.WriteLine("Enter firth number");
    string num5 = Console.ReadLine();
    int total = (int.Parse(num1) + int.Parse(num2)) * (int.Parse(num3)) - (int.Parse(num4));
    Console.WriteLine($"Total = {total / int.Parse(num5)}");
}


