using Creationals.FactoryMethod.RealWorldExample.ConcreteClasses.PaymentProviders;
using Creationals.FactoryMethod.RealWorldExample.SuperClasses;

namespace Creationals.FactoryMethod.RealWorldExample.ConcreteClasses.PaymentProviderFactories;

public class AdyenFactory : PaymentProviderFactory
{
    public override IPaymentProvider CreatePaymentProvider() => new Adyen();
}
