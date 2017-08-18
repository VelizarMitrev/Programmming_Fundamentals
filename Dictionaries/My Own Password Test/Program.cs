using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Own_Password_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ');

            var Accounts = new Dictionary<string, string>();
            int counter = 0;



            while(inputLine[0] != "over")
            {
                string name = inputLine[0];
                string password = inputLine[2];

                Accounts.Add(name, password);

                inputLine = Console.ReadLine().Split(' ');
            }

            foreach(KeyValuePair<string, string> pair in Accounts)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
