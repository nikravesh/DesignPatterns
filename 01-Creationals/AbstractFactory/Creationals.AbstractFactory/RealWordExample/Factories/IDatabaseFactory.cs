using Creationals.AbstractFactory.RealWordExample.SuperClasses;

namespace Creationals.AbstractFactory.RealWordExample.Factories;
public interface IDatabaseFactory
{
    IMyDbConnection CreateConnection();
    IMyDbCommand CreateCommand();
}
