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
    public async Task<IEnumerable<TEntity>> Get() => await _unit.Read();

    [HttpGet("{id}")]
    public async Task<TEntity> Get(Guid id) => await _unit.ReadByid(id);

    [HttpPost]
    public async Task Post(TEntity employee) => await _unit.Create(employee);


    [HttpPut]
    public async Task Put(TEntity employee) => await _unit.Update(employee);

    [HttpDelete("{id}")]
    public async Task Delete(Guid id) => await _unit.Delete(id);

}
