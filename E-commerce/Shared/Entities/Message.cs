namespace Ecommerce.Shared;

public class Message:BaseEntity
{
    public string? Content { get; set; }
    public DateTime CreatedDate = DateTime.Now;
    public Guid? SupportChatId { get; set; }
    public SupportChat? SupportChat { get; set; }
}
