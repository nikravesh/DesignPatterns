using Creationals.AbstractFactory.Concepts.ConcreteClasses;
using Creationals.AbstractFactory.Concepts.Factories;

namespace Creationals.AbstractFactory.Concepts;
public class Client
{
    public Client()
    {
        IProductFactory walnutsProduct = new WalnutFactory();
        walnutsProduct.MakeCake();
        walnutsProduct.MakeDonate();
    }
}