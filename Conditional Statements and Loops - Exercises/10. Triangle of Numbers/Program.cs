using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                for(int j = 1; j < i + 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
