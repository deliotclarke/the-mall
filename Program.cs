
using System;

namespace TheMall
{
    class Program
    {
        static void Main(string[] args)
        {
            DollarStore Dollarama = new DollarStore();

            DollarItem MultiColorPen = new DollarItem()
            {
                Name = "Muli Colored Pen with 12 colors"
            };

            Dollarama.AddToInventory("mcp", MultiColorPen);

            FoodStore Cinnabon = new FoodStore();

            FoodItem ClassicRoll = new FoodItem()
            {
                Name = "Classic Roll",
                Price = 3.50,
                Calories = 880
            };

            FoodItem CaramelPecanBun = new FoodItem()
            {
                Name = "Caramel Pecan Bun",
                Price = 6,
                Calories = 1080
            };

            Cinnabon.AddToInventory("tcr", ClassicRoll);
            Cinnabon.AddToInventory("cpb", CaramelPecanBun);

            Console.WriteLine(Dollarama.GetFromInventory("mcp").Name);
            Console.WriteLine(Cinnabon.GetFromInventory("cpb").Name);
        }
    }
}
