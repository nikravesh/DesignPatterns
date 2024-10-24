using System.Threading.Channels;

using Creationals.FactoryMethod.RealWorldExample.SuperClasses;

namespace Creationals.FactoryMethod.RealWorldExample.ConCreateClasses.PaymentProviders;
public class Paypal : IPaymentProvider
{
    public void ProcessPayment(decimal amount) => 
        Console.WriteLine($"Process {amount} payment through PayPal.");
}
