namespace Ecommerce.Shared;

public class Manager:BaseUser
{
    public bool IsManager { get; set; }
    public ICollection<SupportChat>? SupportChats { get; set; }

}
