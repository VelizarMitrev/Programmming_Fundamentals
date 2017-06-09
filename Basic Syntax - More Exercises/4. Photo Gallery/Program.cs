using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo_number = int.Parse(Console.ReadLine());

            var photo_day = int.Parse(Console.ReadLine());
            var photo_month = int.Parse(Console.ReadLine());
            var photo_year = int.Parse(Console.ReadLine());

            var photo_hours = int.Parse(Console.ReadLine());
            var photo_minutes = int.Parse(Console.ReadLine());

            var photo_bytes = float.Parse(Console.ReadLine());

            var photo_width = int.Parse(Console.ReadLine());
            var photo_height = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0}.jpg", photo_number.ToString("0000"));
            Console.WriteLine("Date Taken: {0}/{1}/{2} {3}:{4}", photo_day.ToString("00"), photo_month.ToString("00"), photo_year, photo_hours.ToString("00"), photo_minutes.ToString("00"));

            if(photo_bytes < 1000)
            {
                Console.WriteLine("Size: {0}B", photo_bytes);
            }else if(photo_bytes >= 1000 && photo_bytes <= 1000000)
            {
                photo_bytes = photo_bytes / 1000;
                Console.WriteLine("Size: {0}KB", photo_bytes);
            }else if(photo_bytes >= 1000000)
            {
                photo_bytes = photo_bytes / 1000000;
                Console.WriteLine("Size: {0}MB", photo_bytes);
            }

            if(photo_width > photo_height)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)", photo_width, photo_height);
            }else if(photo_width == photo_height)
            {
                Console.WriteLine("Resolution: {0}x{1} (square)", photo_width, photo_height);
            }else if(photo_width < photo_height)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)", photo_width, photo_height);
            }

        }
    }
}
