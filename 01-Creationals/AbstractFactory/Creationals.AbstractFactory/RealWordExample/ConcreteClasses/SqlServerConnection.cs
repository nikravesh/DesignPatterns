using Creationals.AbstractFactory.RealWordExample.SuperClasses;

namespace Creationals.AbstractFactory.RealWordExample.ConcreteClasses;

public class SQLServerConnection : IMyDbConnection
{
    public void Close() => Console.WriteLine("SQL server connection closed!");

    public void Open() => Console.WriteLine("SQL server connection opened!");
}
