///Solution to CodeEval challang Shortest Repetition
///  https://www.codeeval.com/open_challenges/107/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShortestRepetition
{
    class Program
    {
        public static void FindShortestRepetition(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var values = reader.ReadLine();
                    var atomicValues = new HashSet<char>();
                    int counter = 0;
                    for (int i = 0; i < values.Count(); i++)
                    {
                        if (!atomicValues.Contains(values[i]))
                        {
                            atomicValues.Add(values[i]);
                        }
                        else
                        {
                            counter++;
                        }

                    }

                    var atomicCount = atomicValues.Count;


                    if (counter < atomicCount)
                        Console.WriteLine((atomicCount)+counter);
                    else
                    {
                        Console.WriteLine(atomicCount);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to the data file:");
            var path = Console.ReadLine();
            FindShortestRepetition(path);

            Console.Read();

        }
    }
}
