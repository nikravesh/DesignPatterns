using Creationals.Builder.RealWorldExample.ConcreteClasses;
using Creationals.Builder.RealWorldExample.Director;
using Creationals.Builder.RealWorldExample.Product;

namespace Creationals.Builder.RealWorldExample;
public class Client
{
    public Client()
    {
        MailSender mail = new();
        MailSenderDirector mailSenderDirector = new(mail);

        mailSenderDirector.Build();
        MailModel result = mail.GetResult();
    }
}
