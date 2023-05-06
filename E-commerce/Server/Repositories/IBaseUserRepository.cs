namespace Ecommerce.Server;

public interface IBaseUserRepository<TEntity>:IBaseSettingRepository<TEntity>
    where TEntity : BaseUser
{
}
