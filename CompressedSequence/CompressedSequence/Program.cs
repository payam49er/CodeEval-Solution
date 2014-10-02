///Solution to compressed sequence on CodeEval https://www.codeeval.com/open_challenges/128/
using System;
using System.IO;
using System.Linq;

namespace CompressedSequence
{
    class Program
    {

        public static void Compress(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (!string.IsNullOrEmpty(lineValue))
                    {
                        var values = lineValue.Split(' ');
                        int count = 0;
                        var temp = values[0];
                        for (int i = 0; i < values.Count(); i++)
                        {
                            if (values[i] == temp)
                            {
                                count++;
                            }
                            else
                            {
                                Console.Write("{0} {1} ", count, temp);
                                count = 1;
                                temp = values[i];
                            }
                        }

                        Console.Write("{0} {1}", count, temp);

                        Console.WriteLine();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to your data file:");
            var path = Console.ReadLine();
            Compress(path);

            Console.Read();
        }
    }
}
