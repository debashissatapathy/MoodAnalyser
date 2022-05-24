using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class AnalyseMood
    {

       
        public string AnalyseMoodMethod(string message)
        {
            string message1 = "SAD";
            string message2 = "happy";
            if (message.ToUpper().Contains(message1.ToUpper()))
            {
                return message1;
            }
            else
            {
                return message2;

            }

        }
    }
}