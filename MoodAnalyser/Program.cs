using System;
using MoodAnalyzer;

namespace MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser!");


            while (true)
            {
                Console.WriteLine("Please choose the option :\n1.Happy or SAD Mood\n2.Using the Default and Parametterized Constructor\n3.Exception\n4.Custom Exception\n"+
                                    "5.reflectors with Default Constructor\n6)reflectors with Parametarised Constructor\n7)Reflections Invoke Method\n8)Reflections to change mood Dynamically"); 
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AnalyseMood A1 = new AnalyseMood();
                        string result1 = A1.AnalyseMoodMethod("I am in  Mood");
                        Console.WriteLine(result1);
                        break;
                    case 2:
                        AnalyzeMoodUsingConstructor A2 = new AnalyzeMoodUsingConstructor();
                        string result2 = A2.AnalyseMoodMethod();
                        Console.WriteLine("Using the Default Constructor here and Mood is :" + result2);

                        AnalyzeMoodUsingConstructor A3 = new AnalyzeMoodUsingConstructor("I am i Happy Mood");
                        string result3 = A3.AnalyseMoodMethod();
                        Console.WriteLine("Using the Parameterized Constructor here and Mood is :" + result3);
                        break;
                    case 3:
                        AnalyzemoodException A4 = new AnalyzemoodException();
                        string result4 = A4.AnalyzeMoodExceptionMethod(null);
                        Console.WriteLine(result4);
                        break;
                    case 4:
                        MoodAnalysisException A5 = new MoodAnalysisException();
                        string result5 = A5.MoodAnalysisExceptionMethod(string.Empty);
                        Console.WriteLine(result5);
                        break;
                    case 5:
                       object result6 = MoodAnalysisFactory.CreateMoodAnalyzer("MoodAnalyzer.MoodAnalysisException", "MoodAnalysisException");
                        Console.WriteLine(result6);
                        break;
                    case 6:
                        
                        object result7 = MoodAnalyzerParameterizedConstructor.UsingParameterizedConstructor("MoodAnalyzer.AnalyseMood1", "AnalyseMood1", "HAPPY");
                        Console.WriteLine(result7);
                        break;
                    case 7:
                        string result8 = MoodAnalysisFactory.InvokeAnalyseMood("Happy", "AnalyseMoodMethod");
                        Console.WriteLine(result8);
                        break;
                    case 8:
                        string result9 = MoodAnalysisFactory.SetField(null, "456_message2");
                        Console.WriteLine(result9);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
