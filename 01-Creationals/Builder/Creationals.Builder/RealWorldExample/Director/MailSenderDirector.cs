using Creationals.Builder.RealWorldExample.Builders;

namespace Creationals.Builder.RealWorldExample.Director;
public class MailSenderDirector
{
    public MailSenderDirector(IMailSenderBuilder builder)
    {
        builder
            .BuildFrom("a.z.nikravesh@gmail.com")
            .BuildTo("a.z.nikravesh@outlook.com")
            .BuildSubject("Send an email")
            .BuildBody("This is a test mail")
            .BuildHasAttachments(false);            
    }
}
