using System;
using System.Collections.Generic;
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

                        var nonRepeated = groups.Where(x => x.freq == 1).Min(x => x.number);
                        if (nonRepeated != null)
                        {

                            var playerNumber = Array.IndexOf(numbers, nonRepeated);
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

        public static void FindPlayerFaster(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (!string.IsNullOrEmpty(lineValue))
                    {
                        var numbers = lineValue.Split(' ').Select<string, int>(x => int.Parse(x)).ToArray();
                        int numCount = numbers.Length;
                        if (numCount > 0)
                        {
                            SortedDictionary<int,int> freqTable = new SortedDictionary<int, int>();
                            var usedInts = Enumerable.Range(0, 10).Select(x => x = 0).ToList();
                            for (int i = 0; i < numCount; i++)
                            {
                                if (freqTable.ContainsKey(numbers[i]))
                                {
                                    freqTable.Remove(numbers[i]);
                                    usedInts[numbers[i]] = i;
                                }
                                else
                                {
                                    if (usedInts[numbers[i]] == 0)
                                    {
                                        freqTable.Add(numbers[i],i+1);
                                    }
                                }
                            }
                            if (freqTable.Count > 0)
                            {
                                Console.WriteLine(freqTable.First().Value);
                            }
                            else
                            {
                                Console.WriteLine(0);
                                freqTable.Clear();
                                usedInts = Enumerable.Range(0, 10).Select(x => x = 0).ToList();
                            }
                        }

                    }
                }
            }
        }

        public static void FindPlayerMoreEffciently(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var linevalue = reader.ReadLine();
                    if (!string.IsNullOrEmpty(linevalue))
                    {
                        var numbers = linevalue.Split(' ');
                        var values = new Dictionary<string, int>();
                        foreach (var number in numbers)
                        {
                            if (values.ContainsKey(number))
                            {
                                values[number]++;
                            }
                            else
                            {
                                values.Add(number,1);
                            }
                        }

                        string MinValue = null;
                        foreach (var value in values)
                        {
                            if (value.Value == 1)
                            {
                                if (MinValue == null ||
                                    String.Compare(value.Key, MinValue, StringComparison.InvariantCulture) == -1)
                                {
                                    MinValue = value.Key;
                                }
                            }
                        }
                        if (MinValue != null)
                        {
                            var playerNumber = Array.IndexOf(numbers, MinValue);
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
            FindPlayerFaster(path);
            FindPlayerMoreEffciently(path);
            Console.Read();
        }
    }
}
