namespace Ecommerce.Server;

public class CategoryRepository : BaseSettingRepository<Category>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}
