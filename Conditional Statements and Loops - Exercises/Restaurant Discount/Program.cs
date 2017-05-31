using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var place = "";
            double final_price = 0;
            double discount = 0;

            if (group <= 50)
            {
                place = "Small Hall";
                final_price = 2500;
            } else if (group > 50 && group <= 100)
            {
                place = "Terrace";
                final_price = 5000;
            }
            else if (group > 100 && group <= 120)
            {
                place = "Great Hall";
                final_price = 7500;
            }


            if (group > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {


                if (package == "Normal")
                {
                    final_price = final_price + 500;
                    discount = 0.05;
                }
                else if (package == "Gold")
                {
                    final_price = final_price + 750;
                    discount = 0.10;
                }
                else if (package == "Platinum")
                {
                    final_price = final_price + 1000;
                    discount = 0.15;
                }



                final_price = final_price - (final_price * discount);
                final_price = final_price / group;

                Console.WriteLine("We can offer you the " + place);
                Console.WriteLine("The price per person is {0:f2}$", final_price);
            }
        }
    }
}
