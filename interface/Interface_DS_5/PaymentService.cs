using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_DS_5.Loggers;
using Interface_DS_5.Providers;

namespace Interface_DS_5
{
    internal class PaymentService(IPaymentProvider[] providers, ILogger logger)
    {
        protected IPaymentProvider[] _providers = providers;
        protected readonly ILogger _logger = logger;

        public void ShowAvailableProviders()
        {
            _logger.Log(string.Format("[LOG] Запрос доступных провайдеров {0}", DateTime.Now));
            Console.WriteLine("Доступные провайдоры: ");

            foreach (IPaymentProvider provider in _providers)
            {
                Console.WriteLine(" - {0}", provider.name);
            }
        }

        public bool Pay(string providerName, double amount)
        {
            _logger.Log(string.Format("[LOG] Попытка оплаты через {0} {1}", providerName, DateTime.Now));

            foreach (IPaymentProvider provider in _providers)
            {
                if (provider.name == providerName)
                {
                    provider.ProcessPayment(amount);
                    return true;
                }
            }

            Console.WriteLine("Провайдер {0} не найден", providerName);

            return false;
        }

        public bool Refounde(string providerName, double amount)
        {
            _logger.Log(string.Format("[LOG] Попытка возврата {0} в {1}", amount, DateTime.Now));

            foreach (IPaymentProvider provider in _providers)
            {
                if (provider.name == providerName)
                {
                    provider.ProcessRefund(amount);
                    return true;
                }
            }

            Console.WriteLine("Провайдер {0} не найден", providerName);

            return false;
        }
    }
}
