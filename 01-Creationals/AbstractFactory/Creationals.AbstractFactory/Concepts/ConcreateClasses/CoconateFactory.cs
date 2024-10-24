using Creationals.AbstractFactory.Concepts.Factories;
using Creationals.AbstractFactory.Concepts.SuperClasses;

namespace Creationals.AbstractFactory.Concepts.ConcreateClasses;

public class CoconateFactory : IProductFactory
{
    public ICake MakeCake()
    {
        return new CoconateCake();
    }

    public IDonate MakeDonate()
    {
        return new CoconateDonate();
    }
}
