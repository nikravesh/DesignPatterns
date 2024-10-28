namespace Creationals.Builder.RealWorldExample.Builders;
public interface IMailSenderBuilder
{
    IMailSenderBuilder BuildFrom();
    IMailSenderBuilder BuildTo();
    IMailSenderBuilder BuildSubject();
    IMailSenderBuilder BuildBody();
    IMailSenderBuilder BuildHasAttachments(bool hasAttachments);
}
