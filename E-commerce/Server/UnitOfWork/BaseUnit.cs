namespace Ecommerce.Server;

public class BaseUnit<TEntity> : IBaseUnit<TEntity>
    where TEntity : BaseEntity
{
    private readonly IBaseRepository<TEntity> _baseRepository;
    public BaseUnit(IBaseRepository<TEntity> repository)
    {
        _baseRepository = repository;

    }
    public async Task<IEnumerable<TEntity>> Read() => await _baseRepository.Get();

    public async Task<TEntity> ReadByid(Guid id) => await _baseRepository.GetById(id);

    public async Task Create(TEntity Obj) => await _baseRepository.Add(Obj);

    public async Task Update(TEntity Obj) => await _baseRepository.Edit(Obj);


    public async Task Delete(Guid id) => await _baseRepository.Remove(id);

}
