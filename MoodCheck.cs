using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public  class MoodCheck
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
            if (this.message.ToLower().Contains("sad")) 
                return "sad";
            else
                return "happy";
        }
    }
}