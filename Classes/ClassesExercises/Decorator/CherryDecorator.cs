namespace Decorator
{
    class CherryDecorator: BakeryDecorator
    {
        public CherryDecorator(IBakery bakery) : base(bakery)
        {
            name = "Cherry";
            price = 2.0;
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
