using Creationals.FactoryMethod.RealWorldExample.SuperClasses;

namespace Creationals.FactoryMethod.RealWorldExample.ConCreateClasses.PaymentProviders;

public class Adyen : IPaymentProvider
{
    public void ProcessPayment(decimal amount) =>
        Console.WriteLine($"Process {amount} payment through Adyen");
}
