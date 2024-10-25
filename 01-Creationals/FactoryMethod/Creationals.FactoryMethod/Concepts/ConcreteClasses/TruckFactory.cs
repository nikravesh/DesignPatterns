using Creationals.FactoryMethod.Concepts.SuperClasses;

namespace Creationals.FactoryMethod.Concepts.ConcreteClasses;

public class TruckFactory : Vehicle
{
    public override IVehicle CreateVehicle() => new Truck();
}
