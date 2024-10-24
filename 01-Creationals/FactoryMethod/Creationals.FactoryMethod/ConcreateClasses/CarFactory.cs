using Creationals.FactoryMethod.SuperClasses;

namespace Creationals.FactoryMethod.ConcreateClasses;
public class CarFactory : Vehicle
{
    public override IVehicle CreateVehicle()
    {
        return new Car();
    }
}
