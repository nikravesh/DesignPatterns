using Creationals.AbstractFactory.Concepts.SuperClasses;

namespace Creationals.AbstractFactory.Concepts.ConcreateClasses;

public class CoconateDonate : IDonate
{
    public string GetDonateType() => "I am a Coconate donate";
}
