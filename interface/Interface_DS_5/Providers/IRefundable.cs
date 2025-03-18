using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_5.Providers
{
    internal interface IRefundable
    {
        bool ProcessRefund(double amount);
    }
}
