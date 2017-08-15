using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var occurances = new Dictionary<char, int>();
            foreach (char c in text)
            {
                if (occurances.ContainsKey(c))
                    occurances[c] = occurances[c] + 1;
                else
                    occurances[c] = 1;
            }
            foreach (var entry in occurances)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }
        }
    }
}
