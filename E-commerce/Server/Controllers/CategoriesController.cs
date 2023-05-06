namespace Ecomerce.Server;
[Route("[controller]")]
[ApiController]


public class CategoriesController : BaseSettingController<Category>
{
    public CategoriesController(ICategoryUnit unit) : base(unit)
    {
    }
}

