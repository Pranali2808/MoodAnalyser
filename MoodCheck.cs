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
                if (this.message.Contains("sad"))//use of contain method
                    return "sad";
                else if (this.message.Contains("happy"))
                    return "happy";
                else if (this.message.Contains(null))
                    return "happy";
            }
            catch 
            {
                return "happy";
            }
            return null; 
        }
    }
}