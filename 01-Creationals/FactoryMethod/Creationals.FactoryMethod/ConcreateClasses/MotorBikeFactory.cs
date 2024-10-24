using Creationals.FactoryMethod.SuperClasses;

namespace Creationals.FactoryMethod.ConcreateClasses;

public class MotorBikeFactory : Vehicle
{
    public override IVehicle CreateVehicle()
    {
        return new MotorBike();
    }
}
