using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalysisException : Exception
    {   public enum ExceptionType
        {
            ENTERED_NULL, ENTERED_EMPTY, NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        public ExceptionType type;
        public MoodAnalysisException(ExceptionType type, string message): base(message)
        {
            this.type = type;
        }
    }
}
