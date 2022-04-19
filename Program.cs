using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Mood Analyser***** ");
            MoodCheck forsad = new MoodCheck("Sad");
            Console.WriteLine("Im Sad :" + forsad.AnalyzeMood());
            MoodCheck forhappy = new MoodCheck("Happy");
            Console.WriteLine("Im in AnyMood : " + forhappy.AnalyzeMood());

           
            MoodCheck fornull = new MoodCheck("");
            Console.WriteLine(" Null Mood : " + fornull.AnalyzeMood());


            Console.ReadLine();
        }
    }
}