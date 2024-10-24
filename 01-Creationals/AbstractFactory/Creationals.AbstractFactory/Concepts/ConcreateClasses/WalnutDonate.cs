using Creationals.AbstractFactory.Concepts.SuperClasses;

namespace Creationals.AbstractFactory.Concepts.ConcreateClasses;

public class WalnutDonate : IDonate
{
    public string GetDonateType() => "I am a Walnut donate";
}
