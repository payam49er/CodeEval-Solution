//solution to challenge https://www.codeeval.com/open_challenges/93/u
using System;
using System.IO;
using System.Text;

namespace CapitaliazeFirstLetter
{
    class Program
    {
        public static void Capitalize(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {


                    var lineValue = reader.ReadLine();

                    if (lineValue != null)
                    {
                        var words = lineValue.Split(' ');
                        foreach (var word in words)
                        {
                            StringBuilder newWord = new StringBuilder();
                            newWord.Append(word[0].ToString().ToUpper());
                            for (int i = 1; i < word.Length; i++)
                            {
                                newWord.Append(word[i]);
                            }
                            Console.Write(newWord + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the path to the file:");
            var path = Console.ReadLine();
            Capitalize(path);

            Console.Read();
        }
    }
}
