///Solution to CodeEval challenge Mixed Contetnt https://www.codeeval.com/open_challenges/115/
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace MixedContent
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {

                    StringBuilder numbers = new StringBuilder();
                    StringBuilder letters = new StringBuilder();

                    var lineValue = reader.ReadLine();
                    if (!string.IsNullOrEmpty(lineValue))
                    {
                        var strings = lineValue.Split(',');
                        foreach (var s in strings)
                        {
                            if (s.ToCharArray().Any(x => char.IsLetter(x)))
                            {
                                letters.Append(s + ",");
                            }
                            else
                            {
                                numbers.Append(s + ",");
                            }
                        }
                    }

                    Console.Write(letters.ToString().TrimEnd(','));
                    if (letters.Length != 0 && numbers.Length != 0)
                        Console.Write("|");

                    Console.Write(numbers.ToString().TrimEnd(','));
                    Console.WriteLine();
                }
            }
        }
    }
}