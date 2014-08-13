///solution to https://www.codeeval.com/open_challenges/152/
using System;
using System.IO;

namespace AgeDistribution
{
    class Program
    {
        public static void PublishAgeDistribution(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (lineValue != null)
                    {
                        int age;
                        int.TryParse(lineValue, out age);
                        if(age > 0 && age <=2)
                            Console.WriteLine("Still in Mama's arms");
                        else if(age >= 3 && age <= 4)
                            Console.WriteLine("Preschool Maniac");
                        else if(age >= 5 && age <= 11)
                            Console.WriteLine("Elementary school");
                        else if(age >= 12 && age <= 14 )
                            Console.WriteLine("Middle school");
                        else if(age >= 15 && age <= 18)
                            Console.WriteLine("High school");
                        else if(age >= 19 && age <= 22)
                            Console.WriteLine("College");
                        else if(age >= 23 && age <= 65)
                            Console.WriteLine("Working for the man");
                        else if(age >=66 && age < 100)
                            Console.WriteLine("The Golden Years");
                        else
                            Console.WriteLine("The program is for humans");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the path to the file:");
            var path = Console.ReadLine();
            PublishAgeDistribution(path);

            Console.Read();
        }
    }
}
