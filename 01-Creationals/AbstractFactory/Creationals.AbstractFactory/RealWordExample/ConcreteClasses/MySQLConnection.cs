using Creationals.AbstractFactory.RealWordExample.SuperClasses;

namespace Creationals.AbstractFactory.RealWordExample.ConcreteClasses;
public class MySQLConnection : IMyDbConnection
{
    public void Close() => Console.WriteLine("MySQL connection closed!");

    public void Open() => Console.WriteLine("MySQL connection opened!");
}
