using System;
using System.IO;
using System.Linq;

namespace RoalerCoaster
{
    class Program
    {
        public static void MakeRollerCoaster(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var readLine = reader.ReadLine();
                    if (readLine != null)
                    {
                        var characters = readLine.ToCharArray().ToList();
                        bool switchVal = true;
                        foreach (var character in characters)
                        {

                            var isletter = character.ToString().Any(x => char.IsLetter(x));
                            if (isletter)
                            {
                                if (switchVal)
                                {
                                    Console.Write(character.ToString().ToUpper());
                                    switchVal = false;
                                }

                                else
                                {
                                    Console.Write(character.ToString().ToLower());
                                    switchVal = true;
                                }
                            }
                            else
                                Console.Write(character);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to the file:");
            var path = Console.ReadLine();
            MakeRollerCoaster(path);

            Console.Read();
        }
    }
}

