using Decorator.Components;
using Decorator.Decorators;
using System;

namespace Decorator
{
    public class StarbuzzCoffee
    {
        public static void Main()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.Description} ${beverage.Cost:f2}");

            Beverage darkRoast = new DarkRoast();
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Whip(darkRoast);
            Console.WriteLine($"{darkRoast.Description} ${darkRoast.Cost:f2}");

            Beverage houseBlend = new HouseBlend();
            houseBlend = new Soy(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);
            Console.WriteLine($"{houseBlend.Description} ${houseBlend.Cost:f2}");
        }
    }
}
