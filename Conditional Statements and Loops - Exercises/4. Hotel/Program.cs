using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            double Temporary_Studio_Price = 0;
            double Studio_Price = 0;
            double Double_Price = 0;
            double Suite_Price = 0;

            if(month == "May" || month == "October")
            {
                Studio_Price = 50;
                Double_Price = 65;
                Suite_Price = 75;

                Studio_Price = Studio_Price * nights;
                Double_Price = Double_Price * nights;
                Suite_Price = Suite_Price * nights;

                if (nights > 7)
                {
                    Studio_Price = Studio_Price * 0.95;
                    Temporary_Studio_Price = Studio_Price / nights;
                }
            }
            else if(month == "June" || month == "September")
            {
                Studio_Price = 60;
                Double_Price = 72;
                Suite_Price = 82;

                Studio_Price = Studio_Price * nights;
                Double_Price = Double_Price * nights;
                Suite_Price = Suite_Price * nights;

                if (nights > 14)
                {
                    Double_Price = Double_Price * 0.90;
                }

            }
            else if (month == "July" || month == "August" || month == "December")
            {
                Studio_Price = 68;
                Double_Price = 77;
                Suite_Price = 89;

                Studio_Price = Studio_Price * nights;
                Double_Price = Double_Price * nights;
                Suite_Price = Suite_Price * nights;

                if (nights > 14)
                {
                    Suite_Price = Suite_Price * 0.85;
                }
            }

            if(month == "September" && nights > 7)
            {
                Studio_Price = Studio_Price - 60;
            }

            if (month == "October" && nights > 7)
            {
                Studio_Price = Studio_Price - Temporary_Studio_Price;
            }

            Console.WriteLine("Studio: {0} lv.", $"{Studio_Price:F2}");
            Console.WriteLine("Double: {0} lv.", $"{Double_Price:F2}");
            Console.WriteLine("Suite: {0} lv.", $"{Suite_Price:F2}");

        }
    }
}
