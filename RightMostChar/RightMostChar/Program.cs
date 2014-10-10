///Solution to CodeEval challenge https://www.codeeval.com/open_challenges/31/
using System;
using System.IO;
using System.Linq;

namespace RightMostChar
{
    class Program
    {
        public static void FindMostRightChar(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine().Split(',');
                    int position = 0;
                    for (int i = 0; i <lineValue[0].Count(); i++)
                    {
                        if (lineValue[0][i] == lineValue[1][0])
                            position = i;
                    }

                    Console.WriteLine(position == 0 ? "-1" : position.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to the file containing the data:");
            var path = Console.ReadLine();
            FindMostRightChar(path);
            Console.Read();
        }
    }
}
