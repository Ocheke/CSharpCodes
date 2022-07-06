// See https://aka.ms/new-console-template for more information
Console.WriteLine("WELCOME, USER!");

List<int> score = new List<int>();


Console.WriteLine("CBT PRACTISE APP.");
Console.WriteLine("BIOLOGY QUESTION PAPER.");
Console.WriteLine("YOU HAVE 10 QUESTIONS IN THIS SESSION.");
Console.WriteLine("KINDLY BE WARNED THAT AN INVALID OPTION WILL MAKE YOU FAIL THE QUESTION NUMBER.");
Console.WriteLine("ANSWERS MUST BE IN UPPER CASE.");
Console.WriteLine(" ");

Console.WriteLine("1.  Which of following resoures cannot be conserved?. ");
Console.WriteLine("A.  Forest.");
Console.WriteLine("B.  Water.");
Console.WriteLine("C.  Soil.");
Console.WriteLine("D.  Garbage.");
string quest1 = Console.ReadLine();

if (quest1 == "D")
    {
        Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 2 POINTS.");
        score.Add(2);
    }
    else if (quest1 != "A" && quest1 != "B" && quest1 != "C" && quest1 != "D")
    {
        Console.WriteLine("INVALID COMMAND. YOU HAVE FAILED THIS ROUND.");
    }
    else
    {
        Console.WriteLine("YOU FAILED THIS ROUND.");
    }
Console.WriteLine(" ");

Console.WriteLine("2.  Which of the following is common in both plant and animal cell?. ");
Console.WriteLine("A.  Cellulose cell wall.");
Console.WriteLine("B.  Chlorophyll.");
Console.WriteLine("C.  Cell membrane.");
Console.WriteLine("D.  Large vacuole.");
string quest2 = Console.ReadLine();

    if(quest2 == "C")
    {
    
        Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 2 POINTS.");
        score.Add(2);
    }
    else if (quest2 != "A" && quest2 != "B" && quest2 != "C" && quest2 != "D")
    {
        Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
    }

    else
      {
            Console.WriteLine("YOU FAILED THIS ROUND.");
      }
Console.WriteLine(" ");

Console.WriteLine("3.  A plant which grows on another plant without an apparent harm to the host is called..?. ");
Console.WriteLine("A.  Parasite.");
Console.WriteLine("B.  Epiphyte.");
Console.WriteLine("C.  Saprophyte.");
Console.WriteLine("D.  Predator.");
string quest3 = Console.ReadLine();

    if (quest3 == "C")
    {
        Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 2 POINTS.");
        score.Add(2);
    }
    else if (quest3 != "A" && quest3 != "B" && quest3 != "C" && quest3 != "D")
    {
        Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
    }
    else
    {
        Console.WriteLine("YOU FAILED THIS ROUND.");
    }
Console.WriteLine(" ");

Console.WriteLine("4.  The following are types of fingerprints except..?. ");
Console.WriteLine("A.  Simple.");
Console.WriteLine("B.  Whorl.");
Console.WriteLine("C.  Loop.");
Console.WriteLine("D.  Compound.");
string quest4 = Console.ReadLine();

    if (quest4 == "A")
    {
        Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 2 POINTS.");
        score.Add(2);
    }
    else if (quest4 != "A" && quest4 != "B" && quest4 != "C" && quest4 != "D")
    {
        Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
    }
    else
    {
        Console.WriteLine("YOU FAILED THIS ROUND.");
    }
Console.WriteLine(" ");

Console.WriteLine("5.  Modern humans belong to the species of ....?. ");
Console.WriteLine("A.  Homo sapiens.");
Console.WriteLine("B.  Homo erectus.");
Console.WriteLine("C.  Homo habilis.");
Console.WriteLine("D.  Homo Neanderthal man.");
string quest5 = Console.ReadLine();

    if (quest5 == "A")
    {
        Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 2 POINTS.");
        score.Add(2);
    }
    else if (quest5 != "A" && quest5 != "B" && quest5 != "C" && quest5 != "D")
    {
        Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
    }
    else
    {
        Console.WriteLine("YOU FAILED THIS ROUND.");
    }
Console.WriteLine(" ");

Console.WriteLine("6.  Detoxification of urea takes place in the...?. ");
Console.WriteLine("A.  Pancreas.");
Console.WriteLine("B.  Heart.");
Console.WriteLine("C.  Lungs.");
Console.WriteLine("D.  Liver.");
string quest6 = Console.ReadLine();

    if (quest6 == "D")
    {
        Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 2 POINTS.");
        score.Add(2);
    }
    else if (quest6 != "A" && quest6 != "B" && quest6 != "C" && quest6 != "D")
    {
        Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
    }
    else
    {
        Console.WriteLine("YOU FAILED THIS ROUND.");
    }
Console.WriteLine(" ");

Console.WriteLine("7.  Rabbits cannot survive in an aquatic habit because they have..?. ");
Console.WriteLine("A.  No scales.");
Console.WriteLine("B.  No gills.");
Console.WriteLine("C.  Forelimbs.");
Console.WriteLine("D.  Lateral line.");
string quest7 = Console.ReadLine();

    if (quest7 == "B")
    {
        Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 2 POINTS.");
        score.Add(2);
    }
    else if (quest7 != "A" && quest7 != "B" && quest7 != "C" && quest7 != "D")
    {
        Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
    }
    else
    {
        Console.WriteLine("YOU FAILED THIS ROUND.");
    }
Console.WriteLine(" ");

Console.WriteLine("8.  Which of the following organisms exhibits division of labour?. ");
Console.WriteLine("A.  Butterfly.");
Console.WriteLine("B.  Cockroach.");
Console.WriteLine("C.  Termite.");
Console.WriteLine("D.  Housefly.");
string quest8 = Console.ReadLine();

    if (quest8 == "C")
    {
        Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 2 POINTS.");
        score.Add(2);
    }
    else if (quest8 != "A" && quest8 != "B" && quest8 != "C" && quest8 != "D")
    {
        Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
    }
    else
    {
        Console.WriteLine("YOU FAILED THIS ROUND.");
    }
Console.WriteLine(" ");

Console.WriteLine("9.  Which of the following hormones is suddenly secreted into the bloodstream of a frightened person?. ");
Console.WriteLine("A.  Insulin.");
Console.WriteLine("B.  Adrenaline.");
Console.WriteLine("C.  Thyroxin.");
Console.WriteLine("D.  Para hormone.");
string quest9 = Console.ReadLine();

    if (quest9 == "B")
    {
        Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 2 POINTS.");
        score.Add(2);
    }
    else if (quest9 != "A" && quest9 != "B" && quest9 != "C" && quest9 != "D")
    {
        Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
    }
    else
    {
        Console.WriteLine("YOU FAILED THIS ROUND.");
    }
Console.WriteLine(" ");

Console.WriteLine("10.  Natural selection arises as a result of..?. ");
Console.WriteLine("A.  Gene mutation.");
Console.WriteLine("B.  Change of habitat.");
Console.WriteLine("C.  Reduction in population.");
Console.WriteLine("D.  Climate change.");
string quest10 = Console.ReadLine();

    if (quest10 == "D")
    {
        Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 2 POINTS.");
        score.Add(2);
    }
    else if (quest10 != "A" && quest10 != "B" && quest10 != "C" && quest10 != "D")
    {
        Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
    }
    else
    {
        Console.WriteLine("YOU FAILED THIS ROUND.");
    }
Console.WriteLine(" ");
Console.WriteLine($"YOUR TOTAL SCORE IS = {score.Sum()}.");





