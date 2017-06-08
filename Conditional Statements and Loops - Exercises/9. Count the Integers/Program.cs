using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int number_count = 0;
            int input_count = 0;
            int num;
            while (running)
            {
                var input = Console.ReadLine();
                input_count++;

                if (int.TryParse(input, out num))
                {
                    number_count++;
                }else
                {
                    break;
                }

                if(input_count > 100)
                {
                    break;
                }
            }
            Console.WriteLine(number_count);
        }
    }
}
