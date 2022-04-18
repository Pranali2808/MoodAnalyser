using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;


namespace MoodAnalyserTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SadReturn()
        {
            string expected = "sad";//arrange
            MoodCheck moodAnalyser = new MoodAnalyser.MoodCheck("Sad");//act
            Assert.AreEqual(expected, moodAnalyser.AnalyzeMood());
        }
       
        [TestMethod]
        public void HappyReturn()
        {
            //Arrange
            string expected = "happy";
            MoodCheck moodAnalyser = new MoodCheck("Happy");//act
            Assert.AreEqual(expected, moodAnalyser.AnalyzeMood());
        }

        public void ImInSadMoodSAD()
        {
            //Arrange
            string message = "I am in SAD mood.";
            MoodCheck moodAnalyser = new MoodCheck(message);
            string mymood = moodAnalyser.AnalyzeMood();//act
            Assert.AreEqual("sad", mymood);
        }
        
        [TestMethod]
        public void ImInAnyMoodHAPPY()
        {
            //Arrange
            string message = "I am in any mood.";
            MoodCheck moodAnalyser = new MoodCheck(message);
            string mymood = moodAnalyser.AnalyzeMood();//act
            Assert.AreEqual("happy", mymood);
        }
    }
}

    

