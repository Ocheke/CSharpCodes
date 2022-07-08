// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("enter first number");
    string num1 = Console.ReadLine();
    Console.WriteLine("enter second number");
    string num2 = Console.ReadLine();
    Console.WriteLine((decimal)int.Parse(num1) / int.Parse(num2));
}
catch(FormatException)
{
    Console.WriteLine("Only numbers allowed");
}
catch(DivideByZeroException)
{
    Console.WriteLine("You can't divide by zero");
}
catch(Exception err)
{
    Console.WriteLine(err);
}
finally
{
    Console.WriteLine("Thanks for trying......");
}

for(int i = 0; i <= 100; i++)
{
    Console.WriteLine(i);
}