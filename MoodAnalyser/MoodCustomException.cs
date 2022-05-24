using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodCustomException : Exception
    {
       public enum ExpType
       {
            Empty_Message, Null_Message,
            NO_SUCH_CLASS, NO_SUH_METHOD,
            NO_SUCH_FIELD
       }
        public readonly ExpType type;

        public MoodCustomException(ExpType type, string message) : base (message)
        {
            this.type = type;
        }
            
    }
    public class MoodAnalysisException
    {
        public string MoodAnalysisExceptionMethod(string message)
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodCustomException(MoodCustomException.ExpType.Empty_Message, "Mood shouldn't be empty");
                }
                string message1 = "SAD";
                if (message.ToUpper().Contains(message1.ToUpper()))
                {
                    return message1;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                    return "HAPPY";
                }
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("You have provided null reference");
                throw new MoodCustomException(MoodCustomException.ExpType.Null_Message, "Mood shouldn't be null");
            }
            return default(string);
        }
    }
}
