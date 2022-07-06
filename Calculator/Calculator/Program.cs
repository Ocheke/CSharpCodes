// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Abigail!");
while (true)
{
    string num1;
    string num2;
    string op;
    Console.WriteLine("Enter first number");
    num1 = Console.ReadLine();
    Console.WriteLine("The operators are +,-,*,/,%,^");
    op = Console.ReadLine();
    Console.WriteLine("Enter second number");
    num2 = Console.ReadLine();

    if (op == "+")
    {
        Console.WriteLine("The result is");
        Console.WriteLine(int.Parse(num1) + int.Parse(num2));
    }
    else if (op == "-")
    {
        Console.WriteLine("The result is");
        Console.WriteLine(int.Parse(num1) - int.Parse(num2));
    }
    else if (op == "*")
    {
        Console.WriteLine("The result is");
        Console.WriteLine(int.Parse(num1) * int.Parse(num2));
    }
    else if (op == "/")
    {
        Console.WriteLine("The result is");
        Console.WriteLine((decimal)int.Parse(num1) / int.Parse(num2));
    }
    else if (op == "%")
    {
        Console.WriteLine("The result is");
        Console.WriteLine(int.Parse(num1) % int.Parse(num2));
    }
    //else if (op == "^")
    //{
        //Console.WriteLine("The result is");
        //Console.WriteLine(Math.Sqrt(int.Parse(num1) + int.Parse(num2)));
    //}
    else if (op == "^")
    {
        Console.WriteLine($"The result is {Math.Sqrt(int.Parse(num1))}");


    }
    else
    {
        Console.WriteLine("Enter a valid number");
    }

}