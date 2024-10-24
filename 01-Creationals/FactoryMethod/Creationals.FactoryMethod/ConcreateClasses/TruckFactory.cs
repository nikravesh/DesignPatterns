using Creationals.FactoryMethod.SuperClasses;

namespace Creationals.FactoryMethod.ConcreateClasses;

public class TruckFactory : Vehicle
{
    public override IVehicle CreateVehicle() => new Truck();
}
