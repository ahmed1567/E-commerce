namespace Ecommerce.Server;

public interface IBaseSettingRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : BaseSettingEntity
{
    Task<TEntity> SearchByName(string name);
}
