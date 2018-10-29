using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPet
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solver();
            s.Mock();

            for(int h = 0; h < s.Houses.Length; h++)
            {
                Console.WriteLine($"House:\t{h + 1}" +
                    $"\tColor:{s.Houses[h].Color}" + 
                    $"\tNationality:{s.Houses[h].Nationality}"+
                    $"\tDrink:{s.Houses[h].Drink}" +
                    $"\tSmoke:{s.Houses[h].Smoke}" +
                    $"\t\tPet: {s.Houses[h].Pet}");
            }

            Console.ReadLine();
        }
    }
}
