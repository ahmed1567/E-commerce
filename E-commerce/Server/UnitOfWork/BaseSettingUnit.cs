namespace Ecommerce.Server;

public class BaseSettingUnit<TEntity> : BaseUnit<TEntity>, IBaseSettingUnit<TEntity>
    where TEntity : BaseSettingEntity
{
    public BaseSettingUnit(IBaseSettingRepository<TEntity> repository) : base(repository)
    {
    }
}
