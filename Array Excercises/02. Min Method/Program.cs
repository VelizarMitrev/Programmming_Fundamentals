using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstnumber = int.Parse(Console.ReadLine());
            var secondnumber = int.Parse(Console.ReadLine());
            var thirdnumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(firstnumber, GetMin(secondnumber, thirdnumber)));
        }

        static int GetMin(int a, int b)
        {
            return Math.Min(a, b);

        }
    }
}