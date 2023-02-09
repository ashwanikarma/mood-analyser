using MoodAnalyserProblem;
using System.Security.Cryptography.X509Certificates;
using static MoodAnalyserProblem.MoodAnalysisException;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyserProblem.MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Sad mood");
        [TestMethod]
        public void GivenSadMood()
        {
            //Arrange
            string expected = "Sad";

            //Act
            string actual = moodAnalyser.analyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenAnyMood()
        {
            //Arrange
            string expected = "Happy";

            //Act
            string actual = moodAnalyser.analyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void TestAnalyseMood_ShouldReturnHAPPY1()
        {
            //Arrange
            string message = null;
            MoodAnalyser mood = new MoodAnalyser(message);

            //Act
            string result = mood.analyseMood();

            //Assert
            Assert.AreEqual(result, "Happy");
        }
        //Test Case 3.1
        [TestMethod]
        public void GivenNullMoodShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
                string actual = moodAnalyzer.analyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Mood Should Not Be Null", ex.Message);
            }
        }
        //Test Case 3.2
        [TestMethod]
        public void GivenEmptyMoodShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
                string actual = moodAnalyzer.analyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Mood Should Not Be Empty", ex.Message);
            }
        }
    }
}