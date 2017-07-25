using System.Runtime.InteropServices;

namespace ClassesExercises
{
    internal class Shampoo: Product
    {
        private const float Discount = 0.02f;
        /// <summary>
        /// Constructor for shampoo products.
        /// </summary>
        /// <param name="name">Name for shampoo</param>
        /// <param name="brand">Brand for shampoo</param>
        public Shampoo(string name, string brand): base(name, brand)
        {
            
        }

        protected override float GetDiscount()
        {
            return Discount;
        }

    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
}
