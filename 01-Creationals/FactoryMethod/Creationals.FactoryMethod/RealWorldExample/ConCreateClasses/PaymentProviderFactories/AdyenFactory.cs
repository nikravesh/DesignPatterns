using Creationals.FactoryMethod.RealWorldExample.ConCreateClasses.PaymentProviders;
using Creationals.FactoryMethod.RealWorldExample.SuperClasses;

namespace Creationals.FactoryMethod.RealWorldExample.ConCreateClasses.PaymentProviderFactories;

public class AdyenFactory : PaymentProviderFactory
{
    public override IPaymentProvider CreatePaymentProvider() => new Adyen();
}
