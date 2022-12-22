namespace Decorator.Components
{
    public abstract class Beverage
    {
        public string Description { get; protected set; } = "Unknown Beverage";
        public double Cost { get; protected set; }
    }
}
