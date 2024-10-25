using Creationals.AbstractFactory.RealWordExample.Factories;
using Creationals.AbstractFactory.RealWordExample.SuperClasses;

namespace Creationals.AbstractFactory.RealWordExample.ConcreteClasses;

public class MongoDBProductFactory : IDatabaseFactory
{
    public IMyDbConnection CreateConnection() => new MongoDBConnection();

    public IMyDbCommand CreateCommand() => new MongoDBCommand();
}
