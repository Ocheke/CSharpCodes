// See https://aka.ms/new-console-template for more information
namespace Simplified_quiz_App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<QuizQuestion> quest = new List<QuizQuestion>()
            {
                new QuizQuestion ("1. How many days are in a week","7","6","8","2","A"),
                new QuizQuestion ("2. What is the study of living things including plants and animals?","Social studies","Chemistry","Biology","Physics","C"),
                new QuizQuestion ("3. How many seconds are in a minute", "20", "60", "50", "12", "B"),
            };
            int totalgrade = 0;
            foreach(var ques in quest)
            {
                AskQuestion(ques);
                totalgrade += CheckAnswer(ques.Answer);
            }

            static void AskQuestion(QuizQuestion question)
            {
                Console.WriteLine(question.Question);
                Console.WriteLine("A " + question.OptionA);
                Console.WriteLine("B " + question.OptionB);
                Console.WriteLine("C " + question.OptionC);
                Console.WriteLine("D " + question.OptionD);
                Console.WriteLine("Enter option: ");
            }

            Console.WriteLine("YOUR RESULT IS: " + totalgrade);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        

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
                    Console.WriteLine("YOU FAILED");
                    return 0;
                }
            }





            /*QuizQuestion question1 = new QuizQuestion();
            question1.Question = "How many days are in a week?";
            question1.OptionA = "7";
            question1.OptionB = "6";
            question1.OptionC = "8";
            question1.OptionD = "2";
            question1.Answer = "7";

            Console.WriteLine(question1.Question);

            QuizQuestion question2 = new QuizQuestion();
            question2.Question = "What is the study of living things including plants and animals?....";
            question2.OptionA = "Social studies";
            question2.OptionB = "Chemistry";
            question2.OptionC = "Biology";
            question2.OptionD = "Physics";
            question2.Answer = "Biology";

            QuizQuestion question3 = new QuizQuestion("How many seconds are in a minute?", "20", "60", "50", "12", "60");
            Console.WriteLine(question3.Question);*/
        }
    }
}