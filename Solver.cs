using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPet
{
    public class Solver
    {
        // This is the correct result        
        public House[] Houses { get; set; } = new House[5];

        private string[] Color { get; set; } = 
            new string[5] { "Yellow", "Red", "Blue", "White", "Green" };
        private string[] Nationality { get; set; } = 
            new string[5] { "Norwegian", "British", "German", "Danish", "Swedish" };
        private string[] Drink { get; set; } =
            new string[5] {"Water", "Tea", "Coffee", "Beer", "Milk"};
        private string[] Smoke { get; set; } =
            new string[5] { "Dunhill", "Blend", "Pull Mall", "Prince", "Bluemaster" };
        private string[] Pet { get; set; } =
            new string[5] { "Cat", "Dog", "Horse", "Bird", "Fish" };

        public void Mock()
        {
            Houses[0] = new House("Yellow", "Norwegian", "Water", "Dunhill", "Cat");
            Houses[1] = new House("Blue", "Danish", "Tea", "Blend", "Horse");
            Houses[2] = new House("Red", "British", "Milk", "Pull Mall", "Bird");
            Houses[3] = new House("Green", "German", "Coffee", "Prince", "Fish");
            Houses[4] = new House("White", "Swedish", "Beer", "Bluemaster", "Dog");
        }

        public void Execute()
        {
            // 1. Generate posible result
            GeneratePosibleResult();

            // 2. Verify 15 clues
        }

        private IEnumerable<House[]> GeneratePosibleResult()
        {
            for(int c = 0; c < Color.Length; c++)
            {
                for(int n = 0; n < Nationality.Length; n++)
                {
                    for(int d = 0; d < Drink.Length; d++)
                    {
                        for(int s = 0; s < Smoke.Length; s++)
                        {
                            var houses = new House[5];
                            for(int p = 0; p < Pet.Length; p++)
                            {
                                houses[p] = new House(Color[c], Nationality[n], Drink[d], Smoke[s], Pet[p]);
                            }
                            yield return houses;
                        }
                    }
                }
            }
        }
    }
}
