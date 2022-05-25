using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer.Tests
{
    [TestClass]
    public class MoodAnalysisExceptionTest
    {
        [TestMethod]
        public void MoodAnalysisExceptionMethodTest1()
        {
            try
            {
                string message = "";
                AnalyzemoodException moodAnalysisException = new AnalyzemoodException();
                string actual = moodAnalysisException.AnalyzeMoodExceptionMethod (message);
            }
            catch (MoodCustomException ex)
            {

                Assert.AreEqual("Mood should not be empty", ex.Message);
            }
        }



        [TestMethod]
        public void MoodAnalysisExceptionMethodTest2()
        {
            try
            {
                string message = null;
                AnalyzemoodException moodAnalysisException = new AnalyzemoodException();
                string actual = moodAnalysisException.AnalyzeMoodExceptionMethod(message);
            }
            catch (MoodCustomException ex)
            {
                Assert.AreEqual("Mood should not be null", ex.Message);
            }
        }
    }

}
