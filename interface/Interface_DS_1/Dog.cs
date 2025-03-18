using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_1
{
    internal class Dog : IAnimal
    {
        private string _name;
        private uint _age;
        public string Name
        { 
            get => _name ; 
            set => _name = value; 
        }
        public uint Age
        { 
            get => _age; 
            set => _age =  value > 0 ? value : _age; 
        }
    }
}
