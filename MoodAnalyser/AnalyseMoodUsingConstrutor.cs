﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class AnalyzeMoodException
    {
        public string AnalyzeMoodExceptionMethod( string message )
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
                    Console.WriteLine("Wrong Input");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("You have provide Null reference: {0}", e.Message);
                return message;
            }
            return default(string);
        }

       
    }
}