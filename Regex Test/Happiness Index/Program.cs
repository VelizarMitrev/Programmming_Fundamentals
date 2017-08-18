using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Happiness_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string HappyPattern = "(:\\))|(:D)|(;\\))|(:\\*)|(:])|(;])|(:})|(;})|(\\(:)|(\\*:)|(c:)|(\\[:)|(\\[;)";
            string SadPattern = "(:\\()|(D:)|(;\\()|(:\\[)|(;\\[)|(:{)|(;{)|(\\):)|(:c)|(\\]:)|(\\];)";
            Regex HappyRegex = new Regex(HappyPattern);
            Regex SadRegex = new Regex(SadPattern);
            string input = Console.ReadLine();
            decimal happiness_index;
            decimal happyemoticons = 0;
            decimal sademoticons = 0;

            MatchCollection HappyMatches = HappyRegex.Matches(input);
            foreach(Match HM in HappyMatches)
            {
                happyemoticons++;
            }

            MatchCollection SadMatches = SadRegex.Matches(input);
            foreach (Match SM in SadMatches)
            {
                sademoticons++;
            }

            happiness_index = happyemoticons / sademoticons;

            Console.Write("Happiness index: {0} ", happiness_index);

            if(happiness_index < 1)
            {
                Console.WriteLine(":(");
            }else if(happiness_index == 1)
            {
                Console.WriteLine(":|");
            }else if(happiness_index > 1 && happiness_index < 2)
            {
                Console.WriteLine(":)");
            }else if(happiness_index >= 2)
            {
                Console.WriteLine(":D");
            }

            Console.Write("[Happy count: {0}, Sad count: {1}] ", happyemoticons.ToString("0.##"), sademoticons.ToString("0.##"));

        }
    }
}
