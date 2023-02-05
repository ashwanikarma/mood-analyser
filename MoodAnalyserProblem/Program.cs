namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Program");
            string message = "I am in Sad Mood";
            MoodAnalyser mood = new MoodAnalyser(message);          
            Console.WriteLine(mood.analyseMood());
        }
    }
}