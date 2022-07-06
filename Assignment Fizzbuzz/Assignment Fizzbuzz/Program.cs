// See https://aka.ms/new-console-template for more information
Console.WriteLine("HELLO, USER!");
Console.WriteLine("WELCOME TO FIZZBUZZ GAME!");
Console.WriteLine(" ");

for (int i = 1; i <= 100; i = i + 1)
{
    if (i % 3 == 0 && i % 5 == 0 )
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
