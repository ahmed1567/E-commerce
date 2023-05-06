namespace Ecommerce.Shared;

public class SupportChat:BaseEntity
{
   public Guid? UserId { get; set; }
    public Guid? ManagerId { get; set; } 
    public Manager? Manager { get; set; }
    public User? User { get; set; }

    public ICollection<Message>? Messages { get; set; }
}
