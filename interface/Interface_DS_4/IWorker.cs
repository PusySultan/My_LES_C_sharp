using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_4
{
    internal interface IWorker
    {
        string name { get; }
        string sersurname { get; }
        bool isHappy { get; }
        bool inProgress { get; set; }
        void Work();
        void GetInfo();
    }
}
