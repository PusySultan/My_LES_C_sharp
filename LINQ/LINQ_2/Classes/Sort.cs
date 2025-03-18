using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_2.Classes
{
    internal class Sort
    {
        public static IEnumerable<Product> Price_descending(List<Product> array)
        {
            return array.OrderByDescending((a) => a.Price);

        }

        public static IEnumerable<Product> Price_ascending(List<Product> array)
        {
            return array.OrderBy((a) => a.Price);

        }

        public static IEnumerable<Product> Price_BeforePrice(List<Product> array, int price)
        {
            return array.Where(x => x.Price < price);
        }

        public static IEnumerable<Product> Price_AfterPrice(List<Product> array, int price)
        {
            return array.Where(x => x.Price > price);
        }

        public static IEnumerable<Product> Price_RangePrice(List<Product> array, int startPrice, int endPrice)
        {
            return array.Where(x => x.Price > startPrice && x.Price < endPrice);
        }

        public static IEnumerable<Product> Category(List<Product> array, string category)
        {
            IEnumerable<Product> ret = array.Where((a) => a.Category == category);

            return ret != null && ret.Any() ? ret : throw new Exception("Have not category");

        }
    }
}
