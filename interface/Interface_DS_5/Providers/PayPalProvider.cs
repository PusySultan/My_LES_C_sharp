using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_5.Providers
{
    internal class PayPalProvider : IPaymentProvider
    {
        public string name => "PayPal";

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
