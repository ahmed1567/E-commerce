namespace Ecommerce.Server;

public class VendorRepository : BaseUserRepository<Vendor>, IVendorRepository
{
    public VendorRepository(ApplicationDbContext context) : base(context)
    {
    }
}