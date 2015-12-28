using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


//solution to codeeval challenge https://www.codeeval.com/open_challenges/183/
namespace Details
{
    class Program
    {
        static void Main( string [] args )
        {

            using (StreamReader reader = File.OpenText(args [0]))
            {

                while (!reader.EndOfStream)
                {
                    string [] lineValue = reader.ReadLine().Split(',');
                    List<int> distances = new List<int>();
                    foreach (var section in lineValue)
                    {
                        //logic to calculate the movement of the Y
                        distances.Add(GetYMovementCount(section));

                    }
                    Console.WriteLine(distances.Min());
                }
            }

           
            Console.Read();
        }

        private static int GetYMovementCount(string data)
        {
            int counter = 0;
            for (int i = 0 ; i < data.Length ; i++)
            {
                if ( data [i] == '.')
                {
                    counter++;
                } 
                else if(data[i] == 'Y') {
                    break;
                } 
                
            }
            return counter;
        }
    }
}
