using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Message
    {
        public static string GetMessage(string lang)
        {
            if(lang == "Hausa")
            {
                return "zo";
            }
            else if(lang == "Yoruba")
            {
                return "wa";
            }
            else if(lang == "Igbo")
            {
                return "bya"; 
            }
            else if(lang == "English")
            {
                return "come";
            }
            else {
                return "";
            }
        }
    }
}
