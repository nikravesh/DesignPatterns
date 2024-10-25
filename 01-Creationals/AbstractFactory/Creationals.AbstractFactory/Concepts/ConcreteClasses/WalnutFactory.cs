using Creationals.AbstractFactory.Concepts.Factories;
using Creationals.AbstractFactory.Concepts.SuperClasses;

namespace Creationals.AbstractFactory.Concepts.ConcreteClasses;

public class WalnutFactory : IProductFactory
{
    public ICake MakeCake()
    {
        return new WalnutCake();
    }

    public IDonate MakeDonate()
    {
        return new WalnutDonate();
    }
}
