using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        string message;

        public MoodAnalyser()
        {
            Console.WriteLine("Sad Message in Default Constructor");
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string analyseMood()
        {
            if (message.Contains("Sad"))
                return "Sad";
            else
                return "Happy";
        }
    }
}
