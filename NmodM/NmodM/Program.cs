//solution to CodeEval challenge N Mod M without using Mod operator https://www.codeeval.com/open_challenges/62/
using System;
using System.IO;

namespace NmodM
{
    class Program
    {
        public static void Modulus(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine().Split(',');
                    var N = Convert.ToInt32(lineValue[0]);
                    var M = Convert.ToInt32(lineValue[1]);
                    var division = N/M;
                    var modulus = N - (division*M);

                    Console.WriteLine(modulus);
                }
            }
        }
        static void Main ( string[] args )
        {
            Console.WriteLine("Please insert the path to the folder containing the data:");
            var path = Console.ReadLine();
            Modulus(path);

            Console.Read();
        }
    }
}
