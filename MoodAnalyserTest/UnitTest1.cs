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
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "I am in a Sad Mood";
            MoodAnalyser mood = new MoodAnalyser(expected);

            //Act
            string actual = mood.analyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            //Arrange
            string expected = "I am in Any Mood";
            MoodAnalyser mood = new MoodAnalyser(expected);

            //Act
            string actual = mood.analyseMood();

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

        //Test case 4
        [TestMethod]
        public void GivenMoodAnalyzeClasssNameShouldReturnMoodAnalyzeObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }
        //Test Case 5
        [TestMethod]
        public void GivenMoodAnalyzeClassNameShouldReturnObjectUsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreatemoodAnalyseUsingParameterizedConstructor("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer", "HAPPY");
            expected.Equals(obj);
        }
        //Test case 6
        [TestMethod]
        public void GivenHappyMoodShouldReturnHappy()
        {
            string expected = "HAPPY";
            string actual = MoodAnalyserFactory.InvokeAnalyzeMood("HAPPY", "AnalyzeMood");
            Assert.AreEqual(expected, actual);
        }
    }
}