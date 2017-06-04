using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());

            if (number1 >= 0 && number1 <= 100 && number2 >= 0 && number2 <= 100)
            {
                if (number1 == number2)
                {

                }
                else
                {
                    if (number1 < number2)
                    {
                        for (int i = number1; i < number2 + 1; i++)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else if (number2 < number1)
                    {
                        for (int i = number2; i < number1 + 1; i++)
                        {
                            Console.WriteLine(i);
                        }

                    }
                }
            }

            
        }
    }
}
