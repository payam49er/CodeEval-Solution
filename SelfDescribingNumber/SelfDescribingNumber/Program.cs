using System;
using System.IO;
using System.Linq;

namespace SelfDescribingNumber
{
    class Program
    {
        public static void SelfDecriptive(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();

                    var len = lineValue.Count();
                    bool isDescriptive = true;
                    if (lineValue[len-1] == '0')
                    {
                        for (int i = 0; i < len; i++)
                        {
                            int digit;
                            int.TryParse(lineValue[i].ToString(), out digit);
                            var pos = lineValue.Count(x => x.ToString() == i.ToString());
                            if (digit != pos)
                            {
                                isDescriptive = false;
                                break;
                            }

                        }
                    }
                    else
                    {
                        isDescriptive = false;
                    }
                    Console.WriteLine(isDescriptive? "1" : "0");
                }
            }
        }

        static void Main ( string[] args )
        {
            Console.WriteLine("Please insert the path to the file containing the data:");
            var path = Console.ReadLine();
            SelfDecriptive(path);

            Console.Read();
        }
    }
}
