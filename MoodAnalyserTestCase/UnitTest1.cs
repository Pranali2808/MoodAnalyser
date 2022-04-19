using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

<<<<<<< HEAD

=======
>>>>>>> UC2_HandleException
namespace MoodAnalyserTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SadReturn()
        {
            string expected = "sad";//arrange
<<<<<<< HEAD
            MoodCheck moodAnalyser = new MoodAnalyser.MoodCheck("Sad");//act
            Assert.AreEqual(expected, moodAnalyser.AnalyzeMood());
        }
       
=======
            MoodCheck moodAnalyser = new MoodCheck("sad");//act
            Assert.AreEqual(expected, moodAnalyser.AnalyzeMood());
        }

>>>>>>> UC2_HandleException
        [TestMethod]
        public void HappyReturn()
        {
            //Arrange
            string expected = "happy";
<<<<<<< HEAD
            MoodCheck moodAnalyser = new MoodCheck("Happy");//act
=======
            MoodCheck moodAnalyser = new MoodCheck("happy");//act
>>>>>>> UC2_HandleException
            Assert.AreEqual(expected, moodAnalyser.AnalyzeMood());
        }

        public void ImInSadMoodSAD()
        {
            //Arrange
<<<<<<< HEAD
            string message = "I am in SAD mood.";
=======
            string message = "I am in sad mood.";
>>>>>>> UC2_HandleException
            MoodCheck moodAnalyser = new MoodCheck(message);
            string mymood = moodAnalyser.AnalyzeMood();//act
            Assert.AreEqual("sad", mymood);
        }
<<<<<<< HEAD
        
=======

>>>>>>> UC2_HandleException
        [TestMethod]
        public void ImInAnyMoodHAPPY()
        {
            //Arrange
            string message = "I am in any mood.";
            MoodCheck moodAnalyser = new MoodCheck(message);
            string mymood = moodAnalyser.AnalyzeMood();//act
            Assert.AreEqual("happy", mymood);
        }
<<<<<<< HEAD
    }
}

    
=======
        
        [TestMethod]
        public void NullMoodHappy()
        {
            //Arrange
            string expected = "happy";
            MoodCheck moodAnalyser = new MoodCheck(null);//act
            Assert.AreEqual(expected, moodAnalyser.AnalyzeMood());
        }
    }
}


>>>>>>> UC2_HandleException

