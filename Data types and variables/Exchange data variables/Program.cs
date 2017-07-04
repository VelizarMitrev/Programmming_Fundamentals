using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_data_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int temp;

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
