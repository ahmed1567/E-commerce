namespace Ecommerce.Server;

public class BaseSettingController<TEntity> : BaseController<TEntity>
    where TEntity : BaseSettingEntity
{
    public BaseSettingController(IBaseSettingUnit<TEntity> unit) : base(unit)
    {
    }

}
