using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Database
    {
        public static List<Product> Products()
        {
            return new List<Product>
                {
                    new Product {Id = 1, Name = "Van camps", Amount = 10},
                    new Product {Id = 2, Name  = "Nutella", Amount = 16},
                    new Product {Id = 3, Name  = "Nesquick", Amount = 17}
                };
        }

        public static List<Sales> Sales()
        {
            return new List<Sales>
                {
                    new Sales {Id = 1, ProductId = 1, TotalPrice = 10, QuantitySold = 3},
                    new Sales {Id = 3, ProductId  = 3, TotalPrice = 17, QuantitySold = 7}
                };
        }
    }
}
