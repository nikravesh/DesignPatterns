using Creationals.FactoryMethod.SuperClasses;

namespace Creationals.FactoryMethod.ConcreateClasses;

public class BikeFactory : Vehicle
{
    public override IVehicle CreateVehicle() => new Bike();
}
