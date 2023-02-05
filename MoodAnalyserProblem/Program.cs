namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Program");
            string message = string.Empty;
            MoodAnalyser mood = new MoodAnalyser(message);          
            Console.WriteLine(mood.analyseMood());
        }
    }
}