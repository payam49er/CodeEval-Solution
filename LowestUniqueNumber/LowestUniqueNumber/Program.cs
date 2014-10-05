using System;
using System.IO;
using System.Linq;

namespace LowestUniqueNumber
{
    class Program
    {
        public static void FindLowestUniqNumber(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var linevalue = reader.ReadLine();
                    if (!string.IsNullOrEmpty(linevalue))
                    {
                        var numbers = linevalue.Split(' ');
                        var groups = numbers.GroupBy(x => x).Select(g => new
                        {
                            number = g.Key,
                            freq = g.Count()
                        });

                        var nonRepeated = groups.Where(x => x.freq == 1).ToList();
                        if (nonRepeated.Count() != 0)
                        {

                            var singles = nonRepeated.Select(x => x.number).ToList();
                            var smallest = singles.Min();
                            var playerNumber = Array.IndexOf(numbers, smallest);
                            Console.WriteLine(playerNumber + 1);
                        }
                        else
                        {
                            Console.WriteLine("0");
                        }

                    }

                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to your data file:");
            var path = Console.ReadLine();
            FindLowestUniqNumber(path);
            Console.Read();
        }
    }
}
