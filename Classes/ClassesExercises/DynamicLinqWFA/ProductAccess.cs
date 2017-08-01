using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DynamicLinqWFA
{
    internal static class ProductAccess
    {
        private static Random generator;
        private static Random Generator => generator ?? (generator = new Random(1));

        public static int NextRand(this int seed, int maximun = 5)
        {
            return Generator.Next(seed, maximun);
        }
        private static IEnumerable<Shampoo> GetShampooData()
        {
            return new List<Shampoo>
            {
                new Shampoo {Name = "Ceramidas", Code = 101, Brand = "Sedal", Distributor = "Unilever" },
                new Shampoo {Name = "Mentol", Code = 205, Brand = "H&S", Distributor = "Companex" },
                new Shampoo {Name = "Duo", Code = 201, Brand = "H&S", Distributor = "Companex" },
                new Shampoo {Name = "Restauracion", Code = 102, Brand = "Sedal", Distributor = "Unilever" },
                new Shampoo {Name = "Duo", Code = 103, Brand = "Sedal", Distributor = "Unilever" },
                new Shampoo {Name = "Palta", Code = 308, Brand = "Wella", Distributor = "Belmet" },
                new Shampoo {Name = "Manzana", Code = 307, Brand = "Wella", Distributor = "Belmet" },
                new Shampoo {Name = "Brillo Gloss", Code = 109, Brand = "Sedal", Distributor = "Unilever" },
                new Shampoo {Name = "Bebe", Code = 701, Brand = "Vita", Distributor = "Vita" }

            };
        }

        internal static List<Shampoo> SearchShampoos(string criteria, string operation, string field)
        {
            var shampoos = GetShampooData();
            var type = typeof (Shampoo);

            var result = Expression.Parameter(type);

            var property = type.GetProperty(field);
            var member = Expression.MakeMemberAccess(result, property);

            var propertyType = property.PropertyType;
            // possible try
            var parsedCriteria = Convert.ChangeType(criteria, propertyType);

            var searchCriteria = Expression.Constant(parsedCriteria, propertyType);

            var matching = operation.Equals("Equals to")
                ? Expression.Equal(member, searchCriteria)
                : Expression.NotEqual(member, searchCriteria);

            var where = Expression.Lambda<Func<Shampoo, bool>>(matching, result);

            return shampoos.Where(where.Compile()).ToList();
        }
    }
}
