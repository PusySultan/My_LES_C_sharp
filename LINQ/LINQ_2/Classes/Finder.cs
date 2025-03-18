using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LINQ_2.Classes
{
    internal class Finder
    {
        // Name: "Laptop 1", Category: "Electronics", Price: 56000

        private Regex regex = new Regex(@":(\s*""([^""]+)""|\s*\d*)");

        private string _dataPath = "..\\..\\..\\Data\\data.txt";

        private List<Product> _products = new List<Product>();

        public List<Product> getProducts()
        {
            Complition();
            return _products;
        }
        private string Reader()
        {
            using (StreamReader sr = new StreamReader(_dataPath))
            {
                return sr.ReadToEnd();
            }
        }

        private void Complition()
        {
            string data = Reader();
            Match match = regex.Match(data);

            string name = string.Empty;
            string category = string.Empty;
            int price = 0;

            while (match.Success)
            {
                name = match.Value.Substring(3, match.Length - 4);
                match = match.NextMatch();

                category = match.Value.Substring(3, match.Length - 4);
                match = match.NextMatch();

                price = Convert.ToInt32(match.Value.Substring(1).Trim());
                match = match.NextMatch();

                _products.Add(new Product(
                    name,
                    category,
                    price));
            }
        }
    }
}
