using Creationals.FactoryMethod.RealWorldExample.SuperClasses;

namespace Creationals.FactoryMethod.RealWorldExample.ConCreateClasses.PaymentProviders;

public class ApplePay : IPaymentProvider
{
    public void ProcessPayment(decimal amount) =>
        Console.WriteLine($"Process {amount} payment through AplePay");
}
