using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int Difference;
            List<int> List1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> List2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List2.RemoveAll(x => List1.Contains(x));

            int TotalOfList1 = List1.Sum(x => Convert.ToInt32(x));
            int TotalOfList2 = List2.Sum(x => Convert.ToInt32(x));

            if(TotalOfList1 == TotalOfList2)
            {
                Console.WriteLine("Yes. Sum: " + TotalOfList1);
            }else if(TotalOfList1 > TotalOfList2)
            {
                Difference = TotalOfList1 - TotalOfList2;
                Console.WriteLine("No. Diff: " + Difference);
            }
            else if (TotalOfList2 > TotalOfList1)
            {
                Difference = TotalOfList2 - TotalOfList1;
                Console.WriteLine("No. Diff: " + Difference);
            }


        }
    }
}
