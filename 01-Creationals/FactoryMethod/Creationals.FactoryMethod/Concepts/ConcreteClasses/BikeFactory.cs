using Creationals.FactoryMethod.Concepts.SuperClasses;

namespace Creationals.FactoryMethod.Concepts.ConcreteClasses;

public class BikeFactory : Vehicle
{
    public override IVehicle CreateVehicle() => new Bike();
}
