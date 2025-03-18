using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_2
{
    internal interface IVehicle
    {
        int Speed { get; set; }

        bool IsActive { get; }

        void drive();
    }
}
