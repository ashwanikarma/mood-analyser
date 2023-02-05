namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Program");

            MoodAnalyser mood = new MoodAnalyser();
            string message = "I am in Sad Mood";
            Console.WriteLine(mood.analyseMood(message));
        }
    }
}