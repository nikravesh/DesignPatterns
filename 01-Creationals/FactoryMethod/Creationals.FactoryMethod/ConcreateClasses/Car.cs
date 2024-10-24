using Creationals.FactoryMethod.SuperClasses;

namespace Creationals.FactoryMethod.ConcreateClasses;

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a car");
    }
}
