using Decorator.Components;

namespace Decorator.Decorators
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
            Description = $"{_beverage.Description}, Soy";
            Cost = .34 + _beverage.Cost;
        }
    }
}
