using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = 0;
            int overflows = 0;
            int times = int.Parse(Console.ReadLine());

            for(int i = 0; i < times; i++)
            {
                n++;
                if(n == 0)
                {
                    overflows++;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine("Overflowed {0} times", overflows);

        }
    }
}
