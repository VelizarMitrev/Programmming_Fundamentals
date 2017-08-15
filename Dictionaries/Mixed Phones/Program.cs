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
            var inputLine = Console.ReadLine()
                .Split(' ');

            var resultDictionary = new SortedDictionary<string, int>();

            while (inputLine[0].ToLower() != "over")
            {
                int intResult = 0;
                if (int.TryParse(inputLine[0], out intResult))
                {
                    resultDictionary[inputLine[2]] = intResult;
                }
                else if (int.TryParse(inputLine[2], out intResult))
                {
                    resultDictionary[inputLine[0]] = intResult;
                }

                inputLine = Console.ReadLine()
                    .Split(' ');
            }


            foreach (var kvp in resultDictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}