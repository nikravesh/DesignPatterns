using Creationals.FactoryMethod.SuperClasses;

namespace Creationals.FactoryMethod.ConcreateClasses;

public class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Riding a Bike");
    }
}
