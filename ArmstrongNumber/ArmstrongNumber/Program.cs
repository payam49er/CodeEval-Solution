///Solution to CodeEval challenge Armstrong Number 
/// https://www.codeeval.com/open_challenges/82/
using System;
using System.IO;

namespace ArmstrongNumber
{
    class Program
    {
        public static void IsArmstrongNumber(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    var len = lineValue.Length;
                    var total = 0.0;
                    for (int i = 0; i < len; i++)
                    {
                        var intValue = char.GetNumericValue(lineValue[i]);
                        
                        var raised = Math.Pow(intValue, len);
                        total += raised;
                    }

                    Console.WriteLine(lineValue == total.ToString() ? "True" : "False");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to the file containing your data:");
            var path = Console.ReadLine();
            IsArmstrongNumber(path);

            Console.Read();
        }
    }
}
