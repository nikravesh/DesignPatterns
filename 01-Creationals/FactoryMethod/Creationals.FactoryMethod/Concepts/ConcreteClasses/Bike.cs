using Creationals.FactoryMethod.Concepts.SuperClasses;

namespace Creationals.FactoryMethod.Concepts.ConcreteClasses;

public class Bike : IVehicle
{
    public void Drive() => Console.WriteLine("Riding a Bike");
}
