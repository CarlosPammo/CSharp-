namespace Decorator
{
    class ArtificialScentDecorator: BakeryDecorator
    {
        public ArtificialScentDecorator(IBakery bakery) : base(bakery)
        {
            name = "Artificial Scent";
            price = 3.0;
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
