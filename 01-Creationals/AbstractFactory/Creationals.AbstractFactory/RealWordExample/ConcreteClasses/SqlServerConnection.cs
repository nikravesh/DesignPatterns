using Creationals.AbstractFactory.RealWordExample.SuperClasses;

namespace Creationals.AbstractFactory.RealWordExample.ConcreteClasses;

public class SqlServerConnection : IMyDbConnection
{
    public void Close() => Console.WriteLine("Sql server connection closed!");

    public void Open() => Console.WriteLine("Sql server connection opened!");
}
