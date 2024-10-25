using Creationals.AbstractFactory.Concepts.SuperClasses;

namespace Creationals.AbstractFactory.Concepts.ConcreteClasses;

public class WalnutDonate : IDonate
{
    public string GetDonateType() => "I am a Walnut donate";
}
