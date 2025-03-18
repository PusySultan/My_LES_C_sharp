using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_5.Providers
{
    internal class VisaProvider : IPaymentProvider
    {
        public string name => "Visa";

        public bool ProcessPayment(double amount)
        {
            Console.WriteLine("Оплата {0} через {1} выполнена", amount, name);
            return true;
        }

        public bool ProcessRefund(double amount)
        {
            Console.WriteLine("Возврат {0} через {1} выполнена", amount, name);
            return true;
        }
    }
}
