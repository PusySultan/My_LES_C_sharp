using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_4
{
    internal interface IManager : IWorker
    {
        IWorker[] subordinates { get; }

        void AddSubordinates(IWorker worker);

        void AddSubordinates(IWorker[] workers);

        void RemoveSubordinates(IWorker worker);

        void RemoveSubordinates(IWorker[] workers);

        void RemoveAllSubordinates();
        void Manage();
    }
}
