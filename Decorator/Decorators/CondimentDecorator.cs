using Decorator.Components;

namespace Decorator.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage _beverage;
    }
}
