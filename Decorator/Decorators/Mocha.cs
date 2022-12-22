using Decorator.Components;
using System;

namespace Decorator.Decorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            Description = $"{_beverage.Description}, Mocha";
            Cost = .20 + _beverage.Cost;
        }
    }
}
