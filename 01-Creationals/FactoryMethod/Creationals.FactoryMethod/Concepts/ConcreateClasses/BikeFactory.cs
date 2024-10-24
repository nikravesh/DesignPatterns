using Creationals.FactoryMethod.Concepts.SuperClasses;

namespace Creationals.FactoryMethod.Concepts.ConcreateClasses;

public class BikeFactory : Vehicle
{
    public override IVehicle CreateVehicle() => new Bike();
}
