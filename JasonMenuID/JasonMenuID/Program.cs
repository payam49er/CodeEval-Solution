using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;


///Solution to https://www.codeeval.com/open_challenges/102/ in two ways
namespace JasonMenuID
{
    class Program
    {
 
        public static void GetJsonIdSums(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();
                    if (!string.IsNullOrEmpty(lineValue))
                    {
                        JavaScriptSerializer json = new JavaScriptSerializer();
                        dynamic result = json.DeserializeObject(lineValue);
                        var header = result["menu"];
                        var items = header["items"];
                        
                        int idSum = 0;

                        foreach (dynamic item in items)
                        {
                            if (item != null && item.ContainsKey("label"))
                            {
                                idSum += item["id"];
                            }
                           
                        }
                        Console.WriteLine(idSum);
                      
                    }
                }
            }
        }

        public static void GetJsonIdByRegExpression(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    string lineValue = reader.ReadLine();
                    Regex regex = new Regex(@"(Label )\d+");
                  
                        int sum = 0;
                        foreach (Match item in regex.Matches(lineValue))
                        {
                            sum += int.Parse(item.Value.Split(' ')[1]);
                        }

                        Console.WriteLine(sum);
                    
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the path to the file containing data:");
            var path = Console.ReadLine();
            GetJsonIdSums(path);

            GetJsonIdByRegExpression(path);

            Console.Read();
        }
    }
}
