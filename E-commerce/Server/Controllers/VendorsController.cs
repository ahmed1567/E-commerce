namespace Ecomerce.Server;
[Route("[controller]")]
[ApiController]


public class VendorsController : BaseUserController<Vendor>
{
    public VendorsController(IVendorUnit unit) : base(unit)
    {
    }
}

