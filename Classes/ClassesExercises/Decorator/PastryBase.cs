namespace Decorator
{
    class PastryBase: IBakery
    {
        private string name = "Pastry Base";
        private double price = 20.0;
        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }
    }
}
