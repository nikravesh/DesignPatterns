using Creationals.FactoryMethod.RealWorldExample.ConCreateClasses.PaymentProviders;
using Creationals.FactoryMethod.RealWorldExample.SuperClasses;

namespace Creationals.FactoryMethod.RealWorldExample.ConCreateClasses.PaymentProviderFactories;

public class ApplePayFactory : PaymentProviderFactory
{
    public override IPaymentProvider CreatePaymentProvider()=>new ApplePay();
}
