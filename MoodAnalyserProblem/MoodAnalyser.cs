using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser()
        {
            Console.WriteLine("Sad Message in Default Constructor");
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        //public string analyseMood(string message)
        //{
        //    if (message.Contains("Sad"))
        //        return "Sad";
        //    else
        //        return "Happy";
        //}
        public string analyseMood()
        {
            try
            {
                if (message.Contains(string.Empty))
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.ENTERED_EMPTY, "Mood Should Not Be Empty");

                if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";

            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.ENTERED_NULL, "Mood Should Not Be Null");
            }
           
        } 
    }
}
