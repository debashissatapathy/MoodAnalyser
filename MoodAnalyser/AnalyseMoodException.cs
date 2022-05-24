using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class AnalyzemoodException
    {
        public string AnalyzeMoodExceptionMethod(string message)
        {
            try
            {
                string message1 = "SAD";
                string message2 = "HAPPY";
                if (message.ToUpper().Contains(message1.ToUpper()))
                {
                    return message1;
                }
                else if (message.ToUpper().Contains(message2.ToUpper()))
                {
                    return message2;
                }
                else
                {
                    Console.WriteLine("wrong input");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("you have provide null reference: {0}", e.Message);
                return message;
            }
            return default(string);
        }


    }
}