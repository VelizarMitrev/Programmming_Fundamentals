using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = decimal.Parse(Console.ReadLine());
            var height = decimal.Parse(Console.ReadLine());
            decimal MegaPixels = 0;

            MegaPixels = (width * height) / 1000000;
            Console.WriteLine("{0}x{1} => {2}MP",width ,height ,Math.Round(MegaPixels, 1)); 

        }
    }
}
