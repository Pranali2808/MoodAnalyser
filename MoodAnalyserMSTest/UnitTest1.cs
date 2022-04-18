using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SadReturn()
        {
            string expected = "sad";
            MoodCheck moodeCheck = new MoodCheck();
            Assert.AreEqual(expected, moodCheck.AnalyseMood());
        }
    }
}