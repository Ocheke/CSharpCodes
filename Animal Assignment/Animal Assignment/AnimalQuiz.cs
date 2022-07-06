using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Assignment
{
    internal class AnimalQuiz
    {
        public string Name { get; set; }
        public string Nutrition { get; set; }
        public string Habitat { get; set; }
        public string Reproduction { get; set; }
        public string Gestation { get; set; }
        public bool Respiration { get; set; }


        public AnimalQuiz(string name, string nut, string hab, string rep, string gest, bool resp)
        {
            Name = name;
            Nutrition = nut;
            Habitat = hab;
            Reproduction = rep;
            Gestation = gest;
            Respiration = resp;
        }

        public AnimalQuiz()
        {

        }

    }
}
