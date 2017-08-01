namespace Decorator
{
    abstract class BakeryDecorator: IBakery
    {
        protected readonly IBakery baseBakery;
        protected string name;
        protected double price;

        protected BakeryDecorator(IBakery bakery)
        {
            baseBakery = bakery;
        }

        public abstract string GetName();

        public abstract double GetPrice();
    }
}
