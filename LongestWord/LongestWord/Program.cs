///solution to https://www.codeeval.com/open_challenges/111/
using System;
using System.IO;
using System.Linq;

namespace LongestWord
{
    class Program
    {
        public static void FindLongestWord(string path)
        {

            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineVal = reader.ReadLine();
                    if (lineVal != null)
                    {
                        var words = lineVal.Trim().Split(' ').ToList();
                        string longestWord = null;
                        int longestWordSize = 0;
                        foreach (var word in words)
                        {
                            if (word.Length > longestWordSize)
                            {
                                longestWord = word;
                                longestWordSize = longestWord.Length;
                            }

                        }

                        Console.WriteLine(longestWord);
                    }
                }
            }
        }


        static
            void Main(string[] args)
        {
            Console.WriteLine("Enter path to the file containing the texts:");
            var path = Console.ReadLine();
            FindLongestWord(path);
            Console.Read();
        }
    }
}
