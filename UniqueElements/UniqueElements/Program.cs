///Solution to CodeEval challenge https://www.codeeval.com/open_challenges/29/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UniqueElements
{
    class Program
    {

        public static void GetUniqElements(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    StringBuilder result = new StringBuilder();
                    if (!string.IsNullOrEmpty(lineValue))
                    {
                        var strVals = lineValue.Split(',').ToList();
                        var hashed = new HashSet<string>();
                        strVals.ForEach(x => hashed.Add(x));
                        foreach (var item in hashed)
                        {
                            result.Append(string.Format("{0}" + ",", item));
                        }
                        Console.Write(result.ToString().TrimEnd(','));
                    }
                    Console.WriteLine();
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please inser the path to the file containing the data:");
            var path = Console.ReadLine();
            GetUniqElements(path);

            Console.Read();
        }
    }
}
