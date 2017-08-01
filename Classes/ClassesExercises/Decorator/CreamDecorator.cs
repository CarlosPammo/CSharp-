namespace Decorator
{
    class CreamDecorator: BakeryDecorator
    {
        public CreamDecorator(IBakery bakery) : base(bakery)
        {
            name = "Cream";
            price = 1.0;
        }

        public override string GetName()
        {
            return baseBakery.GetName() + ", " + name;
        }

        public override double GetPrice()
        {
            return baseBakery.GetPrice() + price;
        }
    }
}
