using Creationals.AbstractFactory.RealWordExample.SuperClasses;

namespace Creationals.AbstractFactory.RealWordExample.ConcreteClasses;
public class SQLServerCommand : IMyDbCommand
{
    public void Execute() => Console.WriteLine("sql server command executed!!");
}
