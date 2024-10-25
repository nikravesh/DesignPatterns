using Creationals.FactoryMethod.Concepts.SuperClasses;

namespace Creationals.FactoryMethod.Concepts.ConcreteClasses;

public class Truck : IVehicle
{
    public void Drive() => Console.WriteLine("Driving a truck");
}
