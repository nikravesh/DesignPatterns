using Creationals.AbstractFactory.Concepts.ConcreateClasses;
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