namespace Ecommerce.Shared;

public class Rating 
{
    public string? Comment { get; set; }

    public int Stars { get; set; }
    
    public Guid UserId { get; set; }
    public Guid ProductId { get; set; }
    public User? User { get; set; }
    public Product? Product { get; set; }


}

