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
            MoodCheck moodAnalyser = new MoodCheck("sad");//act
            Assert.AreEqual(expected, moodAnalyser.AnalyzeMood());
        }

        [TestMethod]
        public void HappyReturn()
        {
            //Arrange
            string expected = "happy";
            MoodCheck moodAnalyser = new MoodCheck("happy");//act
            Assert.AreEqual(expected, moodAnalyser.AnalyzeMood());
        }
        [TestMethod]
        public void ImInSadMoodSAD()
        {
            //Arrange
            string message = "I am in sad mood.";
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

        [TestMethod]
        public void NullMoodHappy()
        {
            //Arrange
            string expected = "Mood should not be Empty";
            //Act
            MoodCheck moodAnalyser = new MoodCheck("");
            string actual = moodAnalyser.AnalyzeMood();
            //Asserts
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EmptyMoodThrowMoodAnalysisExceptionshowingEmptyMood()
        {
            try
            {
                string message = "";
                MoodCheck moodanalyser = new MoodCheck(message);
                string mood = moodanalyser.AnalyzeMood();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Mood Should not be Empty", e.Message);
            }
        }
        [TestMethod]
        public  void EmptyUsingException()
        {    //Arrange
            string expected = "Mood should not be Empty";
            //Act
            MoodCheck moodanalyser = new MoodCheck("");
            string actual = moodanalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
    }
}
    




