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
                Console.WriteLine("Please choose the option :\n1.Happy or SAD Mood\n2.Using the Default and Parametterized Constructor\n3.Exception\n4.Custom Exception");
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
                        string result5 = A5.MoodAnalysisExceptionMethod("I am in sad Mood");
                        Console.WriteLine(result5);
                        break;
                }
            }
        }
    }
}
