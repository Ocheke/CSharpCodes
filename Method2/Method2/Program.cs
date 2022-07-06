// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



static int Root(int x)
{
    return x*x  ;
}
Console.WriteLine(Root(10));

static int Credit(int r)
{
    return r * r * r;

}
Console.WriteLine(Credit(10));


static void Sentence(string day, double time, int year)
{
    Console.WriteLine($"Today is " + day);
    Console.WriteLine("and the time is " + time);
    Console.WriteLine("and the year is " + year);
}
Sentence("Monday", 10.30, 2022);

//DateTime dt = new DateTime(2022, 6, 16,7,10,24,DateTimeKind.Local);

static void Date()
{
    DateTime dt = DateTime.Now;
    Console.WriteLine($"Today is {dt.ToString("dddd")} and the time is {dt.ToString("hh:mm:ss:tt")} and the year is {dt.ToString("yyy")}");
}
Date();

static int Highest(int t, int p)
{
    if (t > p)
    {
        return t;
    }
    else
    {
        return p;
    }
}
Console.WriteLine(Highest(10,0));
