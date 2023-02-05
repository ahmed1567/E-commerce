namespace Ecommerce.Server;

public class ProductRepository : BaseSettingRepository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }
}
