namespace Creationals.Builder.RealWorldExample.Product;
public record MailModel
{
    public string From { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public bool HasAttachemnts { get; set; }
}
