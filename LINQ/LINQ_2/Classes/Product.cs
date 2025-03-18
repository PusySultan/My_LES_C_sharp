using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_2.Classes
{
    internal struct Product
    {
        public string Name;
        public string Category;
        public int Price;

        public Product(string name, string category, int price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }
}
