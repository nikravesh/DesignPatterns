using Creationals.Builder.RealWorldExample.Builders;
using Creationals.Builder.RealWorldExample.Product;

namespace Creationals.Builder.RealWorldExample.ConcreteClasses;
public class MailSender : IMailSenderBuilder
{
    private readonly MailModel _mailModel;

    public MailSender()
    {
        _mailModel = new MailModel();
    }

    public IMailSenderBuilder BuildBody()
    {
        _mailModel.Body =
    }

    public IMailSenderBuilder BuildFrom()
    {
        throw new NotImplementedException();
    }

    public IMailSenderBuilder BuildHasAttachments(bool hasAttachments)
    {
        throw new NotImplementedException();
    }

    public IMailSenderBuilder BuildSubject()
    {
        throw new NotImplementedException();
    }

    public IMailSenderBuilder BuildTo()
    {
        throw new NotImplementedException();
    }
}
