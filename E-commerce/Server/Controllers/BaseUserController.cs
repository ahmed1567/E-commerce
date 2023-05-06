namespace Ecommerce.Server;

public class BaseUserController<TEntity> : BaseController<TEntity>
    where TEntity : BaseUser
{
    private IBaseUserUnit<TEntity> _unit;
    public BaseUserController(IBaseUserUnit<TEntity> unit) : base(unit)
    {
        _unit = unit;
    }

}
