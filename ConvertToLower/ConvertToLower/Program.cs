///solution to https://www.codeeval.com/open_challenges/20/
using System;
using System.IO;

namespace ConvertToLower
{
    class Program
    {

        public static void ConvertToLower(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (lineValue != null)
                    {
                        Console.WriteLine(lineValue.ToLower());
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to the file:");
            var path = Console.ReadLine();
            ConvertToLower(path);

            Console.Read();
        }
    }
}
