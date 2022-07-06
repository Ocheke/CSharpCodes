// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(" ");


Dictionary<int, string> dict = new Dictionary<int, string>();

dict.Add(1, "Sleeping");
dict.Add(2, "Reading");
dict.Add(3, "playing Games");
dict.Add(4, "listening to music");

//foreach (var dicts in dict)
//{
//Console.WriteLine("key "+ dicts.Key +" Value "+ dicts.Value);
//Console.WriteLine(dicts.Key);
//Console.WriteLine(dicts.Value);
//}

for (int i = 1; i <= dict.Count; i = i + 1)
{
    Console.WriteLine(dict[i]);
}

/* for (int i = 2; i <= 5; i++)

    {

         reg = Console.ReadLine();
    }
    int limit = 5;
   /* if (dict.Contains(reg))
    {
        Console.WriteLine("YOU CAN PROCEED");
    }
    else
    {
        Console.WriteLine("YOU HAVE REACHED YOUR TRAIL LIMIT");
    }*/


