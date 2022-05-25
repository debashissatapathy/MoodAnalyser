using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer.Test
{
    [TestClass]
    public class AnalyseMoodUsingConstuctorTest
    {
        
        [TestMethod]
        public void AnalyseMoodUsingConstuctorTest1()
        {
            AnalyzeMoodUsingConstructor A1 = new AnalyzeMoodUsingConstructor();
            string mood = A1.AnalyseMoodMethod();
            Assert.AreEqual("SAD", mood);
        }
        [TestMethod]
        public void AnalyseMoodUsingConstuctorTest2()
        {
            AnalyzeMoodUsingConstructor A2 = new AnalyzeMoodUsingConstructor("I am in any mood");
            string mood = A2.AnalyseMoodMethod();
            Assert.AreEqual("HAPPY", mood);
        }
    }
}
