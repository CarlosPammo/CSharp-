namespace Decorator
{
    class CakeBase: IBakery
    {
        private string name = "Cake Base";
        private double price = 200.0;

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
