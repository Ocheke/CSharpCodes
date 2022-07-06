using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuessApp
{
    internal class ScrabbleWork
    {
        public string scrabble { get; set; }
        public string scrabble2 { get; set; }
        public string scrabble3 { get; set; }
        public string NewWords { get; set; }


        //class array:ScrabbleWork
        //{
        //    public string scrabble;
        //    public string scrabble2;
        //    public string scrabble3;
        //}


        public ScrabbleWork(string guess1, string guess2, string guess3)
        {
            scrabble = guess1;
            scrabble2 = guess2;
            scrabble3 = guess3;
        }
        
        public ScrabbleWork()
        {
            string[] NewWords = new string[3];
        }
    }
}
