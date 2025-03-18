using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_1
{
    internal interface IAnimal
    {
        string Name { get; set; }
        uint Age { get; set; }

        void GetInfo()
        {
            Console.WriteLine("My name: " + Name);
            Console.WriteLine("My age: " + Age);
        }
        void Sound() => Console.WriteLine("it is my voice");

        void Eat() => Console.WriteLine("My eat is meet");
    }
}
