namespace Ecommerce.Shared;

public class User : BaseUser
{
    public ICollection<Cart>? Carts { get; set; }
    public  ICollection<Rating>? Ratings { get; set; }

    public ICollection<Order>? Orders { get; set; }

    public ICollection<SupportChat>? SupportChats { get; set; }

}
