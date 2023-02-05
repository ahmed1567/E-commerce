namespace Ecomerce.Server;
[Route("[controller]")]
[ApiController]


public class ProductsController : BaseSettingController<Product>
{
    public ProductsController(IProductUnit unit) : base(unit)
    {
    }
}

