using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> Words = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < Words.Count; i++)
            {
                if(i % 2 == 1)
                Console.Write(Words[i]);
            }
        }
    }
}
