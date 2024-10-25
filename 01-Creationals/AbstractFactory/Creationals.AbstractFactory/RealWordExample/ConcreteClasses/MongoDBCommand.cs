using Creationals.AbstractFactory.RealWordExample.SuperClasses;

namespace Creationals.AbstractFactory.RealWordExample.ConcreteClasses;

public class MongoDBCommand : IMyDbCommand
{
    public void Execute() => Console.WriteLine("MongoDB command executed!");
