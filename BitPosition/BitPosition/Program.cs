using System;
using System.IO;

namespace BitPosition
{
    class Program
    {

        public static void FindBitPosition(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine().Split(',');
                    var value = Convert.ToInt32(lineValue[0]);
                    var pos1 = Convert.ToInt32(lineValue[1]);
                    var pos2 = Convert.ToInt32(lineValue[2]);
                    if (((value >> pos1-1) & 1) == ((value >> pos2-1) & 1))
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
               
            }
        }

        static void Main ( string[] args )
        {
            Console.WriteLine("Please insert the path to the file containing your data:");
            var path = Console.ReadLine();
            FindBitPosition(path);
            Console.Read();
        }
    }
}
