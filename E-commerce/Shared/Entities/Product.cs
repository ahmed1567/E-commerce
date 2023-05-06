using System.Text.Json.Serialization;

namespace Ecommerce.Shared;

public class Product : BaseSettingEntity
{
    public double Price { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public int  Quantity { get; set; }
    public double Discount { get; set; }
    public Guid? VendorId { get; set; }
    public Guid? SubCategoryId { get; set; }
    public Vendor? Vendor { get; set; }
    public virtual SubCategory? SubCategory { get; set; }
    public virtual ICollection<Cart>? Carts { get; set; }
    public virtual ICollection<Rating>? Ratings { get; set; }
    public ICollection<OrderProduct>? OrderProducts { get; set; }

}
