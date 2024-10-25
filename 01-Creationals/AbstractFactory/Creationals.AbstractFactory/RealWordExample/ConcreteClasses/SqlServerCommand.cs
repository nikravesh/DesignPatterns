using Creationals.AbstractFactory.RealWordExample.SuperClasses;

namespace Creationals.AbstractFactory.RealWordExample.ConcreteClasses;
public class SqlServerCommand : IMyDbCommand
{
    public void Execute() => Console.WriteLine("sql server command executed!!");
}
