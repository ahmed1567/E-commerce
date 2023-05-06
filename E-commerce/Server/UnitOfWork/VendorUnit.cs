namespace Ecommerce.Server;

public class VendorUnit : BaseUserUnit<Vendor>, IVendorUnit
{
    public VendorUnit(IVendorRepository repository) : base(repository)
    {
    }
}
