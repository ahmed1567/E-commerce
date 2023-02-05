namespace Ecommerce.Server;

public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : BaseEntity
{

    protected DbSet<TEntity> _dbSet;
    private readonly ApplicationDbContext _context;

    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public async Task<IEnumerable<TEntity>> Get() => await _dbSet.ToListAsync() ?? Activator.CreateInstance<IEnumerable<TEntity>>();

    public async Task<TEntity> GetById(Guid id)
    {
        TEntity? rowFromDB = await _dbSet.FirstOrDefaultAsync(t => t.Id == id);
        if (rowFromDB == null)
            throw new Exception("THE RAW DOES NOT EXIST IN DB");
        return rowFromDB;
    }


    public async Task Add(TEntity Obj)
    {
        if (Obj == null)
            throw new ArgumentNullException("Employee was not supplied");

        Obj.Id = Guid.NewGuid();

        await _dbSet.AddAsync(Obj);
        await _context.SaveChangesAsync();
    }

    public async Task Edit(TEntity Obj)
    {
        TEntity? rowFromDB = _dbSet.FirstOrDefault(t => t.Id == Obj.Id);
        if (rowFromDB == null)
            throw new Exception("THE RAW DOES NOT EXIST IN DB");

        await Task.Run(() => _dbSet.Update(Obj));
        await _context.SaveChangesAsync();
    }

    public async Task Remove(Guid id)
    {
        TEntity? rowFromDB = _dbSet.FirstOrDefault(t => t.Id == id);
        if (rowFromDB == null)
            throw new Exception("THE RAW DOES NOT EXIST IN DB");

        await Task.Run(() => _dbSet.Remove(rowFromDB));
        await _context.SaveChangesAsync();
    }


}
