namespace Ecommerce.Server;

public class BaseSettingUnit<TEntity> : BaseUnit<TEntity>, IBaseSettingUnit<TEntity>
    where TEntity : BaseSettingEntity
{
    private readonly IBaseSettingRepository<TEntity> _baseRepository;
    public BaseSettingUnit(IBaseSettingRepository<TEntity> repository) : base(repository)
    {
        _baseRepository = repository;
    }

    public async Task<IEnumerable<TEntity>> SearchArray(string name) => await _baseRepository.SearchArray(name);
    public async Task<TEntity> Search(string name) => await _baseRepository.Search(name);

}
