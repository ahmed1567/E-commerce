namespace Ecommerce.Server;

public class ManagerUnit : BaseUserUnit<Manager>, IManagerUnit
{
    public ManagerUnit(IManagerRepository repository) : base(repository)
    {
    }
}
