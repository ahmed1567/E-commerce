namespace Ecommerce.Server;
public class BaseController<TEntity> : Controller
    where TEntity :BaseEntity
{
    private readonly IBaseUnit<TEntity> _unit;

    public BaseController(IBaseUnit<TEntity> unit)
    {
        _unit = unit;
    }

    [HttpGet]
    public virtual async Task<IEnumerable<TEntity>> Get() => await _unit.Read();

    [HttpGet("{id}")]
    public virtual async Task<TEntity> Get(Guid id) => await _unit.ReadByid(id);

    [HttpPost]
    public virtual async Task Post(TEntity entity) => await _unit.Create(entity);


    [HttpPut]
    public virtual async Task Put(TEntity entity) => await _unit.Update(entity);

    [HttpDelete("{id}")]
    public virtual async Task Delete(Guid id) => await _unit.Delete(id);

}
