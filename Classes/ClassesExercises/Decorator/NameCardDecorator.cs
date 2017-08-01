namespace Decorator
{
    class NameCardDecorator: BakeryDecorator
    {
        private int discount = 5;
        public NameCardDecorator(IBakery bakery) : base(bakery)
        {
            name = "Name Card";
            price = 4.0;
        }

        public override string GetName()
        {
            return baseBakery.GetName() + ", " + name + " " + $"\n(Please Collect your discount card for {discount}%)";
        }

        public override double GetPrice()
        {
            return baseBakery.GetPrice() + price;
        }
    }
}
