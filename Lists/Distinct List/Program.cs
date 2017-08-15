using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> List1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> noDupes = List1.Distinct().ToList();

            for (int i = 0; i < noDupes.Count(); i++)
            {
                Console.Write(noDupes[i]);
                Console.Write(" ");
            }


        }
    }
}
