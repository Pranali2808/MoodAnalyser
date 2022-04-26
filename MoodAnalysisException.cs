using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalysisException : Exception // Exception:Represent error that occur during application Execution
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }

         public readonly ExceptionType type;//create type variable

        
        public MoodAnalysisException(ExceptionType Type, string message) : base(message)//parametrised constructor
        {
            this.type = Type;
        }
    }
}