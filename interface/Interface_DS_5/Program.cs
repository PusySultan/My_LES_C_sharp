using Interface_DS_5.Loggers;
using Interface_DS_5.Providers;

namespace Interface_DS_5
{
    internal class Program
    {
        static void Main()
        {
            IPaymentProvider[] providers =
            [
                new VisaProvider(),
                new MirCardProvider(),
                new PayPalProvider(),
            ];

            PaymentService paymentService = new(providers, new Logger());

            paymentService.ShowAvailableProviders();
            Console.WriteLine();
            paymentService.Pay(providerName: "Visa", amount: 100000);
            paymentService.Pay(providerName: "Mir", amount: 250000);
            paymentService.Pay(providerName: "PayPal", amount: 500000);
            Console.WriteLine();
            paymentService.Pay(providerName: "MasterCard", amount: 1000000);
            paymentService.Refounde(providerName: "MasterCard", amount: 1000000);
            paymentService.Refounde(providerName: "PayPal", amount: 500000);
        }
    }
}
