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

    public IMailSenderBuilder BuildBody(string body)
    {
        _mailModel.Body = body;

        return this;
    }

    public IMailSenderBuilder BuildFrom(string emailAddress)
    {
        _mailModel.From = emailAddress;

        return this;
    }

    public IMailSenderBuilder BuildHasAttachments(bool hasAttachments)
    {
        _mailModel.HasAttachemnts = hasAttachments;

        return this;
    }

    public IMailSenderBuilder BuildSubject(string subjects)
    {
        _mailModel.Subject = subjects;

        return this;
    }

    public IMailSenderBuilder BuildTo(params string[] emailAddress)
    {
        _mailModel.To = emailAddress;

        return this;
    }

    public MailModel GetResult()
    {
        return _mailModel;
    }
}
