namespace Ecommerce.Shared;

public class Order:BaseEntity
{
    public double Total { get; set; }
    public Guid UserId { get; set; }

    public DateTime CreatedDate = DateTime.Now; 
    public User? User { get; set; } 
    
    public ICollection<OrderProduct>? OrderProducts { get; set; }

}
