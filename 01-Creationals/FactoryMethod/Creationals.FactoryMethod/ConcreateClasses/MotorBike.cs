using Creationals.FactoryMethod.SuperClasses;

namespace Creationals.FactoryMethod.ConcreateClasses;

public class MotorBike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Riding a MotorBike");
    }
}
