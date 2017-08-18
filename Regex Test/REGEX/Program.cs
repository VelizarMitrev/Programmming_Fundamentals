using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);

            var input = Console.ReadLine();
            Match match = regex.Match(input);

            if (regex.IsMatch(input))
            {
                Console.WriteLine("DA");
            }
        }
    }
}
