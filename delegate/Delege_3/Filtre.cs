using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delege_3
{
    internal class Filtre
    {
        private string _data;

        delegate bool isEven(int a);
        public Filtre(string data)
        {
            _data = data.TrimEnd();
        }

        public void GetEvenNumber()
        { 
            IEnumerable<string> numbers = _data.Split(" ");

            var data = numbers.Where((n) => int.Parse(n) % 2 == 0);

            foreach (var number in data)
            {
                Console.Write(number + " ");
            }
        }

        public void NoFiltre()
        {
            Console.WriteLine(_data);
        }
    }
}
