///solution to CodeEval challenge Split the number:https://www.codeeval.com/open_challenges/131/
using System;
using System.IO;
using System.Text;

namespace SplitNumbers
{
    class Program
    {
        public static void Split(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (!string.IsNullOrEmpty(lineValue))
                    {
                        var line = lineValue.Split(' '); // contains numbers and patterns
                        var numbers = line[0];
                        var pattern = line[1];
                        StringBuilder leftNumber = new StringBuilder();
                        StringBuilder rightNumber = new StringBuilder();
                        string operationType = null;
                        int operationPos = 0;
                        for (int i = 0; i < pattern.Length; i++)
                        {
                            if (char.IsLetter(pattern[i]))
                            {
                                leftNumber.Append(numbers[i]);
                            }
                            else
                            {
                                operationType = pattern[i].ToString();
                                operationPos = i;
                                break;
                            }
                        }

                        for (int i = operationPos; i < pattern.Length-1; i++)
                        {
                            rightNumber.Append(numbers[i]);
                        }

                        int lNumber;
                        int.TryParse(leftNumber.ToString(), out lNumber);

                        int rNumber;
                        int.TryParse(rightNumber.ToString(), out rNumber);

                        if(operationType == "+")
                            Console.WriteLine(lNumber+rNumber);
                        else
                        {
                            Console.WriteLine(lNumber-rNumber);
                        }

                    }
                }
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Insert the path to the file containing the data:");
            var path = Console.ReadLine();
            Split(path);
            Console.Read();
        }
    }
}
