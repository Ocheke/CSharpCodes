// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void MyName()
{
    Console.WriteLine("Abigail");
    Console.WriteLine("joy");
}
MyName();
MyName();
MyName();
MyName();
MyName();


static void AddMethod(int num1, int num2, int num3)
{
    Console.WriteLine(num1 + num2 + num3);
}
AddMethod(10, 5, 2);

AddMethod(50,45,5);

static int TheRemainder(int x, int y)
{
    return x % y;
}
Console.WriteLine(TheRemainder(35 , 4));