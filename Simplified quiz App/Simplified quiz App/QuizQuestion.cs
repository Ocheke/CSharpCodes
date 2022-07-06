using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplified_quiz_App
{
    internal class QuizQuestion
    {
        public string Question;
        public string OptionA;
        public string OptionB;
        public string OptionC;
        public string OptionD;
        public string Answer;



        public QuizQuestion(string quest, string optA, string optB, string optC, string optD, string ans)
        {
            Question = quest;
            OptionA = optA;
            OptionB = optB;
            OptionC = optC;
            OptionD = optD;
            Answer = ans;
        }

        public QuizQuestion()
        {
          
        }

    }
}
