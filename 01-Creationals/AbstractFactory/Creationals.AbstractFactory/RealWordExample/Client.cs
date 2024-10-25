using Creationals.AbstractFactory.RealWordExample.ConcreteClasses;
using Creationals.AbstractFactory.RealWordExample.Factories;
using Creationals.AbstractFactory.RealWordExample.SuperClasses;

namespace Creationals.AbstractFactory.RealWordExample;
public class Client
{
    public Client()
    {
        IDatabaseFactory databaseFactory = new SQLServerProductFactory();
        IMyDbConnection connection = databaseFactory.CreateConnection();
        IMyDbCommand dbCommand = databaseFactory.CreateCommand();

        connection.Open();        
        dbCommand.Execute();
        connection.Close();
    }
}
