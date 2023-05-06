namespace Ecommerce.Server;

public class CategoryUnit : BaseSettingUnit<Category>, ICategoryUnit
{
    public CategoryUnit(ICategoryRepository repository) : base(repository)
    {
    }
    public override async Task Create(Category Obj)
    {
        try { await base.Create(Obj); } catch(Exception ex) { throw new Exception("THE CATEGORY YOU ENTERED IS ALREADY EXIST "); }  
    }
}
