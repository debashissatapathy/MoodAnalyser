using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer.Test
{
    [TestClass]
    public class AnalyseMoodTest
    {
        [TestMethod]
        public void AnalyseMoodMethodTest1()
        {
            AnalyseMood analyse = new AnalyseMood();
            Assert.AreEqual("SAD", analyse.AnalyseMoodMethod("I am in sad mood"));

        }
        [TestMethod]
        public void AnalyseMoodMethodTest2()
        {
            AnalyseMood analyse = new AnalyseMood();
            Assert.AreEqual("happy", analyse.AnalyseMoodMethod("I am in happy mood"));

        }
    }
}
