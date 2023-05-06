namespace Ecommerce.Shared;

public class Vendor:BaseUser
{
    public string TaxNumber { get; set; }
    public ICollection<Product>? Products { get; set; }

}
