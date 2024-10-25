using Creationals.FactoryMethod.RealWorldExample.ConcreteClasses.PaymentProviders;
using Creationals.FactoryMethod.RealWorldExample.SuperClasses;

namespace Creationals.FactoryMethod.RealWorldExample.ConcreteClasses.PaymentProviderFactories;

public class ApplePayFactory : PaymentProviderFactory
{
    public override IPaymentProvider CreatePaymentProvider() => new ApplePay();
}
