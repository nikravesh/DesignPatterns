namespace Creationals.Builder.RealWorldExample.Builders;
public interface IMailSenderBuilder
{
    IMailSenderBuilder BuildFrom(string emailAddress);
    IMailSenderBuilder BuildTo(params string[] emailAddress);
    IMailSenderBuilder BuildSubject(string subjects);
    IMailSenderBuilder BuildBody(string body);
    IMailSenderBuilder BuildHasAttachments(bool hasAttachments);
}
