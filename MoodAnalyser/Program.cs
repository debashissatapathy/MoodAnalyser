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
                Console.WriteLine("Please choose the option :\n1)Happy or SAD Mood\n");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AnalyseMood A1 = new AnalyseMood();
                        string result1 = A1.AnalyseMoodMethod("I am in  Mood");
                        Console.WriteLine(result1);
                        break;
                }
            }
        }
    }
}
