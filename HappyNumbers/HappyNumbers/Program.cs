///Solution to CodeEval challenge Happy Numbers https://www.codeeval.com/open_challenges/39/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HappyNumbers
{
    class Program
    {
        public static void FindHappyNumber(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (!string.IsNullOrEmpty(lineValue))
                    {
                        Console.WriteLine(GetSqaureValue(lineValue)? "1":"0");
                    }
                }
            }
        }

        private static bool GetSqaureValue(string number)
        {
            if (number == "1")
                return true;
            if (number == "4")
                return false;

            List<double> values = new List<double>();
            for (int i = 0; i < number.Length; i++)
            {
                int num;
                int.TryParse(number[i].ToString(), out num);
                values.Add(Math.Pow(num, 2));
            }
           return GetSqaureValue(values.Sum().ToString());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to your file containing data:");
            var path = Console.ReadLine();
            FindHappyNumber(path);

            Console.Read();
        }
    }
}
