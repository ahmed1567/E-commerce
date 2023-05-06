namespace Ecommerce.Server;

public class BaseUserRepository<TEntity> : BaseSettingRepository<TEntity>, IBaseUserRepository<TEntity>
    where TEntity : BaseUser
{
    public BaseUserRepository(ApplicationDbContext context) : base(context)
    {
    }
}
