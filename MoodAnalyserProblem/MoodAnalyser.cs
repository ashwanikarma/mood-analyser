using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string analyseMood(string message)
        {
            if (message.Contains("Sad"))
                return "Sad";
            else
                return "Happy";
        }
    }
}
