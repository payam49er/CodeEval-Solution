///https://www.codeeval.com/open_challenges/91/
/// Your program should accept as its first argument a path to a filename. Input example is the following
///70.920 -38.797 14.354 99.323 90.374 7.581
///-37.507 -3.263 40.079 27.999 65.213 -55.552

using System;
using System.IO;
using System.Linq;

namespace SimpleSorting
{
    class Program
    {
        public static void Sort(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var valuesInLine = reader.ReadLine();
                    if (valuesInLine != null)
                    {
                        var numbers = valuesInLine.Split(' ').ToArray().ToList();
                        var sorted = numbers.OrderBy(x => Convert.ToDouble(x)).ToList();
                        sorted.ForEach(x => Console.Write(x + " "));
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to file:");
            var path = Console.ReadLine();
            Sort(path);

            Console.Read();
        }
    }
}
