namespace Ecommerce.Server;

public interface IBaseSettingRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : BaseSettingEntity
{
    Task<IEnumerable<TEntity>> SearchArray(string name);
    Task<TEntity> Search(string name);
}
