using Creationals.FactoryMethod.Concepts.SuperClasses;

namespace Creationals.FactoryMethod.Concepts.ConcreateClasses;

public class MotorBikeFactory : Vehicle
{
    public override IVehicle CreateVehicle() => new MotorBike();
}
