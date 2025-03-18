using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_1
{
    internal class Cat : IAnimal
    {
        private string _name;
        private uint _age;

        public Cat()
        { 
        }
        public Cat(string name, uint age)
        { 
            Name = name;
            Age = age;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public uint Age
        {
            get => _age;
            set => _age = value > 0 ? value : _age;
        }

        public void Sound() => Console.WriteLine("Mau");
        
        public void Eat() => Console.WriteLine("Milk");
    }
}
