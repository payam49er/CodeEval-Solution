using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

///solution to CodeEval Challenge https://www.codeeval.com/open_challenges/104/
namespace WordToDigit
{
    class Program
    {
        public static void ConverWordToDigit(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    List<string> words = new List<string>
                    {
                        "zero",
                        "one",
                        "two",
                        "three",
                        "four",
                        "five",
                        "six",
                        "seven",
                        "eight",
                        "nine"
                    };
                    int count = 0;
                    Dictionary<string, int> wordsDictionary = words.ToDictionary(word => word, word => count++);

                    {
                        var lineValue = reader.ReadLine().Split(';');
                        foreach (var number in lineValue.Select(s => wordsDictionary[s]))
                        {
                            Console.Write(number);
                        }
                    }
                    Console.WriteLine ();
                }
                
            }
        }

        static void Main ( string[] args )
        {
            Console.WriteLine("Please enter the path to the file containing your data:");
            var path = Console.ReadLine();
            ConverWordToDigit(path);

            Console.Read();
        }
    }
}
