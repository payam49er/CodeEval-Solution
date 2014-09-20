///solution to CodeEval challenge of Multiplying lists https://www.codeeval.com/open_challenges/113/
using System;
using System.IO;
using System.Linq;

namespace MultiplyLists
{
    class Program
    {
        public static void Multiply(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (!string.IsNullOrEmpty(lineValue))
                    {
                        var values = lineValue.Split('|');
                        var leftValues = values[0].Trim().Split(' ');
                        var rightValues = values[1].Trim().Split(' ');
                        for (int i = 0; i < leftValues.Count(); i++)
                        {
                            int valLeft;
                            int.TryParse(leftValues[i], out valLeft);

                            int valRight;
                            int.TryParse(rightValues[i], out valRight);

                            Console.Write(valLeft*valRight + " ");
                        }
                    }

                    Console.WriteLine();
                }
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to the file containing the data:");
            var path = Console.ReadLine();
            Multiply(path);

            Console.Read();
        }
    }
}
