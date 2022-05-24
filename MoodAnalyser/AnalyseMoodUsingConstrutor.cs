using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class AnalyzeMoodUsingConstructor
    {
        public AnalyzeMoodUsingConstructor()
        {

        }

        public string msg1 = "I am in SAD Mood";
        public AnalyzeMoodUsingConstructor(string message)
        {
            this.msg1 = message;
        }


        public string AnalyseMoodMethod()
        {
            string message1 = "SAD";
            if (msg1.ToUpper().Contains(message1.ToUpper()))
            {
                return message1;
            }
            else
            {
                return "HAPPY";
            }

        }
    }
}