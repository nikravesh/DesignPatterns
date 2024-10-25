using Creationals.FactoryMethod.RealWorldExample.ConcreteClasses.PaymentProviders;
using Creationals.FactoryMethod.RealWorldExample.SuperClasses;

namespace Creationals.FactoryMethod.RealWorldExample.ConcreteClasses.PaymentProviderFactories;
public class PaypalFactory : PaymentProviderFactory
{
    public override IPaymentProvider CreatePaymentProvider() => new Paypal();
}
