using Creationals.FactoryMethod.RealWorldExample.SuperClasses;

namespace Creationals.FactoryMethod.RealWorldExample.ConcreteClasses.PaymentProviders;

public class ApplePay : IPaymentProvider
{
    public void ProcessPayment(decimal amount) =>
        Console.WriteLine($"Process {amount} payment through AplePay");
}
