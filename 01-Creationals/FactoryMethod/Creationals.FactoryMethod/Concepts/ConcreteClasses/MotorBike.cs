using Creationals.FactoryMethod.Concepts.SuperClasses;

namespace Creationals.FactoryMethod.Concepts.ConcreteClasses;

public class MotorBike : IVehicle
{
    public void Drive() => Console.WriteLine("Riding a MotorBike");
}
