namespace Creationals.Builder.RealWorldExample.Product;
public record MailModel
    (string From, string To, string Subject, string Body, bool HasAttachements);

