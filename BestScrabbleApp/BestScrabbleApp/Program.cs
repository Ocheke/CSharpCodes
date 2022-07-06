// See https://aka.ms/new-console-template for more information
namespace BestScrabbleApp
{
    class Progarm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLVE THE RIGHT PUZZLE BELOW ; ");
            List<ScrabbleWork> word = new List<ScrabbleWork>()
            {
                new ScrabbleWork ("1. LTUABIUEF","BEAUTIFUL"),
                new ScrabbleWork ("2. LERHRASAE","REHEARSAL"),
                new ScrabbleWork ("3. NERIDF","FRIEND"),
                new ScrabbleWork ("4. IYARTBHD","BIRTHDAY"),
                new ScrabbleWork ("5. YATRWRBESR","STRAWBERRY"),
                new ScrabbleWork ("6. RGVHYIENET","EVERYTHING"),
                new ScrabbleWork ("7. IFNFEDRET","DIFFERENT"),
                new ScrabbleWork ("8. OGTCYNEOLH","TECHNOLOGY"),
                new ScrabbleWork ("9. OANIDTNOFU","FOUNDATION"),
                new ScrabbleWork ("10. PETCNEIOR","RECEPTION"),
            };
            int totalscore = 0;
            foreach (var words in word)
            {
                AskQuestion(words);
                for (int i = 0; i < 3; i = i + 1)
                {
                    if (CheckAnswer(words.unscrabble) == 0)
                    {
                        Console.WriteLine(" WRONG GUESS TRY AGAIN");
                    }
                    else
                    {
                        totalscore++;
                        break;
                    }
                }
            Console.WriteLine($"Unscramble word = {words.unscrabble}");
            }
            Console.WriteLine($"total score = {totalscore}");
            static void AskQuestion(ScrabbleWork question)
            {
                Console.WriteLine(question.scrabble);
            }
            static int CheckAnswer(string correctAnswer)
            {
                string answer = Console.ReadLine();
                if (answer.Equals(correctAnswer, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("PASS! YOU HAVE GOTTEN 1 POINT");
                    return 1;
                }
                else
                {
                    return 0;
                }
                
            }

        }
    }
}