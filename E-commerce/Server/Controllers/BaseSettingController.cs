namespace Ecommerce.Server;

public class BaseSettingController<TEntity> : BaseController<TEntity>
    where TEntity : BaseSettingEntity
{
    private IBaseSettingUnit<TEntity> _unit;
    public BaseSettingController(IBaseSettingUnit<TEntity> unit) : base(unit)
    {
        _unit= unit;    
    }
    [HttpGet("Search/{searchText}")]
    public virtual async Task<IEnumerable<TEntity>> Get([FromRoute] string searchText) =>  await _unit.SearchArray(searchText);
    
    [HttpGet("Search/Single/{searchText}")]
    public virtual async Task<TEntity> GetSingle([FromRoute] string searchText) =>  await _unit.Search(searchText); 
}
