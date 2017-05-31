using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            double profession_price = 0;

            if(profession == "Athlete")
            {
                profession_price = 0.70;
            }else if(profession == "Businessman" || profession == "Businesswoman")
            {
                profession_price = 1;
            }
            else if (profession == "SoftUni Student")
            {
                profession_price = 1.70;
            }else
            {
                profession_price = 1.20;
            }

            string result = "The " + profession + " has to pay " + $"{profession_price * quantity:F2}" + ".";
            Console.WriteLine(result);
        }
    }
}
