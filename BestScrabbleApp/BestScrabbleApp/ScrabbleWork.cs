using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestScrabbleApp
{
    internal class ScrabbleWork
    {
        public string scrabble { get; set; }
        public string unscrabble { get; set; }
        public ScrabbleWork(string guess,string guess1)
        {
            scrabble = guess;
            unscrabble = guess1;
        }
    }
}
