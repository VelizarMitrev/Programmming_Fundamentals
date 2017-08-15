using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                int currentnumber = int.Parse(input);
                int firstdigit = input[0] - '0';

                elements.Insert(firstdigit, currentnumber);

                input = Console.ReadLine();

            }

            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
