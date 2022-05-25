using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer.Test
{
    [TestClass]
    public class MoodAnalyzerExceptionTest
    {
        [TestMethod]
        public void MoodAnalyzerExceptionMethodTest()
        {
            MoodAnalysisException moodAnalysis = new MoodAnalysisException();
            string mood = moodAnalysis.MoodAnalysisExceptionMethod("");
            Assert.AreEqual("SAD", mood);
        }
    }
}
