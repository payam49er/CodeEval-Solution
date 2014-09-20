///solution to CodeEval challenge https://www.codeeval.com/open_challenges/30/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IntersectionOfLists
{
    class Program
    {
        public static void FindIntersection(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (!string.IsNullOrEmpty(lineValue))
                    {
                        var lists = lineValue.Split(';');
                        var rightList = lists[1].Split(',');
                        var leftList = lists[0].Split(',');
                        StringBuilder report = new StringBuilder();
                        HashSet<string> hashedValues = new HashSet<string>();
                        for (int i = 0; i < leftList.Length; i++)
                        {
                            hashedValues.Add(leftList[i]);
                        }

                        foreach (var s in rightList)
                        {
                            if (hashedValues.Contains(s))
                            {
                                report.Append(s + ",");
                            }
                        }

                        Console.Write(report.ToString().TrimEnd(','));
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert your path to the file containing data:");
            var path = Console.ReadLine();
            FindIntersection(path);

            Console.Read();
        }
    }
}
