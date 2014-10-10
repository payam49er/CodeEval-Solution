///solution to CodeEval challenge Calculate Distance https://www.codeeval.com/open_challenges/99/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CalculateDistance
{
    class Program
    {
        public static void CalculateDistance(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    var removechars = new[] {'(', ')', ',',' '};
                    var trimmed = lineValue.Split(removechars);
                    var digits = new List<int>();
                    for (int i = 0; i < trimmed.Count(); i++)
                    {
                        if (trimmed[i] != "")
                        {
                            int digit;
                            int.TryParse(trimmed[i], out digit);
                            digits.Add(digit);
                        }
                    }

                    var s1 = Math.Pow((digits[0] - digits[2]),2);
                    var s2 = Math.Pow((digits[1] - digits[3]),2);
                    var distance = Math.Sqrt(s1 + s2);
                    Console.WriteLine(distance);

                }
            }
            
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to the file containing the data:");
            var path = Console.ReadLine();
            CalculateDistance(path);

            Console.Read();
        }
    }
}
