namespace Ecommerce.Shared;

public class Cart
{
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }
    public virtual Product? Product { get; set; }
    public virtual User? User { get; set; }
}

