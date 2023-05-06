namespace Ecommerce.Server;

public class BaseUserUnit<TEntity> : BaseSettingUnit<TEntity>, IBaseUserUnit<TEntity>
    where TEntity : BaseUser
{
    public BaseUserUnit(IBaseUserRepository<TEntity> repository) : base(repository)
    {
    }
}
