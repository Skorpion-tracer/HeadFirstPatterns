using Decorator.Components;

namespace Decorator.Decorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
            Description = $"{_beverage.Description}, Whip";
            Cost = .75 + _beverage.Cost;
        }
    }
}
