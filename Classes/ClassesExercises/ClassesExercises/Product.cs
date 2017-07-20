namespace ClassesExercises
{
    internal class Product
    {
        /// <summary>
        /// Gets or sets the name of the product. 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the brand of the product. 
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Constructor for a product.
        /// </summary>
        /// <param name="name">Name for a product</param>
        /// <param name="brand">Brand for a product</param>
        public Product(string name, string brand)
        {
            Name = name;
            Brand = brand;
        }
        
        protected virtual float GetDiscount()
        {
            return 0;
        }

        public override string ToString()
        {
            return "Product: " + Name + " " + Brand + " - discount: " + GetDiscount();
        }
    }
}
