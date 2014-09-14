///Solution to Nice Angles problem on CodeEval, https://www.codeeval.com/open_challenges/160/
using System;
using System.IO;

namespace NiceAngles
{
    class Program
    {
        public static void ConvertToMinSec(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var degreeValues = reader.ReadLine();
                    if (degreeValues != null)
                    {
                        var totalVal = degreeValues.Split('.');
                        var intPart = totalVal[0];
                        var minutes = Convert.ToDecimal("0." + totalVal[1])*60;
                        var remainingDecimal = minutes.ToString().Split('.');
                        var minutePart =(int) minutes;
                        var seconds = Convert.ToDecimal("0." + remainingDecimal[1])*60;
                        var secondsPart = (int)seconds;
                        var report = string.Format("{0}"+"."+"{1:00}"+"'"+"{2:00}"+"''",intPart,minutePart,secondsPart);
                       
                        Console.WriteLine(report);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to the file containing data:");
            var path = Console.ReadLine();
            ConvertToMinSec(path);

            Console.Read();
        }
    }
}
