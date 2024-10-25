using Creationals.FactoryMethod.Concepts.SuperClasses;

namespace Creationals.FactoryMethod.Concepts.ConcreteClasses;
public class CarFactory : Vehicle
{
    public override IVehicle CreateVehicle() => new Car();
}
