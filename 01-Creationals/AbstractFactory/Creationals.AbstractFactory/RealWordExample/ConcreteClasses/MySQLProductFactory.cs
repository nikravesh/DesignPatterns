using Creationals.AbstractFactory.RealWordExample.Factories;
using Creationals.AbstractFactory.RealWordExample.SuperClasses;

namespace Creationals.AbstractFactory.RealWordExample.ConcreteClasses;

public class MySQLProductFactory : IDatabaseFactory
{
    public IMyDbConnection CreateConnection() => new MySQLConnection();

    public IMyDbCommand CreateCommand() => new MySQLCommand();
}