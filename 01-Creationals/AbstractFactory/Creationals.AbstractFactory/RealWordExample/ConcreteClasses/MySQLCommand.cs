using Creationals.AbstractFactory.RealWordExample.SuperClasses;

namespace Creationals.AbstractFactory.RealWordExample.ConcreteClasses;

public class MySQLCommand : IMyDbCommand
{
    public void Execute() => Console.WriteLine("MySQL command executed!");
}
