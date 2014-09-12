///Solution to CodeEval challenge https://www.codeeval.com/open_challenges/132/
using System;
using System.IO;
using System.Linq;

namespace MajorElement
{
    class Program
    {
        public static void FindMajorElement(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (lineValue != null)
                    {
                        var values = lineValue.Split(',');
                        var result = values.GroupBy(x => x).SingleOrDefault(x => x.Count() >= values.Length / 2);
                        Console.WriteLine(result != null ? result.Key : "None");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to the file containing data:");
            var path = Console.ReadLine();
            FindMajorElement(path);

            Console.Read();
        }
    }
}
