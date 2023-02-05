namespace Ecommerce.Server;

public interface IBaseUnit<TEntity>
    where TEntity : BaseEntity
{
    Task<IEnumerable<TEntity>> Read();
    Task<TEntity> ReadByid(Guid id);
    Task Create(TEntity Obj);
    Task Update(TEntity Obj);
    Task Delete(Guid id);
}
