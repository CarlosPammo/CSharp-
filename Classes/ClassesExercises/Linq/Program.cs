using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Database.Products();
            var sales = Database.Sales();
            var updatedStockProduct = (from product in products
                                       join quantity in sales on product.Id equals quantity.ProductId
                select new
                {
                    Product = product.Name,
                    Stock = product.Amount - quantity.QuantitySold
                });

            foreach (var product in updatedStockProduct)
            {
                Console.WriteLine(product);
            }
        }
    }
}
