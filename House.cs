using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPet
{
    public class House
    {
        public string Color { get; set; }
        public string Nationality { get; set; }
        public string Drink { get; set; }
        public string Smoke { get; set; }
        public string Pet { get; set; }

        public House()
        {

        }

        public House(string color, string nationality, string drink, string smoke, string pet)
        {
            Color = color;
            Nationality = nationality;
            Drink = drink;
            Smoke = smoke;
            Pet = pet;
        }
    }
}
