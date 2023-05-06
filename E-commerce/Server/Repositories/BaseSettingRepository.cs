namespace Ecommerce.Server;

public class BaseSettingRepository<TEntity> : BaseRepository<TEntity>, IBaseSettingRepository<TEntity>
    where TEntity : BaseSettingEntity
{
    public BaseSettingRepository(ApplicationDbContext context) : base(context)
    {

    }
    
    public virtual async Task<IEnumerable<TEntity>> SearchArray(string name)=>await _dbSet.Where(S=>S.Name==name).ToListAsync() ?? Activator.CreateInstance<IEnumerable<TEntity>>();

    public virtual async Task<TEntity> Search(string name) => await _dbSet.FirstOrDefaultAsync(S => S.Name == name) ??Activator.CreateInstance<TEntity>();

}
