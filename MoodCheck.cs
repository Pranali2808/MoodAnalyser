using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodCheck
    {
        public string message;
        public MoodCheck()//default constructor
        {

        }
        public MoodCheck(string message)//constructor
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try 
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }
                else if (this.message.Contains("sad")) 
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
            catch (MoodAnalysisException exception)
            {
                return exception.Message;
            }



        }
    }
}