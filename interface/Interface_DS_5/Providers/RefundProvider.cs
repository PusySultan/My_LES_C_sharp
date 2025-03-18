using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_DS_5.Loggers;

namespace Interface_DS_5.Providers
{
    internal class RefundProvider(IPaymentProvider[] providers, ILogger logger) 
        : PaymentService(providers, logger), IRefundable
    {
        public bool ProcessRefund(double amount)
        {
            base._logger.Log(string.Format("[LOG] Попытка возврата {0} в {1}", amount, DateTime.Now));

            foreach (IPaymentProvider provider in base._providers)
            {
                //if (provider.name == providerName)
                //{
                //    provider.ProcessPayment(amount);
                //    return true;
                //}
            }

            // Console.WriteLine("Провайдер {0} не найден", providerName);

            return false;
        }

        private void Refounde()
        { 
            
        }
    }
}
