// See https://aka.ms/new-console-template for more information

namespace WordGuessApp
{
    class Progarm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLVE THE RIGHT PUZZLE BELOW ; ");
            //Console.WriteLine("BEAUTIFUL", "BAT", "EAT");
            List<ScrabbleWork> word = new List<ScrabbleWork>()
            {
                new ScrabbleWork ("BEAUTIFUL", "BAT", "EAT"),
                new ScrabbleWork ("REHEARSAL", "HERE", "HEAR"),
            };
            string[] NewWords = new string[3] { "BAT", "EAT", "BEAUTIFUL" };
            foreach(var words in word)
            {
                AskQuestion(words);
                Correct(words.NewWords);
            }

            static void AskQuestion(ScrabbleWork question)
            {
                Console.WriteLine(question.scrabble);
            }

            static void Correct(string correctanswers)
            {
                string secretword = "BEAUTIFUL";
                string guess = "";
                int guessCount = 0;
                int guessLimit = 3;
                bool outOfGuesses = false;

                while (guess != secretword && !outOfGuesses)
                {
                    string answer = Console.ReadLine();
                    if (answer.Equals(correctanswers, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("PASS! YOU HAVE GOTTEN 1 POINT");
                        //return 1;
                    }
                    else
                    {
                        Console.WriteLine($"YOU HAVE {guessLimit = guessLimit - 1} ATTEMPTS LEFT");
                        Console.WriteLine("YOU FAILED");
                        //return 0;
                    }

                    //string answer = Console.ReadLine();
                    if (guessCount <= guessLimit)
                    {
                        guessCount++;
                    }
                    else
                    {
                        outOfGuesses = true;

                    }
                }
                
                //if (outOfGuesses)
                //{
                //    Console.Write("You LOSE!");
                //}
                //else
                //{
                //    Console.Write("You WIN!");
                //}
                //Console.ReadLine();
            }
        }
    }
}

