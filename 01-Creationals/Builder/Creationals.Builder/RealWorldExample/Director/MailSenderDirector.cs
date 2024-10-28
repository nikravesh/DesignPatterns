using Creationals.Builder.RealWorldExample.Builders;

namespace Creationals.Builder.RealWorldExample.Director;
public class MailSenderDirector
{
    private readonly IMailSenderBuilder builder;

    public MailSenderDirector(IMailSenderBuilder builder)
    {
        this.builder = builder;
    }

    public void Build()
    {
        builder
            .BuildFrom("a.z.nikravesh@gmail.com")
            .BuildTo("a.z.nikravesh@outlook.com")
            .BuildSubject("Send an email")
            .BuildBody("This is a test mail")
            .BuildHasAttachments(false);
    }
}
