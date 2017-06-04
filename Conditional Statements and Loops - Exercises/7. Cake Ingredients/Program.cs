using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bake = false;
            int ingredient_count = 0;
            while (bake == false)
            {           
                var ingredient = Console.ReadLine();
                if(ingredient.Length >= 1 && ingredient.Length <= 50)
                {
                    if (ingredient == "Bake!")
                    {
                        bake = true;
                    }
                    else
                    {
                        ingredient_count++;
                        Console.WriteLine("Adding ingredient {0}.", ingredient);
                    }
                    if (ingredient_count > 20)
                    {
                        break;
                    }
                }
                
            }

            if (ingredient_count > 20)
            {

            }
            else
            {
                Console.WriteLine("Preparing cake with {0} ingredients.", ingredient_count);
            }
        }
    }
}
