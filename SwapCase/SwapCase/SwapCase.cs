///solution to CodeEval challenge Swap Case:https://www.codeeval.com/open_challenges/96/
using System;
using System.IO;
using System.Linq;


namespace SwapCase
{
    internal class SwapCase
    {
        public void Swap(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();

                    if (!string.IsNullOrEmpty(lineValue))
                    {
                        for (int i = 0; i < lineValue.Count(); i++)
                        {
                            if (char.IsLetter(lineValue[i]))
                            {
                                if (char.IsLower(lineValue[i]))
                                {
                                    Console.Write(lineValue[i].ToString().ToUpper());
                                }
                                else
                                {
                                    Console.Write(lineValue[i].ToString().ToLower());
                                }
                            }
                            else
                            {
                                Console.Write(lineValue[i]);
                            }
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }

}


