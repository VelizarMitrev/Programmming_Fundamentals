using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var beatsPerMinute = double.Parse(Console.ReadLine());
            var beatsDone = double.Parse(Console.ReadLine());

            var bars = Math.Round(beatsDone * 0.25, 1);
            int totalSeconds = ((int)beatsDone * 60 / (int)beatsPerMinute);
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
