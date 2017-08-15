using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ListExcercisesFlipListSides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int middleOfList = numbers.Count() / 2;

            for (int i = 1; i < middleOfList; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[(numbers.Count - 1) - i];
                numbers[(numbers.Count - 1) - i] = temp;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
