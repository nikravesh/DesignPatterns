using Creationals.FactoryMethod.SuperClasses;

namespace Creationals.FactoryMethod.ConcreateClasses;

public class Truck : IVehicle
{
    public void Drive() => Console.WriteLine("Driving a truck");
}
