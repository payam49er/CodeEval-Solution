///Solution to CodeEval challenge https://www.codeeval.com/open_challenges/83/ Facebook Hacker Cup
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BeautifulString
{
    class Program
    {
        public static void RateString(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {

                    var lineVal = reader.ReadLine().Trim().ToLower();
                    //remove white spaces
                    string pureString = new string(lineVal.Where(x => x != ' ' && char.IsLetter(x)).ToArray());
                    var query = pureString.GroupBy(x => x)
                        .ToDictionary(x => x.Key, x => x.Count())
                        .OrderByDescending(s => s.Value);
                    List<int> values = query.Select(s => s.Value).ToList();
                   
                    int val = 26;
                    int i = 0;
                    int totalBeautyValue = 0;
                    foreach (var countOfValue in values)
                    {
                        int tempVal = countOfValue*val;
                        totalBeautyValue += tempVal;
                        if (countOfValue != tempVal)
                            val--;
                    }

                    Console.WriteLine(totalBeautyValue);
                   
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Insert the path to the file containing your data:");
            var path = Console.ReadLine();
            RateString(path);
            Console.Read();
        }
    }
}
