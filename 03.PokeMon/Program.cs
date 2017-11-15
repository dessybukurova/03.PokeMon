using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int percent = pokePower / 2;
            int count = 0;

            while(pokePower >= distance)
            {
                pokePower -= distance;

                if (pokePower == percent)
                {
                    if (exhaustionFactor > 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                    
                }
                count++;
                
          
                
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}
