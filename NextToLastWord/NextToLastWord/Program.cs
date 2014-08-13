///solution to https://www.codeeval.com/open_challenges/92/
using System;
using System.IO;

namespace NextToLastWord
{
    class Program
    {
        public static void FindNextToLastWord(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (lineValue != null)
                    {
                        var words = lineValue.Split(' ');
                        for (int i = 0; i < words.Length; i++)
                        {
                            Console.WriteLine(words[words.Length-2]);
                            break;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to the file:");
            var path = Console.ReadLine();
            FindNextToLastWord(path);

            Console.Read();
        }
    }
}
