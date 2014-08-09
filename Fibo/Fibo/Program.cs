///The Fibonacci series is defined as: F(0) = 0; F(1) = 1; F(n) = F(n-1) + F(n-2) 
/// when n>1. Given a positive integer 'n', print out the F(n).
/// https://www.codeeval.com/open_challenges/22/
using System;
using System.IO;
using System.Linq;

namespace Fibo
{
    class Program
    {
        public static void WriteFibo(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var readline = reader.ReadLine();
                    if (readline != null)
                    {
                        var numbers = readline.Split(' ').ToArray().Select(x => Convert.ToInt16(x)).ToList();
                        numbers.ForEach(x => Console.WriteLine(GenerateFibo(x)));

                    }
                }
            }
        }

        private static int GenerateFibo(int number)
        {
            if (number == 0)
                return 0;
            if (number == 1)
                return 1;
            return GenerateFibo(number - 1) + GenerateFibo(number - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path");
            var path = Console.ReadLine();
            WriteFibo(path);

            Console.Read();

        }
    }
}
