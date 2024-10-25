using Creationals.AbstractFactory.Concepts.SuperClasses;

namespace Creationals.AbstractFactory.Concepts.ConcreteClasses;

public class CoconateDonate : IDonate
{
    public string GetDonateType() => "I am a Coconate donate";
}
