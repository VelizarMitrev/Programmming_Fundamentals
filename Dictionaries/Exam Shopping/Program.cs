using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, int>();
            var test = Console.ReadLine().Split(' ');

            while (test[0] != "shopping" && test[1] != "time")
            {
                items.Add(test[1], test[2]);




                test = Console.ReadLine().Split(' ');
            }
        }
    }
}
