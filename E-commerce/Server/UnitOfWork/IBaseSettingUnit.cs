namespace Ecommerce.Server;

public interface IBaseSettingUnit<TEntity> : IBaseUnit<TEntity>
    where TEntity : BaseSettingEntity
{
    Task<IEnumerable<TEntity>> SearchArray(string name);
    Task<TEntity> Search(string name);
}
