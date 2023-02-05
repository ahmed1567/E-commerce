namespace Ecommerce.Server;

public class BaseSettingRepository<TEntity> : BaseRepository<TEntity>, IBaseSettingRepository<TEntity>
    where TEntity : BaseSettingEntity
{
    public BaseSettingRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<TEntity> SearchByName(string name)=>await _dbSet.FirstOrDefaultAsync(s=>s.Name == name) ??Activator.CreateInstance<TEntity>();

}
