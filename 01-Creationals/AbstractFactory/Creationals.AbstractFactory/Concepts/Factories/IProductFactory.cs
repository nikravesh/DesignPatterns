using Creationals.AbstractFactory.Concepts.SuperClasses;

namespace Creationals.AbstractFactory.Concepts.Factories;

public interface IProductFactory
{
    ICake MakeCake();
    IDonate MakeDonate();
}
