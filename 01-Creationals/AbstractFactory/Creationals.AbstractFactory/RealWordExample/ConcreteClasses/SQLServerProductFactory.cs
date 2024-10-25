using Creationals.AbstractFactory.RealWordExample.Factories;
using Creationals.AbstractFactory.RealWordExample.SuperClasses;

namespace Creationals.AbstractFactory.RealWordExample.ConcreteClasses;
public class SQLServerProductFactory : IDatabaseFactory
{
    public IMyDbConnection CreateConnection() => new SQLServerConnection();

    public IMyDbCommand CreateCommand() => new SQLServerCommand();
}
