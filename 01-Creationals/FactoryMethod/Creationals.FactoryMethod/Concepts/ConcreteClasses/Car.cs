using Creationals.FactoryMethod.Concepts.SuperClasses;

namespace Creationals.FactoryMethod.Concepts.ConcreteClasses;

public class Car : IVehicle
{
    public void Drive() => Console.WriteLine("Driving a car");
}
