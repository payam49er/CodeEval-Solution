///solution to CodeEval challenge https://www.codeeval.com/open_challenges/112/
using System;
using System.IO;

namespace SwapElements
{
    class Program
    {
        public static void Swap(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (lineValue != null)
                    {
                        var numbersWithPos = lineValue.Split(':');
                        var numbers = numbersWithPos[0].Split(' ');
                        var swapPositions = numbersWithPos[1].Split(',');
                        foreach (var position in swapPositions)
                        {
                            var positions = position.Split('-');
                            var temp = numbers[Convert.ToInt32(positions[0])];
                            numbers[Convert.ToInt32(positions[0])] = numbers[Convert.ToInt32(positions[1])];
                            numbers[Convert.ToInt32(positions[1])] = temp;
                        }

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            Console.Write(numbers[i]+" ");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to the file containing data:");
            var path = Console.ReadLine();
            Swap(path);
            Console.Read();
        }
    }
}
