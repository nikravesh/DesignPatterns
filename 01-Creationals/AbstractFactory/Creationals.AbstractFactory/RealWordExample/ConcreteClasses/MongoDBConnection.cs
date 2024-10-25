using Creationals.AbstractFactory.RealWordExample.SuperClasses;

namespace Creationals.AbstractFactory.RealWordExample.ConcreteClasses;
public class MongoDBConnection : IMyDbConnection
{
    public void Close() => Console.WriteLine("MongoDB connection closed!");

    public void Open() => Console.WriteLine("MongoDB connection opened!");
}
