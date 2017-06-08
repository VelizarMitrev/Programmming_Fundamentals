using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var middle_spare = input - 2;
            var beggining_spare = input;

            for(int row = 0; row < input; row++)
            {
                for (int col = 0; col < input; col++)
                {
                    if (col == row)
                    {
                        Console.Write("X");
                    } else if (col == input - row - 1)
                    {
                        Console.Write("X");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
