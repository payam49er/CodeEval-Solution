///solution to codeeval challenge Hidden Digits: https://www.codeeval.com/open_challenges/122
using System;
using System.Collections.Generic;
using System.IO;

namespace HiddenDigits
{
    class Program
    {
        public static void FindHiddenDigits(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                var dataSource = new Dictionary<char, int>();
                int i = 0;
                for (char c = 'a'; c <= 'j'; c++)
                {
                    dataSource.Add(c, i++);
                }

                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (!string.IsNullOrEmpty(lineValue))
                    {

                        bool containsValue = false;
                        for (int j = 0; j < lineValue.Length; j++)
                        {
                            if (char.IsLetter(lineValue[j]) && char.IsLower(lineValue[j]))
                            {
                                if (dataSource.ContainsKey(lineValue[j]))
                                {
                                    containsValue = true;
                                    Console.Write(dataSource[lineValue[j]]);
                                }
                            }
                            else if (char.IsDigit(lineValue[j]))
                            {
                                containsValue = true;
                                Console.Write(lineValue[j]);
                            }
                        }

                        if(!containsValue)
                            Console.Write("NONE");

                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Please insert the path to your file containing data:");
            var path = Console.ReadLine();
            FindHiddenDigits(path);

            Console.Read();
        }
    }
}
