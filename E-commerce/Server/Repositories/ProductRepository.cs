namespace Ecommerce.Server;

public class ProductRepository : BaseSettingRepository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }

    //public override async Task<IEnumerable<Product>> Get() => await _dbSet.Include(p => p.Category).ToListAsync();    

}
