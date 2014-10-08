///Solution to CodeEval challenge Find A Writer https://www.codeeval.com/open_challenges/97/
using System;
using System.IO;

namespace FindAWriter
{
    class Program
    {

        public static void FindTheWriter(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (!string.IsNullOrEmpty(lineValue))
                    {
                        var charsAndKeys = lineValue.Split('|');
                        var trimmedChars = charsAndKeys[0].ToCharArray();
                        //keys are in part 1 , while the chars are in part 0
                        var trimmedKeys = charsAndKeys[1].Trim().Split(' ');
                        for (int i = 0; i < trimmedKeys.Length; i++)
                        {
                            var index = trimmedKeys[i];
                            int intIndex;
                            int.TryParse(index, out intIndex);
                            var character = trimmedChars[intIndex-1];
                            Console.Write(character);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to the file containing your data:");
            var path = Console.ReadLine();
            FindTheWriter(path);
            Console.Read();
        }
    }
}
