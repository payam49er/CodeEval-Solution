//solution to CodeEval challenge Query Board https://www.codeeval.com/open_challenges/87/
using System;
using System.IO;

namespace QueryBoard
{
    class Program
    {
        public static void GetQuery(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                int[,] board = new int[256, 256];

                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine().Split(' ');
                    string command = lineValue[0];
                    switch (command)
                    {
                        case "SetCol":
                            int columnNumber = Convert.ToInt32 (lineValue[1]);
                            int columnValue = Convert.ToInt32(lineValue[2]);
                           
                            for (int j = 0; j < 256; j++)
                            {
                                board[j,columnNumber] =columnValue;
                            }
                            break;
                        case "SetRow":
                            int rowNumber = Convert.ToInt32 (lineValue[1]);
                            int rowValue = Convert.ToInt32(lineValue[2]);
                           
                            for (int i = 0; i < 256; i++)
                            {
                                board[rowNumber,i] = rowValue;
                            }
                            break;
                        case "QueryCol":
                            
                            int columnVal = 0;
                            int columnNum = Convert.ToInt32 (lineValue[1]);
                            for (int j = 0; j < 256; j++)
                            {
                                columnVal += board[j,columnNum];
                            }
                          
                            Console.WriteLine(columnVal);
                            break;
                        case "QueryRow":
                            int rowVal = 0;
                            int rowNum = Convert.ToInt32 (lineValue[1]);
                            for (int i = 0; i < 256; i++)
                            {
                                rowVal += board[rowNum,i];
                            }
                           
                            Console.WriteLine(rowVal);
                            break;
                    }
                }
            }
        }

       

        static void Main ( string[] args )
        {
            Console.WriteLine("Please insert the path to the file containing the data:");
            var path = Console.ReadLine();
            GetQuery(path);

            Console.Read();
        }
    }
}
