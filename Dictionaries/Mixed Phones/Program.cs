using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ');

            var resultDictionary = new SortedDictionary<string, long>();

            while (inputLine[0].ToLower() != "over")
            {
                long longResult = 0;
                if (long.TryParse(inputLine[0], out longResult))
                {
                    resultDictionary[inputLine[2]] = longResult;
                }
                else if (long.TryParse(inputLine[2], out longResult))
                {
                    resultDictionary[inputLine[0]] = longResult;
                }

                inputLine = Console.ReadLine().Split(' ');
            }


            foreach (var kvp in resultDictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}