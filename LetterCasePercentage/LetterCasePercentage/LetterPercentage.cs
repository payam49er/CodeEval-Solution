///Solution to https://www.codeeval.com/open_challenges/147/
using System;
using System.IO;

namespace LetterCasePercentage
{
    public class LetterPercentage
    {
        public void CalculatePercentage(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line != null)
                    {
                        var countLowerCase = 0;

                        for (int i = 0; i < line.Length; i++)
                        {
                            if (char.IsLower(line[i]))
                            {
                                countLowerCase++;
                            }
                        }

                        double lowerPercentage = (countLowerCase / (double)(line.Length)) * 100;
                        double upperPercentage = 100 - lowerPercentage;

                        Console.WriteLine("lowercase: {0:f2}" + " " + "uppercase: {1:f2}", lowerPercentage, upperPercentage);
                    }
                }
            }
        }
    }
}

