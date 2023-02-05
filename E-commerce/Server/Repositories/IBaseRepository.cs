namespace Ecommerce.Server;

public interface IBaseRepository<TEntity>
    where TEntity : BaseEntity
{
    Task<IEnumerable<TEntity>> Get();
    Task<TEntity> GetById(Guid id);
    Task Add(TEntity Obj);
    Task Edit(TEntity Obj);
    Task Remove(Guid id);
}