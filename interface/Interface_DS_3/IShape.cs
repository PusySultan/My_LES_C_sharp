using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_3
{
    internal interface IShape
    {
        string type { get; }
        double CalculateArea();

        double CalculatePerimetr();
    }
}
